<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ITCreateAccount
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
        PanelTop = New Panel()
        Panel3 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        cbGender = New ComboBox()
        DateTimePickDOB = New DateTimePicker()
        tbID = New TextBox()
        Label5 = New Label()
        tbPagIbig = New TextBox()
        Label4 = New Label()
        tbPhilhealth = New TextBox()
        Label3 = New Label()
        tbSSS = New TextBox()
        Label2 = New Label()
        btnRegister = New Button()
        cbPosition = New ComboBox()
        tbPreferredPassword = New TextBox()
        lblPreferredPassword = New Label()
        tbPreferredUsername = New TextBox()
        lblPreferredUsername = New Label()
        lblPosition = New Label()
        tbEmail = New TextBox()
        lblEmail = New Label()
        lblBday = New Label()
        lblGender = New Label()
        tbAge = New TextBox()
        lblAge = New Label()
        tbName = New TextBox()
        lblName = New Label()
        PanelTop.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelTop
        ' 
        PanelTop.Controls.Add(Panel3)
        PanelTop.Controls.Add(Panel2)
        PanelTop.Dock = DockStyle.Top
        PanelTop.Location = New Point(0, 0)
        PanelTop.Name = "PanelTop"
        PanelTop.Size = New Size(997, 142)
        PanelTop.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        Panel3.Controls.Add(Label1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 87)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(997, 55)
        Panel3.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(203), CByte(203), CByte(203))
        Label1.Location = New Point(413, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 25)
        Label1.TabIndex = 0
        Label1.Text = "Personal Information"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(997, 87)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.Top
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(997, 87)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(cbGender)
        Panel4.Controls.Add(DateTimePickDOB)
        Panel4.Controls.Add(tbID)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(tbPagIbig)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(tbPhilhealth)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(tbSSS)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(btnRegister)
        Panel4.Controls.Add(cbPosition)
        Panel4.Controls.Add(tbPreferredPassword)
        Panel4.Controls.Add(lblPreferredPassword)
        Panel4.Controls.Add(tbPreferredUsername)
        Panel4.Controls.Add(lblPreferredUsername)
        Panel4.Controls.Add(lblPosition)
        Panel4.Controls.Add(tbEmail)
        Panel4.Controls.Add(lblEmail)
        Panel4.Controls.Add(lblBday)
        Panel4.Controls.Add(lblGender)
        Panel4.Controls.Add(tbAge)
        Panel4.Controls.Add(lblAge)
        Panel4.Controls.Add(tbName)
        Panel4.Controls.Add(lblName)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 142)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(997, 590)
        Panel4.TabIndex = 1
        ' 
        ' cbGender
        ' 
        cbGender.BackColor = SystemColors.ScrollBar
        cbGender.DropDownStyle = ComboBoxStyle.DropDownList
        cbGender.FormattingEnabled = True
        cbGender.Items.AddRange(New Object() {"Female", "Male"})
        cbGender.Location = New Point(586, 75)
        cbGender.Name = "cbGender"
        cbGender.Size = New Size(371, 23)
        cbGender.Sorted = True
        cbGender.TabIndex = 27
        ' 
        ' DateTimePickDOB
        ' 
        DateTimePickDOB.CustomFormat = "dd-MM-yyyy"
        DateTimePickDOB.Format = DateTimePickerFormat.Custom
        DateTimePickDOB.Location = New Point(87, 107)
        DateTimePickDOB.Name = "DateTimePickDOB"
        DateTimePickDOB.Size = New Size(206, 23)
        DateTimePickDOB.TabIndex = 26
        ' 
        ' tbID
        ' 
        tbID.BackColor = SystemColors.ScrollBar
        tbID.BorderStyle = BorderStyle.None
        tbID.Location = New Point(29, 301)
        tbID.Name = "tbID"
        tbID.Size = New Size(931, 16)
        tbID.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlDarkDark
        Label5.Location = New Point(29, 281)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 17)
        Label5.TabIndex = 24
        Label5.Text = "Employee ID:"
        ' 
        ' tbPagIbig
        ' 
        tbPagIbig.BackColor = SystemColors.ScrollBar
        tbPagIbig.BorderStyle = BorderStyle.None
        tbPagIbig.Location = New Point(27, 449)
        tbPagIbig.Name = "tbPagIbig"
        tbPagIbig.Size = New Size(931, 16)
        tbPagIbig.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlDarkDark
        Label4.Location = New Point(29, 429)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 17)
        Label4.TabIndex = 22
        Label4.Text = "Pag-Ibig"
        ' 
        ' tbPhilhealth
        ' 
        tbPhilhealth.BackColor = SystemColors.ScrollBar
        tbPhilhealth.BorderStyle = BorderStyle.None
        tbPhilhealth.Location = New Point(26, 407)
        tbPhilhealth.Name = "tbPhilhealth"
        tbPhilhealth.Size = New Size(931, 16)
        tbPhilhealth.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(26, 387)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 17)
        Label3.TabIndex = 20
        Label3.Text = "Philhealth"
        ' 
        ' tbSSS
        ' 
        tbSSS.BackColor = SystemColors.ScrollBar
        tbSSS.BorderStyle = BorderStyle.None
        tbSSS.Location = New Point(26, 368)
        tbSSS.Name = "tbSSS"
        tbSSS.Size = New Size(931, 16)
        tbSSS.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(26, 348)
        Label2.Name = "Label2"
        Label2.Size = New Size(29, 17)
        Label2.TabIndex = 18
        Label2.Text = "SSS"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Transparent
        btnRegister.FlatAppearance.BorderColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegister.ForeColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnRegister.Location = New Point(29, 487)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(931, 32)
        btnRegister.TabIndex = 17
        btnRegister.Text = "Create account"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' cbPosition
        ' 
        cbPosition.BackColor = SystemColors.ScrollBar
        cbPosition.DropDownStyle = ComboBoxStyle.DropDownList
        cbPosition.FormattingEnabled = True
        cbPosition.Items.AddRange(New Object() {"Project Manager", "Front-End Developer", "Back-End Developer", "Data Analyst", "IT Admin", "HR Admin", "Accounting Admin"})
        cbPosition.Location = New Point(87, 139)
        cbPosition.Name = "cbPosition"
        cbPosition.Size = New Size(873, 23)
        cbPosition.TabIndex = 16
        ' 
        ' tbPreferredPassword
        ' 
        tbPreferredPassword.BackColor = SystemColors.ScrollBar
        tbPreferredPassword.BorderStyle = BorderStyle.None
        tbPreferredPassword.Location = New Point(29, 260)
        tbPreferredPassword.Name = "tbPreferredPassword"
        tbPreferredPassword.Size = New Size(931, 16)
        tbPreferredPassword.TabIndex = 15
        ' 
        ' lblPreferredPassword
        ' 
        lblPreferredPassword.AutoSize = True
        lblPreferredPassword.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPreferredPassword.ForeColor = SystemColors.ControlDarkDark
        lblPreferredPassword.Location = New Point(29, 240)
        lblPreferredPassword.Name = "lblPreferredPassword"
        lblPreferredPassword.Size = New Size(126, 17)
        lblPreferredPassword.TabIndex = 14
        lblPreferredPassword.Text = "Preferred Password:"
        ' 
        ' tbPreferredUsername
        ' 
        tbPreferredUsername.BackColor = SystemColors.ScrollBar
        tbPreferredUsername.BorderStyle = BorderStyle.None
        tbPreferredUsername.Location = New Point(29, 221)
        tbPreferredUsername.Name = "tbPreferredUsername"
        tbPreferredUsername.Size = New Size(931, 16)
        tbPreferredUsername.TabIndex = 13
        ' 
        ' lblPreferredUsername
        ' 
        lblPreferredUsername.AutoSize = True
        lblPreferredUsername.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPreferredUsername.ForeColor = SystemColors.ControlDarkDark
        lblPreferredUsername.Location = New Point(29, 201)
        lblPreferredUsername.Name = "lblPreferredUsername"
        lblPreferredUsername.Size = New Size(129, 17)
        lblPreferredUsername.TabIndex = 12
        lblPreferredUsername.Text = "Preferred Username:"
        ' 
        ' lblPosition
        ' 
        lblPosition.AutoSize = True
        lblPosition.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPosition.ForeColor = SystemColors.ControlDarkDark
        lblPosition.Location = New Point(29, 139)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(57, 17)
        lblPosition.TabIndex = 10
        lblPosition.Text = "Position:"
        ' 
        ' tbEmail
        ' 
        tbEmail.BackColor = SystemColors.ScrollBar
        tbEmail.BorderStyle = BorderStyle.None
        tbEmail.Location = New Point(586, 108)
        tbEmail.Name = "tbEmail"
        tbEmail.Size = New Size(374, 16)
        tbEmail.TabIndex = 9
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmail.ForeColor = SystemColors.ControlDarkDark
        lblEmail.Location = New Point(528, 106)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(42, 17)
        lblEmail.TabIndex = 8
        lblEmail.Text = "Email:"
        ' 
        ' lblBday
        ' 
        lblBday.AutoSize = True
        lblBday.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblBday.ForeColor = SystemColors.ControlDarkDark
        lblBday.Location = New Point(29, 106)
        lblBday.Name = "lblBday"
        lblBday.Size = New Size(58, 17)
        lblBday.TabIndex = 6
        lblBday.Text = "Birthday:"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblGender.ForeColor = SystemColors.ControlDarkDark
        lblGender.Location = New Point(528, 76)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(54, 17)
        lblGender.TabIndex = 4
        lblGender.Text = "Gender:"
        ' 
        ' tbAge
        ' 
        tbAge.BackColor = SystemColors.ScrollBar
        tbAge.BorderStyle = BorderStyle.None
        tbAge.Location = New Point(87, 79)
        tbAge.Name = "tbAge"
        tbAge.Size = New Size(409, 16)
        tbAge.TabIndex = 3
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblAge.ForeColor = SystemColors.ControlDarkDark
        lblAge.Location = New Point(29, 77)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(34, 17)
        lblAge.TabIndex = 2
        lblAge.Text = "Age:"
        ' 
        ' tbName
        ' 
        tbName.BackColor = SystemColors.ScrollBar
        tbName.BorderStyle = BorderStyle.None
        tbName.Location = New Point(87, 51)
        tbName.Name = "tbName"
        tbName.Size = New Size(873, 16)
        tbName.TabIndex = 1
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblName.ForeColor = SystemColors.ControlDarkDark
        lblName.Location = New Point(29, 49)
        lblName.Name = "lblName"
        lblName.Size = New Size(46, 17)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' ITCreateAccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 732)
        Controls.Add(Panel4)
        Controls.Add(PanelTop)
        FormBorderStyle = FormBorderStyle.None
        Name = "ITCreateAccount"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegisterForm"
        PanelTop.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tbAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents tbPreferredPassword As TextBox
    Friend WithEvents lblPreferredPassword As Label
    Friend WithEvents tbPreferredUsername As TextBox
    Friend WithEvents lblPreferredUsername As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblBday As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents cbPosition As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbPhilhealth As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbSSS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPagIbig As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickDOB As DateTimePicker
    Friend WithEvents cbGender As ComboBox
End Class
