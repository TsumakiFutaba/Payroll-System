Public Class PayrollForm
    Private Sub btnPaySlip_Click(sender As Object, e As EventArgs) Handles btnPaySlip.Click
        Dim frm As New PayslipForm
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        TransparentBG.ShowForm(frm)
    End Sub
End Class