Imports System.Data.SqlClient
Public Class EmployeeTimeInTimeOutForm
    Dim engine = "localhost, 1433"
    Dim db = "payrolldatabase"
    Dim con As New SqlConnection("Data Source=" + engine + ";Initial Catalog=" + db + ";Integrated Security=true")

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelDate.Text = Date.Now.ToString("yyyy/M/dd")
        LabelTime.Text = Date.Now.ToString("HH:mm:ss tt")
    End Sub

    Private Sub btnTimeInOut_Click(sender As Object, e As EventArgs) Handles btnTimeIn.Click

        Dim USERNAME As String = lblUsername.Text
        Dim inTime As String = LabelTime.Text
        Dim inDate As String = LabelDate.Text
        Dim inStatus As String = "Time In"
        Dim validate As String = "SELECT * FROM Employee_Attendances WHERE [USERNAME] = @USERNAME AND [inDate]=@inDate AND [inStatus]=@inStatus"
        Using con As SqlConnection = New SqlConnection("Data Source=" + engine + ";Initial Catalog=" + db + ";Integrated Security=true;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(validate, con)
                cmd.Parameters.AddWithValue("@USERNAME", USERNAME)
                cmd.Parameters.AddWithValue("@inDate", inDate)
                cmd.Parameters.AddWithValue("inStatus", inStatus)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim myTable As New DataTable

                adapter.Fill(myTable)
                If myTable.Rows.Count > 0 Then
                    MessageBox.Show("You have already time-in for today!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Else
                    Dim addquery As String = "INSERT INTO Employee_Attendances([USERNAME],[inTime],[inDate],[inStatus])VALUES(@USERNAME,@inTime,@inDate,@inStatus)"
                    Dim com = New SqlCommand(addquery, con)

                    com.Parameters.AddWithValue("@USERNAME", USERNAME)
                    com.Parameters.AddWithValue("inTime", inTime)
                    com.Parameters.AddWithValue("inDate", inDate)
                    com.Parameters.AddWithValue("inStatus", inStatus)

                    Dim x As Integer = 0
                    Try
                        con.Open()
                        x = com.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        con.Close()
                        cmd.Parameters.Clear()
                    End Try
                    Select Case x
                        Case 1
                            MessageBox.Show("Successfully Added Time-Out!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Case 0
                            MessageBox.Show("Wrong Entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Select
                End If
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTimeOut.Click

        Dim USERNAME As String = lblUsername.Text
        Dim inDate As String = LabelDate.Text
        Dim outTime As String = LabelTime.Text
        Dim outDate As String = LabelDate.Text
        Dim outStatus As String = "Time Out"
        Dim validate As String = "SELECT * FROM Employee_Attendances WHERE [USERNAME] = @USERNAME AND [outDate]=@outDate AND [outStatus]=@outStatus"
        Using con As SqlConnection = New SqlConnection("Data Source=" + engine + ";Initial Catalog=" + db + ";Integrated Security=true;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(validate, con)
                cmd.Parameters.AddWithValue("@USERNAME", USERNAME)
                cmd.Parameters.AddWithValue("@outDate", outDate)
                cmd.Parameters.AddWithValue("outStatus", outStatus)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim myTable As New DataTable

                adapter.Fill(myTable)
                If myTable.Rows.Count > 0 Then
                    MessageBox.Show("You have already time-out for today!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Else
                    Dim addquery As String = "UPDATE Employee_Attendances SET outTime=@outTime,outDate=@outDate,outStatus=@outStatus WHERE USERNAME=@USERNAME AND inDate=@inDate"
                    Dim com = New SqlCommand(addquery, con)

                    com.Parameters.AddWithValue("@USERNAME", USERNAME)
                    com.Parameters.AddWithValue("inDate", inDate)
                    com.Parameters.AddWithValue("outTime", outTime)
                    com.Parameters.AddWithValue("outDate", outDate)
                    com.Parameters.AddWithValue("outStatus", outStatus)

                    Dim x As Integer = 0
                    Try
                        con.Open()
                        x = com.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        con.Close()
                        cmd.Parameters.Clear()
                    End Try
                    Select Case x
                        Case 1
                            MessageBox.Show("Successfully Added Time-Out!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Case 0
                            MessageBox.Show("Wrong Entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Select
                End If
            End Using
        End Using

    End Sub
End Class