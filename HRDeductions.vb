Imports System.Data.SqlClient

Public Class HRDeductions
    Dim engine = "localhost, 1433"
    Dim db = "payrolldatabase"
    Public Sub FetchData()
        Dim columnsToFetch As String = "employee_name, sss, philhealth, pagibig"

        Dim query As String = $"SELECT {columnsToFetch} FROM Employee_Info"

        Dim dataTable As New DataTable


        Using con As New SqlConnection("Data Source=" + engine + ";Initial Catalog=" + db + ";Integrated Security=true")
            con.Open()
            Using adapter As New SqlDataAdapter(query, con)
                adapter.Fill(dataTable)
            End Using
            con.Close()

        End Using
        DGVDeductions.Columns.Clear()
        DGVDeductions.DataSource = dataTable

    End Sub

    Private Sub HRDeductions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchData()

    End Sub
End Class