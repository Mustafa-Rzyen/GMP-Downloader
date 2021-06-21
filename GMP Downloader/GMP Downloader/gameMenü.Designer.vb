<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gameMenü
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gameMenü))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Tool = New MetroFramework.Components.MetroToolTip()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaVScrollBar1 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Name = "Panel1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.GunaLabel2)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'GunaLabel2
        '
        resources.ApplyResources(Me.GunaLabel2, "GunaLabel2")
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel2.Name = "GunaLabel2"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Tool
        '
        Me.Tool.StripAmpersands = True
        Me.Tool.Style = MetroFramework.MetroColorStyle.Black
        Me.Tool.StyleManager = Nothing
        Me.Tool.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'GunaVScrollBar1
        '
        Me.GunaVScrollBar1.LargeChange = 10
        resources.ApplyResources(Me.GunaVScrollBar1, "GunaVScrollBar1")
        Me.GunaVScrollBar1.Maximum = 100
        Me.GunaVScrollBar1.Name = "GunaVScrollBar1"
        Me.GunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.GunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        '
        'gameMenü
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaVScrollBar1)
        Me.Name = "gameMenü"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Tool As MetroFramework.Components.MetroToolTip
    Friend WithEvents Timer3 As Timer
    Friend WithEvents GunaVScrollBar1 As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
