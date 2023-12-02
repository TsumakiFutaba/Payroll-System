Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing


Public Class LogInForm
    Dim con As New SqlConnection("Data Source=DESKTOP-9FJ16TI\SQLEXPRESS;Initial Catalog=payrolldatabase;Integrated Security=true")
    Dim cmd As New SqlCommand
    Dim sd As New SqlDataAdapter
    Dim dt As New DataTable
    Private loginAttempts As Integer = 0
    Dim str As String
    Dim fullName As String
    Dim email As String
    Dim employeeUN As String
    Dim employeePW As String
    Dim employeeID As String
    Dim attempt As Integer


    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If tbUsername.Text = "hradmin" Then
            HRAdmin.Show()
        ElseIf tbUsername.Text = "itadmin" Then
            ITAdmin.Show()
        ElseIf tbUsername.Text = "employee" Then
            EmployeeDashboard.Show()
        ElseIf tbUsername.Text = "accountingadmin" Then
            AccountingAdmin.Show()
        ElseIf tbUsername.Text = "changepassword" Then
            OneTimeEmployeePasswordChange.Show()

        End If
        Me.Hide()

        Dim username As String = tbUsername.Text
        Dim password As String = tbPassword.Text

        If con.State = ConnectionState.Open Then con.Close()

        If username = "" Or password = "" Then
            MessageBox.Show("Username and Password do not match.", "Message...", MessageBoxButtons.OK)

        Else
            str = "SELECT * FROM Employee_Info WHERE Username = '" & tbUsername.Text & "' AND Password = '" & tbPassword.Text & "'"
            con.Open()

            Dim mysC As New SqlCommand(str, con)
            Dim DR As SqlDataReader

            DR = mysC.ExecuteReader

            If DR.HasRows Then

                While DR.Read
                    fullName = DR.GetString("Name").ToUpper
                    email = DR.GetString("Email")
                    employeeUN = DR.GetString("Username")
                    employeePW = DR.GetString("Password")
                    employeeID = DR.GetInt32("ID")
                    attempt = DR.GetInt32("LoginAttempts")


                End While

                EmployeeTimeInTimeOutForm.lblUsername.Text = $"Hi, {fullName}"
                EmployeeMyAccount.lblFullName.Text = fullName
                EmployeeMyAccount.lblEmail.Text = email
                EmployeeMyAccount.lblUsername.Text = employeeUN
                EmployeeMyAccount.lblPassword.Text = employeePW


                MessageBox.Show("Welcome to the System!", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                EmployeeDashboard.Show()
                Me.Hide()

                con.Close()

                tbPassword.Text = ""
                tbUsername.Text = ""


            Else
                MessageBox.Show("Login failed. Username and Password do not match.", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Show()

                attempt += 1
                If attempt = 3 Then
                        tbUsername.Enabled = False
                        tbPassword.Enabled = False
                        btnLogin.Enabled = False
                    MessageBox.Show("3 attempts has been used. Please contact the IT Admin to unlock.")
                    Me.Show()
                    End If

            End If
        End If





    End Sub

End Class