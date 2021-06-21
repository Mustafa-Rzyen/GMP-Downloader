<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminForm))
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.updateProgress = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.GunaLinePanel3 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton11 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.boyutLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.kontrol = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.animated = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GunaLinePanel3.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaLinePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Controls.Add(Me.updateProgress)
        Me.animated.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(-2, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(672, 377)
        Me.Panel4.TabIndex = 157
        '
        'updateProgress
        '
        Me.updateProgress.Animated = True
        Me.updateProgress.AnimationSpeed = 1.5!
        Me.updateProgress.BackColor = System.Drawing.Color.Transparent
        Me.animated.SetDecoration(Me.updateProgress, BunifuAnimatorNS.DecorationType.None)
        Me.updateProgress.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.updateProgress.FillThickness = 3
        Me.updateProgress.Location = New System.Drawing.Point(311, 274)
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Guna2ControlBox2)
        Me.Panel3.Controls.Add(Me.Guna2ControlBox1)
        Me.animated.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(-5, -8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(672, 37)
        Me.Panel3.TabIndex = 2
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.Animated = True
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.animated.SetDecoration(Me.Guna2ControlBox2, BunifuAnimatorNS.DecorationType.None)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DarkGray
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(586, 3)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.PressedDepth = 0
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(42, 37)
        Me.Guna2ControlBox2.TabIndex = 160
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.animated.SetDecoration(Me.Guna2ControlBox1, BunifuAnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Crimson
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DarkGray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(628, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedDepth = 0
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(42, 37)
        Me.Guna2ControlBox1.TabIndex = 159
        '
        'GunaLinePanel3
        '
        Me.GunaLinePanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaLinePanel3.Controls.Add(Me.GunaAdvenceButton1)
        Me.GunaLinePanel3.Controls.Add(Me.GunaAdvenceButton2)
        Me.GunaLinePanel3.Controls.Add(Me.GunaAdvenceButton11)
        Me.GunaLinePanel3.Controls.Add(Me.Label3)
        Me.GunaLinePanel3.Controls.Add(Me.boyutLabel)
        Me.GunaLinePanel3.Controls.Add(Me.Label2)
        Me.GunaLinePanel3.Controls.Add(Me.Label5)
        Me.GunaLinePanel3.Controls.Add(Me.Label1)
        Me.animated.SetDecoration(Me.GunaLinePanel3, BunifuAnimatorNS.DecorationType.None)
        Me.GunaLinePanel3.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel3.Location = New System.Drawing.Point(0, -1)
        Me.GunaLinePanel3.Name = "GunaLinePanel3"
        Me.GunaLinePanel3.Size = New System.Drawing.Size(667, 378)
        Me.GunaLinePanel3.TabIndex = 159
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Animated = True
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.07!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Crimson
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Crimson
        Me.GunaAdvenceButton1.BorderSize = 1
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedImage = Nothing
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animated.SetDecoration(Me.GunaAdvenceButton1, BunifuAnimatorNS.DecorationType.None)
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(536, 318)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.IndianRed
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.IndianRed
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = CType(resources.GetObject("GunaAdvenceButton1.OnHoverImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnPressedDepth = 0
        Me.GunaAdvenceButton1.Radius = 2
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(105, 36)
        Me.GunaAdvenceButton1.TabIndex = 156
        Me.GunaAdvenceButton1.Text = "Başlat"
        Me.GunaAdvenceButton1.TextOffsetX = 5
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.07!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BorderSize = 1
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaAdvenceButton2.CheckedImage = Nothing
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animated.SetDecoration(Me.GunaAdvenceButton2, BunifuAnimatorNS.DecorationType.None)
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = CType(resources.GetObject("GunaAdvenceButton2.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(153, 253)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverImage = CType(resources.GetObject("GunaAdvenceButton2.OnHoverImage"), System.Drawing.Image)
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnPressedDepth = 0
        Me.GunaAdvenceButton2.Radius = 1
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(24, 20)
        Me.GunaAdvenceButton2.TabIndex = 157
        Me.GunaAdvenceButton2.Visible = False
        '
        'GunaAdvenceButton11
        '
        Me.GunaAdvenceButton11.Animated = True
        Me.GunaAdvenceButton11.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton11.AnimationSpeed = 0.07!
        Me.GunaAdvenceButton11.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton11.BaseColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton11.BorderSize = 1
        Me.GunaAdvenceButton11.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GunaAdvenceButton11.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton11.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaAdvenceButton11.CheckedImage = Nothing
        Me.GunaAdvenceButton11.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animated.SetDecoration(Me.GunaAdvenceButton11, BunifuAnimatorNS.DecorationType.None)
        Me.GunaAdvenceButton11.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton11.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton11.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GunaAdvenceButton11.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton11.Image = Nothing
        Me.GunaAdvenceButton11.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton11.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaAdvenceButton11.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.GunaAdvenceButton11.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GunaAdvenceButton11.Location = New System.Drawing.Point(431, 318)
        Me.GunaAdvenceButton11.Name = "GunaAdvenceButton11"
        Me.GunaAdvenceButton11.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton11.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton11.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton11.OnHoverImage = Nothing
        Me.GunaAdvenceButton11.OnHoverLineColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton11.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton11.OnPressedDepth = 0
        Me.GunaAdvenceButton11.Radius = 2
        Me.GunaAdvenceButton11.Size = New System.Drawing.Size(99, 36)
        Me.GunaAdvenceButton11.TabIndex = 155
        Me.GunaAdvenceButton11.Text = "KAPAT"
        Me.GunaAdvenceButton11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.animated.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(298, 35)
        Me.Label3.TabIndex = 162
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'boyutLabel
        '
        Me.boyutLabel.BackColor = System.Drawing.Color.Transparent
        Me.animated.SetDecoration(Me.boyutLabel, BunifuAnimatorNS.DecorationType.None)
        Me.boyutLabel.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.boyutLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.boyutLabel.Location = New System.Drawing.Point(20, 17)
        Me.boyutLabel.Name = "boyutLabel"
        Me.boyutLabel.Size = New System.Drawing.Size(298, 39)
        Me.boyutLabel.TabIndex = 73
        Me.boyutLabel.Text = "Yönetici Onayı"
        Me.boyutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.animated.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(20, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(627, 45)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Mevcut hata kodlarını uygulama menüsünden aratmanız yeterli olacaktır, sorunların" &
    "ıza çözüm bulacaktır."
        Me.Label2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.animated.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(298, 20)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Uygulama başlatılırken hata ile karşılaştı,"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.animated.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 100)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "- İnternet bağlantınızdan kaynaklı sorun olabilir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Yönetici izni verilmediğin" &
    "den kaynaklı olabilir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Güncelleme sorunu olabilir"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'kontrol
        '
        Me.kontrol.TargetControl = Me.Panel3
        '
        'animated
        '
        Me.animated.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        Me.animated.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.animated.DefaultAnimation = Animation1
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BackgroundImage = CType(resources.GetObject("GunaElipsePanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaElipsePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLinePanel3)
        Me.animated.SetDecoration(Me.GunaElipsePanel1, BunifuAnimatorNS.DecorationType.None)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(3, 0)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(667, 376)
        Me.GunaElipsePanel1.TabIndex = 4
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GunaLinePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GunaLinePanel1.Controls.Add(Me.Panel4)
        Me.GunaLinePanel1.Controls.Add(Me.GunaElipsePanel1)
        Me.animated.SetDecoration(Me.GunaLinePanel1, BunifuAnimatorNS.DecorationType.None)
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(-3, 28)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(670, 376)
        Me.GunaLinePanel1.TabIndex = 14
        '
        'adminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackLocation = MetroFramework.Forms.BackLocation.BottomLeft
        Me.ClientSize = New System.Drawing.Size(665, 404)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.Panel3)
        Me.animated.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "adminForm"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Text = "Yönetici Onayı"
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GunaLinePanel3.ResumeLayout(False)
        Me.GunaLinePanel3.PerformLayout()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents updateProgress As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton11 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents boyutLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents animated As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Timer1 As Timer
    Friend WithEvents kontrol As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents GunaLinePanel3 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
