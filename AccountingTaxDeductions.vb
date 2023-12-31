﻿Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class AccountingTaxDeductions
    Dim engine = "localhost, 1433"
    Dim db = "payrolldatabase"
    Dim conn As String = ($"Data Source={engine};Initial Catalog={db};Integrated Security=true")

    Public Sub SearchID()
        Dim ID As Integer = Integer.Parse(tbSearchBar.Text)
        Dim query As String = "SELECT * FROM Employee_Info WHERE employee_id =@employee_id"

        Using connection As New SqlConnection(conn)
            connection.Open()


            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@employee_id", ID)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim name As String = reader("employee_name").ToString
                        Dim SSS As Integer = reader("sss").ToString
                        Dim Philhealth As Integer = reader("philhealth").ToString
                        Dim PagIbig As Integer = reader("pagibig").ToString

                        Label1.Text = name
                        tbSSS.Text = SSS
                        tbPhilhealth.Text = Philhealth
                        tbPagIbig.Text = PagIbig

                    Else
                        MessageBox.Show($"User with ID {ID} not found.")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Sub UpdateSSS()
        Dim newSSS As String = tbSSS.Text.Trim()
        Dim searchedID As Integer = Integer.Parse(tbSearchBar.Text)
        Dim currentSSS As String = GetCurrentSSSFromDatabase(searchedID)

        If currentSSS IsNot Nothing Then
            Dim query As String = "UPDATE Employee_Info SET sss = @NewSSS WHERE employee_id = @employee_id"

            Using connection As New SqlConnection(conn)
                connection.Open()

                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@NewSSS", newSSS)
                    cmd.Parameters.AddWithValue("@employee_id", searchedID)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Update successful.")
                    Else
                        MessageBox.Show($"No rows updated for ID: {searchedID}")
                    End If
                End Using
            End Using
        Else
            MessageBox.Show("Current SSS value not found.")
        End If
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchID()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateSSS()
    End Sub
    Private Function GetCurrentSSSFromDatabase(ByVal ID As Integer) As String
        Dim currentSSS As String = Nothing
        Dim query As String = "SELECT sss FROM Employee_Info WHERE employee_id = @employee_id"

        Using connection As New SqlConnection(conn)
            connection.Open()

            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@employee_id", ID)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    currentSSS = reader("sss").ToString()
                End If
            End Using
        End Using

        Return currentSSS
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdatePhilhealth()
    End Sub
    Public Sub UpdatePhilhealth()
        Dim newPhilhealth As String = tbPhilhealth.Text.Trim()
        Dim searchedID As Integer

        If Integer.TryParse(tbSearchBar.Text, searchedID) Then
            Dim currentPhilhealth As String = GetCurrentPhilhealthFromDatabase(searchedID)

            If currentPhilhealth IsNot Nothing Then
                Dim query As String = "UPDATE Employee_Info SET philhealth = @NewPhilhealth WHERE employee_id = @employee_id"

                Using connection As New SqlConnection(conn)
                    connection.Open()

                    Using cmd As New SqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@NewPhilhealth", newPhilhealth)
                        cmd.Parameters.AddWithValue("@employee_id", searchedID)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Update successful.")
                        Else
                            MessageBox.Show($"No rows updated for ID: {searchedID}")
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("Current Philhealth value not found.")
            End If
        Else
            MessageBox.Show("Invalid ID. Please enter a valid integer.")
        End If
    End Sub

    Private Function GetCurrentPhilhealthFromDatabase(ByVal ID As Integer) As String
        Dim currentPhilhealth As String = Nothing
        Dim query As String = "SELECT philhealth FROM Employee_Info WHERE employee_id = @employee_id"

        Using connection As New SqlConnection(conn)
            connection.Open()

            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@employee_id", ID)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    currentPhilhealth = reader("philhealth").ToString()
                End If
            End Using
        End Using

        Return currentPhilhealth
    End Function

    Public Sub UpdatePagIbig()
        Dim newPagIbig As String = tbPagIbig.Text.Trim()
        Dim searchedID As Integer

        If Integer.TryParse(tbSearchBar.Text, searchedID) Then
            Dim currentPagIbig As String = GetCurrentPagIbigFromDatabase(searchedID)

            If currentPagIbig IsNot Nothing Then
                Dim query As String = "UPDATE Employee_Info SET pagibig = @NewPagibig WHERE employee_id = @employee_id"

                Using connection As New SqlConnection(conn)
                    connection.Open()

                    Using cmd As New SqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@NewPagibig", newPagIbig)
                        cmd.Parameters.AddWithValue("@employee_id", searchedID)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Update successful.")
                        Else
                            MessageBox.Show($"No rows updated for ID: {searchedID}")
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("Current PagIbig value not found.")
            End If
        Else
            MessageBox.Show("Invalid ID. Please enter a valid integer.")
        End If
    End Sub

    Private Function GetCurrentPagIbigFromDatabase(ByVal ID As Integer) As String
        Dim currentPagIbig As String = Nothing
        Dim query As String = "SELECT pagibig FROM Employee_Info WHERE employee_id = @employee_id"

        Using connection As New SqlConnection(conn)
            connection.Open()

            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@employee_id", ID)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    currentPagIbig = reader("pagibig").ToString()
                End If
            End Using
        End Using

        Return currentPagIbig
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UpdatePagIbig()

    End Sub

    Private Sub tbSSS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSSS.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbPhilhealth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPhilhealth.KeyPress
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

    Private Sub tbSearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSearchBar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


End Class