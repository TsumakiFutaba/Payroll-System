Imports System.Data.SqlClient
Imports payroll_system_project.DatabaseHandler

Public Class OneTimeEmployeePasswordChange
    Dim engine = "localhost, 1433"
    Dim db = "payrolldatabase"
    Dim con As String = ($"Data Source={engine};Initial Catalog={db};Integrated Security=true")

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim thisUsername As String = tbUsername.Text
        SearchUsername()
        If tbNewPassword.TextLength > 0 Then
            UpdatePassword()
        Else
            MessageBox.Show("New Password contains no value. Please input characters.")
        End If
    End Sub
    Public Sub SearchUsername()
        Dim thisUsername As String = tbUsername.Text
        Dim NewPassword As String = tbNewPassword.Text

        Dim query As String = "SELECT * FROM Employee_Info WHERE usrname = @usrname"

        Using connection As New SqlConnection(con)
            connection.Open()


            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@usrname", thisUsername)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim username As String = reader("usrname").ToString
                    Else
                        MessageBox.Show($"User with username {thisUsername} not found.")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Sub UpdatePassword()
        Dim newPassword As String = tbNewPassword.Text.Trim()
        Dim searchedUsername As String = tbUsername.Text.Trim()

        If Not String.IsNullOrEmpty(searchedUsername) Then
            Dim currentPassword As String = GetCurrentPasswordFromDatabase(searchedUsername)

            If currentPassword IsNot Nothing Then
                Dim query As String = "UPDATE Employee_Info SET pw = @newpw WHERE usrname = @usrname"

                Using connection As New SqlConnection(con)
                    connection.Open()

                    Using cmd As New SqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@newpw", newPassword)
                        cmd.Parameters.AddWithValue("@usrname", searchedUsername)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Update successful.")
                        Else
                            MessageBox.Show($"No rows updated for Username: {searchedUsername}")
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("Current Username value not found.")
            End If
        Else
            MessageBox.Show("Invalid Username. Please enter a valid set of characters.")
        End If
    End Sub

    Private Function GetCurrentPasswordFromDatabase(Username As String) As String
        Dim currentPassword As String = Nothing
        Dim query As String = "SELECT pw FROM Employee_Info WHERE usrname = @usrname"

        Using connection As New SqlConnection(con)
            connection.Open()

            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@usrname", Username)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    currentPassword = reader("pw").ToString()
                End If
            End Using
        End Using
        Return currentPassword
    End Function

    Private Sub newPWChanged(sender As Object, e As EventArgs) Handles tbNewPassword.TextChanged
        Dim containsLowercase As Boolean = False
        Dim containsUpperCase As Boolean = False
        Dim containsNumber As Boolean = False
        Dim containsSymbol As Boolean = False
        Dim containsEightCharacters As Boolean = False
        Dim textInPWTextBox As String = tbNewPassword.Text

        Dim strikeoutFont As New Font(chbOneLowercaseCharacter.Font, FontStyle.Strikeout)
        Dim NotstrikeoutFont As New Font(chbOneLowercaseCharacter.Font, FontStyle.Strikeout = False)

        For Each letters As Char In textInPWTextBox
            If Char.IsLower(letters) Then
                containsLowercase = True
            End If
        Next

        For Each letters As Char In textInPWTextBox
            If Char.IsUpper(letters) Then
                containsUpperCase = True
            End If
        Next

        For Each letters As Char In textInPWTextBox
            If Char.IsNumber(letters) Then
                containsNumber = True
            End If
        Next

        For Each letters As Char In textInPWTextBox
            If Char.IsSymbol(letters) Or Char.IsPunctuation(letters) Then
                containsSymbol = True
            End If
        Next

        If containsLowercase Then
            chbOneLowercaseCharacter.Checked = True
            chbOneLowercaseCharacter.CheckState = CheckState.Checked
            chbOneLowercaseCharacter.Font = strikeoutFont
            Debug.WriteLine("Lowercase character found. Checkbox checked.")
        ElseIf Not containsLowercase Then
            chbOneLowercaseCharacter.Checked = False
            chbOneLowercaseCharacter.CheckState = CheckState.Unchecked
            chbOneLowercaseCharacter.Font = NotstrikeoutFont
        End If

        If containsUpperCase Then
            chbOneUppercaseCharacter.Checked = True
            chbOneUppercaseCharacter.CheckState = CheckState.Checked
            Debug.WriteLine("Uppercase character found. Checkbox checked.")
        ElseIf Not containsUpperCase Then
            chbOneUppercaseCharacter.Checked = False
            chbOneUppercaseCharacter.CheckState = CheckState.Unchecked
        End If

        If containsNumber Then
            chbOneNumberCharacter.Checked = True
            chbOneNumberCharacter.CheckState = CheckState.Checked
            Debug.WriteLine("Number found. Checkbox checked.")
        ElseIf Not containsNumber Then
            chbOneNumberCharacter.Checked = False
            chbOneNumberCharacter.CheckState = CheckState.Unchecked
        End If

        If textInPWTextBox.Length >= 8 Then
            chbCharactersMinimum.Checked = True
            chbCharactersMinimum.CheckState = CheckState.Checked
            Debug.WriteLine("8 characters met. Checkbox checked.")
            containsEightCharacters = True
        ElseIf textInPWTextBox.Length < 8 Then
            chbCharactersMinimum.Checked = False
            chbCharactersMinimum.CheckState = CheckState.Unchecked
            containsEightCharacters = False
        End If

        If containsSymbol Then
            chbOneSpecialCharacter.Checked = True
            chbOneSpecialCharacter.CheckState = CheckState.Checked
            Debug.WriteLine("Symbols found. Checkbox checked.")
            containsSymbol = True
        ElseIf Not containsSymbol Then
            chbOneSpecialCharacter.Checked = False
            chbOneSpecialCharacter.CheckState = CheckState.Unchecked
            containsSymbol = False
        End If
    End Sub
End Class