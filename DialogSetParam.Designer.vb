<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class DialogSetParam
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public CommonDialog1Open As System.Windows.Forms.OpenFileDialog
  Public WithEvents AcceptButton_Renamed As System.Windows.Forms.Button
    Public WithEvents TextRampDuration As System.Windows.Forms.TextBox
    Public WithEvents TextBolusInjectionVolume As System.Windows.Forms.TextBox
    Public WithEvents TextScanTime As System.Windows.Forms.TextBox
  Public WithEvents _Label2_7 As System.Windows.Forms.Label
    Public WithEvents _Label2_6 As System.Windows.Forms.Label
    Public WithEvents _Label2_5 As System.Windows.Forms.Label
    Public WithEvents LabelStatus As System.Windows.Forms.Label
  Public WithEvents _Label2_1 As System.Windows.Forms.Label
    Public WithEvents _Label2_2 As System.Windows.Forms.Label
    Public WithEvents _Label2_0 As System.Windows.Forms.Label
  Public WithEvents Label2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CommonDialog1Open = New System.Windows.Forms.OpenFileDialog()
        Me.AcceptButton_Renamed = New System.Windows.Forms.Button()
        Me.TextRampDuration = New System.Windows.Forms.TextBox()
        Me.TextBolusInjectionVolume = New System.Windows.Forms.TextBox()
        Me.TextScanTime = New System.Windows.Forms.TextBox()
        Me._Label2_7 = New System.Windows.Forms.Label()
        Me._Label2_6 = New System.Windows.Forms.Label()
        Me._Label2_5 = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me._Label2_1 = New System.Windows.Forms.Label()
        Me._Label2_2 = New System.Windows.Forms.Label()
        Me._Label2_0 = New System.Windows.Forms.Label()
        Me.Label2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.GroupBoxParams = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioHyper = New System.Windows.Forms.RadioButton()
        Me.RadioIso = New System.Windows.Forms.RadioButton()
        Me.LabelIsoHyper = New System.Windows.Forms.Label()
        Me.TextSetpoint = New System.Windows.Forms.TextBox()
        Me.LabelSetpoint = New System.Windows.Forms.Label()
        Me.ButtonDestDir = New System.Windows.Forms.Button()
        Me.LabelDestDir = New System.Windows.Forms.Label()
        Me.TextScanID = New System.Windows.Forms.TextBox()
        Me.LabelScanID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextSyringe = New System.Windows.Forms.TextBox()
        Me.LabelSyringe = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelMaxInfuRate = New System.Windows.Forms.Label()
        Me.TextMaxInfuRate = New System.Windows.Forms.TextBox()
        Me.RadioF = New System.Windows.Forms.RadioButton()
        Me.RadioM = New System.Windows.Forms.RadioButton()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.TextSubjID = New System.Windows.Forms.TextBox()
        Me.LabelSubjID = New System.Windows.Forms.Label()
        Me.CheckNoPump = New System.Windows.Forms.CheckBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ListBoxInfo = New System.Windows.Forms.ListBox()
        Me.CheckPresetVAS = New System.Windows.Forms.CheckBox()
        Me.CheckFastSimu = New System.Windows.Forms.CheckBox()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxParams.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AcceptButton_Renamed
        '
        Me.AcceptButton_Renamed.BackColor = System.Drawing.SystemColors.Control
        Me.AcceptButton_Renamed.Cursor = System.Windows.Forms.Cursors.Default
        Me.AcceptButton_Renamed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcceptButton_Renamed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AcceptButton_Renamed.Location = New System.Drawing.Point(33, 557)
        Me.AcceptButton_Renamed.Margin = New System.Windows.Forms.Padding(4)
        Me.AcceptButton_Renamed.Name = "AcceptButton_Renamed"
        Me.AcceptButton_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AcceptButton_Renamed.Size = New System.Drawing.Size(133, 50)
        Me.AcceptButton_Renamed.TabIndex = 17
        Me.AcceptButton_Renamed.Text = "OK"
        Me.AcceptButton_Renamed.UseVisualStyleBackColor = False
        '
        'TextRampDuration
        '
        Me.TextRampDuration.AcceptsReturn = True
        Me.TextRampDuration.BackColor = System.Drawing.SystemColors.Window
        Me.TextRampDuration.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextRampDuration.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextRampDuration.Location = New System.Drawing.Point(240, 62)
        Me.TextRampDuration.Margin = New System.Windows.Forms.Padding(4)
        Me.TextRampDuration.MaxLength = 0
        Me.TextRampDuration.Name = "TextRampDuration"
        Me.TextRampDuration.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextRampDuration.Size = New System.Drawing.Size(105, 22)
        Me.TextRampDuration.TabIndex = 2
        Me.TextRampDuration.Text = "15"
        Me.TextRampDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBolusInjectionVolume
        '
        Me.TextBolusInjectionVolume.AcceptsReturn = True
        Me.TextBolusInjectionVolume.BackColor = System.Drawing.SystemColors.Window
        Me.TextBolusInjectionVolume.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBolusInjectionVolume.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBolusInjectionVolume.Location = New System.Drawing.Point(240, 98)
        Me.TextBolusInjectionVolume.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBolusInjectionVolume.MaxLength = 0
        Me.TextBolusInjectionVolume.Name = "TextBolusInjectionVolume"
        Me.TextBolusInjectionVolume.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBolusInjectionVolume.Size = New System.Drawing.Size(105, 22)
        Me.TextBolusInjectionVolume.TabIndex = 3
        Me.TextBolusInjectionVolume.Text = "150"
        Me.TextBolusInjectionVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextScanTime
        '
        Me.TextScanTime.AcceptsReturn = True
        Me.TextScanTime.BackColor = System.Drawing.SystemColors.Window
        Me.TextScanTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextScanTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextScanTime.Location = New System.Drawing.Point(240, 25)
        Me.TextScanTime.Margin = New System.Windows.Forms.Padding(4)
        Me.TextScanTime.MaxLength = 0
        Me.TextScanTime.Name = "TextScanTime"
        Me.TextScanTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextScanTime.Size = New System.Drawing.Size(105, 22)
        Me.TextScanTime.TabIndex = 1
        Me.TextScanTime.Text = "20"
        Me.TextScanTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Label2_7
        '
        Me._Label2_7.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_7, CType(7, Short))
        Me._Label2_7.Location = New System.Drawing.Point(347, 98)
        Me._Label2_7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._Label2_7.Name = "_Label2_7"
        Me._Label2_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_7.Size = New System.Drawing.Size(40, 25)
        Me._Label2_7.TabIndex = 13
        Me._Label2_7.Text = "UL"
        Me._Label2_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_Label2_6
        '
        Me._Label2_6.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_6, CType(6, Short))
        Me._Label2_6.Location = New System.Drawing.Point(347, 62)
        Me._Label2_6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._Label2_6.Name = "_Label2_6"
        Me._Label2_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_6.Size = New System.Drawing.Size(40, 25)
        Me._Label2_6.TabIndex = 12
        Me._Label2_6.Text = "SEC"
        Me._Label2_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_Label2_5
        '
        Me._Label2_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_5, CType(5, Short))
        Me._Label2_5.Location = New System.Drawing.Point(347, 25)
        Me._Label2_5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._Label2_5.Name = "_Label2_5"
        Me._Label2_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_5.Size = New System.Drawing.Size(40, 25)
        Me._Label2_5.TabIndex = 11
        Me._Label2_5.Text = "MIN"
        Me._Label2_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelStatus
        '
        Me.LabelStatus.BackColor = System.Drawing.SystemColors.Control
        Me.LabelStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelStatus.Location = New System.Drawing.Point(34, 611)
        Me.LabelStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelStatus.Size = New System.Drawing.Size(400, 64)
        Me.LabelStatus.TabIndex = 20
        '
        '_Label2_1
        '
        Me._Label2_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_1, CType(1, Short))
        Me._Label2_1.Location = New System.Drawing.Point(13, 62)
        Me._Label2_1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._Label2_1.Name = "_Label2_1"
        Me._Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_1.Size = New System.Drawing.Size(160, 25)
        Me._Label2_1.TabIndex = 23
        Me._Label2_1.Text = "Bolus Duration"
        Me._Label2_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_Label2_2
        '
        Me._Label2_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_2, CType(2, Short))
        Me._Label2_2.Location = New System.Drawing.Point(13, 98)
        Me._Label2_2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._Label2_2.Name = "_Label2_2"
        Me._Label2_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_2.Size = New System.Drawing.Size(160, 25)
        Me._Label2_2.TabIndex = 24
        Me._Label2_2.Text = "Bolus Infusion Volume"
        Me._Label2_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_Label2_0
        '
        Me._Label2_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_0, CType(0, Short))
        Me._Label2_0.Location = New System.Drawing.Point(13, 25)
        Me._Label2_0.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._Label2_0.Name = "_Label2_0"
        Me._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_0.Size = New System.Drawing.Size(160, 25)
        Me._Label2_0.TabIndex = 22
        Me._Label2_0.Text = "Session Length"
        Me._Label2_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxParams
        '
        Me.GroupBoxParams.Controls.Add(Me.Label1)
        Me.GroupBoxParams.Controls.Add(Me.ListBox1)
        Me.GroupBoxParams.Controls.Add(Me.Panel1)
        Me.GroupBoxParams.Controls.Add(Me.LabelIsoHyper)
        Me.GroupBoxParams.Controls.Add(Me.TextSetpoint)
        Me.GroupBoxParams.Controls.Add(Me.LabelSetpoint)
        Me.GroupBoxParams.Controls.Add(Me.ButtonDestDir)
        Me.GroupBoxParams.Controls.Add(Me.LabelDestDir)
        Me.GroupBoxParams.Controls.Add(Me.TextScanID)
        Me.GroupBoxParams.Controls.Add(Me.LabelScanID)
        Me.GroupBoxParams.Controls.Add(Me.Label4)
        Me.GroupBoxParams.Controls.Add(Me.TextSyringe)
        Me.GroupBoxParams.Controls.Add(Me.LabelSyringe)
        Me.GroupBoxParams.Controls.Add(Me.Label3)
        Me.GroupBoxParams.Controls.Add(Me.LabelMaxInfuRate)
        Me.GroupBoxParams.Controls.Add(Me.TextMaxInfuRate)
        Me.GroupBoxParams.Controls.Add(Me.RadioF)
        Me.GroupBoxParams.Controls.Add(Me.RadioM)
        Me.GroupBoxParams.Controls.Add(Me.LabelGender)
        Me.GroupBoxParams.Controls.Add(Me.TextSubjID)
        Me.GroupBoxParams.Controls.Add(Me.LabelSubjID)
        Me.GroupBoxParams.Controls.Add(Me.TextRampDuration)
        Me.GroupBoxParams.Controls.Add(Me.TextBolusInjectionVolume)
        Me.GroupBoxParams.Controls.Add(Me.TextScanTime)
        Me.GroupBoxParams.Controls.Add(Me._Label2_7)
        Me.GroupBoxParams.Controls.Add(Me._Label2_6)
        Me.GroupBoxParams.Controls.Add(Me._Label2_5)
        Me.GroupBoxParams.Controls.Add(Me._Label2_1)
        Me.GroupBoxParams.Controls.Add(Me._Label2_2)
        Me.GroupBoxParams.Controls.Add(Me._Label2_0)
        Me.GroupBoxParams.Location = New System.Drawing.Point(34, 18)
        Me.GroupBoxParams.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxParams.Name = "GroupBoxParams"
        Me.GroupBoxParams.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxParams.Size = New System.Drawing.Size(400, 482)
        Me.GroupBoxParams.TabIndex = 21
        Me.GroupBoxParams.TabStop = False
        Me.GroupBoxParams.Text = "Set Parameters"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(13, 435)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "COM Port:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(158, 440)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(187, 20)
        Me.ListBox1.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioHyper)
        Me.Panel1.Controls.Add(Me.RadioIso)
        Me.Panel1.Location = New System.Drawing.Point(219, 350)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(167, 43)
        Me.Panel1.TabIndex = 33
        '
        'RadioHyper
        '
        Me.RadioHyper.AutoSize = True
        Me.RadioHyper.Location = New System.Drawing.Point(88, 10)
        Me.RadioHyper.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioHyper.Name = "RadioHyper"
        Me.RadioHyper.Size = New System.Drawing.Size(67, 21)
        Me.RadioHyper.TabIndex = 12
        Me.RadioHyper.TabStop = True
        Me.RadioHyper.Text = "Hyper"
        Me.RadioHyper.UseVisualStyleBackColor = True
        '
        'RadioIso
        '
        Me.RadioIso.AutoSize = True
        Me.RadioIso.Location = New System.Drawing.Point(21, 9)
        Me.RadioIso.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioIso.Name = "RadioIso"
        Me.RadioIso.Size = New System.Drawing.Size(47, 21)
        Me.RadioIso.TabIndex = 11
        Me.RadioIso.TabStop = True
        Me.RadioIso.Text = "Iso"
        Me.RadioIso.UseVisualStyleBackColor = True
        '
        'LabelIsoHyper
        '
        Me.LabelIsoHyper.BackColor = System.Drawing.SystemColors.Control
        Me.LabelIsoHyper.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelIsoHyper.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelIsoHyper.Location = New System.Drawing.Point(13, 357)
        Me.LabelIsoHyper.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelIsoHyper.Name = "LabelIsoHyper"
        Me.LabelIsoHyper.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelIsoHyper.Size = New System.Drawing.Size(160, 25)
        Me.LabelIsoHyper.TabIndex = 31
        Me.LabelIsoHyper.Text = "Iso or Hyper"
        Me.LabelIsoHyper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextSetpoint
        '
        Me.TextSetpoint.AcceptsReturn = True
        Me.TextSetpoint.BackColor = System.Drawing.SystemColors.Window
        Me.TextSetpoint.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextSetpoint.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextSetpoint.Location = New System.Drawing.Point(240, 210)
        Me.TextSetpoint.Margin = New System.Windows.Forms.Padding(4)
        Me.TextSetpoint.MaxLength = 0
        Me.TextSetpoint.Name = "TextSetpoint"
        Me.TextSetpoint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextSetpoint.Size = New System.Drawing.Size(105, 22)
        Me.TextSetpoint.TabIndex = 6
        Me.TextSetpoint.Text = "40"
        Me.TextSetpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelSetpoint
        '
        Me.LabelSetpoint.BackColor = System.Drawing.SystemColors.Control
        Me.LabelSetpoint.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelSetpoint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSetpoint.Location = New System.Drawing.Point(13, 210)
        Me.LabelSetpoint.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSetpoint.Name = "LabelSetpoint"
        Me.LabelSetpoint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelSetpoint.Size = New System.Drawing.Size(160, 25)
        Me.LabelSetpoint.TabIndex = 27
        Me.LabelSetpoint.Text = "VAS Set Point"
        Me.LabelSetpoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonDestDir
        '
        Me.ButtonDestDir.Location = New System.Drawing.Point(347, 394)
        Me.ButtonDestDir.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDestDir.Name = "ButtonDestDir"
        Me.ButtonDestDir.Size = New System.Drawing.Size(40, 25)
        Me.ButtonDestDir.TabIndex = 13
        Me.ButtonDestDir.Text = "..."
        Me.ButtonDestDir.UseVisualStyleBackColor = True
        '
        'LabelDestDir
        '
        Me.LabelDestDir.BackColor = System.Drawing.SystemColors.Control
        Me.LabelDestDir.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelDestDir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelDestDir.Location = New System.Drawing.Point(13, 394)
        Me.LabelDestDir.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDestDir.Name = "LabelDestDir"
        Me.LabelDestDir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelDestDir.Size = New System.Drawing.Size(304, 25)
        Me.LabelDestDir.TabIndex = 32
        Me.LabelDestDir.Text = "Data Dir: "
        Me.LabelDestDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextScanID
        '
        Me.TextScanID.AcceptsReturn = True
        Me.TextScanID.BackColor = System.Drawing.SystemColors.Window
        Me.TextScanID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextScanID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextScanID.Location = New System.Drawing.Point(240, 283)
        Me.TextScanID.Margin = New System.Windows.Forms.Padding(4)
        Me.TextScanID.MaxLength = 0
        Me.TextScanID.Name = "TextScanID"
        Me.TextScanID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextScanID.Size = New System.Drawing.Size(105, 22)
        Me.TextScanID.TabIndex = 8
        Me.TextScanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelScanID
        '
        Me.LabelScanID.BackColor = System.Drawing.SystemColors.Control
        Me.LabelScanID.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelScanID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelScanID.Location = New System.Drawing.Point(13, 283)
        Me.LabelScanID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelScanID.Name = "LabelScanID"
        Me.LabelScanID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelScanID.Size = New System.Drawing.Size(160, 25)
        Me.LabelScanID.TabIndex = 29
        Me.LabelScanID.Text = "Scan ID (eg. 1CFN)"
        Me.LabelScanID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(347, 172)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(40, 25)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "mm"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextSyringe
        '
        Me.TextSyringe.AcceptsReturn = True
        Me.TextSyringe.BackColor = System.Drawing.SystemColors.Window
        Me.TextSyringe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextSyringe.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextSyringe.Location = New System.Drawing.Point(240, 172)
        Me.TextSyringe.Margin = New System.Windows.Forms.Padding(4)
        Me.TextSyringe.MaxLength = 0
        Me.TextSyringe.Name = "TextSyringe"
        Me.TextSyringe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextSyringe.Size = New System.Drawing.Size(105, 22)
        Me.TextSyringe.TabIndex = 5
        Me.TextSyringe.Text = "14.50"
        Me.TextSyringe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelSyringe
        '
        Me.LabelSyringe.BackColor = System.Drawing.SystemColors.Control
        Me.LabelSyringe.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelSyringe.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSyringe.Location = New System.Drawing.Point(13, 172)
        Me.LabelSyringe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSyringe.Name = "LabelSyringe"
        Me.LabelSyringe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelSyringe.Size = New System.Drawing.Size(160, 25)
        Me.LabelSyringe.TabIndex = 26
        Me.LabelSyringe.Text = "Syringe Diameter"
        Me.LabelSyringe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(347, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(40, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "ULM"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMaxInfuRate
        '
        Me.LabelMaxInfuRate.BackColor = System.Drawing.SystemColors.Control
        Me.LabelMaxInfuRate.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelMaxInfuRate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelMaxInfuRate.Location = New System.Drawing.Point(13, 135)
        Me.LabelMaxInfuRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMaxInfuRate.Name = "LabelMaxInfuRate"
        Me.LabelMaxInfuRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelMaxInfuRate.Size = New System.Drawing.Size(160, 25)
        Me.LabelMaxInfuRate.TabIndex = 25
        Me.LabelMaxInfuRate.Text = "Max Infusion Rate"
        Me.LabelMaxInfuRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextMaxInfuRate
        '
        Me.TextMaxInfuRate.AcceptsReturn = True
        Me.TextMaxInfuRate.BackColor = System.Drawing.SystemColors.Window
        Me.TextMaxInfuRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextMaxInfuRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextMaxInfuRate.Location = New System.Drawing.Point(240, 135)
        Me.TextMaxInfuRate.Margin = New System.Windows.Forms.Padding(4)
        Me.TextMaxInfuRate.MaxLength = 0
        Me.TextMaxInfuRate.Name = "TextMaxInfuRate"
        Me.TextMaxInfuRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextMaxInfuRate.Size = New System.Drawing.Size(105, 22)
        Me.TextMaxInfuRate.TabIndex = 4
        Me.TextMaxInfuRate.Text = "250"
        Me.TextMaxInfuRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadioF
        '
        Me.RadioF.Location = New System.Drawing.Point(307, 320)
        Me.RadioF.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioF.Name = "RadioF"
        Me.RadioF.Size = New System.Drawing.Size(46, 25)
        Me.RadioF.TabIndex = 10
        Me.RadioF.TabStop = True
        Me.RadioF.Text = "F"
        Me.RadioF.UseVisualStyleBackColor = True
        '
        'RadioM
        '
        Me.RadioM.Location = New System.Drawing.Point(240, 320)
        Me.RadioM.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioM.Name = "RadioM"
        Me.RadioM.Size = New System.Drawing.Size(46, 25)
        Me.RadioM.TabIndex = 9
        Me.RadioM.TabStop = True
        Me.RadioM.Text = "M"
        Me.RadioM.UseVisualStyleBackColor = True
        '
        'LabelGender
        '
        Me.LabelGender.BackColor = System.Drawing.SystemColors.Control
        Me.LabelGender.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelGender.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelGender.Location = New System.Drawing.Point(13, 320)
        Me.LabelGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelGender.Size = New System.Drawing.Size(160, 25)
        Me.LabelGender.TabIndex = 30
        Me.LabelGender.Text = "Gender"
        Me.LabelGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextSubjID
        '
        Me.TextSubjID.AcceptsReturn = True
        Me.TextSubjID.BackColor = System.Drawing.SystemColors.Window
        Me.TextSubjID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextSubjID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextSubjID.Location = New System.Drawing.Point(240, 246)
        Me.TextSubjID.Margin = New System.Windows.Forms.Padding(4)
        Me.TextSubjID.MaxLength = 0
        Me.TextSubjID.Name = "TextSubjID"
        Me.TextSubjID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextSubjID.Size = New System.Drawing.Size(105, 22)
        Me.TextSubjID.TabIndex = 7
        Me.TextSubjID.Text = "CX0000CHR"
        Me.TextSubjID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelSubjID
        '
        Me.LabelSubjID.BackColor = System.Drawing.SystemColors.Control
        Me.LabelSubjID.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelSubjID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSubjID.Location = New System.Drawing.Point(13, 246)
        Me.LabelSubjID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSubjID.Name = "LabelSubjID"
        Me.LabelSubjID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelSubjID.Size = New System.Drawing.Size(160, 25)
        Me.LabelSubjID.TabIndex = 28
        Me.LabelSubjID.Text = "Subject ID"
        Me.LabelSubjID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckNoPump
        '
        Me.CheckNoPump.AutoSize = True
        Me.CheckNoPump.Location = New System.Drawing.Point(33, 520)
        Me.CheckNoPump.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckNoPump.Name = "CheckNoPump"
        Me.CheckNoPump.Size = New System.Drawing.Size(114, 21)
        Me.CheckNoPump.TabIndex = 14
        Me.CheckNoPump.Text = "WithoutPump"
        Me.CheckNoPump.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonCancel.Location = New System.Drawing.Point(299, 557)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonCancel.Size = New System.Drawing.Size(133, 50)
        Me.ButtonCancel.TabIndex = 18
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ListBoxInfo
        '
        Me.ListBoxInfo.FormattingEnabled = True
        Me.ListBoxInfo.ItemHeight = 16
        Me.ListBoxInfo.Location = New System.Drawing.Point(187, 563)
        Me.ListBoxInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxInfo.Name = "ListBoxInfo"
        Me.ListBoxInfo.Size = New System.Drawing.Size(103, 36)
        Me.ListBoxInfo.TabIndex = 19
        Me.ListBoxInfo.TabStop = False
        Me.ListBoxInfo.Visible = False
        '
        'CheckPresetVAS
        '
        Me.CheckPresetVAS.AutoSize = True
        Me.CheckPresetVAS.Location = New System.Drawing.Point(156, 520)
        Me.CheckPresetVAS.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckPresetVAS.Name = "CheckPresetVAS"
        Me.CheckPresetVAS.Size = New System.Drawing.Size(138, 21)
        Me.CheckPresetVAS.TabIndex = 15
        Me.CheckPresetVAS.Text = "Load Preset VAS"
        Me.CheckPresetVAS.UseVisualStyleBackColor = True
        '
        'CheckFastSimu
        '
        Me.CheckFastSimu.AutoSize = True
        Me.CheckFastSimu.Location = New System.Drawing.Point(307, 520)
        Me.CheckFastSimu.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckFastSimu.Name = "CheckFastSimu"
        Me.CheckFastSimu.Size = New System.Drawing.Size(122, 21)
        Me.CheckFastSimu.TabIndex = 16
        Me.CheckFastSimu.Text = "FastSimulation"
        Me.CheckFastSimu.UseVisualStyleBackColor = True
        '
        'DialogSetParam
        '
        Me.AcceptButton = Me.AcceptButton_Renamed
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(459, 684)
        Me.Controls.Add(Me.CheckFastSimu)
        Me.Controls.Add(Me.CheckPresetVAS)
        Me.Controls.Add(Me.CheckNoPump)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.GroupBoxParams)
        Me.Controls.Add(Me.ListBoxInfo)
        Me.Controls.Add(Me.AcceptButton_Renamed)
        Me.Controls.Add(Me.LabelStatus)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(184, 250)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogSetParam"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Controled Infusion - Set Parameters"
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxParams.ResumeLayout(False)
        Me.GroupBoxParams.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxParams As System.Windows.Forms.GroupBox
  Public WithEvents TextSubjID As System.Windows.Forms.TextBox
  Public WithEvents LabelSubjID As System.Windows.Forms.Label
  Friend WithEvents RadioM As System.Windows.Forms.RadioButton
  Public WithEvents LabelGender As System.Windows.Forms.Label
  Friend WithEvents RadioF As System.Windows.Forms.RadioButton
  Public WithEvents ButtonCancel As System.Windows.Forms.Button
  Friend WithEvents ListBoxInfo As System.Windows.Forms.ListBox
  Public WithEvents Label3 As System.Windows.Forms.Label
  Public WithEvents LabelMaxInfuRate As System.Windows.Forms.Label
  Public WithEvents TextMaxInfuRate As System.Windows.Forms.TextBox
  Friend WithEvents CheckNoPump As System.Windows.Forms.CheckBox
  Public WithEvents LabelSyringe As System.Windows.Forms.Label
  Public WithEvents Label4 As System.Windows.Forms.Label
  Public WithEvents TextSyringe As System.Windows.Forms.TextBox
  Friend WithEvents CheckPresetVAS As System.Windows.Forms.CheckBox
  Friend WithEvents CheckFastSimu As System.Windows.Forms.CheckBox
  Public WithEvents TextScanID As System.Windows.Forms.TextBox
  Public WithEvents LabelScanID As System.Windows.Forms.Label
  Friend WithEvents ButtonDestDir As System.Windows.Forms.Button
  Public WithEvents LabelDestDir As System.Windows.Forms.Label
  Public WithEvents TextSetpoint As System.Windows.Forms.TextBox
  Public WithEvents LabelSetpoint As System.Windows.Forms.Label
  Friend WithEvents RadioHyper As System.Windows.Forms.RadioButton
  Friend WithEvents RadioIso As System.Windows.Forms.RadioButton
  Public WithEvents LabelIsoHyper As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
#End Region
End Class