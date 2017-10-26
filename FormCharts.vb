Option Strict Off
Option Explicit On
Imports System
Imports System.IO.Ports
Imports VB = Microsoft.VisualBasic

Friend Class FormCharts
  Inherits System.Windows.Forms.Form
  Public bUpdateVASvalue As Boolean = False
  Public barValue As Short
  Public timerat0 As Integer = 0
  Public ZeroHold As Integer = 5000
  Public BorderMargin As Short = 20
  Public Minutes, Seconds As Short
  Public TimeIndex As Short = 0
  Public TIDone As Short = -1
  Public TimerTestCount As Double
  Public CycleLen As Short = 15
  Public TotalInfuCount As Short = ScanTime / CycleLen

  Public recVASvalue, VASRatings(TotalInfuCount), lpVASRatings(TotalInfuCount) As Single
  Public NextInfuRate, InfuRate(TotalInfuCount) As Single  'ul/min
  Public redrawRecVAS, redrawRecInfusion, updateRec As Rectangle
  Public pO, pVAS(TotalInfuCount), pInfu(TotalInfuCount), pB, pE As Point
  Public sysmesg As String = ""
  Public K1, K2, K3, K4, m0 As Single

  Public Const BeltWidth As Single = 10
  Public Const inBeltGain As Single = 0.25
  Public Const outBeltGain As Single = 0.5
  Public SpCurr As Single ' 
  Public Const VASTooHighValue As Short = 70
  Public Const VASTooHighLimit As Short = 2 ' 
  Public VASTooHighCounter As Short = 0
  Public Const InfuDelayAt0 As Short = 2 '
  Public InfuDelayAt0Counter As Short = 0
  Public bVASfromFile As Boolean = False
  Dim timenow As DateTime = DateTime.Now
  Dim rNofilename As Integer

  Private Sub CommandExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CommandExit.Click
    EndInjection()
    WritePainData(SubjID & ScanID)

    Dim ScreenSize As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
    Dim screenGrab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
    Dim g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(screenGrab)
    g.CopyFromScreen(New Point(0, 0), New Point(0, 0), ScreenSize)

    screenGrab.Save(DestDir & "\" & SubjID & ScanID & CStr(rNofilename) & ".jpeg")
    End
  End Sub

  Private Sub FormCharts_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
    Dim rand As New Random()
    rNofilename = rand.Next(1, 1000)
    If FastSimulation Then
      TimerTest.Interval = 100
      ZeroHold = 100
      RampDuration = 5
    Else
      TimerTest.Interval = 500
      ZeroHold = 5000

    End If
    Me.Left = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
    Me.Top = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
    VASbar.ForeColor = Color.PaleGreen
    FormVASonly.VASbar.ForeColor = VASbar.ForeColor

    TimerTestCount = -RampDuration

    Minutes = Fix(TimerTestCount / 60)
    Seconds = Fix(TimerTestCount - Minutes * 60)
    If Seconds < 0 Or Minutes < 0 Then
      Seconds = System.Math.Abs(Seconds)
      Minutes = System.Math.Abs(Minutes)
      LabelTimer.Text = "-" & Format(Minutes, "00") & ":" & Format(Seconds, "00")
      FormVASonly.LabelTimer.Text = LabelTimer.Text
    Else
      LabelTimer.Text = Format(Minutes, "00") & ":" & Format(Seconds, "00")
      FormVASonly.LabelTimer.Text = LabelTimer.Text
    End If
    RadioButtonM.Checked = DialogSetParam.RadioM.Checked
    RadioButtonF.Checked = DialogSetParam.RadioF.Checked
    Me.Text = SubjID & ScanID
    FormVASonly.Text = Me.Text

    If TestPresetVAS Then

      Dim OFDpreset As New OpenFileDialog
      Dim FileName As String
      OFDpreset.InitialDirectory = DestDir
      OFDpreset.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
      OFDpreset.FilterIndex = 2
      OFDpreset.RestoreDirectory = True
      OFDpreset.Multiselect = False

      If OFDpreset.ShowDialog() = Windows.Forms.DialogResult.OK Then
        bVASfromFile = True
        FileName = OFDpreset.FileName
        LabelSysmesg.Text = FileName
        ReadPainData(FileName)
      Else
        bVASfromFile = False
        Dim presetVAS() As Short = {10, 20, 25, 30, 40, 35, 40, 40, 35, 45, _
                           35, 40, 40, 45, 35, 35, 40, 40, 35, 40, _
                           40, 35, 35, 40, 40, 40, 40, 35, 40, 40, _
                           40, 40, 40, 40, 45, 35, 40, 40, 45, 40, _
                           40, 40, 40, 40, 40, 40, 40, 40, 40, 40, _
                           40, 40, 40, 40, 45, 45, 45, 45, 45, 40, _
                           45, 45, 45, 40, 45, 55, 45, 50, 45, 45, _
                           45, 45, 45, 50, 50} 'from cf2509h2c
        For i As Short = 0 To presetVAS.Length - 1
          VASRatings(i) = presetVAS(i)
        Next
        Erase presetVAS
      End If
    End If

  End Sub

  Private Sub TimerTest_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTest.Tick
    Dim cursorx, cursory As Integer

    TimerTestCount = TimerTestCount + TimerTest.Interval / 1000 'seconds

    If System.Math.Abs(TimerTestCount) < 0.1 Then
      EndInjection()
      LabelVASvalue.ForeColor = Color.Green
      FormVASonly.LabelVASvalue.ForeColor = LabelVASvalue.ForeColor
      ButtonRate.Enabled = True
      FormVASonly.ButtonRate.Enabled = ButtonRate.Enabled
    End If

    Minutes = Fix(TimerTestCount / 60)
    Seconds = Fix(TimerTestCount - Minutes * 60)
    If Seconds < 0 Or Minutes < 0 Then
      Seconds = System.Math.Abs(Seconds)
      Minutes = System.Math.Abs(Minutes)
      LabelTimer.Text = "-" & Format(Minutes, "00") & ":" & Format(Seconds, "00")
      FormVASonly.LabelTimer.Text = LabelTimer.Text
    Else
      LabelTimer.Text = Format(Minutes, "00") & ":" & Format(Seconds, "00")
      FormVASonly.LabelTimer.Text = LabelTimer.Text
    End If

    If TimeIndex >= TotalInfuCount Then
      TimerTest.Enabled = False
      EndInjection()
      WritePainData(SubjID & ScanID)

      Dim ScreenSize As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
      Dim screenGrab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
      Dim g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(screenGrab)
      g.CopyFromScreen(New Point(0, 0), New Point(0, 0), ScreenSize)

      screenGrab.Save(DestDir & "\" & SubjID & ScanID & CStr(rNofilename) & ".jpeg")

      MsgBox("Thank you for participating!", MsgBoxStyle.Information, "Done")
      Me.Close()
      End
    End If
    If TimerTestCount >= 0 Then
      If timerat0 = 0 Then

        Me.Cursor = New Cursor(Cursor.Current.Handle)
        cursorx = Fix(FormVASonly.Location.X + FormVASonly.ButtonRate.Location.X + FormVASonly.ButtonRate.Size.Width / 2)
        cursory = Fix(FormVASonly.Location.Y + FormVASonly.ButtonRate.Location.Y + FormVASonly.ButtonRate.Size.Height / 2)
        Cursor.Position = New Point(cursorx, cursory)
      End If


      If barValue = 0 Then
        timerat0 += TimerTest.Interval
      End If
      If timerat0 < ZeroHold Then
        Return
      End If
      barValue = barValue + VASbar.Step
      If barValue > 100 Then
        barValue = 0
        timerat0 = 0
        If bUpdateVASvalue = True Then

          recVASvalue = -1
        End If
        bUpdateVASvalue = True
        If TestPresetVAS Then
          recVASvalue = VASRatings(TimeIndex)
        Else
          If recVASvalue = -1 Then
            If TimeIndex >= 1 Then
              VASRatings(TimeIndex) = Fix(VASRatings(TimeIndex - 1)) + 0.1
            Else
              VASRatings(TimeIndex) = 0.1
            End If
          Else
            VASRatings(TimeIndex) = recVASvalue
          End If
        End If
        LabelPrevVAS.Text = recVASvalue

        CalcNextInfuRate()
        If Not bVASfromFile Then
          InfuRate(TimeIndex) = NextInfuRate
        End If

        TIDone = TimeIndex
        LabelNextVol.Text = Format(InfuRate(TimeIndex), "##0.0")

        If TestWithoutPump = False Then
          If InfuRate(TimeIndex) < 0.4828 Then '
            Response = SendToComm("STP")
          Else
                        Response = SendToComm("irate " & Format(InfuRate(TimeIndex) * RateScale, "###0.0 u/m"))
                        Response = SendToComm("RUN")
          End If
          LabelStatus.Text = "Setting infusion rate to " & Format(InfuRate(TimeIndex) * RateScale, "###0.0") & " u/m"
          If Response <> "" Then
            LabelStatus.Text = "Rate setting error: " & Response & ". Check pump and connections. " & LabelStatus.Text
          End If
        End If


        redrawRecVAS = CalcRedrawRec(GroupBoxVAS, 100, TIDone, VASRatings(TIDone), pVAS)
        GroupBoxVAS.Invalidate(redrawRecVAS)

        redrawRecInfusion = CalcRedrawRec(GroupBoxInfusion, MaxInfuRate, TIDone, InfuRate(TIDone), pInfu)
        GroupBoxInfusion.Invalidate(redrawRecInfusion)
        LabelVASvalue.ForeColor = Color.Green
        FormVASonly.LabelVASvalue.ForeColor = LabelVASvalue.ForeColor
        ButtonRate.Enabled = True
        FormVASonly.ButtonRate.Enabled = ButtonRate.Enabled

        Me.Cursor = New Cursor(Cursor.Current.Handle)

        cursorx = Fix(FormVASonly.Location.X + FormVASonly.ButtonRate.Location.X + FormVASonly.ButtonRate.Size.Width / 2)
        cursory = Fix(FormVASonly.Location.Y + FormVASonly.ButtonRate.Location.Y + FormVASonly.ButtonRate.Size.Height / 2)
        Cursor.Position = New Point(cursorx, cursory)


        TimeIndex = TimeIndex + 1

      End If
      If bUpdateVASvalue Then
        LabelVASvalue.Text = barValue
        FormVASonly.LabelVASvalue.Text = LabelVASvalue.Text
      End If
      VASbar.Value = barValue
      FormVASonly.VASbar.Value = VASbar.Value
    End If
  End Sub

  Private Sub FormCharts_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
    LabelVASvalue.ForeColor = Color.Black
    FormVASonly.LabelVASvalue.ForeColor = LabelVASvalue.ForeColor
    bUpdateVASvalue = False
    recVASvalue = barValue
  End Sub

  Private Sub FormCharts_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.A) Then
      LabelVASvalue.ForeColor = Color.Black
      FormVASonly.ForeColor = LabelVASvalue.ForeColor
      bUpdateVASvalue = False
      recVASvalue = barValue
      e.Handled = True
    End If
  End Sub

  Private Sub DrawAxes(ByVal gr As Graphics, ByVal targetObj As Object, ByVal YMax As Short)
    Dim AxesPen As New Pen(Brushes.Black)
    Dim GridPen As New Pen(Brushes.Gray)
    Dim pO, pXEnd, pYEnd, pMarkB, pMarkE As New Point
    Dim i, x, y, xo, yo As Integer
    Dim nMarkX As Integer = 20
    Dim nMarkY As Integer = 10
    Dim xstep, ystep As Integer
    Dim xMarkLen As Integer = 5


    AxesPen.Width = 2.0F
    GridPen.Width = 1.0F
    GridPen.DashStyle = Drawing2D.DashStyle.Dash


    x = targetObj.Size.Width - BorderMargin / 2
    y = targetObj.Size.Height - BorderMargin
    xo = BorderMargin * 1.5
    yo = y
    xstep = CInt((x - xo) / nMarkX)
    ystep = CInt((yo - BorderMargin) / nMarkY)
    pO.X = xo
    pO.Y = yo
    pXEnd.X = x
    pXEnd.Y = y
    pYEnd.X = xo
    pYEnd.Y = BorderMargin

    For i = 1 To nMarkX
      x = xo + i * xstep
      pMarkB.X = x
      pMarkE.X = x
      pMarkB.Y = yo
      pMarkE.Y = pYEnd.Y
      If i = 5 Or i = 10 Or i = 15 Then
        GridPen.Width = 2.0F
      Else
        GridPen.Width = 1.0F
      End If
      gr.DrawLine(GridPen, pMarkB, pMarkE)
    Next
    For i = 1 To nMarkY
      y = yo - i * ystep
      pMarkB.X = xo
      pMarkE.X = pXEnd.X
      pMarkB.Y = y
      pMarkE.Y = y
      If i = nMarkY / 2 Then
        GridPen.Width = 2.0F
      Else
        GridPen.Width = 1.0F
      End If
      gr.DrawLine(GridPen, pMarkB, pMarkE)
    Next
    Dim pAxes As Point() = {pXEnd, pO, pYEnd}
    gr.DrawLines(AxesPen, pAxes)
    gr.DrawRectangle(AxesPen, New Rectangle(xo, pYEnd.Y, x - xo, yo - pYEnd.Y))
    AxesPen.Dispose()
    Using AxesFont As New Font("Arial", 8, FontStyle.Regular)
      gr.DrawString("000", AxesFont, Brushes.Gray, 1, yo - 10)
      gr.DrawString(Format(YMax / 2, "000"), AxesFont, Brushes.Gray, 1, yo - 7 - ystep * nMarkY / 2)
      gr.DrawString(Format(YMax, "000"), AxesFont, Brushes.Gray, 1, pYEnd.Y - 4)

    End Using
  End Sub

  Private Function CalcRedrawRec(ByVal targetObj As Object, ByVal scaleY As Integer, ByVal xParam As Single, ByVal yParam As Single, ByRef pEs() As Point) As Rectangle

    Dim unitX, unitY As Single
    pO.X = BorderMargin * 1.5
    pO.Y = targetObj.Size.Height - BorderMargin
    unitX = (targetObj.Size.Width - 2 * BorderMargin) / (ScanTime / CycleLen)
    unitY = (targetObj.Size.Height - 2 * BorderMargin) / scaleY ' pain scale 0-100, infusion 0-250

    pE.X = CInt(pO.X + xParam * unitX)
    pE.Y = CInt(pO.Y - yParam * unitY)
    pEs(xParam).X = pE.X
    pEs(xParam).Y = pE.Y
    CalcRedrawRec = New Rectangle(pE.X - 3, pE.Y - 3, 6, 6)

    If xParam >= 1 Then
      Dim minY As Single
      pB = pEs(xParam - 1)
      Dim sizeY As Single = pE.Y - pB.Y
      If pB.Y > pE.Y Then
        minY = pE.Y
        sizeY = pB.Y - pE.Y
      End If
      updateRec = New Rectangle(pB.X, minY, pE.X - pB.X, sizeY)
    End If
  End Function
  Private Sub DrawVAS(ByVal gr As Graphics, ByVal targetObj As Object)
    Dim VASPen As New Pen(Color.Green, 1.0F)
    Dim VASBrush As New SolidBrush(Color.Green)
    Dim pEs(TimeIndex) As Point
    Dim recTemp As Rectangle
    If TimerTestCount <= 0 Then
      Exit Sub
    End If
    For i As Short = 0 To TIDone
      pEs(i) = pVAS(i)
      recTemp = CalcRedrawRec(GroupBoxVAS, 100, i, VASRatings(i), pEs)
      gr.FillRectangle(VASBrush, recTemp)
    Next

    If TimeIndex >= 1 Then
      'gr.DrawCurve(VASPen, pEs)
      'gr.DrawLines(Pens.Red, pEs)
    End If
  End Sub
  Private Sub DrawInfusion(ByVal gr As Graphics, ByVal targetObj As Object)
    Dim InfusionPen As New Pen(Color.SteelBlue, 1.0F)
    Dim InfusionBrush As New SolidBrush(Color.SteelBlue)
    Dim pEs(TimeIndex) As Point
    Dim recTemp As Rectangle
    If TimerTestCount <= 0 Then
      Exit Sub
    End If
    For i As Short = 0 To TIDone
      pEs(i) = pInfu(i)
      recTemp = CalcRedrawRec(GroupBoxInfusion, MaxInfuRate, i, InfuRate(i), pEs)
      gr.FillRectangle(InfusionBrush, recTemp)
    Next
    gr.FillRectangle(InfusionBrush, redrawRecInfusion)
    If TimeIndex >= 1 Then
      'gr.DrawLines(Pens.Red, pEs)
    End If
  End Sub
  Private Sub GroupBoxVAS_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupBoxVAS.Paint
    DrawAxes(e.Graphics, sender, 100)
    If TimeIndex >= 0 Then
      DrawVAS(e.Graphics, sender)
    End If
  End Sub
  Private Sub GroupBoxInfusion_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupBoxInfusion.Paint
    DrawAxes(e.Graphics, sender, MaxInfuRate)
    If TimeIndex >= 0 Then
      DrawInfusion(e.Graphics, sender)
    End If
  End Sub

  Friend Sub ButtonRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRate.Click
    If Not RadioButtonM.Checked And Not RadioButtonF.Checked Then

      MsgBox("Please select the gender profile first.", MsgBoxStyle.Information, "Information:")
      Exit Sub 'Return
    End If
    If Not CommandPause.Enabled Then
      ButtonRate.Text = "Rate"
      FormVASonly.ButtonRate.Text = ButtonRate.Text
      CommandPause.Enabled = True
      TimerTest.Enabled = True

      If Not TestWithoutPump Then
        Response = SendToComm("RUN")
      End If
    Else
      If TimerTest.Enabled = False Then

        ButtonRate.Enabled = False
        FormVASonly.ButtonRate.Enabled = ButtonRate.Enabled
        TimeIndex = 0

        InjectingFlag = False
        StartInjection()
        TimerTest.Enabled = True

        bUpdateVASvalue = True
        ButtonRate.Text = "Rate"
        FormVASonly.ButtonRate.Text = ButtonRate.Text
        LabelStatus.Text = "Starting bolus infusion at " & Format(BolusInfusionRate, "##0.0") & " u/m"
      Else
        ButtonRate.Enabled = False
        FormVASonly.ButtonRate.Enabled = ButtonRate.Enabled
        LabelVASvalue.ForeColor = Color.Black
        FormVASonly.LabelVASvalue.ForeColor = LabelVASvalue.ForeColor
        bUpdateVASvalue = False
        If Not TestPresetVAS Then
          recVASvalue = barValue
        End If
      End If
    End If
  End Sub

  Private Sub CheckBoxVASchart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxVASchart.CheckedChanged
    GroupBoxVAS.Visible = CheckBoxVASchart.Checked
  End Sub

  Private Sub CheckBoxInfusionchart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxInfusionchart.CheckedChanged
    GroupBoxInfusion.Visible = CheckBoxInfusionchart.Checked
  End Sub

  Private Sub CheckStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckStatus.CheckedChanged

    If CheckStatus.Checked Then
      LabelStatus.ForeColor = Color.Black
    Else
      LabelStatus.ForeColor = LabelStatus.BackColor
    End If
  End Sub

  Private Sub CalcNextInfuRate()
    Dim V As Double
    Dim Time4H As Short = 2
    Dim dt As Single = CycleLen / 60
    Dim nTimePts As Short = System.Math.Round(Time4H / dt) - 1
    Dim upsample As Short = 10
    Dim nk As Short = 35
    Dim tptest(upsample * 2) As Single
    Dim ktest(nk - 1), ss(upsample * 2, nk - 1), minss As Single
    Dim ctest As Single
    Dim htest(nTimePts) As Single
    Dim Hmeas As Single
    Dim maxind, minssik, minssitp As Short
    Dim tpmeas As Single
    Dim kfit, tpfit, cfit, Afit As Single
    Dim tth(System.Math.Round(Time4H * 5 / dt * upsample)) As Single
    Dim hfit(System.Math.Round(Time4H * 5 / dt * upsample)) As Single
    Dim shfit(System.Math.Round(Time4H * 5 / dt * upsample)) As Single
    Dim sl As Single = 0
    Dim TheoInd As Short = 0
    Dim b, L, T As Single
    Dim Kp, Ki, Kd As Single

    V = BolusInjectionVolume
    FilterVAS(TimeIndex)
    If TimeIndex < nTimePts Then

      NextInfuRate = 0
      Exit Sub

    ElseIf TimeIndex = nTimePts Then

      Hmeas = lpVASRatings(0)
      maxind = 0
      For i As Short = 0 To nTimePts
        If Hmeas < lpVASRatings(i) Then
          Hmeas = lpVASRatings(i)
          maxind = i
        End If
      Next
      tpmeas = maxind * dt

      For itp As Short = 0 To upsample * 2
        tptest(itp) = tpmeas - dt + dt / upsample * itp
        For ik As Short = 0 To nk - 1
          ktest(ik) = 1.1 + ik * 0.2
          ctest = System.Math.Log(ktest(ik)) / (ktest(ik) - 1) / tptest(itp)
          ss(itp, ik) = 0
          For ip As Short = 0 To nTimePts
            htest(ip) = Hmeas * (System.Math.Exp(-ctest * ip * dt) - _
                                 System.Math.Exp(-ctest * ktest(ik) * ip * dt)) / _
            (System.Math.Exp(-System.Math.Log(ktest(ik)) / (ktest(ik) - 1)) - _
             System.Math.Exp(-ktest(ik) * (System.Math.Log(ktest(ik)) / (ktest(ik) - 1))))
            ss(itp, ik) = ss(itp, ik) + (lpVASRatings(ip) - htest(ip)) ^ 2
          Next
          If itp = 0 And ik = 0 Then
            minss = ss(itp, ik)
          End If
          If minss >= ss(itp, ik) Then
            minss = ss(itp, ik)
            minssitp = itp
            minssik = ik
          End If
        Next
      Next
      sysmesg = sysmesg & Format(Hmeas, "###0.00  ") & Format(tpmeas, "####0.00  ")

      kfit = ktest(minssik)
      tpfit = tptest(minssitp)
      cfit = System.Math.Log(kfit) / (kfit - 1) / tpfit
      If Not (cfit < 10 And cfit > 0.01) Then
        cfit = 1
      End If
      Afit = Hmeas / V / (System.Math.Exp(-System.Math.Log(kfit) / (kfit - 1)) _
                      - System.Math.Exp(-kfit * System.Math.Log(kfit) / (kfit - 1)))
      sysmesg = sysmesg & Format(kfit, "###0.0  ") & Format(tpfit, "###0.0  ") & Format(cfit, "###0.0  ") & Format(Afit, "###0.0  ")

      For i As Short = 0 To tth.Length - 1
        tth(i) = dt / upsample * i
        hfit(i) = Hmeas * (System.Math.Exp(-cfit * tth(i)) - _
                  System.Math.Exp(-cfit * kfit * tth(i))) / _
                  (System.Math.Exp(-System.Math.Log(kfit) / (kfit - 1)) - _
                  System.Math.Exp(-kfit * (System.Math.Log(kfit) / (kfit - 1))))
        If i = 0 Then
          shfit(i) = hfit(i) * dt / upsample
        Else
          shfit(i) = Afit * V / cfit * (System.Math.Exp(-cfit * kfit * tth(i)) / kfit - _
                                  System.Math.Exp(-cfit * tth(i)) + 1 - 1 / kfit)
        End If
        If sl < hfit(i) Then
          sl = hfit(i)
          TheoInd = i
        End If
      Next
      b = shfit(TheoInd) - sl * tth(TheoInd)
      L = -b / sl
      T = (Afit * V / cfit * (kfit - 1) / kfit - b) / sl - L

      Kp = 1.2 * T / L
      Ki = Kp / 2 / L
      Kd = Kp * L / 2

      If Not (Kp < 100 And Kp > 0.1) Then
        Kp = 12.34
        Ki = 11.7
        Kd = 3.4
      End If
      sysmesg = sysmesg & Format(Kp, "###0.0  ") & Format(Ki, "###0.0   ") & Format(Kd, "###0.0  ")

      K1 = Ki * dt
      K2 = Kp + Ki * dt + Kd / dt
      K3 = -Kp - 2 * Kd / dt
      K4 = Kd / dt
      m0 = 0
      sysmesg = sysmesg & Format(K1, "###0.0  ") & Format(K2, "###0.0   ") & Format(K3, "###0.0  ") & Format(K4, "###0.0  ")
    End If

    LabelSysmesg.Text = sysmesg

    If System.Math.Abs(VASSetPoint - lpVASRatings(TimeIndex)) <= BeltWidth Then
      SpCurr = lpVASRatings(TimeIndex) + (VASSetPoint - lpVASRatings(TimeIndex)) * inBeltGain
    Else
      SpCurr = lpVASRatings(TimeIndex) + (VASSetPoint - lpVASRatings(TimeIndex)) * outBeltGain
    End If

    If TimeIndex = nTimePts Then '8
      NextInfuRate = m0 + (K1 * SpCurr - K2 * lpVASRatings(TimeIndex)) / 10
    ElseIf TimeIndex = nTimePts + 1 Then '9
      NextInfuRate = InfuRate(TimeIndex - 1) + (K1 * SpCurr - K2 * lpVASRatings(TimeIndex) - _
        K3 * lpVASRatings(TimeIndex - 1)) / 10
    ElseIf TimeIndex > nTimePts + 1 Then
      NextInfuRate = InfuRate(TimeIndex - 1) + (K1 * SpCurr - K2 * lpVASRatings(TimeIndex) - _
        K3 * lpVASRatings(TimeIndex - 1) - K4 * lpVASRatings(TimeIndex - 2)) / 10
    End If

    If NextInfuRate > MaxInfuRate Then
      NextInfuRate = MaxInfuRate
    End If
    If NextInfuRate < 0 Then
      NextInfuRate = 0
    End If
    If VASRatings(TimeIndex) >= VASTooHighValue Then
      VASTooHighCounter = VASTooHighCounter + 1
    Else
      VASTooHighCounter = 0
    End If
    If VASTooHighCounter >= VASTooHighLimit Then
      InfuDelayAt0Counter = InfuDelayAt0
    End If
    If InfuDelayAt0Counter > 0 Then
      NextInfuRate = 0
      InfuDelayAt0Counter = InfuDelayAt0Counter - 1
    End If

    LabelStatus.Text = "SpCurr=" & Format(SpCurr, "###0.0  ") & "TimeIndex=" & Format(TimeIndex, "#0")

  End Sub

  Private Sub FilterVAS(ByVal k As Short)

    Dim blp(1), alp(1) As Single
    blp(0) = 0.2929
    blp(1) = 0.2929
    alp(0) = 1
    alp(1) = -0.4142

    lpVASRatings(0) = blp(0) * VASRatings(0)
    If k > 0 Then
      lpVASRatings(k) = blp(0) * VASRatings(k) + blp(1) * VASRatings(k - 1) - alp(1) * lpVASRatings(k - 1)
    End If
  End Sub

  Private Sub CommandPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandPause.Click
    TimerTest.Stop()
    ButtonRate.Text = "Cont."
    FormVASonly.ButtonRate.Text = ButtonRate.Text
    ButtonRate.Enabled = True
    FormVASonly.ButtonRate.Text = ButtonRate.Text
    CommandPause.Enabled = False
    If Not TestWithoutPump Then
      EndInjection()
    End If
  End Sub

  Public Sub WritePainData(ByVal subjIDscan As String)
    Dim FileNumber As Short
    Dim avgVAS As Single = 0
    Dim avgInfuRate As Single = 0
    Dim FileName, currLine As String

    For i As Short = 0 To TimeIndex - 1
      avgVAS = avgVAS + VASRatings(i)
      avgInfuRate = avgInfuRate + InfuRate(i)
    Next
    avgVAS = avgVAS / TimeIndex
    avgInfuRate = avgInfuRate / TimeIndex

    FileName = DestDir & "\" & subjIDscan & CStr(rNofilename) & ".txt"
    FileNumber = FreeFile()
    FileOpen(FileNumber, FileName, OpenMode.Output)

    PrintLine(FileNumber, "============================================================")
    PrintLine(FileNumber, "File name:    " & FileName)
    PrintLine(FileNumber, "subject ID:   " & SubjID)
    PrintLine(FileNumber, "scan ID:      " & ScanID)
    PrintLine(FileNumber, "Date:         " & VB.Left(Today.ToString("s"), 10))
    PrintLine(FileNumber, "Bolus Volume: " & Format(BolusInjectionVolume, "####") & " UL")
    PrintLine(FileNumber, "Bolus Dur.:   " & Format(RampDuration, "###") & " sec")
        PrintLine(FileNumber, "Avg InfuRate: " & Format(avgInfuRate, "###0.0") & " u/m")
        PrintLine(FileNumber, "Avg VAS:      " & Format(avgVAS, "###"))
    PrintLine(FileNumber, "Set Point:    " & Format(VASSetPoint, "00"))
    PrintLine(FileNumber, sysmesg)
    PrintLine(FileNumber, "Columns: ")
    PrintLine(FileNumber, "1)VASTime    2)VAS/10     3)InfuTime    4)InfuRate")
    PrintLine(FileNumber, "============================================================")

    For iL As Short = 0 To TimeIndex - 1
      Seconds = ((iL + 1) * CycleLen Mod 60)
      Minutes = Fix((iL + 1) * CycleLen / 60)
      currLine = Format(Minutes, "00") & "'" & Format(Seconds, "00") & "''"
      currLine = currLine & "       " & Format(VASRatings(iL) / 10, "0.00") & "          "
      Seconds = (iL * CycleLen Mod 60)
      Minutes = Fix(iL * CycleLen / 60)
      If VASRatings(iL) >= 100 Then
        currLine = VB.Left(currLine, 28)
      End If
      currLine = currLine & Format(Minutes, "00") & "'" & Format(Seconds, "00") & "''"
      currLine = currLine & "       " & Format(InfuRate(iL), "000.00") & "        "
      PrintLine(FileNumber, currLine)
    Next
    FileClose(FileNumber)
  End Sub

  Public Sub ReadPainData(ByVal FileName As String)
    Dim FileNumber As Short
    Dim commentCount As Short = 0
    Dim iL As Short = 0
    Dim currLine As String

    FileNumber = FreeFile()
    FileOpen(FileNumber, FileName, OpenMode.Input)

    While commentCount < 2
      currLine = LineInput(FileNumber)
      If StrComp(VB.Left(currLine, 5), "=====") = 0 Then
        commentCount += 1
      End If
    End While

    While Not EOF(FileNumber)

      currLine = LineInput(FileNumber)
      Minutes = CShort(VB.Left(currLine, 2))
      Seconds = CShort(VB.Right(VB.Left(currLine, 5), 2))
      VASRatings(iL) = CSng(VB.Right(VB.Left(currLine, 18), 4)) * 10
      InfuRate(iL) = CSng(VB.Right(VB.Left(currLine, 48), 6))
      iL += 1
    End While
    FileClose(FileNumber)
  End Sub

End Class