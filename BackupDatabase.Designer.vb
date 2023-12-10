<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupDatabase
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
        components = New ComponentModel.Container()
        lblBackup = New Label()
        panelBackup = New Panel()
        lReports = New Label()
        btnBrowse1 = New Button()
        TimerBackup = New Timer(components)
        sfdBackup = New SaveFileDialog()
        ofdBackup = New OpenFileDialog()
        Label1 = New Label()
        Panel1 = New Panel()
        tbLocation1 = New TextBox()
        btnBackup = New Button()
        Label2 = New Label()
        Panel2 = New Panel()
        tbLocation2 = New TextBox()
        Label3 = New Label()
        btnRestore = New Button()
        btnBrowse2 = New Button()
        panelBackup.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblBackup
        ' 
        lblBackup.AutoSize = True
        lblBackup.BackColor = Color.Transparent
        lblBackup.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblBackup.ForeColor = SystemColors.ButtonHighlight
        lblBackup.Location = New Point(12, 54)
        lblBackup.Name = "lblBackup"
        lblBackup.Size = New Size(124, 20)
        lblBackup.TabIndex = 0
        lblBackup.Text = "Backup Database"
        ' 
        ' panelBackup
        ' 
        panelBackup.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        panelBackup.Controls.Add(lReports)
        panelBackup.Location = New Point(0, 0)
        panelBackup.Name = "panelBackup"
        panelBackup.Size = New Size(478, 51)
        panelBackup.TabIndex = 4
        ' 
        ' lReports
        ' 
        lReports.AutoSize = True
        lReports.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lReports.ForeColor = Color.WhiteSmoke
        lReports.Location = New Point(137, 9)
        lReports.Name = "lReports"
        lReports.Size = New Size(209, 32)
        lReports.TabIndex = 5
        lReports.Text = "Database Backup"
        ' 
        ' btnBrowse1
        ' 
        btnBrowse1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnBrowse1.ForeColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnBrowse1.Location = New Point(326, 9)
        btnBrowse1.Name = "btnBrowse1"
        btnBrowse1.Size = New Size(92, 27)
        btnBrowse1.TabIndex = 6
        btnBrowse1.Text = "Browse"
        btnBrowse1.UseVisualStyleBackColor = True
        ' 
        ' sfdBackup
        ' 
        sfdBackup.DefaultExt = "bak"
        ' 
        ' ofdBackup
        ' 
        ofdBackup.FileName = "OpenFileDialog1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(3, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 20)
        Label1.TabIndex = 8
        Label1.Text = "Location:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        Panel1.Controls.Add(tbLocation1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnBackup)
        Panel1.Controls.Add(btnBrowse1)
        Panel1.Location = New Point(22, 77)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(437, 82)
        Panel1.TabIndex = 6
        ' 
        ' tbLocation1
        ' 
        tbLocation1.Location = New Point(86, 11)
        tbLocation1.Name = "tbLocation1"
        tbLocation1.Size = New Size(222, 23)
        tbLocation1.TabIndex = 9
        ' 
        ' btnBackup
        ' 
        btnBackup.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnBackup.ForeColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnBackup.Location = New Point(326, 42)
        btnBackup.Name = "btnBackup"
        btnBackup.Size = New Size(92, 27)
        btnBackup.TabIndex = 7
        btnBackup.Text = "Backup"
        btnBackup.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(12, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 20)
        Label2.TabIndex = 7
        Label2.Text = "Backup Database"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        Panel2.Controls.Add(tbLocation2)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(btnRestore)
        Panel2.Controls.Add(btnBrowse2)
        Panel2.Location = New Point(22, 223)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(437, 82)
        Panel2.TabIndex = 8
        ' 
        ' tbLocation2
        ' 
        tbLocation2.Location = New Point(86, 11)
        tbLocation2.Name = "tbLocation2"
        tbLocation2.Size = New Size(222, 23)
        tbLocation2.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(3, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 8
        Label3.Text = "Location:"
        ' 
        ' btnRestore
        ' 
        btnRestore.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnRestore.ForeColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnRestore.Location = New Point(326, 42)
        btnRestore.Name = "btnRestore"
        btnRestore.Size = New Size(92, 27)
        btnRestore.TabIndex = 7
        btnRestore.Text = "Restore"
        btnRestore.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse2
        ' 
        btnBrowse2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnBrowse2.ForeColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnBrowse2.Location = New Point(326, 9)
        btnBrowse2.Name = "btnBrowse2"
        btnBrowse2.Size = New Size(92, 27)
        btnBrowse2.TabIndex = 6
        btnBrowse2.Text = "Browse"
        btnBrowse2.UseVisualStyleBackColor = True
        ' 
        ' BackupDatabase
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = SystemColors.ControlLight
        BackgroundImage = My.Resources.Resources.Untitled_design__1_
        ClientSize = New Size(479, 325)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(panelBackup)
        Controls.Add(lblBackup)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "BackupDatabase"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BackupDatabase"
        panelBackup.ResumeLayout(False)
        panelBackup.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBackup As Label
    Friend WithEvents panelBackup As Panel
    Friend WithEvents lReports As Label
    Friend WithEvents btnBrowse1 As Button
    Friend WithEvents TimerBackup As Timer
    Friend WithEvents sfdBackup As SaveFileDialog
    Friend WithEvents ofdBackup As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBackup As Button
    Friend WithEvents tbLocation1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbLocation2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRestore As Button
    Friend WithEvents btnBrowse2 As Button
End Class
