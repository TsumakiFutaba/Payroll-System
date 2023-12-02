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
        Button1 = New Button()
        Label4 = New Label()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
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
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(CheckBox5)
        Panel2.Controls.Add(CheckBox4)
        Panel2.Controls.Add(CheckBox3)
        Panel2.Controls.Add(CheckBox2)
        Panel2.Controls.Add(CheckBox1)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(TextBox1)
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
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(203), CByte(203), CByte(203))
        Button1.Location = New Point(38, 320)
        Button1.Name = "Button1"
        Button1.Size = New Size(404, 36)
        Button1.TabIndex = 10
        Button1.Text = "Confirm"
        Button1.UseVisualStyleBackColor = False
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
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.ForeColor = SystemColors.ControlDark
        CheckBox5.Location = New Point(233, 163)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(145, 19)
        CheckBox5.TabIndex = 8
        CheckBox5.Text = "8 characters minimum"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox4.ForeColor = SystemColors.ControlDark
        CheckBox4.Location = New Point(233, 138)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(143, 19)
        CheckBox4.TabIndex = 7
        CheckBox4.Text = "one number character"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.ForeColor = SystemColors.ControlDark
        CheckBox3.Location = New Point(38, 188)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(137, 19)
        CheckBox3.TabIndex = 6
        CheckBox3.Text = "one special character"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.ForeColor = SystemColors.ControlDark
        CheckBox2.Location = New Point(38, 163)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(155, 19)
        CheckBox2.TabIndex = 5
        CheckBox2.Text = "one uppercase character"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.ForeColor = SystemColors.ControlDark
        CheckBox1.Location = New Point(38, 138)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(153, 19)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "one lowercase character"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(137, 62)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(305, 29)
        TextBox2.TabIndex = 3
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
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(137, 13)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(305, 29)
        TextBox1.TabIndex = 1
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
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
End Class
