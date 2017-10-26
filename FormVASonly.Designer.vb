<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVASonly
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVASonly))
    Me.LabelVASvalue = New System.Windows.Forms.Label
    Me.VASbar = New System.Windows.Forms.ProgressBar
    Me.LabelTimer = New System.Windows.Forms.Label
    Me.ButtonRate = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'LabelVASvalue
    '
    Me.LabelVASvalue.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.LabelVASvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelVASvalue.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelVASvalue.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.LabelVASvalue.Location = New System.Drawing.Point(456, 61)
    Me.LabelVASvalue.Name = "LabelVASvalue"
    Me.LabelVASvalue.Size = New System.Drawing.Size(100, 100)
    Me.LabelVASvalue.TabIndex = 10
    Me.LabelVASvalue.Text = "0"
    Me.LabelVASvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'VASbar
    '
    Me.VASbar.ForeColor = System.Drawing.SystemColors.Desktop
    Me.VASbar.Location = New System.Drawing.Point(89, 61)
    Me.VASbar.Name = "VASbar"
    Me.VASbar.Size = New System.Drawing.Size(360, 140)
    Me.VASbar.Step = 5
    Me.VASbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
    Me.VASbar.TabIndex = 9
    '
    'LabelTimer
    '
    Me.LabelTimer.BackColor = System.Drawing.SystemColors.Control
    Me.LabelTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelTimer.Cursor = System.Windows.Forms.Cursors.Default
    Me.LabelTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelTimer.ForeColor = System.Drawing.SystemColors.ControlText
    Me.LabelTimer.Location = New System.Drawing.Point(456, 176)
    Me.LabelTimer.Name = "LabelTimer"
    Me.LabelTimer.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.LabelTimer.Size = New System.Drawing.Size(100, 25)
    Me.LabelTimer.TabIndex = 8
    Me.LabelTimer.Text = "00:00"
    Me.LabelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'ButtonRate
    '
    Me.ButtonRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ButtonRate.Location = New System.Drawing.Point(562, 61)
    Me.ButtonRate.Name = "ButtonRate"
    Me.ButtonRate.Size = New System.Drawing.Size(140, 140)
    Me.ButtonRate.TabIndex = 16
    Me.ButtonRate.Text = "Start"
    Me.ButtonRate.UseVisualStyleBackColor = True
    '
    'FormVASonly
    '
    Me.AcceptButton = Me.ButtonRate
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(792, 266)
    Me.Controls.Add(Me.ButtonRate)
    Me.Controls.Add(Me.LabelVASvalue)
    Me.Controls.Add(Me.VASbar)
    Me.Controls.Add(Me.LabelTimer)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.Name = "FormVASonly"
    Me.Text = "FormVASonly"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LabelVASvalue As System.Windows.Forms.Label
  Friend WithEvents VASbar As System.Windows.Forms.ProgressBar
  Public WithEvents LabelTimer As System.Windows.Forms.Label
  Friend WithEvents ButtonRate As System.Windows.Forms.Button
End Class
