Imports System.Threading
Imports System.Data.SqlClient

Public Class PayrollForm
    Dim engine = "localhost, 1433"
    Dim db = "payrolldatabase"
    Dim conn As String = ($"Data Source={engine};Initial Catalog={db};Integrated Security=true")

    Private Sub btnPaySlip_Click(sender As Object, e As EventArgs) Handles btnPaySlip.Click
        Dim frm As New PayslipForm
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        TransparentBG.ShowForm(frm)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchID()

    End Sub
    Public Sub SearchID()
        Dim ID As Integer = Integer.Parse(tbSearchBar.Text)
        Dim USERNAME As String = lblNameValue.Text
        Dim query As String = "SELECT * FROM Employee_Info WHERE employee_id=@employee_id"
        Dim totalQuery As String = "SELECT SUM(totalHours) AS TotalSum FROM Employee_Attendances WHERE USERNAME=@USERNAME"
        Dim deductionQuery As String = "SELECT (ISNULL(sss, 0) + ISNULL(philhealth, 0) + ISNULL(pagibig, 0)) AS TotalSum FROM Employee_Info WHERE usrname=@USERNAME"


        Using con As New SqlConnection(conn)
            con.Open()


            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@employee_id", ID)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim name As String = reader("employee_name").ToString
                        Dim sss As Integer = reader("sss").ToString
                        Dim philhealth As Integer = reader("philhealth").ToString
                        Dim pagibig As Integer = reader("pagibig").ToString
                        Dim BasicHourlyWage As Integer = reader("basicwage").ToString
                        lblNameValue.Text = name.ToUpper
                        lblSssValue.Text = sss
                        lblPhilHealthValue.Text = philhealth
                        lblPagIbigValue.Text = pagibig
                        lblBasicSalaryValue.Text = BasicHourlyWage
                    Else

                        MessageBox.Show($"User with ID {ID} not found.")
                    End If
                End Using
            End Using
        End Using


        'Total Hours
        Using con As New SqlConnection(conn)
            con.Open()

            Using cmd2 As New SqlCommand(totalQuery, con)
                cmd2.Parameters.AddWithValue("@USERNAME", lblNameValue.Text)

                Using reader As SqlDataReader = cmd2.ExecuteReader()
                    If reader.Read() Then
                        Dim totalSum As Integer = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
                        If DGVPayroll.Rows.Count > 0 AndAlso DGVPayroll.Columns.Count > 0 Then
                            DGVPayroll.Rows(0).Cells(0).Value = totalSum
                        Else

                        End If
                    End If
                End Using
            End Using
        End Using

        'Wages
        Using con As New SqlConnection(conn)
            con.Open()

            Using cmd3 As New SqlCommand(totalQuery, con)
                cmd3.Parameters.AddWithValue("@USERNAME", lblNameValue.Text)

                Using reader As SqlDataReader = cmd3.ExecuteReader()
                    If reader.Read() Then
                        Dim totalSum As Integer = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
                        Dim basicsalary As Integer = Convert.ToInt32(lblBasicSalaryValue.Text)
                        If DGVPayroll.Rows.Count > 0 AndAlso DGVPayroll.Columns.Count > 0 Then
                            DGVPayroll.Rows(0).Cells(1).Value = totalSum * basicsalary
                        Else

                        End If
                    End If
                End Using
            End Using
        End Using

        'Total Deductions
        Using con As New SqlConnection(conn)
            con.Open()

            Using cmd4 As New SqlCommand(deductionQuery, con)
                cmd4.Parameters.AddWithValue("@USERNAME", lblNameValue.Text)

                Using reader As SqlDataReader = cmd4.ExecuteReader()
                    If reader.Read() Then
                        Dim totalSum As Integer = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
                        If DGVPayroll.Rows.Count > 0 AndAlso DGVPayroll.Columns.Count > 0 Then
                            DGVPayroll.Rows(0).Cells(2).Value = totalSum
                        Else

                        End If
                    End If
                End Using
            End Using
        End Using

        Using con As New SqlConnection(conn)
            con.Open()

            Using cmd5 As New SqlCommand(deductionQuery, con)
                cmd5.Parameters.AddWithValue("@USERNAME", lblNameValue.Text)

                Using reader As SqlDataReader = cmd5.ExecuteReader()
                    If reader.Read() Then
                        Dim totalSum As Integer = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
                        Dim Wages As Integer = Convert.ToInt32(DGVPayroll.Rows(0).Cells(1).Value)
                        If DGVPayroll.Rows.Count > 0 AndAlso DGVPayroll.Columns.Count > 0 Then
                            DGVPayroll.Rows(0).Cells(3).Value = totalSum - Wages
                        Else

                        End If
                    End If
                End Using
            End Using
            con.Close()
        End Using
    End Sub

    Private connectionString As String = ($"Data Source={engine};Initial Catalog={db};Integrated Security=true")

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If DGVPayroll.Rows.Count > 0 Then
            For Each row As DataGridViewRow In DGVPayroll.Rows
                If Not row.IsNewRow Then
                    Dim column2Value As String = row.Cells(1).Value.ToString()

                    InsertIntoDatabase(column2Value)
                End If

            Next
            MessageBox.Show("Data saved into the database successfully.")
        Else
            MessageBox.Show("No rows in the DataGridView to save.")
        End If
    End Sub

    Private Sub InsertIntoDatabase(column2Value As String)
        Try
            Using con As New SqlConnection(conn)
                Dim query As String = "INSERT INTO Employee_Audit @netwages"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@column2value", column2Value)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class