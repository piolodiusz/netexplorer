Public Class netexplorer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.TabPages.Add(tab)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newform As New tab
        TabControl1.TabPages.Add(newform)
    End Sub
End Class
