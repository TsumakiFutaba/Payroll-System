Imports System.Data.SqlClient

Public Class HRAttendanceForm
    Dim engine = "localhost, 1433"
    Dim db = "payrolldatabase"
    Public Sub FetchData()
        Dim columnsToFetch As String = "USERNAME, inTime, inStatus, inDate, outTime, outStatus, outDate, totalHours"
        Dim query As String = $"SELECT {columnsToFetch} FROM Employee_Attendances"
        Dim dataTable As New DataTable


        Using con As New SqlConnection($"Data Source={engine};Initial Catalog={db};Integrated Security=true")
            con.Open()
            Using adapter As New SqlDataAdapter(query, con)
                adapter.Fill(dataTable)
            End Using
            con.Close()

        End Using
        dgvAttendance.Columns.Clear()
        dgvAttendance.DataSource = dataTable

    End Sub
    Private Sub HRAttendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchData()
    End Sub
End Class