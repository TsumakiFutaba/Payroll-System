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
        lblAttendance = New Label()
        pnlForDGVAttendance = New Panel()
        dgvAttendance = New DataGridView()
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
        dgvAttendance.Dock = DockStyle.Fill
        dgvAttendance.Location = New Point(0, 0)
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.ReadOnly = True
        dgvAttendance.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvAttendance.RowTemplate.Height = 25
        dgvAttendance.Size = New Size(997, 643)
        dgvAttendance.TabIndex = 0
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
End Class
