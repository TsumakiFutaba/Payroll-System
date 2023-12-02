Imports System.Data.SqlClient

Module CRUDConnection
    Public result As String
    Dim con As New SqlConnection("Data Source=DESKTOP-V5VR7RP\SQLEXPRESS;Initial Catalog=payrolldatabase;Integrated Security=true")
    Public da As New SqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Public cmd As New SqlCommand

    Public Sub reloadtxt(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            dt = New DataTable
            da = New SqlDataAdapter(sql, con)
            da.Fill(dt)

        Catch ex As Exception
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub createLogged(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
            End With
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub updateLogged(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
            End With
        Catch ex As Exception
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
End Module
