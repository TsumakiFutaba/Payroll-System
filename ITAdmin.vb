Public Class ITAdmin

    Sub ShowPanel(theForm As Form)
        With theForm
            .TopLevel = False
            pnlContent.Controls.Add(theForm)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        ShowPanel(ITLoginAttempts)
    End Sub

    Private Sub btnDeductions_Click(sender As Object, e As EventArgs) Handles btnDeductions.Click
        ShowPanel(ITLockAccounts)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowPanel(ITMyAccount)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowPanel(ITUsers)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LogInForm.Show()
        Me.Hide()
    End Sub

    Private Sub ITAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowPanel(ITUsers)
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        ShowPanel(ITCreateAccount)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBackupDatabase.Click
        BackupDatabase.Show()
        Me.Hide()
    End Sub
End Class