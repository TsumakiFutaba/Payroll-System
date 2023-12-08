Imports System.Data.SqlClient
Public Class BackupDatabase

    Dim con, con1 As SqlConnection
    Dim cmd As SqlCommand
    Dim dread As SqlDataReader

    Private Sub BackupDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        server("localhost, 1433")
    End Sub

    Sub server(ByVal engine As String)
        con = New SqlConnection("Data Source=" & engine & ";Database=Master;Integrated Security=SSPI;")
        con.Open()
        cmd = New SqlCommand("SELECT * FROM sysservers where srvproduct='SQL Server'", con)
        dread = cmd.ExecuteReader()
        While dread.Read
            cbServer.Items.Add(dread(2))
        End While
        dread.Close()
    End Sub

    Sub connection()
        con = New SqlConnection("Data Source=" & Trim(cbServer.Text) & ";Database=Master;Integrated Security=true")
        con.Open()
        cbDatabase.Items.Clear()
        cmd = New SqlCommand("SELECT * FROM sysdatabases", con)
        dread = cmd.ExecuteReader()
        While dread.Read
            cbDatabase.Items.Add(dread(0))
        End While
        dread.Close()
    End Sub

    Private Sub cbServer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServer.SelectedIndexChanged
        connection()
    End Sub

    Sub query(ByVal que As String)
        On Error Resume Next
        cmd = New SqlCommand(que, con)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub TimerBackup_Tick(sender As Object, e As EventArgs) Handles TimerBackup.Tick
        If prgbrBackup.Value = 100 Then
            TimerBackup.Enabled = False
            prgbrBackup.Visible = False
            MsgBox("Backup Successfull!")
        Else
            prgbrBackup.Value = prgbrBackup.Value + 5
        End If
    End Sub

    Sub blank(ByVal engine As String)
        If cbServer.Text = "" Or cbDatabase.Text = "" Then
            MsgBox("Server name and database Blank Field")
            Exit Sub
        Else
            If engine = "backup" Then
                sfdBackup.FileName = cbDatabase.Text
                sfdBackup.ShowDialog()
                TimerBackup.Enabled = True
                prgbrBackup.Visible = True
                Dim save As String
                save = sfdBackup.FileName
                query($"backup database {cbDatabase.Text} to disk='{save}'")
            ElseIf engine = "restore" Then
                ofdBackup.ShowDialog()
                TimerBackup.Enabled = True
                prgbrBackup.Visible = True
                query("restore database " & cbDatabase.Text & " FROM disk='" & ofdBackup.FileName & "'")
            End If
        End If
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        blank("backup")
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        blank("restore")
    End Sub
End Class