Public Class EmployeeDashboard
    Sub ShowPanel(theForm As Form)
        With theForm
            .TopLevel = False
            pnlContent.Controls.Add(theForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowPanel(EmployeeTimeInTimeOutForm)
    End Sub

    Private Sub EmployeeDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowPanel(EmployeeTimeInTimeOutForm)
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        ShowPanel(EmployeeMyAttendance)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowPanel(EmployeeMyAccount)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LogInForm.Show()
        Me.Hide()
    End Sub
End Class