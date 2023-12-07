<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OneTimeEmployeePasswordChange
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
        Label1 = New Label()
        Panel2 = New Panel()
        TextBox3 = New TextBox()
        Label5 = New Label()
        btnConfirm = New Button()
        Label4 = New Label()
        chbCharactersMinimum = New CheckBox()
        chbOneNumberCharacter = New CheckBox()
        chbOneSpecialCharacter = New CheckBox()
        chbOneUppercaseCharacter = New CheckBox()
        chbOneLowercaseCharacter = New CheckBox()
        tbNewPassword = New TextBox()
        Label3 = New Label()
        tbUsername = New TextBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 74)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(203), CByte(203), CByte(203))
        Label1.Location = New Point(137, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 32)
        Label1.TabIndex = 0
        Label1.Text = "Change Password"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLightLight
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(btnConfirm)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(chbCharactersMinimum)
        Panel2.Controls.Add(chbOneNumberCharacter)
        Panel2.Controls.Add(chbOneSpecialCharacter)
        Panel2.Controls.Add(chbOneUppercaseCharacter)
        Panel2.Controls.Add(chbOneLowercaseCharacter)
        Panel2.Controls.Add(tbNewPassword)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(tbUsername)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 74)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(500, 376)
        Panel2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(38, 276)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(404, 29)
        TextBox3.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.ControlDarkDark
        Label5.Location = New Point(38, 245)
        Label5.Name = "Label5"
        Label5.Size = New Size(261, 15)
        Label5.TabIndex = 11
        Label5.Text = "Where did your parents meet? (Secret Password)"
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnConfirm.FlatAppearance.BorderSize = 0
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.ForeColor = Color.FromArgb(CByte(203), CByte(203), CByte(203))
        btnConfirm.Location = New Point(38, 320)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(404, 36)
        btnConfirm.TabIndex = 10
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Silver
        Label4.Location = New Point(38, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(197, 15)
        Label4.TabIndex = 9
        Label4.Text = "Your new password should contain: "
        ' 
        ' chbCharactersMinimum
        ' 
        chbCharactersMinimum.AutoSize = True
        chbCharactersMinimum.Enabled = False
        chbCharactersMinimum.ForeColor = SystemColors.ControlDark
        chbCharactersMinimum.Location = New Point(233, 163)
        chbCharactersMinimum.Name = "chbCharactersMinimum"
        chbCharactersMinimum.Size = New Size(145, 19)
        chbCharactersMinimum.TabIndex = 8
        chbCharactersMinimum.Text = "8 characters minimum"
        chbCharactersMinimum.UseVisualStyleBackColor = True
        ' 
        ' chbOneNumberCharacter
        ' 
        chbOneNumberCharacter.AutoSize = True
        chbOneNumberCharacter.Enabled = False
        chbOneNumberCharacter.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chbOneNumberCharacter.ForeColor = SystemColors.ControlDark
        chbOneNumberCharacter.Location = New Point(233, 138)
        chbOneNumberCharacter.Name = "chbOneNumberCharacter"
        chbOneNumberCharacter.Size = New Size(143, 19)
        chbOneNumberCharacter.TabIndex = 4
        chbOneNumberCharacter.Text = "one number character"
        chbOneNumberCharacter.UseVisualStyleBackColor = True
        ' 
        ' chbOneSpecialCharacter
        ' 
        chbOneSpecialCharacter.AutoSize = True
        chbOneSpecialCharacter.Enabled = False
        chbOneSpecialCharacter.ForeColor = SystemColors.ControlDark
        chbOneSpecialCharacter.Location = New Point(38, 188)
        chbOneSpecialCharacter.Name = "chbOneSpecialCharacter"
        chbOneSpecialCharacter.Size = New Size(137, 19)
        chbOneSpecialCharacter.TabIndex = 6
        chbOneSpecialCharacter.Text = "one special character"
        chbOneSpecialCharacter.UseVisualStyleBackColor = True
        ' 
        ' chbOneUppercaseCharacter
        ' 
        chbOneUppercaseCharacter.AutoSize = True
        chbOneUppercaseCharacter.Enabled = False
        chbOneUppercaseCharacter.ForeColor = SystemColors.ControlDark
        chbOneUppercaseCharacter.Location = New Point(38, 163)
        chbOneUppercaseCharacter.Name = "chbOneUppercaseCharacter"
        chbOneUppercaseCharacter.Size = New Size(155, 19)
        chbOneUppercaseCharacter.TabIndex = 5
        chbOneUppercaseCharacter.Text = "one uppercase character"
        chbOneUppercaseCharacter.UseVisualStyleBackColor = True
        ' 
        ' chbOneLowercaseCharacter
        ' 
        chbOneLowercaseCharacter.AutoSize = True
        chbOneLowercaseCharacter.Enabled = False
        chbOneLowercaseCharacter.ForeColor = SystemColors.ControlDark
        chbOneLowercaseCharacter.Location = New Point(38, 138)
        chbOneLowercaseCharacter.Name = "chbOneLowercaseCharacter"
        chbOneLowercaseCharacter.Size = New Size(153, 19)
        chbOneLowercaseCharacter.TabIndex = 4
        chbOneLowercaseCharacter.Text = "one lowercase character"
        chbOneLowercaseCharacter.UseVisualStyleBackColor = True
        ' 
        ' tbNewPassword
        ' 
        tbNewPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        tbNewPassword.Location = New Point(137, 62)
        tbNewPassword.Name = "tbNewPassword"
        tbNewPassword.PasswordChar = "*"c
        tbNewPassword.Size = New Size(305, 29)
        tbNewPassword.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(38, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 15)
        Label3.TabIndex = 2
        Label3.Text = "New password: "
        ' 
        ' tbUsername
        ' 
        tbUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        tbUsername.Location = New Point(137, 13)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(305, 29)
        tbUsername.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(38, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 0
        Label2.Text = "Username: "
        ' 
        ' OneTimeEmployeePasswordChange
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(500, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "OneTimeEmployeePasswordChange"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OneTimeEmployeePasswordChange"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tbNewPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents chbCharactersMinimum As CheckBox
    Friend WithEvents chbOneNumberCharacter As CheckBox
    Friend WithEvents chbOneSpecialCharacter As CheckBox
    Friend WithEvents chbOneUppercaseCharacter As CheckBox
    Friend WithEvents chbOneLowercaseCharacter As CheckBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
End Class
