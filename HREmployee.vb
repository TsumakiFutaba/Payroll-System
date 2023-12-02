Imports System.Data.SqlClient
Public Class HREmployee
    Public Sub FetchData()
        Dim columnsToFetch As String = "Name, Position"

        Dim query As String = $"SELECT {columnsToFetch} FROM Employee_Info"

        Dim dataTable As New DataTable


        Using con As New SqlConnection("Data Source=DESKTOP-V5VR7RP\SQLEXPRESS;Initial Catalog=payrolldatabase;Integrated Security=true")
            con.Open()
            Using adapter As New SqlDataAdapter(query, con)
                adapter.Fill(dataTable)
            End Using
            con.Close()

        End Using
        dgvEmployee.Columns.Clear()
        dgvEmployee.DataSource = dataTable

    End Sub

    Private Sub HREmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchData()

    End Sub
End Class