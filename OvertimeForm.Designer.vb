<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OvertimeForm
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblOvertime = New Label()
        pnlOvertime = New Panel()
        DGVOvertime = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        pnlOvertime.SuspendLayout()
        CType(DGVOvertime, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblOvertime
        ' 
        lblOvertime.AutoSize = True
        lblOvertime.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblOvertime.ForeColor = SystemColors.ControlDarkDark
        lblOvertime.Location = New Point(39, 22)
        lblOvertime.Name = "lblOvertime"
        lblOvertime.Size = New Size(175, 47)
        lblOvertime.TabIndex = 0
        lblOvertime.Text = "Overtime"
        ' 
        ' pnlOvertime
        ' 
        pnlOvertime.Controls.Add(DGVOvertime)
        pnlOvertime.Location = New Point(0, 89)
        pnlOvertime.Name = "pnlOvertime"
        pnlOvertime.Size = New Size(1000, 646)
        pnlOvertime.TabIndex = 1
        ' 
        ' DGVOvertime
        ' 
        DGVOvertime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVOvertime.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGVOvertime.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGVOvertime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVOvertime.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DGVOvertime.Dock = DockStyle.Fill
        DGVOvertime.Location = New Point(0, 0)
        DGVOvertime.Name = "DGVOvertime"
        DGVOvertime.ReadOnly = True
        DGVOvertime.RowTemplate.Height = 25
        DGVOvertime.Size = New Size(1000, 646)
        DGVOvertime.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Date"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Number of Hours"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Rate"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' OvertimeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 732)
        Controls.Add(pnlOvertime)
        Controls.Add(lblOvertime)
        FormBorderStyle = FormBorderStyle.None
        Name = "OvertimeForm"
        Text = "OvertimeForm"
        pnlOvertime.ResumeLayout(False)
        CType(DGVOvertime, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblOvertime As Label
    Friend WithEvents pnlOvertime As Panel
    Friend WithEvents DGVOvertime As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
