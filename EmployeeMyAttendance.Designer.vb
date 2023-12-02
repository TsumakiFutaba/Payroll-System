<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeMyAttendance
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
        lblAttendance = New Label()
        pnlForDGVAttendance = New Panel()
        dgvAttendance = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        pnlForDGVAttendance.SuspendLayout()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblAttendance
        ' 
        lblAttendance.AutoSize = True
        lblAttendance.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        lblAttendance.ForeColor = SystemColors.ControlDarkDark
        lblAttendance.Location = New Point(39, 22)
        lblAttendance.Name = "lblAttendance"
        lblAttendance.Size = New Size(288, 47)
        lblAttendance.TabIndex = 8
        lblAttendance.Text = "My Attendances"
        ' 
        ' pnlForDGVAttendance
        ' 
        pnlForDGVAttendance.Controls.Add(dgvAttendance)
        pnlForDGVAttendance.Location = New Point(0, 89)
        pnlForDGVAttendance.Name = "pnlForDGVAttendance"
        pnlForDGVAttendance.Size = New Size(997, 643)
        pnlForDGVAttendance.TabIndex = 9
        ' 
        ' dgvAttendance
        ' 
        dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAttendance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders
        dgvAttendance.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Silver
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowFrame
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.InactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvAttendance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendance.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgvAttendance.Dock = DockStyle.Fill
        dgvAttendance.Location = New Point(0, 0)
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.ReadOnly = True
        dgvAttendance.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvAttendance.RowTemplate.Height = 25
        dgvAttendance.Size = New Size(997, 643)
        dgvAttendance.TabIndex = 0
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle2.BackColor = Color.White
        Column1.DefaultCellStyle = DataGridViewCellStyle2
        Column1.HeaderText = "Date"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Resizable = DataGridViewTriState.False
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Resizable = DataGridViewTriState.False
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Time In"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Resizable = DataGridViewTriState.False
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Time Out"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Resizable = DataGridViewTriState.False
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Total Hours"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Resizable = DataGridViewTriState.False
        ' 
        ' EmployeeMyAttendance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 732)
        Controls.Add(pnlForDGVAttendance)
        Controls.Add(lblAttendance)
        FormBorderStyle = FormBorderStyle.None
        Name = "EmployeeMyAttendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EmployeeAttendanceForm"
        pnlForDGVAttendance.ResumeLayout(False)
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAttendance As Label
    Friend WithEvents pnlForDGVAttendance As Panel
    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
