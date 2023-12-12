'Imports System.Data.SqlClient
Imports payroll_system_project.DatabaseHandler

Public Class OneTimeEmployeePasswordChange

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim sql_data As Dictionary(Of String, Object) = DatabaseHandler.UserData(tbUsername.Text)

        If Not String.IsNullOrEmpty(tbNewPassword.Text) And
            (Not String.IsNullOrEmpty(tbSecretPW.Text) And sql_data.GetValueOrDefault("secretpw") = tbSecretPW.Text) Then
            UpdatePassword(sql_data.GetValueOrDefault("usrname"), sql_data.GetValueOrDefault("pw"), tbNewPassword.Text)
        Else
            MessageBox.Show("New Password and Secret Password contains no value. Please input characters.")
        End If

    End Sub

    Public Sub UpdatePassword(db_usrname As String, db_pw As String, newpw As String)
        If Not String.IsNullOrEmpty(db_usrname) Then

            If Not String.IsNullOrEmpty(db_pw) And (
                Not String.IsNullOrEmpty(newpw) _
                And
                (chbOneLowercaseCharacter.Checked = True And chbOneLowercaseCharacter.CheckState = CheckState.Checked _
                And chbOneNumberCharacter.Checked = True And chbOneNumberCharacter.CheckState = CheckState.Checked _
                And chbOneUppercaseCharacter.Checked = True And chbOneUppercaseCharacter.CheckState = CheckState.Checked _
                And chbCharactersMinimum.Checked = True And chbCharactersMinimum.CheckState = CheckState.Checked _
                And chbOneSpecialCharacter.Checked = True And chbOneSpecialCharacter.CheckState = CheckState.Checked)
                ) Then

                Dim sql_updated_rows As Int32 = DatabaseHandler.UpdatePW(db_usrname, newpw)

                If sql_updated_rows > 0 Then
                    MessageBox.Show("Password successfully changes.")
                    Me.Hide()
                    LogInForm.Show()
                Else
                    MessageBox.Show($"Cannot change password.{vbCrLf}Check password conditions.")
                End If

            Else

                MessageBox.Show("Please check your credentials.")

            End If

        Else

            MessageBox.Show("Invalid Username. Please enter a valid set of characters.")

        End If
    End Sub
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