' The program's database handler module, which contains all of
' the database operations for it. It's objective is to
' communicate with a Microsoft SQL Server database engine
' to perform SQL executions/transactions (kind of like ORM)
' and also simplify the procedure of the program by isolating
' the executions/transactions to the actual program logic.

Imports System.Data.SqlClient

Module DatabaseHandler

    ' The variable for SQL Statements
    Private query As String
    ' The database server address or engine
    Private ReadOnly db_engine As String = "localhost, 1433"
    ' The database name within the server
    Private ReadOnly db As String = "payrolldatabase"
    ' The connection that will allow the program to communicate to the database server
    Private ReadOnly conn As New SqlConnection($"Data Source={db_engine};Initial Catalog={db};Integrated Security=true")
    Private db_cmd As SqlCommand
    Private db_reader As SqlDataReader

    ' Querying the database for username, password, and role of a user, 
    ' and return it as a set of Key-Value pair
    Public Function LoginData(usrname As TextBox, pw As TextBox) As Dictionary(Of String, String)

        Dim searched_usr As String
        Dim searched_pw As String
        Dim searched_role As String
        Dim res As New Dictionary(Of String, String)
        query = "SELECT usrname, pw, role FROM Employee_Info WHERE usrname = @usrname"

        Try

            conn.Open()
            db_cmd = New SqlCommand(query, conn)
            db_cmd.Parameters.AddWithValue("@usrname", usrname.Text)
            db_reader = db_cmd.ExecuteReader()

            If db_reader.Read() Then

                searched_usr = db_reader("usrname").ToString()
                searched_pw = db_reader("pw").ToString()
                searched_role = db_reader("role").ToString()

                res.Add("usrname", db_reader("usrname").ToString())
                res.Add("pw", db_reader("pw").ToString())
                res.Add("role", db_reader("role").ToString())

            Else

                MessageBox.Show("Username and Password are not found.")
                usrname.Clear()
                pw.Clear()
                usrname.Focus()

            End If

        Catch ex As Exception

            MessageBox.Show($"HTTP 500: Unexpected Error.{vbCrLf}Message:{ex}")
            Application.Exit()

        Finally

            db_reader.Close()
            conn.Close()

        End Try

        Return res

    End Function

    ' TODO: Try to analyze further for some optimizations
    Public Function GetUser(usrname As String) As String

        Dim searchedUser As String = Nothing
        query = "SELECT usrname FROM Employee_Info WHERE usrname = @usrname"

        Try
            conn.Open()
            db_cmd = New SqlCommand(query, conn)
            db_cmd.Parameters.AddWithValue("@usrname", usrname)
            db_reader = db_cmd.ExecuteReader()
            If db_reader.Read() Then
                searchedUser = db_reader("usrname").ToString()
            Else
                MessageBox.Show($"HTTP 404: Username '{usrname}' not found.")
            End If
        Catch ex As Exception
            MessageBox.Show($"HTTP 500: Unexpected Error.{vbCrLf}Message:{ex}")
            Application.Exit()
        Finally
            db_reader.Close()
            conn.Close()
        End Try

        Return searchedUser

    End Function

    ' TODO: Implement the password update logic based on GetUser
    Public Sub PassUpdate(usrname As TextBox, pw As TextBox)

        Dim searchedUser = GetUser(usrname.Text.Trim())

        If Not String.IsNullOrEmpty(searchedUser) Then

        End If

    End Sub

End Module
