<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayslipForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DGVNetPay = New DataGridView()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        pnlDeductions = New Panel()
        DGVDeductions = New DataGridView()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        lblPayPeriod = New Label()
        lblDateofPayment = New Label()
        lblHourlyRate = New Label()
        pnlEntitlements = New Panel()
        DGVEntitlements = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        lblPosition = New Label()
        Button1 = New Button()
        pnl = New Panel()
        pnlNetPay = New Panel()
        lblNameValue = New Label()
        pnlPay = New Panel()
        lblName = New Label()
        pbLogo = New PictureBox()
        pnlHeader = New Panel()
        Label1 = New Label()
        CType(DGVNetPay, ComponentModel.ISupportInitialize).BeginInit()
        pnlDeductions.SuspendLayout()
        CType(DGVDeductions, ComponentModel.ISupportInitialize).BeginInit()
        pnlEntitlements.SuspendLayout()
        CType(DGVEntitlements, ComponentModel.ISupportInitialize).BeginInit()
        pnl.SuspendLayout()
        pnlNetPay.SuspendLayout()
        pnlPay.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGVNetPay
        ' 
        DGVNetPay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVNetPay.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGVNetPay.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGVNetPay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVNetPay.Columns.AddRange(New DataGridViewColumn() {Column5, Column6})
        DGVNetPay.Dock = DockStyle.Fill
        DGVNetPay.Location = New Point(0, 0)
        DGVNetPay.Name = "DGVNetPay"
        DGVNetPay.RowTemplate.Height = 25
        DGVNetPay.Size = New Size(927, 118)
        DGVNetPay.TabIndex = 2
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Net Pay"
        Column5.Name = "Column5"
        Column5.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Total"
        Column6.Name = "Column6"
        Column6.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' pnlDeductions
        ' 
        pnlDeductions.Controls.Add(DGVDeductions)
        pnlDeductions.Location = New Point(25, 110)
        pnlDeductions.Name = "pnlDeductions"
        pnlDeductions.Size = New Size(927, 164)
        pnlDeductions.TabIndex = 1
        ' 
        ' DGVDeductions
        ' 
        DGVDeductions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVDeductions.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGVDeductions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGVDeductions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVDeductions.Columns.AddRange(New DataGridViewColumn() {Column3, Column4})
        DGVDeductions.Dock = DockStyle.Fill
        DGVDeductions.Location = New Point(0, 0)
        DGVDeductions.Name = "DGVDeductions"
        DGVDeductions.RowTemplate.Height = 25
        DGVDeductions.Size = New Size(927, 164)
        DGVDeductions.TabIndex = 1
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Deductions"
        Column3.Name = "Column3"
        Column3.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Total"
        Column4.Name = "Column4"
        Column4.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonHighlight
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlDark
        Label5.Location = New Point(681, 64)
        Label5.Name = "Label5"
        Label5.Size = New Size(231, 32)
        Label5.TabIndex = 14
        Label5.Text = "                               "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonHighlight
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlDark
        Label4.Location = New Point(681, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(231, 32)
        Label4.TabIndex = 13
        Label4.Text = "                               "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlDark
        Label3.Location = New Point(196, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 32)
        Label3.TabIndex = 12
        Label3.Text = "                               "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(196, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(231, 32)
        Label2.TabIndex = 11
        Label2.Text = "                               "
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.ForeColor = SystemColors.ControlDark
        Label13.Location = New Point(687, 73)
        Label13.Name = "Label13"
        Label13.Size = New Size(0, 45)
        Label13.TabIndex = 10
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.ForeColor = SystemColors.ControlDark
        Label12.Location = New Point(681, 71)
        Label12.Name = "Label12"
        Label12.Size = New Size(0, 45)
        Label12.TabIndex = 9
        ' 
        ' lblPayPeriod
        ' 
        lblPayPeriod.AutoSize = True
        lblPayPeriod.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblPayPeriod.ForeColor = SystemColors.GrayText
        lblPayPeriod.Location = New Point(496, 71)
        lblPayPeriod.Name = "lblPayPeriod"
        lblPayPeriod.Size = New Size(117, 25)
        lblPayPeriod.TabIndex = 8
        lblPayPeriod.Text = "Pay Period :"
        ' 
        ' lblDateofPayment
        ' 
        lblDateofPayment.AutoSize = True
        lblDateofPayment.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblDateofPayment.ForeColor = SystemColors.GrayText
        lblDateofPayment.Location = New Point(491, 30)
        lblDateofPayment.Name = "lblDateofPayment"
        lblDateofPayment.Size = New Size(170, 25)
        lblDateofPayment.TabIndex = 6
        lblDateofPayment.Text = "Date of Payment :"
        ' 
        ' lblHourlyRate
        ' 
        lblHourlyRate.AutoSize = True
        lblHourlyRate.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblHourlyRate.ForeColor = SystemColors.GrayText
        lblHourlyRate.Location = New Point(42, 98)
        lblHourlyRate.Name = "lblHourlyRate"
        lblHourlyRate.Size = New Size(128, 25)
        lblHourlyRate.TabIndex = 4
        lblHourlyRate.Text = "Hourly Rate :"
        ' 
        ' pnlEntitlements
        ' 
        pnlEntitlements.Controls.Add(DGVEntitlements)
        pnlEntitlements.Location = New Point(25, 6)
        pnlEntitlements.Name = "pnlEntitlements"
        pnlEntitlements.Size = New Size(927, 86)
        pnlEntitlements.TabIndex = 0
        ' 
        ' DGVEntitlements
        ' 
        DGVEntitlements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVEntitlements.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DGVEntitlements.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        DGVEntitlements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVEntitlements.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        DGVEntitlements.Dock = DockStyle.Fill
        DGVEntitlements.Location = New Point(0, 0)
        DGVEntitlements.Name = "DGVEntitlements"
        DGVEntitlements.ReadOnly = True
        DGVEntitlements.RowTemplate.Height = 25
        DGVEntitlements.Size = New Size(927, 86)
        DGVEntitlements.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Entitlements"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Total"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Resizable = DataGridViewTriState.False
        Column2.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' lblPosition
        ' 
        lblPosition.AutoSize = True
        lblPosition.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblPosition.ForeColor = SystemColors.GrayText
        lblPosition.Location = New Point(42, 57)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(94, 25)
        lblPosition.TabIndex = 2
        lblPosition.Text = "Position :"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(225), CByte(121), CByte(119))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(688, 419)
        Button1.Name = "Button1"
        Button1.Size = New Size(264, 23)
        Button1.TabIndex = 3
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' pnl
        ' 
        pnl.AllowDrop = True
        pnl.Controls.Add(Button1)
        pnl.Controls.Add(pnlNetPay)
        pnl.Controls.Add(pnlDeductions)
        pnl.Controls.Add(pnlEntitlements)
        pnl.Dock = DockStyle.Fill
        pnl.Location = New Point(0, 243)
        pnl.Name = "pnl"
        pnl.Size = New Size(981, 450)
        pnl.TabIndex = 7
        ' 
        ' pnlNetPay
        ' 
        pnlNetPay.Controls.Add(DGVNetPay)
        pnlNetPay.Location = New Point(25, 291)
        pnlNetPay.Name = "pnlNetPay"
        pnlNetPay.Size = New Size(927, 118)
        pnlNetPay.TabIndex = 2
        ' 
        ' lblNameValue
        ' 
        lblNameValue.AutoSize = True
        lblNameValue.BackColor = SystemColors.ButtonHighlight
        lblNameValue.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblNameValue.ForeColor = SystemColors.ControlDark
        lblNameValue.Location = New Point(196, 12)
        lblNameValue.Name = "lblNameValue"
        lblNameValue.Size = New Size(231, 32)
        lblNameValue.TabIndex = 1
        lblNameValue.Text = "                               "
        ' 
        ' pnlPay
        ' 
        pnlPay.Controls.Add(Label5)
        pnlPay.Controls.Add(Label4)
        pnlPay.Controls.Add(Label3)
        pnlPay.Controls.Add(Label2)
        pnlPay.Controls.Add(Label13)
        pnlPay.Controls.Add(Label12)
        pnlPay.Controls.Add(lblPayPeriod)
        pnlPay.Controls.Add(lblDateofPayment)
        pnlPay.Controls.Add(lblHourlyRate)
        pnlPay.Controls.Add(lblPosition)
        pnlPay.Controls.Add(lblNameValue)
        pnlPay.Controls.Add(lblName)
        pnlPay.Dock = DockStyle.Top
        pnlPay.Location = New Point(0, 99)
        pnlPay.Name = "pnlPay"
        pnlPay.Size = New Size(981, 144)
        pnlPay.TabIndex = 6
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblName.ForeColor = SystemColors.GrayText
        lblName.Location = New Point(42, 18)
        lblName.Name = "lblName"
        lblName.Size = New Size(74, 25)
        lblName.TabIndex = 0
        lblName.Text = "Name :"
        ' 
        ' pbLogo
        ' 
        pbLogo.Dock = DockStyle.Fill
        pbLogo.Image = My.Resources.Resources.Payslip__981x99___1_
        pbLogo.Location = New Point(0, 0)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(981, 99)
        pbLogo.TabIndex = 0
        pbLogo.TabStop = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(pbLogo)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(981, 99)
        pnlHeader.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(437, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 4
        ' 
        ' PayslipForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(981, 693)
        Controls.Add(pnl)
        Controls.Add(pnlPay)
        Controls.Add(pnlHeader)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "PayslipForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PayslipForm"
        CType(DGVNetPay, ComponentModel.ISupportInitialize).EndInit()
        pnlDeductions.ResumeLayout(False)
        CType(DGVDeductions, ComponentModel.ISupportInitialize).EndInit()
        pnlEntitlements.ResumeLayout(False)
        CType(DGVEntitlements, ComponentModel.ISupportInitialize).EndInit()
        pnl.ResumeLayout(False)
        pnlNetPay.ResumeLayout(False)
        pnlPay.ResumeLayout(False)
        pnlPay.PerformLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlHeader.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGVNetPay As DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents pnlDeductions As Panel
    Friend WithEvents DGVDeductions As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblPayPeriod As Label
    Friend WithEvents lblDateofPayment As Label
    Friend WithEvents lblHourlyRate As Label
    Friend WithEvents pnlEntitlements As Panel
    Friend WithEvents DGVEntitlements As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents lblPosition As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pnl As Panel
    Friend WithEvents pnlNetPay As Panel
    Friend WithEvents lblNameValue As Label
    Friend WithEvents pnlPay As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label1 As Label
End Class
