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
    Public Function UserData(usrname As String) As Dictionary(Of String, Object)
        Dim res As New Dictionary(Of String, Object)
        query = "SELECT * FROM Employee_Info WHERE usrname = @usrname"
        Try
            conn.Open()
            db_cmd = New SqlCommand(query, conn)
            db_cmd.Parameters.AddWithValue("@usrname", usrname)
            db_reader = db_cmd.ExecuteReader()
            If db_reader.Read() Then
                res.Add("employee_id", db_reader("employee_id"))
                res.Add("employee_name", db_reader("employee_name"))
                res.Add("age", db_reader("age"))
                res.Add("gender", db_reader("gender"))
                res.Add("bday", db_reader("bday").ToString())
                res.Add("email", db_reader("email"))
                res.Add("role", db_reader("role"))
                res.Add("usrname", db_reader("usrname"))
                res.Add("pw", db_reader("pw"))
                res.Add("sss", db_reader("sss"))
                res.Add("philhealth", db_reader("philhealth"))
                res.Add("pagibig", db_reader("pagibig"))
                res.Add("newpw", db_reader("newpw"))
                res.Add("secretpw", db_reader("secretpw"))
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

End Module
