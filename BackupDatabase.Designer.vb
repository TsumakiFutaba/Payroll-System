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
        Label1 = New Label()
        cbServer = New ComboBox()
        cbDatabase = New ComboBox()
        lblData = New Label()
        panelBackup = New Panel()
        lReports = New Label()
        prgbrBackup = New ProgressBar()
        btnBackup = New Button()
        btnRestore = New Button()
        TimerBackup = New Timer(components)
        sfdBackup = New SaveFileDialog()
        ofdBackup = New OpenFileDialog()
        panelBackup.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(71, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 25)
        Label1.TabIndex = 0
        Label1.Text = "Server:"
        ' 
        ' cbServer
        ' 
        cbServer.FormattingEnabled = True
        cbServer.Location = New Point(148, 68)
        cbServer.Name = "cbServer"
        cbServer.Size = New Size(248, 23)
        cbServer.TabIndex = 1
        ' 
        ' cbDatabase
        ' 
        cbDatabase.FormattingEnabled = True
        cbDatabase.Location = New Point(148, 104)
        cbDatabase.Name = "cbDatabase"
        cbDatabase.Size = New Size(248, 23)
        cbDatabase.TabIndex = 3
        ' 
        ' lblData
        ' 
        lblData.AutoSize = True
        lblData.BackColor = Color.Transparent
        lblData.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblData.ForeColor = SystemColors.ButtonHighlight
        lblData.Location = New Point(46, 104)
        lblData.Name = "lblData"
        lblData.Size = New Size(94, 25)
        lblData.TabIndex = 2
        lblData.Text = "Database:"
        ' 
        ' panelBackup
        ' 
        panelBackup.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        panelBackup.Controls.Add(lReports)
        panelBackup.Location = New Point(0, 0)
        panelBackup.Name = "panelBackup"
        panelBackup.Size = New Size(472, 51)
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
        ' prgbrBackup
        ' 
        prgbrBackup.Location = New Point(148, 138)
        prgbrBackup.Name = "prgbrBackup"
        prgbrBackup.Size = New Size(248, 18)
        prgbrBackup.TabIndex = 5
        ' 
        ' btnBackup
        ' 
        btnBackup.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnBackup.Location = New Point(147, 165)
        btnBackup.Name = "btnBackup"
        btnBackup.Size = New Size(115, 29)
        btnBackup.TabIndex = 6
        btnBackup.Text = "Backup"
        btnBackup.UseVisualStyleBackColor = True
        ' 
        ' btnRestore
        ' 
        btnRestore.Location = New Point(270, 165)
        btnRestore.Name = "btnRestore"
        btnRestore.Size = New Size(126, 29)
        btnRestore.TabIndex = 7
        btnRestore.Text = "Restore"
        btnRestore.UseVisualStyleBackColor = True
        ' 
        ' TimerBackup
        ' 
        ' 
        ' sfdBackup
        ' 
        sfdBackup.DefaultExt = "bak"
        ' 
        ' ofdBackup
        ' 
        ofdBackup.FileName = "OpenFileDialog1"
        ' 
        ' BackupDatabase
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = SystemColors.ControlLight
        BackgroundImage = My.Resources.Resources.Untitled_design__1_
        ClientSize = New Size(471, 226)
        Controls.Add(btnRestore)
        Controls.Add(btnBackup)
        Controls.Add(prgbrBackup)
        Controls.Add(panelBackup)
        Controls.Add(cbDatabase)
        Controls.Add(lblData)
        Controls.Add(cbServer)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "BackupDatabase"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BackupDatabase"
        panelBackup.ResumeLayout(False)
        panelBackup.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbServer As ComboBox
    Friend WithEvents cbDatabase As ComboBox
    Friend WithEvents lblData As Label
    Friend WithEvents panelBackup As Panel
    Friend WithEvents lReports As Label
    Friend WithEvents prgbrBackup As ProgressBar
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnRestore As Button
    Friend WithEvents TimerBackup As Timer
    Friend WithEvents sfdBackup As SaveFileDialog
    Friend WithEvents ofdBackup As OpenFileDialog
End Class
