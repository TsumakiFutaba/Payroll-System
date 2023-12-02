Public Class SplashScreenForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width += 3
        If Panel2.Width >= Panel1.Width Then
            Timer1.Stop()
            Me.Hide()
            LogInForm.Show()

        End If
    End Sub

End Class
