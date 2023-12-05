Imports System.Data.SqlClient
Imports System.Data

Public Class LogInForm
    Dim engine = "localhost, 1433"
    Dim db = "payrolldatabase"


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As New SqlConnection($"Data Source={engine};Initial Catalog={db};Integrated Security=true")
        Dim cmd As New SqlCommand("SELECT usrname,pw,position FROM Employee_Info WHERE usrname ='" & tbUsername.Text & "' AND pw='" & tbPassword.Text & "' AND position='" & cbRole.Text & "'", con)
        Dim usrnameParam As New SqlParameter("@usrname", tbUsername.Text)
        Dim pwParam As New SqlParameter("@pw", tbPassword.Text)
        Dim roleParam As New SqlParameter("@position", cbRole.Text)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        cmd.Parameters.Add(usrnameParam)
        cmd.Parameters.Add(pwParam)
        cmd.Parameters.Add(roleParam)

        cmd.Connection.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If (dt.Rows.Count > 0) Then
            MessageBox.Show($"You are Logged In as {dt.Rows(0)(2)}!")
            Select Case cbRole.SelectedIndex
                Case 0
                    Dim IT As New ITAdmin
                    IT.Show()
                    Me.Hide()
                Case 1
                    Dim HR As New HRAdmin
                    HR.Show()
                    Me.Hide()
                Case 2
                    Dim Accounting As New AccountingAdmin
                    Accounting.Show()
                    Me.Hide()
                Case 3
                    Dim Employee As New EmployeeDashboard
                    Employee.Show()
                    Me.Hide()
            End Select
        Else

            MessageBox.Show("Username and Password are not found.")
            tbUsername.Clear()
            tbPassword.Clear()
            tbUsername.Focus()


        End If
        cmd.Connection.Close()

    End Sub
End Class