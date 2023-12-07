Imports System.Data.SqlClient
Public Class EmployeeMyAttendance


    Private Sub EmployeeMyAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchData()

    End Sub

    Public Sub FetchData()
        Dim columnsToFetch As String = "USERNAME, inTime, inStatus, inDate, outTime, outStatus, outDate"

        Dim query As String = $"SELECT {columnsToFetch} FROM Employee_Attendances"

        Dim dataTable As New DataTable


        Using con As New SqlConnection("Data Source=DESKTOP-9FJ16TI\SQLEXPRESS;Initial Catalog=payrolldatabase;Integrated Security=true")
            con.Open()
            Using adapter As New SqlDataAdapter(query, con)
                adapter.Fill(dataTable)
            End Using
            con.Close()

        End Using
        dgvAttendance.Columns.Clear()
        dgvAttendance.DataSource = dataTable
    End Sub

End Class