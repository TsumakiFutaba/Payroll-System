Imports payroll_system_project.DatabaseHandler
Public Class LogInForm
    Private Function RoleWindow(role As String) As Form
        If role = "IT Admin" Then
            Return ITAdmin
        End If
        If role = "HR Admin" Then
            Return HRAdmin
        End If
        If role = "Accounting Admin" Then
            Return AccountingAdmin
        End If
        Return EmployeeDashboard
    End Function
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sql_data As Dictionary(Of String, Object)
        Dim NextWindow As Form
        sql_data = DatabaseHandler.UserData(tbUsername.Text)

        If sql_data.GetValueOrDefault("usrname") = tbUsername.Text And sql_data.GetValueOrDefault("role") = cbRole.Text _
            And (sql_data.GetValueOrDefault("pw") = tbPassword.Text Or sql_data.GetValueOrDefault("newpw") = tbPassword.Text) Then
            MessageBox.Show($"You are Logged In as {sql_data.GetValueOrDefault("role")}!")
            NextWindow = RoleWindow(sql_data.GetValueOrDefault("role"))
            NextWindow.Show()
            Me.Hide()
        Else
            MessageBox.Show($"HTTP 404: Username and Password are not found.")
            tbUsername.Clear()
            tbPassword.Clear()
            cbRole.ResetText()
            tbUsername.Focus()
        End If

    End Sub

    Private Sub btnForgotpw_Click(sender As Object, e As EventArgs) Handles btnForgotpw.Click
        OneTimeEmployeePasswordChange.Show()
        Me.Hide()
    End Sub
End Class