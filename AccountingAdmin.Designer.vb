<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountingAdmin
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
        pnlLeft = New Panel()
        pnlSalarytext = New Panel()
        pnlSS = New Panel()
        lSummary = New Label()
        pnlButtons2 = New Panel()
        Button1 = New Button()
        btnLogout = New Button()
        pnlButtons1 = New Panel()
        Button2 = New Button()
        pnlReports = New Panel()
        lReports = New Label()
        btnDashboard = New Button()
        pnlLogo = New Panel()
        pbLogo = New PictureBox()
        pnlMain = New Panel()
        pnlContent = New Panel()
        pnlTop = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        pnlLeft.SuspendLayout()
        pnlSalarytext.SuspendLayout()
        pnlSS.SuspendLayout()
        pnlButtons2.SuspendLayout()
        pnlButtons1.SuspendLayout()
        pnlReports.SuspendLayout()
        pnlLogo.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlTop.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLeft
        ' 
        pnlLeft.Controls.Add(pnlSalarytext)
        pnlLeft.Controls.Add(pnlButtons1)
        pnlLeft.Controls.Add(pnlLogo)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(0, 0)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(203, 800)
        pnlLeft.TabIndex = 2
        ' 
        ' pnlSalarytext
        ' 
        pnlSalarytext.Controls.Add(pnlSS)
        pnlSalarytext.Controls.Add(pnlButtons2)
        pnlSalarytext.Dock = DockStyle.Fill
        pnlSalarytext.Location = New Point(0, 472)
        pnlSalarytext.Name = "pnlSalarytext"
        pnlSalarytext.Size = New Size(203, 328)
        pnlSalarytext.TabIndex = 2
        ' 
        ' pnlSS
        ' 
        pnlSS.BackColor = Color.FromArgb(CByte(75), CByte(85), CByte(95))
        pnlSS.Controls.Add(lSummary)
        pnlSS.Dock = DockStyle.Top
        pnlSS.Location = New Point(0, 0)
        pnlSS.Name = "pnlSS"
        pnlSS.Size = New Size(203, 51)
        pnlSS.TabIndex = 7
        ' 
        ' lSummary
        ' 
        lSummary.AutoSize = True
        lSummary.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lSummary.ForeColor = Color.WhiteSmoke
        lSummary.Location = New Point(12, 14)
        lSummary.Name = "lSummary"
        lSummary.Size = New Size(72, 21)
        lSummary.TabIndex = 0
        lSummary.Text = "Settings"
        ' 
        ' pnlButtons2
        ' 
        pnlButtons2.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        pnlButtons2.Controls.Add(Button1)
        pnlButtons2.Controls.Add(btnLogout)
        pnlButtons2.Dock = DockStyle.Fill
        pnlButtons2.Location = New Point(0, 0)
        pnlButtons2.Name = "pnlButtons2"
        pnlButtons2.Size = New Size(203, 328)
        pnlButtons2.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        Button1.Image = My.Resources.Resources.icons8_account_24
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(1, 252)
        Button1.Name = "Button1"
        Button1.Size = New Size(203, 34)
        Button1.TabIndex = 9
        Button1.Text = "My Account"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogout.ForeColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        btnLogout.Image = My.Resources.Resources.logout_logout
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(0, 289)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(203, 34)
        btnLogout.TabIndex = 8
        btnLogout.Text = "Log out"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' pnlButtons1
        ' 
        pnlButtons1.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        pnlButtons1.Controls.Add(Button2)
        pnlButtons1.Controls.Add(pnlReports)
        pnlButtons1.Controls.Add(btnDashboard)
        pnlButtons1.Dock = DockStyle.Top
        pnlButtons1.Location = New Point(0, 68)
        pnlButtons1.Name = "pnlButtons1"
        pnlButtons1.Size = New Size(203, 404)
        pnlButtons1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        Button2.Image = My.Resources.Resources.icons8_audit_24
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(0, 85)
        Button2.Name = "Button2"
        Button2.Size = New Size(203, 34)
        Button2.TabIndex = 3
        Button2.Text = "Payroll Audit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' pnlReports
        ' 
        pnlReports.BackColor = Color.FromArgb(CByte(75), CByte(85), CByte(95))
        pnlReports.Controls.Add(lReports)
        pnlReports.Dock = DockStyle.Top
        pnlReports.Location = New Point(0, 0)
        pnlReports.Name = "pnlReports"
        pnlReports.Size = New Size(203, 46)
        pnlReports.TabIndex = 2
        ' 
        ' lReports
        ' 
        lReports.AutoSize = True
        lReports.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lReports.ForeColor = Color.WhiteSmoke
        lReports.Location = New Point(12, 11)
        lReports.Name = "lReports"
        lReports.Size = New Size(179, 25)
        lReports.TabIndex = 0
        lReports.Text = "Accounting Admin"
        ' 
        ' btnDashboard
        ' 
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnDashboard.ForeColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        btnDashboard.Image = My.Resources.Resources.icons8_accounting_24
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(0, 47)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(203, 34)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "Tax Deductions"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' pnlLogo
        ' 
        pnlLogo.Controls.Add(pbLogo)
        pnlLogo.Dock = DockStyle.Top
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(203, 68)
        pnlLogo.TabIndex = 0
        ' 
        ' pbLogo
        ' 
        pbLogo.Dock = DockStyle.Fill
        pbLogo.Image = My.Resources.Resources.Logo
        pbLogo.Location = New Point(0, 0)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(203, 68)
        pbLogo.TabIndex = 0
        pbLogo.TabStop = False
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(pnlContent)
        pnlMain.Controls.Add(pnlTop)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(203, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(997, 800)
        pnlMain.TabIndex = 3
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = SystemColors.ControlLight
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 68)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(997, 732)
        pnlContent.TabIndex = 1
        ' 
        ' pnlTop
        ' 
        pnlTop.BackColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        pnlTop.Controls.Add(FlowLayoutPanel1)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.Size = New Size(997, 68)
        pnlTop.TabIndex = 0
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(0, 68)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(200, 100)
        FlowLayoutPanel1.TabIndex = 8
        ' 
        ' AccountingAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 800)
        Controls.Add(pnlMain)
        Controls.Add(pnlLeft)
        FormBorderStyle = FormBorderStyle.None
        Name = "AccountingAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AccountingAdmin"
        pnlLeft.ResumeLayout(False)
        pnlSalarytext.ResumeLayout(False)
        pnlSS.ResumeLayout(False)
        pnlSS.PerformLayout()
        pnlButtons2.ResumeLayout(False)
        pnlButtons1.ResumeLayout(False)
        pnlReports.ResumeLayout(False)
        pnlReports.PerformLayout()
        pnlLogo.ResumeLayout(False)
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlTop.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlSalarytext As Panel
    Friend WithEvents pnlSS As Panel
    Friend WithEvents lSummary As Label
    Friend WithEvents pnlButtons2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlButtons1 As Panel
    Friend WithEvents pnlReports As Panel
    Friend WithEvents lReports As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button2 As Button
End Class
