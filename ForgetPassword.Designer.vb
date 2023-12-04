<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgetPassword
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
        tbSecurityAnswer = New TextBox()
        lblSecurityQuestion = New Label()
        tbSubmit = New Button()
        SuspendLayout()
        ' 
        ' tbSecurityAnswer
        ' 
        tbSecurityAnswer.Location = New Point(236, 80)
        tbSecurityAnswer.Name = "tbSecurityAnswer"
        tbSecurityAnswer.Size = New Size(198, 23)
        tbSecurityAnswer.TabIndex = 0
        ' 
        ' lblSecurityQuestion
        ' 
        lblSecurityQuestion.AutoSize = True
        lblSecurityQuestion.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblSecurityQuestion.Location = New Point(23, 83)
        lblSecurityQuestion.Name = "lblSecurityQuestion"
        lblSecurityQuestion.Size = New Size(195, 15)
        lblSecurityQuestion.TabIndex = 1
        lblSecurityQuestion.Text = "Where did your parents first met?"
        ' 
        ' tbSubmit
        ' 
        tbSubmit.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        tbSubmit.Location = New Point(160, 138)
        tbSubmit.Name = "tbSubmit"
        tbSubmit.Size = New Size(132, 43)
        tbSubmit.TabIndex = 2
        tbSubmit.Text = "SUBMIT"
        tbSubmit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(463, 273)
        Controls.Add(tbSubmit)
        Controls.Add(lblSecurityQuestion)
        Controls.Add(tbSecurityAnswer)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbSecurityAnswer As TextBox
    Friend WithEvents lblSecurityQuestion As Label
    Friend WithEvents tbSubmit As Button
End Class
