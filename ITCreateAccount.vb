Imports System.Data.SqlClient

Public Class ITCreateAccount
    Dim engine = "localhost, 1433"
    Dim db = "payrolldatabase"
    Dim con As New SqlConnection("Data Source=" + engine + ";Initial Catalog=" + db + ";Integrated Security=true")
    Dim cmd As New SqlCommand
    Dim sd As New SqlDataAdapter
    Dim dt As New DataTable
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles btnRegister.MouseHover
        btnRegister.ForeColor = Color.FromArgb(203, 203, 203)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave
        btnRegister.ForeColor = Color.FromArgb(70, 80, 90)

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        con.Open()

        'cmd = New SqlCommand("insert into dbo.Employee_Info values ('" & tbName.Text & "','" & tbAge.Text & "','" & tbGender.Text & "','" & DateTimePickDOB.Text & "','" & cbPosition.Text & "','" & tbPreferredUsername.Text & "','" & tbPreferredPassword.Text & "','" & tbSSS.Text & "','" & "','" & tbPhilhealth.Text & "','" & "','" & tbPagIbig.Text & "')", con)
        'cmd.ExecuteNonQuery()
        ' (ID, Name, Age, Gender, Birthday, Email, Position, Username, Password, SSS, Philhealth, Pagibig) 

        cmd = New SqlCommand("INSERT INTO Employee_Info VALUES (@employee_id, @employee_name, @age, @gender, @bday, @email, @position, @usrname, @pw, @sss, @philhealth, @pagibig)", con)

        cmd.Parameters.AddWithValue("@employee_id", tbID.Text)
        cmd.Parameters.AddWithValue("@employee_name", tbName.Text)
        cmd.Parameters.AddWithValue("@age", tbAge.Text)
        cmd.Parameters.AddWithValue("@gender", cbGender.Text)
        cmd.Parameters.AddWithValue("@bday", DateTimePickDOB.Value)
        cmd.Parameters.AddWithValue("@email", tbEmail.Text)
        cmd.Parameters.AddWithValue("@position", cbPosition.Text)
        cmd.Parameters.AddWithValue("@usrname", tbPreferredUsername.Text)
        cmd.Parameters.AddWithValue("@pw", tbPreferredPassword.Text)
        cmd.Parameters.AddWithValue("@sss", tbSSS.Text)
        cmd.Parameters.AddWithValue("@philhealth", tbPhilhealth.Text)
        cmd.Parameters.AddWithValue("@pagibig", tbPagIbig.Text)


        cmd.ExecuteNonQuery()

        MessageBox.Show("Successfully Added!")
        con.Close()

        ClearText()


    End Sub

    Public Function ClearText()
        tbName.Text = ""
        tbAge.Text = ""
        cbGender.Text = ""
        tbEmail.Text = ""
        cbPosition.Text = ""
        tbPreferredPassword.Text = ""
        tbPreferredPassword.Text = ""
        tbSSS.Text = ""
        tbPhilhealth.Text = ""
        tbPagIbig.Text = ""
    End Function

    Private Sub Age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbAge.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub EmployeeID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbID.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbSSS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSSS.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbPhilHealth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPhilhealth.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbPagIbig_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPagIbig.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class