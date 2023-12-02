<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HROverview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlDashboard = New Panel()
        lblOverview = New Label()
        pnlTotalEmployee = New Panel()
        lblTextemployee = New Label()
        lblTotalemployee = New Label()
        pbEmployeePicture = New PictureBox()
        pnlDashboard.SuspendLayout()
        pnlTotalEmployee.SuspendLayout()
        CType(pbEmployeePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.Controls.Add(lblOverview)
        pnlDashboard.Controls.Add(pnlTotalEmployee)
        pnlDashboard.Dock = DockStyle.Fill
        pnlDashboard.Location = New Point(0, 0)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(997, 732)
        pnlDashboard.TabIndex = 1
        ' 
        ' lblOverview
        ' 
        lblOverview.AutoSize = True
        lblOverview.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        lblOverview.ForeColor = SystemColors.ControlDarkDark
        lblOverview.Location = New Point(39, 22)
        lblOverview.Name = "lblOverview"
        lblOverview.Size = New Size(176, 47)
        lblOverview.TabIndex = 6
        lblOverview.Text = "Overview"
        ' 
        ' pnlTotalEmployee
        ' 
        pnlTotalEmployee.BackColor = Color.FromArgb(CByte(25), CByte(137), CByte(185))
        pnlTotalEmployee.Controls.Add(lblTextemployee)
        pnlTotalEmployee.Controls.Add(lblTotalemployee)
        pnlTotalEmployee.Controls.Add(pbEmployeePicture)
        pnlTotalEmployee.Location = New Point(97, 208)
        pnlTotalEmployee.Name = "pnlTotalEmployee"
        pnlTotalEmployee.Size = New Size(777, 279)
        pnlTotalEmployee.TabIndex = 0
        ' 
        ' lblTextemployee
        ' 
        lblTextemployee.AutoSize = True
        lblTextemployee.BackColor = Color.Transparent
        lblTextemployee.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblTextemployee.ForeColor = Color.WhiteSmoke
        lblTextemployee.Location = New Point(168, 144)
        lblTextemployee.Name = "lblTextemployee"
        lblTextemployee.Size = New Size(154, 25)
        lblTextemployee.TabIndex = 1
        lblTextemployee.Text = "Total Employees"
        ' 
        ' lblTotalemployee
        ' 
        lblTotalemployee.AutoSize = True
        lblTotalemployee.Font = New Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalemployee.ForeColor = Color.White
        lblTotalemployee.Location = New Point(226, 59)
        lblTotalemployee.Name = "lblTotalemployee"
        lblTotalemployee.Size = New Size(50, 59)
        lblTotalemployee.TabIndex = 0
        lblTotalemployee.Text = "0"
        ' 
        ' pbEmployeePicture
        ' 
        pbEmployeePicture.Image = My.Resources.Resources.total_employee
        pbEmployeePicture.Location = New Point(400, 31)
        pbEmployeePicture.Name = "pbEmployeePicture"
        pbEmployeePicture.Size = New Size(248, 212)
        pbEmployeePicture.SizeMode = PictureBoxSizeMode.StretchImage
        pbEmployeePicture.TabIndex = 3
        pbEmployeePicture.TabStop = False
        ' 
        ' HROverview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 732)
        Controls.Add(pnlDashboard)
        FormBorderStyle = FormBorderStyle.None
        Name = "HROverview"
        Text = "DashboardForm"
        pnlDashboard.ResumeLayout(False)
        pnlDashboard.PerformLayout()
        pnlTotalEmployee.ResumeLayout(False)
        pnlTotalEmployee.PerformLayout()
        CType(pbEmployeePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents lblOverview As Label
    Friend WithEvents pnlTotalEmployee As Panel
    Friend WithEvents lblTextemployee As Label
    Friend WithEvents lblTotalemployee As Label
    Friend WithEvents pbEmployeePicture As PictureBox
End Class
