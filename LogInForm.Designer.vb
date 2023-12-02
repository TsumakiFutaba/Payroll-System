<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        Panel1 = New Panel()
        pbLogo = New PictureBox()
        Panel2 = New Panel()
        Button1 = New Button()
        btnLogin = New Button()
        lblPassword = New Label()
        tbPassword = New TextBox()
        lblUsername = New Label()
        tbUsername = New TextBox()
        lblLoginCredentialstoProceed = New Label()
        lblLoginTxt = New Label()
        Panel1.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(pbLogo)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 353)
        Panel1.TabIndex = 0
        ' 
        ' pbLogo
        ' 
        pbLogo.Dock = DockStyle.Fill
        pbLogo.Image = My.Resources.Resources.Untitled_design
        pbLogo.Location = New Point(0, 0)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(250, 353)
        pbLogo.TabIndex = 0
        pbLogo.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.Untitled_design__1_
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(lblPassword)
        Panel2.Controls.Add(tbPassword)
        Panel2.Controls.Add(lblUsername)
        Panel2.Controls.Add(tbUsername)
        Panel2.Controls.Add(lblLoginCredentialstoProceed)
        Panel2.Controls.Add(lblLoginTxt)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(250, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(389, 353)
        Panel2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Underline, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(203), CByte(203), CByte(203))
        Button1.Location = New Point(215, 239)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 32)
        Button1.TabIndex = 7
        Button1.Text = "Forgot password?"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ButtonFace
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.SlateGray
        btnLogin.Location = New Point(34, 282)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(318, 32)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblPassword.ForeColor = SystemColors.ButtonHighlight
        lblPassword.Location = New Point(29, 189)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(67, 19)
        lblPassword.TabIndex = 5
        lblPassword.Text = "Password"
        ' 
        ' tbPassword
        ' 
        tbPassword.BackColor = SystemColors.InactiveCaption
        tbPassword.BorderStyle = BorderStyle.None
        tbPassword.ForeColor = SystemColors.WindowFrame
        tbPassword.Location = New Point(34, 212)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New Size(318, 16)
        tbPassword.TabIndex = 4
        tbPassword.UseSystemPasswordChar = True
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsername.ForeColor = SystemColors.ButtonHighlight
        lblUsername.Location = New Point(29, 142)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(71, 19)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username"
        ' 
        ' tbUsername
        ' 
        tbUsername.BackColor = SystemColors.InactiveCaption
        tbUsername.BorderStyle = BorderStyle.None
        tbUsername.ForeColor = SystemColors.WindowFrame
        tbUsername.Location = New Point(34, 165)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(318, 16)
        tbUsername.TabIndex = 2
        ' 
        ' lblLoginCredentialstoProceed
        ' 
        lblLoginCredentialstoProceed.AutoSize = True
        lblLoginCredentialstoProceed.BackColor = Color.Transparent
        lblLoginCredentialstoProceed.ForeColor = SystemColors.ButtonShadow
        lblLoginCredentialstoProceed.Location = New Point(92, 101)
        lblLoginCredentialstoProceed.Name = "lblLoginCredentialstoProceed"
        lblLoginCredentialstoProceed.Size = New Size(187, 15)
        lblLoginCredentialstoProceed.TabIndex = 1
        lblLoginCredentialstoProceed.Text = "Log in your credentials to proceed"
        ' 
        ' lblLoginTxt
        ' 
        lblLoginTxt.AutoSize = True
        lblLoginTxt.BackColor = Color.Transparent
        lblLoginTxt.Font = New Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point)
        lblLoginTxt.ForeColor = SystemColors.ButtonFace
        lblLoginTxt.Location = New Point(92, 24)
        lblLoginTxt.Name = "lblLoginTxt"
        lblLoginTxt.Size = New Size(189, 72)
        lblLoginTxt.TabIndex = 0
        lblLoginTxt.Text = "Log In"
        ' 
        ' LogInForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(639, 353)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LogInForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblLoginTxt As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents lblLoginCredentialstoProceed As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Button1 As Button
End Class
