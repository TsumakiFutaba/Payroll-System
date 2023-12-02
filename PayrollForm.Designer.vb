<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollForm
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
        pnlCenter = New Panel()
        pnlDGVPayroll = New Panel()
        DGVPayroll = New DataGridView()
        pnlPayrollInformation = New Panel()
        ComboBox1 = New ComboBox()
        lblPagIbigValue = New Label()
        lblPhilHealthValue = New Label()
        lblSssValue = New Label()
        lblOvertimePayValue = New Label()
        lblBasicSalaryValue = New Label()
        lblNameValue = New Label()
        btnSearch = New Button()
        tbSearchBar = New TextBox()
        lblSearchEmployee = New Label()
        lblOvertimePay = New Label()
        lblPagIbig = New Label()
        lblPhilHealth = New Label()
        lblSss = New Label()
        lblDeductions = New Label()
        Label5 = New Label()
        lblBasicSalary = New Label()
        lblEmployeeName = New Label()
        lblSalaryScheme = New Label()
        lblPayroll = New Label()
        btnPaySlip = New Button()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        pnlCenter.SuspendLayout()
        pnlDGVPayroll.SuspendLayout()
        CType(DGVPayroll, ComponentModel.ISupportInitialize).BeginInit()
        pnlPayrollInformation.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlCenter
        ' 
        pnlCenter.BackColor = SystemColors.ControlLightLight
        pnlCenter.Controls.Add(pnlDGVPayroll)
        pnlCenter.Controls.Add(pnlPayrollInformation)
        pnlCenter.Location = New Point(0, 89)
        pnlCenter.Name = "pnlCenter"
        pnlCenter.Size = New Size(997, 596)
        pnlCenter.TabIndex = 1
        ' 
        ' pnlDGVPayroll
        ' 
        pnlDGVPayroll.Controls.Add(DGVPayroll)
        pnlDGVPayroll.Dock = DockStyle.Fill
        pnlDGVPayroll.Location = New Point(0, 327)
        pnlDGVPayroll.Name = "pnlDGVPayroll"
        pnlDGVPayroll.Size = New Size(997, 269)
        pnlDGVPayroll.TabIndex = 1
        ' 
        ' DGVPayroll
        ' 
        DGVPayroll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVPayroll.BackgroundColor = SystemColors.ControlLightLight
        DGVPayroll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVPayroll.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column8})
        DGVPayroll.Dock = DockStyle.Fill
        DGVPayroll.Location = New Point(0, 0)
        DGVPayroll.Name = "DGVPayroll"
        DGVPayroll.ReadOnly = True
        DGVPayroll.RowTemplate.Height = 25
        DGVPayroll.Size = New Size(997, 269)
        DGVPayroll.TabIndex = 0
        ' 
        ' pnlPayrollInformation
        ' 
        pnlPayrollInformation.BackColor = SystemColors.ControlLightLight
        pnlPayrollInformation.Controls.Add(ComboBox1)
        pnlPayrollInformation.Controls.Add(lblPagIbigValue)
        pnlPayrollInformation.Controls.Add(lblPhilHealthValue)
        pnlPayrollInformation.Controls.Add(lblSssValue)
        pnlPayrollInformation.Controls.Add(lblOvertimePayValue)
        pnlPayrollInformation.Controls.Add(lblBasicSalaryValue)
        pnlPayrollInformation.Controls.Add(lblNameValue)
        pnlPayrollInformation.Controls.Add(btnSearch)
        pnlPayrollInformation.Controls.Add(tbSearchBar)
        pnlPayrollInformation.Controls.Add(lblSearchEmployee)
        pnlPayrollInformation.Controls.Add(lblOvertimePay)
        pnlPayrollInformation.Controls.Add(lblPagIbig)
        pnlPayrollInformation.Controls.Add(lblPhilHealth)
        pnlPayrollInformation.Controls.Add(lblSss)
        pnlPayrollInformation.Controls.Add(lblDeductions)
        pnlPayrollInformation.Controls.Add(Label5)
        pnlPayrollInformation.Controls.Add(lblBasicSalary)
        pnlPayrollInformation.Controls.Add(lblEmployeeName)
        pnlPayrollInformation.Controls.Add(lblSalaryScheme)
        pnlPayrollInformation.Dock = DockStyle.Top
        pnlPayrollInformation.Location = New Point(0, 0)
        pnlPayrollInformation.Name = "pnlPayrollInformation"
        pnlPayrollInformation.Size = New Size(997, 327)
        pnlPayrollInformation.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.InactiveCaption
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        ComboBox1.Location = New Point(755, 134)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(197, 23)
        ComboBox1.TabIndex = 22
        ' 
        ' lblPagIbigValue
        ' 
        lblPagIbigValue.AutoSize = True
        lblPagIbigValue.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblPagIbigValue.ForeColor = Color.FromArgb(CByte(56), CByte(59), CByte(62))
        lblPagIbigValue.Location = New Point(488, 263)
        lblPagIbigValue.Name = "lblPagIbigValue"
        lblPagIbigValue.Size = New Size(42, 25)
        lblPagIbigValue.TabIndex = 19
        lblPagIbigValue.Text = "245"
        ' 
        ' lblPhilHealthValue
        ' 
        lblPhilHealthValue.AutoSize = True
        lblPhilHealthValue.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblPhilHealthValue.ForeColor = Color.FromArgb(CByte(56), CByte(59), CByte(62))
        lblPhilHealthValue.Location = New Point(341, 264)
        lblPhilHealthValue.Name = "lblPhilHealthValue"
        lblPhilHealthValue.Size = New Size(42, 25)
        lblPhilHealthValue.TabIndex = 18
        lblPhilHealthValue.Text = "245"
        ' 
        ' lblSssValue
        ' 
        lblSssValue.AutoSize = True
        lblSssValue.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblSssValue.ForeColor = Color.FromArgb(CByte(56), CByte(59), CByte(62))
        lblSssValue.Location = New Point(224, 264)
        lblSssValue.Name = "lblSssValue"
        lblSssValue.Size = New Size(42, 25)
        lblSssValue.TabIndex = 17
        lblSssValue.Text = "900"
        ' 
        ' lblOvertimePayValue
        ' 
        lblOvertimePayValue.AutoSize = True
        lblOvertimePayValue.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblOvertimePayValue.ForeColor = Color.FromArgb(CByte(56), CByte(59), CByte(62))
        lblOvertimePayValue.Location = New Point(224, 207)
        lblOvertimePayValue.Name = "lblOvertimePayValue"
        lblOvertimePayValue.Size = New Size(42, 25)
        lblOvertimePayValue.TabIndex = 16
        lblOvertimePayValue.Text = "200"
        ' 
        ' lblBasicSalaryValue
        ' 
        lblBasicSalaryValue.AutoSize = True
        lblBasicSalaryValue.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblBasicSalaryValue.ForeColor = Color.FromArgb(CByte(56), CByte(59), CByte(62))
        lblBasicSalaryValue.Location = New Point(224, 170)
        lblBasicSalaryValue.Name = "lblBasicSalaryValue"
        lblBasicSalaryValue.Size = New Size(66, 25)
        lblBasicSalaryValue.TabIndex = 15
        lblBasicSalaryValue.Text = "30,000"
        ' 
        ' lblNameValue
        ' 
        lblNameValue.AutoSize = True
        lblNameValue.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblNameValue.ForeColor = Color.FromArgb(CByte(56), CByte(59), CByte(62))
        lblNameValue.Location = New Point(224, 125)
        lblNameValue.Name = "lblNameValue"
        lblNameValue.Size = New Size(91, 25)
        lblNameValue.TabIndex = 14
        lblNameValue.Text = "John Doe"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.InactiveCaption
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.Location = New Point(602, 67)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 13
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' tbSearchBar
        ' 
        tbSearchBar.BackColor = SystemColors.ControlLight
        tbSearchBar.BorderStyle = BorderStyle.None
        tbSearchBar.Location = New Point(393, 71)
        tbSearchBar.Name = "tbSearchBar"
        tbSearchBar.Size = New Size(202, 16)
        tbSearchBar.TabIndex = 12
        ' 
        ' lblSearchEmployee
        ' 
        lblSearchEmployee.AutoSize = True
        lblSearchEmployee.ForeColor = SystemColors.ControlDarkDark
        lblSearchEmployee.Location = New Point(247, 71)
        lblSearchEmployee.Name = "lblSearchEmployee"
        lblSearchEmployee.Size = New Size(136, 15)
        lblSearchEmployee.TabIndex = 11
        lblSearchEmployee.Text = "Search Employee name :"
        ' 
        ' lblOvertimePay
        ' 
        lblOvertimePay.AutoSize = True
        lblOvertimePay.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lblOvertimePay.ForeColor = SystemColors.ControlDarkDark
        lblOvertimePay.Location = New Point(93, 206)
        lblOvertimePay.Name = "lblOvertimePay"
        lblOvertimePay.Size = New Size(109, 19)
        lblOvertimePay.TabIndex = 10
        lblOvertimePay.Text = "Overtime Pay :"
        lblOvertimePay.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPagIbig
        ' 
        lblPagIbig.AutoSize = True
        lblPagIbig.Font = New Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPagIbig.ForeColor = SystemColors.ControlDarkDark
        lblPagIbig.Location = New Point(483, 289)
        lblPagIbig.Name = "lblPagIbig"
        lblPagIbig.Size = New Size(54, 17)
        lblPagIbig.TabIndex = 9
        lblPagIbig.Text = "Pag-IBIG"
        lblPagIbig.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPhilHealth
        ' 
        lblPhilHealth.AutoSize = True
        lblPhilHealth.Font = New Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPhilHealth.ForeColor = SystemColors.ControlDarkDark
        lblPhilHealth.Location = New Point(330, 289)
        lblPhilHealth.Name = "lblPhilHealth"
        lblPhilHealth.Size = New Size(64, 17)
        lblPhilHealth.TabIndex = 6
        lblPhilHealth.Text = "PhilHealth"
        lblPhilHealth.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSss
        ' 
        lblSss.AutoSize = True
        lblSss.Font = New Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblSss.ForeColor = SystemColors.ControlDarkDark
        lblSss.Location = New Point(232, 289)
        lblSss.Name = "lblSss"
        lblSss.Size = New Size(26, 17)
        lblSss.TabIndex = 5
        lblSss.Text = "SSS"
        lblSss.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDeductions
        ' 
        lblDeductions.AutoSize = True
        lblDeductions.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lblDeductions.ForeColor = SystemColors.ControlDarkDark
        lblDeductions.Location = New Point(111, 268)
        lblDeductions.Name = "lblDeductions"
        lblDeductions.Size = New Size(91, 19)
        lblDeductions.TabIndex = 4
        lblDeductions.Text = "Deductions :"
        lblDeductions.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlDarkDark
        Label5.Location = New Point(699, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 19)
        Label5.TabIndex = 3
        Label5.Text = "Date :"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblBasicSalary
        ' 
        lblBasicSalary.AutoSize = True
        lblBasicSalary.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lblBasicSalary.ForeColor = SystemColors.ControlDarkDark
        lblBasicSalary.Location = New Point(108, 169)
        lblBasicSalary.Name = "lblBasicSalary"
        lblBasicSalary.Size = New Size(98, 19)
        lblBasicSalary.TabIndex = 2
        lblBasicSalary.Text = "Basic Salary :"
        ' 
        ' lblEmployeeName
        ' 
        lblEmployeeName.AutoSize = True
        lblEmployeeName.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmployeeName.ForeColor = SystemColors.ControlDarkDark
        lblEmployeeName.Location = New Point(79, 125)
        lblEmployeeName.Name = "lblEmployeeName"
        lblEmployeeName.Size = New Size(127, 19)
        lblEmployeeName.TabIndex = 1
        lblEmployeeName.Text = "Employee Name :"
        ' 
        ' lblSalaryScheme
        ' 
        lblSalaryScheme.AutoSize = True
        lblSalaryScheme.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        lblSalaryScheme.ForeColor = SystemColors.ActiveCaptionText
        lblSalaryScheme.Location = New Point(392, 10)
        lblSalaryScheme.Name = "lblSalaryScheme"
        lblSalaryScheme.Size = New Size(203, 37)
        lblSalaryScheme.TabIndex = 0
        lblSalaryScheme.Text = "Salary Scheme"
        ' 
        ' lblPayroll
        ' 
        lblPayroll.AutoSize = True
        lblPayroll.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblPayroll.ForeColor = SystemColors.ControlDarkDark
        lblPayroll.Location = New Point(39, 22)
        lblPayroll.Name = "lblPayroll"
        lblPayroll.Size = New Size(134, 47)
        lblPayroll.TabIndex = 0
        lblPayroll.Text = "Payroll"
        ' 
        ' btnPaySlip
        ' 
        btnPaySlip.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnPaySlip.FlatAppearance.BorderSize = 0
        btnPaySlip.FlatStyle = FlatStyle.Flat
        btnPaySlip.ForeColor = Color.FromArgb(CByte(203), CByte(203), CByte(203))
        btnPaySlip.Location = New Point(714, 694)
        btnPaySlip.Name = "btnPaySlip"
        btnPaySlip.Size = New Size(279, 33)
        btnPaySlip.TabIndex = 2
        btnPaySlip.Text = "Payslip"
        btnPaySlip.UseVisualStyleBackColor = False
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Date"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Time In"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Time Out"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Number of Working Hours"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Wage"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Total Deductions"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Net Wage"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' PayrollForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 732)
        Controls.Add(btnPaySlip)
        Controls.Add(pnlCenter)
        Controls.Add(lblPayroll)
        FormBorderStyle = FormBorderStyle.None
        Name = "PayrollForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PayrollForm"
        pnlCenter.ResumeLayout(False)
        pnlDGVPayroll.ResumeLayout(False)
        CType(DGVPayroll, ComponentModel.ISupportInitialize).EndInit()
        pnlPayrollInformation.ResumeLayout(False)
        pnlPayrollInformation.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents pnlCenter As Panel
    Friend WithEvents lblPayroll As Label
    Friend WithEvents pnlPayrollInformation As Panel
    Friend WithEvents pnlDGVPayroll As Panel
    Friend WithEvents lblBasicSalary As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblSalaryScheme As Label
    Friend WithEvents lblDeductions As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblOvertimePay As Label
    Friend WithEvents lblPagIbig As Label
    Friend WithEvents lblPhilHealth As Label
    Friend WithEvents lblSss As Label
    Friend WithEvents DGVPayroll As DataGridView
    Friend WithEvents lblSearchEmployee As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents tbSearchBar As TextBox
    Friend WithEvents lblNameValue As Label
    Friend WithEvents lblSssValue As Label
    Friend WithEvents lblOvertimePayValue As Label
    Friend WithEvents lblBasicSalaryValue As Label
    Friend WithEvents lblPagIbigValue As Label
    Friend WithEvents lblPhilHealthValue As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnPaySlip As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
