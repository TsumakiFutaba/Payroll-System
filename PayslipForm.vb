Public Class PayslipForm
    Private Sub PayslipForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        DGVEntitlements.Rows.Add()
        DGVEntitlements.Rows(0).Cells(0).Value = "Wages"
        DGVEntitlements.Rows.Add()
        DGVEntitlements.Rows(1).Cells(0).Value = "Overtime"

        DGVDeductions.Rows.Add()
        DGVDeductions.Rows(0).Cells(0).Value = "SSS"
        DGVDeductions.Rows.Add()
        DGVDeductions.Rows(1).Cells(0).Value = "PhilHealth"
        DGVDeductions.Rows.Add()
        DGVDeductions.Rows(2).Cells(0).Value = "PagIbig"
        DGVDeductions.Rows.Add()
        DGVDeductions.Rows(3).Cells(0).Value = "Abscences"
        DGVDeductions.Rows.Add()
        DGVDeductions.Rows(4).Cells(0).Value = "Tardiness"

        DGVNetPay.Rows.Add()
        DGVNetPay.Rows(0).Cells(0).Value = "Total Basic Salary After Overtime Pay"
        DGVNetPay.Rows.Add()
        DGVNetPay.Rows(1).Cells(0).Value = "Less: Total Deduction"
        DGVNetPay.Rows.Add()
        DGVNetPay.Rows(2).Cells(0).Value = "Total Net Pay"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class