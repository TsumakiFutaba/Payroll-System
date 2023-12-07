Public Class LogInForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim sql_data As Dictionary(Of String, String) = DatabaseHandler.LoginData(tbUsername, tbPassword)

        If sql_data.GetValueOrDefault("usrname") = tbUsername.Text And sql_data.GetValueOrDefault("pw") = tbPassword.Text _
            And sql_data.GetValueOrDefault("role") = cbRole.Text Then

            MessageBox.Show($"You are Logged In as {sql_data.GetValueOrDefault("role")}!")

            ShowWindow(sql_data.GetValueOrDefault("role"))

        End If

    End Sub

    Private Sub ShowWindow(role As String)

        If role = "IT Admin" Then
            ITAdmin.Show()
        End If

        If role = "HR Admin" Then
            HRAdmin.Show()
        End If

        If role = "Accounting Admin" Then
            AccountingAdmin.Show()
        End If

        If role = "User" Then
            EmployeeDashboard.Show()
        End If

        Me.Hide()

    End Sub

    Private Sub btnForgotpw_Click(sender As Object, e As EventArgs) Handles btnForgotpw.Click
        OneTimeEmployeePasswordChange.Show()
        Me.Hide()
    End Sub
End Class