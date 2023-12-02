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
        Button1 = New Button()
        EMPLOYEEID = New TextBox()
        btnTimeInOut = New Button()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        lblUsername = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        LabelTime = New Label()
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
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(EMPLOYEEID)
        Panel1.Controls.Add(btnTimeInOut)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblUsername)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(770, 393)
        Panel1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(403, 294)
        Button1.Name = "Button1"
        Button1.Size = New Size(261, 60)
        Button1.TabIndex = 24
        Button1.Text = "TIME OUT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' EMPLOYEEID
        ' 
        EMPLOYEEID.Location = New Point(345, 237)
        EMPLOYEEID.Name = "EMPLOYEEID"
        EMPLOYEEID.Size = New Size(319, 23)
        EMPLOYEEID.TabIndex = 22
        ' 
        ' btnTimeInOut
        ' 
        btnTimeInOut.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnTimeInOut.FlatAppearance.BorderColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnTimeInOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(80), CByte(90))
        btnTimeInOut.FlatStyle = FlatStyle.Flat
        btnTimeInOut.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnTimeInOut.ForeColor = Color.White
        btnTimeInOut.Location = New Point(126, 294)
        btnTimeInOut.Name = "btnTimeInOut"
        btnTimeInOut.Size = New Size(261, 60)
        btnTimeInOut.TabIndex = 23
        btnTimeInOut.Text = "TIME IN"
        btnTimeInOut.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(126, 232)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 25)
        Label2.TabIndex = 21
        Label2.Text = "Enter your Employee ID:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Untitled_design1
        PictureBox1.Location = New Point(310, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 150)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.White
        lblUsername.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblUsername.ForeColor = SystemColors.ControlDarkDark
        lblUsername.Location = New Point(286, 169)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(224, 45)
        lblUsername.TabIndex = 19
        lblUsername.Text = "Hi, John Doe!"
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
    Friend WithEvents EMPLOYEEID As TextBox
    Friend WithEvents btnTimeInOut As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents Button1 As Button
End Class
