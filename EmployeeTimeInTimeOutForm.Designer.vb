<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeTimeInTimeOutForm
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
        LabelDate = New Label()
        Timer1 = New Timer(components)
        Panel1 = New Panel()
        btnTimeOut = New Button()
        btnTimeIn = New Button()
        PictureBox1 = New PictureBox()
        lblHi = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        LabelTime = New Label()
        lblUsername = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelDate
        ' 
        LabelDate.AutoSize = True
        LabelDate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LabelDate.ForeColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        LabelDate.Location = New Point(619, 41)
        LabelDate.Name = "LabelDate"
        LabelDate.Size = New Size(110, 21)
        LabelDate.TabIndex = 0
        LabelDate.Text = "Date and Time"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(lblUsername)
        Panel1.Controls.Add(btnTimeOut)
        Panel1.Controls.Add(btnTimeIn)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblHi)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(770, 393)
        Panel1.TabIndex = 1
        ' 
        ' btnTimeOut
        ' 
        btnTimeOut.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnTimeOut.FlatAppearance.BorderColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnTimeOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnTimeOut.FlatStyle = FlatStyle.Flat
        btnTimeOut.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnTimeOut.ForeColor = Color.White
        btnTimeOut.Location = New Point(415, 269)
        btnTimeOut.Name = "btnTimeOut"
        btnTimeOut.Size = New Size(261, 60)
        btnTimeOut.TabIndex = 24
        btnTimeOut.Text = "TIME OUT"
        btnTimeOut.UseVisualStyleBackColor = False
        ' 
        ' btnTimeIn
        ' 
        btnTimeIn.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnTimeIn.FlatAppearance.BorderColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnTimeIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnTimeIn.FlatStyle = FlatStyle.Flat
        btnTimeIn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnTimeIn.ForeColor = Color.White
        btnTimeIn.Location = New Point(106, 269)
        btnTimeIn.Name = "btnTimeIn"
        btnTimeIn.Size = New Size(261, 60)
        btnTimeIn.TabIndex = 23
        btnTimeIn.Text = "TIME IN"
        btnTimeIn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Untitled_design1
        PictureBox1.Location = New Point(313, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 150)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' lblHi
        ' 
        lblHi.AutoSize = True
        lblHi.BackColor = Color.WhiteSmoke
        lblHi.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblHi.ForeColor = SystemColors.ControlDarkDark
        lblHi.Location = New Point(284, 206)
        lblHi.Name = "lblHi"
        lblHi.Size = New Size(63, 45)
        lblHi.TabIndex = 19
        lblHi.Text = "Hi,"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(102, 93)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(770, 485)
        Panel2.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Panel1)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 92)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(770, 393)
        Panel4.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(LabelTime)
        Panel3.Controls.Add(LabelDate)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(770, 92)
        Panel3.TabIndex = 2
        ' 
        ' LabelTime
        ' 
        LabelTime.AutoSize = True
        LabelTime.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTime.ForeColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        LabelTime.Location = New Point(19, 31)
        LabelTime.Name = "LabelTime"
        LabelTime.Size = New Size(238, 45)
        LabelTime.TabIndex = 1
        LabelTime.Text = "Date and Time"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.WhiteSmoke
        lblUsername.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblUsername.ForeColor = SystemColors.ControlDarkDark
        lblUsername.Location = New Point(340, 206)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(172, 45)
        lblUsername.TabIndex = 20
        lblUsername.Text = "John Doe!"
        ' 
        ' EmployeeTimeInTimeOutForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        BackgroundImage = My.Resources.Resources.Background1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(997, 732)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "EmployeeTimeInTimeOutForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LabelDate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelTime As Label
    Friend WithEvents btnTimeIn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHi As Label
    Friend WithEvents btnTimeOut As Button
    Friend WithEvents lblUsername As Label
End Class
