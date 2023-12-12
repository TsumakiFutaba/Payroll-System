Imports System.Data.SqlClient
Public Class BackupDatabase
    Dim engine = "localhost, 1433"
    Dim db = "payrolldatabase"
    Dim con As New SqlConnection($"Server={engine};database={db};Integrated Security=true")
    Private Sub btnBrowse1_Click(sender As Object, e As EventArgs) Handles btnBrowse1.Click
        Dim dlg As New FolderBrowserDialog()
        If (dlg.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            tbLocation1.Text = dlg.SelectedPath
        End If
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim database As String = con.Database.ToString()
        If (tbLocation1.Text Is String.Empty) Then
            MessageBox.Show("Please enter backup file location.")
        Else
            Dim str As String = "BACKUP DATABASE [" + database + "] TO DISK ='" + tbLocation1.Text + "\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'"
            con.Open()
            Dim cmd As New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Database Backup successfully done!")
        End If

    End Sub

    Private Sub btnBrowse2_Click(sender As Object, e As EventArgs) Handles btnBrowse2.Click
        Dim dlg As OpenFileDialog = New OpenFileDialog()
        dlg.Filter = "SQL SERVER BACKUP FILE|*.bak"
        dlg.Title = "Restore database"
        If (dlg.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            tbLocation2.Text = dlg.FileName
        End If

    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim database As String = con.Database.ToString()
        con.Open()
        Dim str1 As String = String.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE")
        Dim cmd1 As New SqlCommand(str1, con)
        cmd1.ExecuteNonQuery()

        Dim str2 As String = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK ='" + tbLocation2.Text + "' WITH REPLACE"
        Dim cmd2 As New SqlCommand(str2, con)
        cmd2.ExecuteNonQuery()

        Dim str3 As String = String.Format("ALTER DATABASE [" + database + "] SET MULTI_USER")
        Dim cmd3 As New SqlCommand(str3, con)
        cmd3.ExecuteNonQuery()

        MessageBox.Show("Restoration of Database done successfully!")
        con.Close()
    End Sub
End Class
