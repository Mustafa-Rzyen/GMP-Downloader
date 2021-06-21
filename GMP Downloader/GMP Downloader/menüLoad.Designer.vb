<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menüLoad
    Inherits System.Windows.Forms.UserControl

    'UserControl, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.updateProgress = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.SuspendLayout()
        '
        'updateProgress
        '
        Me.updateProgress.Animated = True
        Me.updateProgress.AnimationSpeed = 1.5!
        Me.updateProgress.BackColor = System.Drawing.Color.Transparent
        Me.updateProgress.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.updateProgress.FillThickness = 3
        Me.updateProgress.Location = New System.Drawing.Point(577, 357)
        Me.updateProgress.Name = "updateProgress"
        Me.updateProgress.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid
        Me.updateProgress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.updateProgress.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.updateProgress.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.updateProgress.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.updateProgress.ProgressThickness = 3
        Me.updateProgress.ShadowDecoration.Depth = 0
        Me.updateProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.updateProgress.ShadowDecoration.Parent = Me.updateProgress
        Me.updateProgress.Size = New System.Drawing.Size(50, 50)
        Me.updateProgress.TabIndex = 30
        Me.updateProgress.Value = 15
        '
        'menüLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Controls.Add(Me.updateProgress)
        Me.Name = "menüLoad"
        Me.Size = New System.Drawing.Size(1204, 766)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents updateProgress As Guna.UI2.WinForms.Guna2CircleProgressBar
End Class
