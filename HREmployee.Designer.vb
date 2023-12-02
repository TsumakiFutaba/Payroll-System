<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HREmployee
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
        pnlEmployee = New Panel()
        pnlForDGVEmployee = New Panel()
        dgvEmployee = New DataGridView()
        Column6 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        lblEmployee = New Label()
        pnlEmployee.SuspendLayout()
        pnlForDGVEmployee.SuspendLayout()
        CType(dgvEmployee, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlEmployee
        ' 
        pnlEmployee.Controls.Add(pnlForDGVEmployee)
        pnlEmployee.Controls.Add(lblEmployee)
        pnlEmployee.Dock = DockStyle.Fill
        pnlEmployee.Location = New Point(0, 0)
        pnlEmployee.Name = "pnlEmployee"
        pnlEmployee.Size = New Size(997, 732)
        pnlEmployee.TabIndex = 2
        ' 
        ' pnlForDGVEmployee
        ' 
        pnlForDGVEmployee.Controls.Add(dgvEmployee)
        pnlForDGVEmployee.Location = New Point(0, 89)
        pnlForDGVEmployee.Name = "pnlForDGVEmployee"
        pnlForDGVEmployee.Size = New Size(997, 643)
        pnlForDGVEmployee.TabIndex = 1
        ' 
        ' dgvEmployee
        ' 
        dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEmployee.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployee.Columns.AddRange(New DataGridViewColumn() {Column6, Column8})
        dgvEmployee.Dock = DockStyle.Fill
        dgvEmployee.Location = New Point(0, 0)
        dgvEmployee.Name = "dgvEmployee"
        dgvEmployee.ReadOnly = True
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvEmployee.RowsDefaultCellStyle = DataGridViewCellStyle2
        dgvEmployee.RowTemplate.Height = 25
        dgvEmployee.Size = New Size(997, 643)
        dgvEmployee.TabIndex = 0
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Name"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Position"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' lblEmployee
        ' 
        lblEmployee.AutoSize = True
        lblEmployee.BackColor = Color.Transparent
        lblEmployee.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmployee.ForeColor = SystemColors.ControlDarkDark
        lblEmployee.Location = New Point(39, 22)
        lblEmployee.Name = "lblEmployee"
        lblEmployee.Size = New Size(181, 47)
        lblEmployee.TabIndex = 0
        lblEmployee.Text = "Employee"
        ' 
        ' HREmployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 732)
        Controls.Add(pnlEmployee)
        FormBorderStyle = FormBorderStyle.None
        Name = "HREmployee"
        Text = "Form5"
        pnlEmployee.ResumeLayout(False)
        pnlEmployee.PerformLayout()
        pnlForDGVEmployee.ResumeLayout(False)
        CType(dgvEmployee, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlEmployee As Panel
    Friend WithEvents pnlForDGVEmployee As Panel
    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents lblEmployee As Label
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
