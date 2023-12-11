<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRAttendanceForm
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
        pnlAttendance = New Panel()
        pnlForDGVAttendance = New Panel()
        dgvAttendance = New DataGridView()
        lblAttendance = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        pnlAttendance.SuspendLayout()
        pnlForDGVAttendance.SuspendLayout()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlAttendance
        ' 
        pnlAttendance.Controls.Add(pnlForDGVAttendance)
        pnlAttendance.Controls.Add(lblAttendance)
        pnlAttendance.Dock = DockStyle.Fill
        pnlAttendance.Location = New Point(0, 0)
        pnlAttendance.Name = "pnlAttendance"
        pnlAttendance.Size = New Size(997, 732)
        pnlAttendance.TabIndex = 8
        ' 
        ' pnlForDGVAttendance
        ' 
        pnlForDGVAttendance.Controls.Add(dgvAttendance)
        pnlForDGVAttendance.Location = New Point(0, 89)
        pnlForDGVAttendance.Name = "pnlForDGVAttendance"
        pnlForDGVAttendance.Size = New Size(997, 643)
        pnlForDGVAttendance.TabIndex = 8
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
        dgvAttendance.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8})
        dgvAttendance.Dock = DockStyle.Fill
        dgvAttendance.Location = New Point(0, 0)
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.ReadOnly = True
        dgvAttendance.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvAttendance.RowTemplate.Height = 25
        dgvAttendance.Size = New Size(997, 643)
        dgvAttendance.TabIndex = 0
        ' 
        ' lblAttendance
        ' 
        lblAttendance.AutoSize = True
        lblAttendance.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        lblAttendance.ForeColor = SystemColors.ControlDarkDark
        lblAttendance.Location = New Point(39, 22)
        lblAttendance.Name = "lblAttendance"
        lblAttendance.Size = New Size(210, 47)
        lblAttendance.TabIndex = 7
        lblAttendance.Text = "Attendance"
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "Name"
        DataGridViewCellStyle2.BackColor = Color.White
        Column1.DefaultCellStyle = DataGridViewCellStyle2
        Column1.HeaderText = "Name"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Resizable = DataGridViewTriState.False
        Column1.Visible = False
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "inTime"
        Column2.HeaderText = "Time In"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Resizable = DataGridViewTriState.False
        Column2.Visible = False
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "inStatus"
        Column3.HeaderText = "Status"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Resizable = DataGridViewTriState.False
        Column3.Visible = False
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "inDate"
        Column4.HeaderText = "Date In"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Resizable = DataGridViewTriState.False
        Column4.Visible = False
        ' 
        ' Column5
        ' 
        Column5.DataPropertyName = "outTime"
        Column5.HeaderText = "Time Out"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Resizable = DataGridViewTriState.False
        Column5.Visible = False
        ' 
        ' Column6
        ' 
        Column6.DataPropertyName = "outStatus"
        Column6.HeaderText = "Status"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Visible = False
        ' 
        ' Column7
        ' 
        Column7.DataPropertyName = "outDate"
        Column7.HeaderText = "Date Out"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Visible = False
        ' 
        ' Column8
        ' 
        Column8.DataPropertyName = "totalHours"
        Column8.HeaderText = "Total Hours"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Visible = False
        ' 
        ' HRAttendanceForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 732)
        Controls.Add(pnlAttendance)
        FormBorderStyle = FormBorderStyle.None
        Name = "HRAttendanceForm"
        Text = "Form6"
        pnlAttendance.ResumeLayout(False)
        pnlAttendance.PerformLayout()
        pnlForDGVAttendance.ResumeLayout(False)
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlAttendance As Panel
    Friend WithEvents pnlForDGVAttendance As Panel
    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents lblAttendance As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
