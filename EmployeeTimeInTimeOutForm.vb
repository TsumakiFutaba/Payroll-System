Imports System.Data.SqlClient
Public Class EmployeeTimeInTimeOutForm
    Dim engine = "DESKTOP-44FGDPO\SQLEXPRESS"
    Dim db = "payrolldatabase"
    Dim con As New SqlConnection("Data Source=" + engine + "\SQLEXPRESS;Initial Catalog=" + db + ";Integrated Security=true")


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelDate.Text = Date.Now.ToString("yyyy/M/dd")
        LabelTime.Text = Date.Now.ToString("HH:mm:ss tt")
    End Sub

    Private Sub btnTimeInOut_Click(sender As Object, e As EventArgs) Handles btnTimeInOut.Click
#If False Then
        Try
            If EMPLOYEEID.Text = "" Then
                MessageBox.Show("Please enter your Employee ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                reloadtxt("SELECT * FROM Employee_Information_ WHERE EmployeeID='" & EMPLOYEEID.Text & "'")
                If dt.Rows.Count > 0 Then
                    reloadtxt("SELECT * FROM Employee_Attendance WHERE EmployeeID='" & EMPLOYEEID.Text & "' AND LOGDATE='" & LabelDate.Text & "' AND AM_STATUS='Time In' AND PM_STATUS='Time Out'")
                    If dt.Rows.Count > 0 Then
                        MessageBox.Show("You have already timed in and out for today", "Already", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        reloadtxt("SELECT * FROM Employee_Attendance WHERE EmployeeID ='" & EMPLOYEEID.Text & "' AND LOGDATE='" & LabelDate.Text & "' AND AM_STAUTS='Time In'")
                        If dt.Rows.Count > 0 Then
                            updateLogged("UPDATE Employee_Attendance SET TIMEOUT='" & TimeOfDay & "', PM_STATUS='Time Out' WHERE EmployeeID='" & btnTimeInOut.Text & "' AND LOGDATE='" & LabelDate.Text & "'")
                            MessageBox.Show("Successfully Timed Out!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            createLogged("INSERT INTO Employee_Attendance(EmployeeID,LOGDATE,TIMEIN,AM_STATUS)VALUES('" & btnTimeInOut.Text & "','" & LabelDate.Text & "','" & TimeOfDay & "','TIme In')")
                            MessageBox.Show("Successfully Timed In!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                    End If
                Else
                    MessageBox.Show("Employee ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        Catch ex As Exception

        End Try
#End If
#If False Then
         con.Open()

        Dim str As String = "SELECT * FROM Employee_Info WHERE Username = '" & LogInForm.tbUsername.Text & "' AND Password = '" & LogInForm.tbPassword.Text & "'"

        Dim cmd As New SqlCommand(str, con)

        Dim DR As SqlDataReader
        DR = cmd.ExecuteReader
#End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class