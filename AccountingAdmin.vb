Public Class AccountingAdmin
    Sub ShowPanel(theForm As Form)
        With theForm
            .TopLevel = False
            pnlContent.Controls.Add(theForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub AccountingAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowPanel(AccountingTaxDeductions)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShowPanel(AccountingPayrollAudit)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowPanel(AccountingTaxDeductions)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowPanel(AccountingMyAccount)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LogInForm.Show()
        Me.Hide()
    End Sub
End Class