<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRDeductions
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
        lblDeductions = New Label()
        pnlDeductions = New Panel()
        DGVDeductions = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        pnlDeductions.SuspendLayout()
        CType(DGVDeductions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblDeductions
        ' 
        lblDeductions.AutoSize = True
        lblDeductions.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblDeductions.ForeColor = SystemColors.ControlDarkDark
        lblDeductions.Location = New Point(39, 22)
        lblDeductions.Name = "lblDeductions"
        lblDeductions.Size = New Size(206, 47)
        lblDeductions.TabIndex = 0
        lblDeductions.Text = "Deductions"
        ' 
        ' pnlDeductions
        ' 
        pnlDeductions.Controls.Add(DGVDeductions)
        pnlDeductions.Location = New Point(0, 89)
        pnlDeductions.Name = "pnlDeductions"
        pnlDeductions.Size = New Size(997, 643)
        pnlDeductions.TabIndex = 1
        ' 
        ' DGVDeductions
        ' 
        DGVDeductions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVDeductions.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DGVDeductions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGVDeductions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVDeductions.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column7})
        DGVDeductions.Dock = DockStyle.Fill
        DGVDeductions.Location = New Point(0, 0)
        DGVDeductions.Name = "DGVDeductions"
        DGVDeductions.ReadOnly = True
        DGVDeductions.RowTemplate.Height = 25
        DGVDeductions.Size = New Size(997, 643)
        DGVDeductions.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Name"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "SSS"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Phil Health"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Pag-IBIG"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Total Deduction"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' HRDeductions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 732)
        Controls.Add(pnlDeductions)
        Controls.Add(lblDeductions)
        FormBorderStyle = FormBorderStyle.None
        Name = "HRDeductions"
        Text = "Deductions"
        pnlDeductions.ResumeLayout(False)
        CType(DGVDeductions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDeductions As Label
    Friend WithEvents pnlDeductions As Panel
    Friend WithEvents DGVDeductions As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
