<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreenForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        pbSplashScreen = New PictureBox()
        Timer1 = New Timer(components)
        Panel2 = New Panel()
        Panel1 = New Panel()
        CType(pbSplashScreen, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbSplashScreen
        ' 
        pbSplashScreen.Image = My.Resources.Resources._Blue___Black_Simple_Company_Logo
        pbSplashScreen.Location = New Point(0, 0)
        pbSplashScreen.Name = "pbSplashScreen"
        pbSplashScreen.Size = New Size(500, 510)
        pbSplashScreen.TabIndex = 0
        pbSplashScreen.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 10
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(54), CByte(69), CByte(79))
        Panel2.Location = New Point(0, 499)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(47, 10)
        Panel2.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 499)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 3)
        Panel1.TabIndex = 1
        ' 
        ' SplashScreenForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(500, 502)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(pbSplashScreen)
        FormBorderStyle = FormBorderStyle.None
        Name = "SplashScreenForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(pbSplashScreen, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbSplashScreen As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
