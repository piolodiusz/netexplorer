<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ustawienia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ustawienia))
        Me.TextBoxu = New System.Windows.Forms.TextBox()
        Me.Ustaw = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxu
        '
        Me.TextBoxu.Location = New System.Drawing.Point(23, 48)
        Me.TextBoxu.Name = "TextBoxu"
        Me.TextBoxu.Size = New System.Drawing.Size(308, 20)
        Me.TextBoxu.TabIndex = 0
        '
        'Ustaw
        '
        Me.Ustaw.Location = New System.Drawing.Point(129, 103)
        Me.Ustaw.Name = "Ustaw"
        Me.Ustaw.Size = New System.Drawing.Size(83, 23)
        Me.Ustaw.TabIndex = 1
        Me.Ustaw.Text = "Ustaw"
        Me.Ustaw.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxu)
        Me.GroupBox1.Controls.Add(Me.Ustaw)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 229)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Strona Domowa"
        '
        'Ustawienia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 257)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ustawienia"
        Me.Text = "Ustawienia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxu As TextBox
    Friend WithEvents Ustaw As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
