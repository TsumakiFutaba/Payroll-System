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


        Using connection As New SqlConnection(conn)
            connection.Open()


            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@employee_id", ID)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim name As String = reader("employee_name").ToString
                        Dim SSS As Integer = reader("sss").ToString
                        Dim Philhealth As Integer = reader("philhealth").ToString
                        Dim PagIbig As Integer = reader("pagibig").ToString
                        Dim BasicHourlyWage As Integer = reader("basicwage").ToString
                        lblNameValue.Text = name.ToUpper
                        lblSssValue.Text = SSS
                        lblPhilHealthValue.Text = Philhealth
                        lblPagIbigValue.Text = PagIbig
                        lblBasicSalaryValue.Text = BasicHourlyWage


                    Else

                        MessageBox.Show($"User with ID {ID} not found.")
                    End If
                End Using
            End Using
        End Using


        'Total Hours
        Using connection As New SqlConnection(conn)
            connection.Open()

            Using cmd As New SqlCommand(totalQuery, connection)
                cmd.Parameters.AddWithValue("@USERNAME", lblNameValue.Text)

                Using reader As SqlDataReader = cmd.ExecuteReader()
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
        Using connection As New SqlConnection(conn)
            connection.Open()

            Using cmd As New SqlCommand(totalQuery, connection)
                cmd.Parameters.AddWithValue("@USERNAME", lblNameValue.Text)

                Using reader As SqlDataReader = cmd.ExecuteReader()
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
        Using connection As New SqlConnection(conn)
            connection.Open()

            Using cmd As New SqlCommand(deductionQuery, connection)
                cmd.Parameters.AddWithValue("@USERNAME", lblNameValue.Text)

                Using reader As SqlDataReader = cmd.ExecuteReader()
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

        'Net Wages
        Using connection As New SqlConnection(conn)
            connection.Open()

            Using cmd As New SqlCommand(deductionQuery, connection)
                cmd.Parameters.AddWithValue("@USERNAME", lblNameValue.Text)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim totalSum As Integer = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
                        Dim Wages As Integer = Convert.ToInt32(DGVPayroll.Rows(0).Cells(1).Value)
                        If DGVPayroll.Rows.Count > 0 AndAlso DGVPayroll.Columns.Count > 0 Then
                            DGVPayroll.Rows(0).Cells(3).Value = Wages - totalSum
                        Else

                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class