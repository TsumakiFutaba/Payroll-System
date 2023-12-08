Imports System.Data.SqlClient

Public Class ITUsers
    Private Sub ITUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        FetchData()
    End Sub

    Public Sub FetchData()
        Dim columnsToFetch As String = "employee_id, employee_name, usrname, pw"

        Dim query As String = $"SELECT {columnsToFetch} FROM Employee_Info"

        Dim dataTable As New DataTable

        Using con As New SqlConnection("Data Source=localhost, 1433;Initial Catalog=payrolldatabase;Integrated Security=true")
            con.Open()
            Using adapter As New SqlDataAdapter(query, con)
                adapter.Fill(dataTable)
            End Using
            con.Close()

        End Using
        dgvUsers.Columns.Clear()
        dgvUsers.DataSource = dataTable


    End Sub
End Class
