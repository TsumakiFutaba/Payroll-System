<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ITLockAccounts
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
        lblOverview = New Label()
        Panel6 = New Panel()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewButtonColumn()
        Column5 = New DataGridViewButtonColumn()
        Panel6.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblOverview
        ' 
        lblOverview.AutoSize = True
        lblOverview.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        lblOverview.ForeColor = SystemColors.ControlDarkDark
        lblOverview.Location = New Point(39, 22)
        lblOverview.Name = "lblOverview"
        lblOverview.Size = New Size(257, 47)
        lblOverview.TabIndex = 9
        lblOverview.Text = "Lock Accounts"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ControlLightLight
        Panel6.Controls.Add(DataGridView1)
        Panel6.Location = New Point(0, 89)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(997, 643)
        Panel6.TabIndex = 22
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column4, Column3, Column5})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(997, 643)
        DataGridView1.TabIndex = 0
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
        ' Column4
        ' 
        Column4.HeaderText = "Status"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Option"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Resizable = DataGridViewTriState.True
        Column3.SortMode = DataGridViewColumnSortMode.Automatic
        Column3.Text = "Enable"
        Column3.UseColumnTextForButtonValue = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Option"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Resizable = DataGridViewTriState.True
        Column5.SortMode = DataGridViewColumnSortMode.Automatic
        Column5.Text = "Disable"
        Column5.UseColumnTextForButtonValue = True
        ' 
        ' ITLockAccounts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 732)
        Controls.Add(Panel6)
        Controls.Add(lblOverview)
        FormBorderStyle = FormBorderStyle.None
        Name = "ITLockAccounts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ITLockAccounts"
        Panel6.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblOverview As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
End Class
