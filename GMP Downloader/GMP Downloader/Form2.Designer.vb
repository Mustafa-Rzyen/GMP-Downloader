<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits MetroFramework.Forms.MetroForm

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.adminLabel = New Guna.UI.WinForms.GunaLabel()
        Me.btnKapat2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnOnayla2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnKapat = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.keyText = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnOnayla = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.boyutLabel = New System.Windows.Forms.Label()
        Me.kontrol = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(4, -35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(472, 34)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.btnKapat)
        Me.Panel2.Controls.Add(Me.keyText)
        Me.Panel2.Controls.Add(Me.btnOnayla)
        Me.Panel2.Controls.Add(Me.boyutLabel)
        Me.Panel2.Location = New System.Drawing.Point(-2, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(547, 270)
        Me.Panel2.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.adminLabel)
        Me.Panel4.Controls.Add(Me.btnKapat2)
        Me.Panel4.Controls.Add(Me.btnOnayla2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Location = New System.Drawing.Point(1, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(546, 227)
        Me.Panel4.TabIndex = 159
        '
        'adminLabel
        '
        Me.adminLabel.AutoSize = True
        Me.adminLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!)
        Me.adminLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.adminLabel.Location = New System.Drawing.Point(200, 75)
        Me.adminLabel.Name = "adminLabel"
        Me.adminLabel.Size = New System.Drawing.Size(152, 25)
        Me.adminLabel.TabIndex = 159
        Me.adminLabel.Text = "Manager Login"
        Me.adminLabel.UseMnemonic = False
        '
        'btnKapat2
        '
        Me.btnKapat2.Animated = True
        Me.btnKapat2.AnimationHoverSpeed = 0.07!
        Me.btnKapat2.AnimationSpeed = 0.07!
        Me.btnKapat2.BackColor = System.Drawing.Color.Transparent
        Me.btnKapat2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnKapat2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnKapat2.BorderSize = 1
        Me.btnKapat2.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnKapat2.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnKapat2.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnKapat2.CheckedImage = Nothing
        Me.btnKapat2.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnKapat2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKapat2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnKapat2.FocusedColor = System.Drawing.Color.Empty
        Me.btnKapat2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnKapat2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnKapat2.Image = Nothing
        Me.btnKapat2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnKapat2.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnKapat2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.btnKapat2.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnKapat2.Location = New System.Drawing.Point(141, 157)
        Me.btnKapat2.Name = "btnKapat2"
        Me.btnKapat2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnKapat2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnKapat2.OnHoverForeColor = System.Drawing.Color.White
        Me.btnKapat2.OnHoverImage = Nothing
        Me.btnKapat2.OnHoverLineColor = System.Drawing.Color.Empty
        Me.btnKapat2.OnPressedColor = System.Drawing.Color.Black
        Me.btnKapat2.OnPressedDepth = 0
        Me.btnKapat2.Radius = 1
        Me.btnKapat2.Size = New System.Drawing.Size(119, 36)
        Me.btnKapat2.TabIndex = 158
        Me.btnKapat2.Text = "KAPAT"
        Me.btnKapat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnOnayla2
        '
        Me.btnOnayla2.Animated = True
        Me.btnOnayla2.AnimationHoverSpeed = 0.07!
        Me.btnOnayla2.AnimationSpeed = 0.07!
        Me.btnOnayla2.BackColor = System.Drawing.Color.Transparent
        Me.btnOnayla2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnOnayla2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnOnayla2.BorderSize = 1
        Me.btnOnayla2.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnOnayla2.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnOnayla2.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnOnayla2.CheckedImage = Nothing
        Me.btnOnayla2.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnOnayla2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOnayla2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOnayla2.FocusedColor = System.Drawing.Color.Empty
        Me.btnOnayla2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnOnayla2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnOnayla2.Image = Nothing
        Me.btnOnayla2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnOnayla2.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnOnayla2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.btnOnayla2.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnOnayla2.Location = New System.Drawing.Point(285, 157)
        Me.btnOnayla2.Name = "btnOnayla2"
        Me.btnOnayla2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOnayla2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOnayla2.OnHoverForeColor = System.Drawing.Color.White
        Me.btnOnayla2.OnHoverImage = Nothing
        Me.btnOnayla2.OnHoverLineColor = System.Drawing.Color.Empty
        Me.btnOnayla2.OnPressedColor = System.Drawing.Color.Black
        Me.btnOnayla2.OnPressedDepth = 0
        Me.btnOnayla2.Radius = 1
        Me.btnOnayla2.Size = New System.Drawing.Size(119, 36)
        Me.btnOnayla2.TabIndex = 156
        Me.btnOnayla2.Text = "Kod Gir"
        Me.btnOnayla2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(540, 26)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "GMPKEY+ij+SqbedBimwpLpjj9wTkzC20F3RJ7Ls1NU"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(250, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(5, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 34)
        Me.Panel1.TabIndex = 158
        '
        'btnKapat
        '
        Me.btnKapat.Animated = True
        Me.btnKapat.AnimationHoverSpeed = 0.07!
        Me.btnKapat.AnimationSpeed = 0.07!
        Me.btnKapat.BackColor = System.Drawing.Color.Transparent
        Me.btnKapat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnKapat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnKapat.BorderSize = 1
        Me.btnKapat.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnKapat.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnKapat.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnKapat.CheckedImage = Nothing
        Me.btnKapat.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKapat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnKapat.FocusedColor = System.Drawing.Color.Empty
        Me.btnKapat.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnKapat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnKapat.Image = Nothing
        Me.btnKapat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnKapat.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnKapat.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.btnKapat.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnKapat.Location = New System.Drawing.Point(142, 197)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnKapat.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnKapat.OnHoverForeColor = System.Drawing.Color.White
        Me.btnKapat.OnHoverImage = Nothing
        Me.btnKapat.OnHoverLineColor = System.Drawing.Color.Empty
        Me.btnKapat.OnPressedColor = System.Drawing.Color.Black
        Me.btnKapat.OnPressedDepth = 0
        Me.btnKapat.Radius = 1
        Me.btnKapat.Size = New System.Drawing.Size(119, 36)
        Me.btnKapat.TabIndex = 157
        Me.btnKapat.Text = "KAPAT"
        Me.btnKapat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'keyText
        '
        Me.keyText.Animated = True
        Me.keyText.BorderRadius = 1
        Me.keyText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.keyText.DefaultText = ""
        Me.keyText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.keyText.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.keyText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.keyText.DisabledState.Parent = Me.keyText
        Me.keyText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.keyText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.keyText.FocusedState.Parent = Me.keyText
        Me.keyText.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.keyText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.keyText.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.keyText.HoverState.Parent = Me.keyText
        Me.keyText.Location = New System.Drawing.Point(49, 139)
        Me.keyText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.keyText.Name = "keyText"
        Me.keyText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.keyText.PlaceholderText = ""
        Me.keyText.SelectedText = ""
        Me.keyText.ShadowDecoration.Parent = Me.keyText
        Me.keyText.Size = New System.Drawing.Size(453, 27)
        Me.keyText.TabIndex = 156
        Me.keyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnOnayla
        '
        Me.btnOnayla.Animated = True
        Me.btnOnayla.AnimationHoverSpeed = 0.07!
        Me.btnOnayla.AnimationSpeed = 0.07!
        Me.btnOnayla.BackColor = System.Drawing.Color.Transparent
        Me.btnOnayla.BaseColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnOnayla.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnOnayla.BorderSize = 1
        Me.btnOnayla.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnOnayla.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnOnayla.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnOnayla.CheckedImage = Nothing
        Me.btnOnayla.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnOnayla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOnayla.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOnayla.FocusedColor = System.Drawing.Color.Empty
        Me.btnOnayla.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnOnayla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnOnayla.Image = Nothing
        Me.btnOnayla.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnOnayla.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnOnayla.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.btnOnayla.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnOnayla.Location = New System.Drawing.Point(286, 197)
        Me.btnOnayla.Name = "btnOnayla"
        Me.btnOnayla.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOnayla.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOnayla.OnHoverForeColor = System.Drawing.Color.White
        Me.btnOnayla.OnHoverImage = Nothing
        Me.btnOnayla.OnHoverLineColor = System.Drawing.Color.Empty
        Me.btnOnayla.OnPressedColor = System.Drawing.Color.Black
        Me.btnOnayla.OnPressedDepth = 0
        Me.btnOnayla.Radius = 1
        Me.btnOnayla.Size = New System.Drawing.Size(119, 36)
        Me.btnOnayla.TabIndex = 155
        Me.btnOnayla.Text = "ONAYLA"
        Me.btnOnayla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'boyutLabel
        '
        Me.boyutLabel.Font = New System.Drawing.Font("Microsoft YaHei", 13.0!)
        Me.boyutLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.boyutLabel.Location = New System.Drawing.Point(49, 72)
        Me.boyutLabel.Name = "boyutLabel"
        Me.boyutLabel.Size = New System.Drawing.Size(453, 55)
        Me.boyutLabel.TabIndex = 73
        Me.boyutLabel.Text = "Yönetici yetkisi almak için lütfen, Mevcut anahtarı giriniz"
        Me.boyutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'kontrol
        '
        Me.kontrol.TargetControl = Me.Panel1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 267)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Text = "GMP Downloader Admin Key"
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnKapat As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents keyText As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnOnayla As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents boyutLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents kontrol As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnKapat2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnOnayla2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents adminLabel As Guna.UI.WinForms.GunaLabel
End Class
