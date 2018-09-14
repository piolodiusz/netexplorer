<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplikacje
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aplikacje))
        Me.Bitly = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Bitly
        '
        Me.Bitly.BackgroundImage = CType(resources.GetObject("Bitly.BackgroundImage"), System.Drawing.Image)
        Me.Bitly.Location = New System.Drawing.Point(59, 56)
        Me.Bitly.Name = "Bitly"
        Me.Bitly.Size = New System.Drawing.Size(200, 196)
        Me.Bitly.TabIndex = 0
        Me.Bitly.UseVisualStyleBackColor = True
        '
        'Aplikacje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 327)
        Me.Controls.Add(Me.Bitly)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Aplikacje"
        Me.Text = "Apps"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bitly As Button
End Class
