Imports Awesomium.Core

Public Class tab
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If TextBox1.Text.Contains(".biz") Or TextBox1.Text.Contains(".info") Or TextBox1.Text.Contains(".pro") Or TextBox1.Text.Contains(".co") Or TextBox1.Text.Contains(".eu") Or TextBox1.Text.Contains(".pl") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".by") Or TextBox1.Text.Contains(".ly") Then
                WebControl1.Source = New Uri("http://" + TextBox1.Text)
                If TextBox1.Text.Contains("http://") Or TextBox1.Text.Contains("https://") Then
                    WebControl1.Source = New Uri(TextBox1.Text)
                End If
            Else
                WebControl1.Source = New Uri(My.Settings.Wyszukaj + TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles WebControl1.ShowCreatedWebView

    End Sub

    Private Sub WebControl1_LoadingFrame(sender As Object, e As LoadingFrameEventArgs) Handles WebControl1.LoadingFrame
        Button3.Show()
    End Sub

    Private Sub WebControl1_LoadingFrameComplete(sender As Object, e As FrameEventArgs) Handles WebControl1.LoadingFrameComplete
        TextBox1.Text = WebControl1.Source.ToString
        Dim url As Uri = New Uri(TextBox1.Text)
        Me.Text = WebControl1.Title
        Button3.Hide()
        My.Settings.Historia.Add(WebControl1.Source.ToString)
        My.Settings.Save()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If WebControl1.CanGoBack Then
            WebControl1.GoBack()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WebControl1.CanGoForward Then
            WebControl1.GoForward()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebControl1.Source = New Uri(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebControl1.Stop()
    End Sub

    Private Sub tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebControl1.Source = New Uri(My.Settings.Domowa.ToString)
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Panel1.Hide()
        Close.Hide()
    End Sub

    Private Sub Open_Click(sender As Object, e As EventArgs) Handles Open.Click
        Panel1.Show()
        Close.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Informacje.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebControl1.Source = New Uri(My.Settings.Domowa)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Aplikacje.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Ustawienia.Show()
    End Sub
End Class