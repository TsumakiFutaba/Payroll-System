Public Class TransparentBG
    Dim _Child As Form = Nothing

    Public Sub ShowForm(Child As Form)
        InitializeComponent()
        _Child = Child
        Me.MaximizedBounds = WorkingArea
        Me.WindowState = FormWindowState.Maximized
        Me.ShowDialog()

    End Sub
    Private Sub TransparentBG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _Child.ShowDialog()
        Me.Dispose()
    End Sub
End Class