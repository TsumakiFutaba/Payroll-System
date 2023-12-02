Public Class HRAdmin

    Sub HighlighActiveButton(myButton As Button, myForm As Form)
        If myForm.Visible() Then
            myButton.BackColor = Color.FromArgb(95, 105, 115)
        ElseIf Not myForm.Visible() Then
            myButton.BackColor = Color.FromArgb(70, 80, 90)
        End If
    End Sub
    Sub ShowPanel(theForm As Form)
        With theForm
            .TopLevel = False
            pnlContent.Controls.Add(theForm)
            .BringToFront()
            .Show()
        End With

    End Sub
    Sub HidePanel(theForm As Form)
        With theForm
            .TopLevel = False
            pnlContent.Controls.Add(theForm)
            .Hide()
        End With

    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowPanel(HROverview)

    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        HidePanel(HROverview)
        HidePanel(HREmployee)
        ShowPanel(HRAttendanceForm)

    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        HidePanel(HROverview)
        HidePanel(HRAttendanceForm)
        ShowPanel(HREmployee)

    End Sub

    Private Sub btnDeductions_Click(sender As Object, e As EventArgs) Handles btnDeductions.Click
        ShowPanel(HRDeductions)
    End Sub



    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        ShowPanel(PayrollForm)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LogInForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowPanel(HROverview)
    End Sub
End Class