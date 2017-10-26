Option Strict Off
Option Explicit On
Imports System
Imports System.IO.Ports
Imports VB = Microsoft.VisualBasic
Friend Class DialogSetParam
  Inherits System.Windows.Forms.Form
  Public CurrentIndex As Short

  Private Sub AcceptButton_Renamed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AcceptButton_Renamed.Click
    If Not (RadioM.Checked) And Not (RadioF.Checked) Then
      MsgBox("Please select the gender profile: M or F.", MsgBoxStyle.Information, "Information:")
      Return
    End If
    If Not (RadioIso.Checked) And Not (RadioHyper.Checked) Then
      MsgBox("Please select which type of saline is to be used: Iso or Hyper.", MsgBoxStyle.Information, "Information:")
      Return
    End If
    AcceptButton_Renamed.Enabled = False
    LabelStatus.Text = ""
    ScanTime = CDbl(TextScanTime.Text) * 60
    RampDuration = CDbl(TextRampDuration.Text)
    BolusInjectionVolume = CDbl(TextBolusInjectionVolume.Text)
    BolusInfusionRate = BolusInjectionVolume / (RampDuration / 60)
    MaxInfuRate = CShort(TextMaxInfuRate.Text)
    VASSetPoint = CShort(TextSetpoint.Text)
        If 0 Then
            InitCommSP(ListBox1.SelectedItem.ToString)
            LabelStatus.Text = "InitCommSP() run"
            Response = SendToComm("STP")
            LabelStatus.Text = "SendToComSP() run"
            MsgBox("setting serial communication. ", MsgBoxStyle.Information)
        End If

        If TestWithoutPump Then
      AcceptButton_Renamed.Enabled = True
      Me.Hide()
      FormCharts.Show()
      FormVASonly.Show()
    Else
      Console.WriteLine (ListBox1.SelectedItem.ToString)
      InitCommSP(ListBox1.SelectedItem.ToString)
      Response = SendToComm("STP")
      If Response = "TimeOut" Then
        LabelStatus.Text = "Device time out! Please check connection and power."

        AcceptButton_Renamed.Enabled = True
        Exit Sub
      End If
            ' Response = SendToComm("CLV")
            ' Response = SendToComm("KEY")
            ' Response = SendToComm("MMD" & TextSyringe.Text)
            ' Response = SendToComm("DIA")
            ' clear both the infused and withdrawn volumes
            ' FormCharts.LabelStatus.Text = Format(BolusInfusionRate, "###0.0") & " ULM " & Response
            ' Response = SendToComm("ULM" & Format(BolusInfusionRate * RateScale, "###0.0"))
            Response = SendToComm("cvolumn")
            ' set syringe diameter to input text field
            Response = SendToComm("diameter " & TextSyringe.Text)
            FormCharts.LabelStatus.Text = Format(BolusInfusionRate, "###0.0") & " u/m " & Response
            Response = SendToComm("irate " & Format(BolusInfusionRate * RateScale, "###0.0 u/m"))
            If Response <> "" Then
        LabelStatus.Text = LabelStatus.Text & "Rate setting error: " & Response
      Else
        Response = SendToComm("RUN")
        Me.Hide()
        FormCharts.Show()
        FormVASonly.Show()
      End If
      AcceptButton_Renamed.Enabled = True
    End If
  End Sub

  Private Sub DialogSetParam_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
    TextSubjID.Text = SubjID
    LabelDestDir.Text = "Data Dir.: " & DestDir

    Me.Left = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
    Me.Top = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
    BaudRate = 1200

    Dim openFileDialog1 As New OpenFileDialog()
        Dim Ports As String() = IO.Ports.SerialPort.GetPortNames()
        ' For Each sp As String In My.Computer.Ports.SerialPortNames
        For Each sp As String In Ports
            Console.WriteLine(sp)
            ListBox1.Items.Add(sp)
        Next
        If (Ports.Length > 0) Then
            ListBox1.SetSelected(0, True)
        End If
        Exit Sub

  End Sub

  Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
    End
  End Sub

  Private Sub TextSubjID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextSubjID.TextChanged
    SubjID = Me.TextSubjID.Text
  End Sub

  Private Sub CheckNoPump_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckNoPump.CheckedChanged
    TestWithoutPump = CheckNoPump.Checked
  End Sub

  Private Sub CheckPresetVAS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckPresetVAS.CheckedChanged
    TestPresetVAS = CheckPresetVAS.Checked
  End Sub

  Private Sub CheckFastSimu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckFastSimu.CheckedChanged
    FastSimulation = CheckFastSimu.Checked
  End Sub

  Private Sub TextScanID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextScanID.TextChanged
    ScanID = TextScanID.Text
  End Sub

  Private Sub ButtonDestDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDestDir.Click
    Dim FolderBrowserDialog1 As New FolderBrowserDialog
    If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
      DestDir = FolderBrowserDialog1.SelectedPath
      LabelDestDir.Text = "Data Dir.: " & DestDir
      My.Computer.FileSystem.CurrentDirectory = DestDir
    End If
  End Sub

  Private Sub RadioIso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioIso.CheckedChanged
    If RadioIso.Checked Then
      TextMaxInfuRate.Text = 50
    End If
  End Sub

  Private Sub RadioHyper_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioHyper.CheckedChanged
    If RadioHyper.Checked Then
      TextMaxInfuRate.Text = 250
    End If
  End Sub


End Class