Public Class FormVASonly

  Friend Sub ButtonRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRate.Click
    FormCharts.ButtonRate_click(sender, e)
  End Sub

  Private Sub FormVASonly_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim VASScreen() As System.Windows.Forms.Screen
    VASScreen = System.Windows.Forms.Screen.AllScreens
    If VASScreen.Length > 1 Then
      Me.Left = (VASScreen(1).Bounds.Width - Me.Width) / 2
      Me.Top = (VASScreen(1).Bounds.Height - Me.Height) / 2
    Else
      Me.Left = (VASScreen(0).Bounds.Width - Me.Width) / 2
      Me.Top = (VASScreen(0).Bounds.Height - Me.Height) / 2
    End If
    'Me.Left = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
    'Me.Top = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
  End Sub
End Class