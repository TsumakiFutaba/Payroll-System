Imports System.Data.SqlClient

Public Class ITUsers
    'Dim con As New SqlConnection("Data Source=DESKTOP-V5VR7RP\SQLEXPRESS;Initial Catalog=payrolldatabase;Integrated Security=true")

    Private Sub ITUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchData()
    End Sub

    Public Sub FetchData()
        Dim columnsToFetch As String = "ID, Name, Username, Password"

        Dim query As String = $"SELECT {columnsToFetch} FROM Employee_Info"

        Dim dataTable As New DataTable


        Using con As New SqlConnection("Data Source=DESKTOP-9FJ16TI\SQLEXPRESS;Initial Catalog=payrolldatabase;Integrated Security=true")
            con.Open()
            Using adapter As New SqlDataAdapter(query, con)
                adapter.Fill(dataTable)
            End Using
            con.Close()

        End Using
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = dataTable


    End Sub
End Class
