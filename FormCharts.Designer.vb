<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormCharts
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
  Public WithEvents CommandExit As System.Windows.Forms.Button
  Public WithEvents LabelStatus As System.Windows.Forms.Label
  Public WithEvents LabelTimer As System.Windows.Forms.Label
  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCharts))
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.CommandExit = New System.Windows.Forms.Button
    Me.LabelStatus = New System.Windows.Forms.Label
    Me.LabelTimer = New System.Windows.Forms.Label
    Me.CommandPause = New System.Windows.Forms.Button
    Me.VASbar = New System.Windows.Forms.ProgressBar
    Me.TimerTest = New System.Windows.Forms.Timer(Me.components)
    Me.LabelVASvalue = New System.Windows.Forms.Label
    Me.LabelNextVol = New System.Windows.Forms.Label
    Me.GroupBoxVAS = New System.Windows.Forms.GroupBox
    Me.LabelPrevVAS = New System.Windows.Forms.Label
    Me.GroupBoxInfusion = New System.Windows.Forms.GroupBox
    Me.ButtonRate = New System.Windows.Forms.Button
    Me.CheckBoxVASchart = New System.Windows.Forms.CheckBox
    Me.CheckBoxInfusionchart = New System.Windows.Forms.CheckBox
    Me.RadioButtonM = New System.Windows.Forms.RadioButton
    Me.RadioButtonF = New System.Windows.Forms.RadioButton
    Me.PanelChecksRadios = New System.Windows.Forms.Panel
    Me.CheckStatus = New System.Windows.Forms.CheckBox
    Me.LabelSysmesg = New System.Windows.Forms.Label
    Me.LabelTitle = New System.Windows.Forms.Label
    Me.LabelAuthor = New System.Windows.Forms.Label
    Me.GroupBoxVAS.SuspendLayout()
    Me.GroupBoxInfusion.SuspendLayout()
    Me.PanelChecksRadios.SuspendLayout()
    Me.SuspendLayout()
    '
    'CommandExit
    '
    Me.CommandExit.BackColor = System.Drawing.SystemColors.Control
    Me.CommandExit.Cursor = System.Windows.Forms.Cursors.Default
    Me.CommandExit.ForeColor = System.Drawing.SystemColors.ControlText
    Me.CommandExit.Location = New System.Drawing.Point(579, 455)
    Me.CommandExit.Name = "CommandExit"
    Me.CommandExit.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.CommandExit.Size = New System.Drawing.Size(65, 65)
    Me.CommandExit.TabIndex = 2
    Me.CommandExit.Text = "Exit"
    Me.CommandExit.UseVisualStyleBackColor = False
    '
    'LabelStatus
    '
    Me.LabelStatus.BackColor = System.Drawing.SystemColors.Control
    Me.LabelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelStatus.Cursor = System.Windows.Forms.Cursors.Default
    Me.LabelStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelStatus.ForeColor = System.Drawing.SystemColors.ControlText
    Me.LabelStatus.Location = New System.Drawing.Point(10, 495)
    Me.LabelStatus.Name = "LabelStatus"
    Me.LabelStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.LabelStatus.Size = New System.Drawing.Size(360, 25)
    Me.LabelStatus.TabIndex = 3
    '
    'LabelTimer
    '
    Me.LabelTimer.BackColor = System.Drawing.SystemColors.Control
    Me.LabelTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelTimer.Cursor = System.Windows.Forms.Cursors.Default
    Me.LabelTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelTimer.ForeColor = System.Drawing.SystemColors.ControlText
    Me.LabelTimer.Location = New System.Drawing.Point(377, 495)
    Me.LabelTimer.Name = "LabelTimer"
    Me.LabelTimer.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.LabelTimer.Size = New System.Drawing.Size(100, 25)
    Me.LabelTimer.TabIndex = 0
    Me.LabelTimer.Text = "00:00"
    Me.LabelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'CommandPause
    '
    Me.CommandPause.Location = New System.Drawing.Point(579, 380)
    Me.CommandPause.Name = "CommandPause"
    Me.CommandPause.Size = New System.Drawing.Size(65, 65)
    Me.CommandPause.TabIndex = 4
    Me.CommandPause.Text = "Pause"
    Me.CommandPause.UseVisualStyleBackColor = True
    '
    'VASbar
    '
    Me.VASbar.ForeColor = System.Drawing.SystemColors.Desktop
    Me.VASbar.Location = New System.Drawing.Point(10, 380)
    Me.VASbar.Name = "VASbar"
    Me.VASbar.Size = New System.Drawing.Size(360, 100)
    Me.VASbar.Step = 5
    Me.VASbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
    Me.VASbar.TabIndex = 6
    '
    'TimerTest
    '
    Me.TimerTest.Interval = 500
    '
    'LabelVASvalue
    '
    Me.LabelVASvalue.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.LabelVASvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelVASvalue.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelVASvalue.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.LabelVASvalue.Location = New System.Drawing.Point(377, 380)
    Me.LabelVASvalue.Name = "LabelVASvalue"
    Me.LabelVASvalue.Size = New System.Drawing.Size(100, 100)
    Me.LabelVASvalue.TabIndex = 7
    Me.LabelVASvalue.Text = "0"
    Me.LabelVASvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'LabelNextVol
    '
    Me.LabelNextVol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelNextVol.ForeColor = System.Drawing.Color.SteelBlue
    Me.LabelNextVol.Location = New System.Drawing.Point(732, 0)
    Me.LabelNextVol.Name = "LabelNextVol"
    Me.LabelNextVol.Size = New System.Drawing.Size(40, 15)
    Me.LabelNextVol.TabIndex = 10
    Me.LabelNextVol.Text = "250"
    Me.LabelNextVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'GroupBoxVAS
    '
    Me.GroupBoxVAS.Controls.Add(Me.LabelPrevVAS)
    Me.GroupBoxVAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBoxVAS.Location = New System.Drawing.Point(10, 40)
    Me.GroupBoxVAS.Name = "GroupBoxVAS"
    Me.GroupBoxVAS.Size = New System.Drawing.Size(780, 160)
    Me.GroupBoxVAS.TabIndex = 13
    Me.GroupBoxVAS.TabStop = False
    Me.GroupBoxVAS.Text = "VAS ratings"
    '
    'LabelPrevVAS
    '
    Me.LabelPrevVAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelPrevVAS.ForeColor = System.Drawing.Color.Green
    Me.LabelPrevVAS.Location = New System.Drawing.Point(732, 0)
    Me.LabelPrevVAS.Name = "LabelPrevVAS"
    Me.LabelPrevVAS.Size = New System.Drawing.Size(40, 15)
    Me.LabelPrevVAS.TabIndex = 18
    Me.LabelPrevVAS.Text = "0"
    Me.LabelPrevVAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'GroupBoxInfusion
    '
    Me.GroupBoxInfusion.Controls.Add(Me.LabelNextVol)
    Me.GroupBoxInfusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBoxInfusion.Location = New System.Drawing.Point(10, 205)
    Me.GroupBoxInfusion.Name = "GroupBoxInfusion"
    Me.GroupBoxInfusion.Size = New System.Drawing.Size(780, 160)
    Me.GroupBoxInfusion.TabIndex = 14
    Me.GroupBoxInfusion.TabStop = False
    Me.GroupBoxInfusion.Text = "Infusion Volume"
    '
    'ButtonRate
    '
    Me.ButtonRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ButtonRate.Location = New System.Drawing.Point(650, 380)
    Me.ButtonRate.Name = "ButtonRate"
    Me.ButtonRate.Size = New System.Drawing.Size(140, 140)
    Me.ButtonRate.TabIndex = 15
    Me.ButtonRate.Text = "Start"
    Me.ButtonRate.UseVisualStyleBackColor = True
    '
    'CheckBoxVASchart
    '
    Me.CheckBoxVASchart.Checked = True
    Me.CheckBoxVASchart.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckBoxVASchart.Location = New System.Drawing.Point(5, 5)
    Me.CheckBoxVASchart.Name = "CheckBoxVASchart"
    Me.CheckBoxVASchart.Size = New System.Drawing.Size(80, 20)
    Me.CheckBoxVASchart.TabIndex = 16
    Me.CheckBoxVASchart.Text = "VAS"
    Me.CheckBoxVASchart.UseVisualStyleBackColor = True
    '
    'CheckBoxInfusionchart
    '
    Me.CheckBoxInfusionchart.Checked = True
    Me.CheckBoxInfusionchart.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckBoxInfusionchart.Location = New System.Drawing.Point(5, 30)
    Me.CheckBoxInfusionchart.Name = "CheckBoxInfusionchart"
    Me.CheckBoxInfusionchart.Size = New System.Drawing.Size(80, 20)
    Me.CheckBoxInfusionchart.TabIndex = 17
    Me.CheckBoxInfusionchart.Text = "Infusion"
    Me.CheckBoxInfusionchart.UseVisualStyleBackColor = True
    '
    'RadioButtonM
    '
    Me.RadioButtonM.AutoCheck = False
    Me.RadioButtonM.AutoSize = True
    Me.RadioButtonM.Location = New System.Drawing.Point(5, 115)
    Me.RadioButtonM.Name = "RadioButtonM"
    Me.RadioButtonM.Size = New System.Drawing.Size(34, 17)
    Me.RadioButtonM.TabIndex = 18
    Me.RadioButtonM.TabStop = True
    Me.RadioButtonM.Text = "M"
    Me.RadioButtonM.UseVisualStyleBackColor = True
    '
    'RadioButtonF
    '
    Me.RadioButtonF.AutoCheck = False
    Me.RadioButtonF.AutoSize = True
    Me.RadioButtonF.Location = New System.Drawing.Point(45, 115)
    Me.RadioButtonF.Name = "RadioButtonF"
    Me.RadioButtonF.Size = New System.Drawing.Size(31, 17)
    Me.RadioButtonF.TabIndex = 19
    Me.RadioButtonF.TabStop = True
    Me.RadioButtonF.Text = "F"
    Me.RadioButtonF.UseVisualStyleBackColor = True
    '
    'PanelChecksRadios
    '
    Me.PanelChecksRadios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PanelChecksRadios.Controls.Add(Me.CheckStatus)
    Me.PanelChecksRadios.Controls.Add(Me.RadioButtonF)
    Me.PanelChecksRadios.Controls.Add(Me.RadioButtonM)
    Me.PanelChecksRadios.Controls.Add(Me.CheckBoxInfusionchart)
    Me.PanelChecksRadios.Controls.Add(Me.CheckBoxVASchart)
    Me.PanelChecksRadios.Location = New System.Drawing.Point(483, 380)
    Me.PanelChecksRadios.Name = "PanelChecksRadios"
    Me.PanelChecksRadios.Size = New System.Drawing.Size(89, 140)
    Me.PanelChecksRadios.TabIndex = 20
    '
    'CheckStatus
    '
    Me.CheckStatus.Checked = True
    Me.CheckStatus.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckStatus.Location = New System.Drawing.Point(5, 55)
    Me.CheckStatus.Name = "CheckStatus"
    Me.CheckStatus.Size = New System.Drawing.Size(80, 20)
    Me.CheckStatus.TabIndex = 20
    Me.CheckStatus.Text = "Status"
    Me.CheckStatus.UseVisualStyleBackColor = True
    '
    'LabelSysmesg
    '
    Me.LabelSysmesg.Location = New System.Drawing.Point(10, 525)
    Me.LabelSysmesg.Name = "LabelSysmesg"
    Me.LabelSysmesg.Size = New System.Drawing.Size(775, 20)
    Me.LabelSysmesg.TabIndex = 21
    Me.LabelSysmesg.Text = "sysmesg:"
    '
    'LabelTitle
    '
    Me.LabelTitle.AutoSize = True
    Me.LabelTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelTitle.Location = New System.Drawing.Point(12, 9)
    Me.LabelTitle.Name = "LabelTitle"
    Me.LabelTitle.Size = New System.Drawing.Size(186, 19)
    Me.LabelTitle.TabIndex = 22
    Me.LabelTitle.Text = "Controlled Infuser V1.2"
    '
    'LabelAuthor
    '
    Me.LabelAuthor.AutoSize = True
    Me.LabelAuthor.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAuthor.ForeColor = System.Drawing.Color.Black
    Me.LabelAuthor.Location = New System.Drawing.Point(437, 13)
    Me.LabelAuthor.Name = "LabelAuthor"
    Me.LabelAuthor.Size = New System.Drawing.Size(353, 15)
    Me.LabelAuthor.TabIndex = 23
    Me.LabelAuthor.Text = "Translational NeuroImaging Lab @ MBNI, University of Michigan"
    Me.LabelAuthor.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    'FormCharts
    '
    Me.AcceptButton = Me.ButtonRate
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(794, 548)
    Me.Controls.Add(Me.LabelAuthor)
    Me.Controls.Add(Me.LabelTitle)
    Me.Controls.Add(Me.LabelSysmesg)
    Me.Controls.Add(Me.PanelChecksRadios)
    Me.Controls.Add(Me.ButtonRate)
    Me.Controls.Add(Me.GroupBoxInfusion)
    Me.Controls.Add(Me.GroupBoxVAS)
    Me.Controls.Add(Me.LabelVASvalue)
    Me.Controls.Add(Me.VASbar)
    Me.Controls.Add(Me.CommandPause)
    Me.Controls.Add(Me.CommandExit)
    Me.Controls.Add(Me.LabelStatus)
    Me.Controls.Add(Me.LabelTimer)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.ForeColor = System.Drawing.SystemColors.ControlText
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Location = New System.Drawing.Point(3, 22)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FormCharts"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.GroupBoxVAS.ResumeLayout(False)
    Me.GroupBoxInfusion.ResumeLayout(False)
    Me.PanelChecksRadios.ResumeLayout(False)
    Me.PanelChecksRadios.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CommandPause As System.Windows.Forms.Button
  Friend WithEvents VASbar As System.Windows.Forms.ProgressBar
  Friend WithEvents TimerTest As System.Windows.Forms.Timer
  Friend WithEvents LabelVASvalue As System.Windows.Forms.Label
  Friend WithEvents LabelNextVol As System.Windows.Forms.Label
  Friend WithEvents GroupBoxVAS As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBoxInfusion As System.Windows.Forms.GroupBox
  Friend WithEvents ButtonRate As System.Windows.Forms.Button
  Friend WithEvents CheckBoxVASchart As System.Windows.Forms.CheckBox
  Friend WithEvents CheckBoxInfusionchart As System.Windows.Forms.CheckBox
  Friend WithEvents LabelPrevVAS As System.Windows.Forms.Label
  Friend WithEvents RadioButtonM As System.Windows.Forms.RadioButton
  Friend WithEvents RadioButtonF As System.Windows.Forms.RadioButton
  Friend WithEvents PanelChecksRadios As System.Windows.Forms.Panel
  Friend WithEvents CheckStatus As System.Windows.Forms.CheckBox
  Friend WithEvents LabelSysmesg As System.Windows.Forms.Label
  Friend WithEvents LabelTitle As System.Windows.Forms.Label
  Friend WithEvents LabelAuthor As System.Windows.Forms.Label
#End Region
End Class