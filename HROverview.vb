Imports System.Data.SqlClient

Public Class HROverview

    Public Sub CountEmployees()
        Dim query As String = "SELECT COUNT(*) FROM Employee_Info"

        Using con As New SqlConnection("Data Source=DESKTOP-V5VR7RP\SQLEXPRESS;Initial Catalog=payrolldatabase;Integrated Security=true")
            con.Open()

            Using cmd As New SqlCommand(query, con)
                Dim totalEmployees As Integer = CInt(cmd.ExecuteScalar())

                lblTotalemployee.Text = totalEmployees.ToString
            End Using
        End Using


    End Sub

    Private Sub HROverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountEmployees()
    End Sub


End Class