Public Class Ustawienia
    Private Sub Ustawienia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxu.Text = My.Settings.Domowa
    End Sub

    Private Sub Ustaw_Click(sender As Object, e As EventArgs) Handles Ustaw.Click
        If TextBoxu.Text.Contains("http://") Then
            My.Settings.Domowa = (TextBoxu.Text)
            My.Settings.Save()
        Else
            My.Settings.Domowa = ("http://" + TextBoxu.Text)
            My.Settings.Save()
        End If
    End Sub
End Class