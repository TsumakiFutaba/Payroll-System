<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeMyAccount
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
        lblOvertime = New Label()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        Panel6 = New Panel()
        lblPassword = New Label()
        Label10 = New Label()
        Panel5 = New Panel()
        lblUsername = New Label()
        Label8 = New Label()
        Panel4 = New Panel()
        lblEmail = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        lblFullName = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblOvertime
        ' 
        lblOvertime.AutoSize = True
        lblOvertime.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblOvertime.ForeColor = SystemColors.ControlDarkDark
        lblOvertime.Location = New Point(39, 22)
        lblOvertime.Name = "lblOvertime"
        lblOvertime.Size = New Size(367, 47)
        lblOvertime.TabIndex = 1
        lblOvertime.Text = "Personal Information"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 89)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(998, 645)
        Panel1.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(214, 451)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(784, 34)
        Panel3.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(25, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 0
        Label3.Text = "********"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonShadow
        Label2.Location = New Point(39, 451)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 30)
        Label2.TabIndex = 14
        Label2.Text = "New Password"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.FromArgb(CByte(203), CByte(203), CByte(203))
        Button2.Location = New Point(718, 588)
        Button2.Name = "Button2"
        Button2.Size = New Size(267, 34)
        Button2.TabIndex = 13
        Button2.Text = "Change Password"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_account_96
        PictureBox1.Location = New Point(394, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(142, 140)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.Control
        Panel6.Controls.Add(lblPassword)
        Panel6.Location = New Point(214, 399)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(784, 34)
        Panel6.TabIndex = 9
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblPassword.ForeColor = SystemColors.ControlDarkDark
        lblPassword.Location = New Point(25, 10)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(47, 15)
        lblPassword.TabIndex = 0
        lblPassword.Text = "********"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = SystemColors.ButtonShadow
        Label10.Location = New Point(39, 399)
        Label10.Name = "Label10"
        Label10.Size = New Size(103, 30)
        Label10.TabIndex = 8
        Label10.Text = "Password"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.Control
        Panel5.Controls.Add(lblUsername)
        Panel5.Location = New Point(214, 345)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(784, 34)
        Panel5.TabIndex = 7
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblUsername.ForeColor = SystemColors.ControlDarkDark
        lblUsername.Location = New Point(25, 10)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(94, 15)
        lblUsername.TabIndex = 0
        lblUsername.Text = "johndoe992023"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ButtonShadow
        Label8.Location = New Point(39, 343)
        Label8.Name = "Label8"
        Label8.Size = New Size(111, 30)
        Label8.TabIndex = 6
        Label8.Text = "Username"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.Controls.Add(lblEmail)
        Panel4.Location = New Point(214, 235)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(784, 34)
        Panel4.TabIndex = 5
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmail.ForeColor = SystemColors.ControlDarkDark
        lblEmail.Location = New Point(25, 10)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(134, 15)
        lblEmail.TabIndex = 0
        lblEmail.Text = "johndoe99@gmail.com"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ButtonShadow
        Label6.Location = New Point(39, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 30)
        Label6.TabIndex = 4
        Label6.Text = "Email"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(lblFullName)
        Panel2.Location = New Point(214, 184)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(784, 34)
        Panel2.TabIndex = 1
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblFullName.ForeColor = SystemColors.ControlDarkDark
        lblFullName.Location = New Point(25, 10)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(33, 15)
        lblFullName.TabIndex = 0
        lblFullName.Text = "John"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonShadow
        Label1.Location = New Point(39, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 30)
        Label1.TabIndex = 0
        Label1.Text = "Full Name"
        ' 
        ' EmployeeMyAccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 732)
        Controls.Add(Panel1)
        Controls.Add(lblOvertime)
        FormBorderStyle = FormBorderStyle.None
        Name = "EmployeeMyAccount"
        Text = "EmployeeMyAccount"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblOvertime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblFullName As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
