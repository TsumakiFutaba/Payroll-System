<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ITUsers
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
        lblOverview = New Label()
        Panel6 = New Panel()
        dgvUsers = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewButtonColumn()
        Panel6.SuspendLayout()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblOverview
        ' 
        lblOverview.AutoSize = True
        lblOverview.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        lblOverview.ForeColor = SystemColors.ControlDarkDark
        lblOverview.Location = New Point(39, 22)
        lblOverview.Name = "lblOverview"
        lblOverview.Size = New Size(108, 47)
        lblOverview.TabIndex = 10
        lblOverview.Text = "Users"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ControlLightLight
        Panel6.Controls.Add(dgvUsers)
        Panel6.Location = New Point(0, 89)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(997, 643)
        Panel6.TabIndex = 23
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsers.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgvUsers.Dock = DockStyle.Fill
        dgvUsers.Location = New Point(0, 0)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        dgvUsers.RowTemplate.Height = 25
        dgvUsers.Size = New Size(997, 643)
        dgvUsers.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
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
        Column3.HeaderText = "Username"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Password"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Option"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Resizable = DataGridViewTriState.True
        Column5.SortMode = DataGridViewColumnSortMode.Automatic
        Column5.Text = "Change Password"
        Column5.UseColumnTextForButtonValue = True
        ' 
        ' ITUsers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 732)
        Controls.Add(Panel6)
        Controls.Add(lblOverview)
        FormBorderStyle = FormBorderStyle.None
        Name = "ITUsers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ITUsers"
        Panel6.ResumeLayout(False)
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblOverview As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
End Class
