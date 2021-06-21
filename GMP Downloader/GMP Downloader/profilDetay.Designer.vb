<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class profilDetay
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
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profilDetay))
        Me.btnSteam = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGame = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMenü = New Guna.UI2.WinForms.Guna2Button()
        Me.userNameID = New Guna.UI.WinForms.GunaLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.profilEditPanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnImageUpload = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.userImage2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.uyarıLabel = New Guna.UI.WinForms.GunaLabel()
        Me.btnİptal = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.userMailText = New Guna.UI2.WinForms.Guna2TextBox()
        Me.userNameText = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnOnayla = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnEdit = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Tool = New MetroFramework.Components.MetroToolTip()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.userImage = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.GunaVScrollBar1 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ShowAnimasyon = New Guna.UI2.WinForms.Guna2Transition()
        Me.HideAnimasyon = New Guna.UI2.WinForms.Guna2Transition()
        Me.profilEditPanel.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        CType(Me.userImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.userImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSteam
        '
        Me.btnSteam.Animated = True
        Me.btnSteam.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnSteam.CheckedState.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSteam.CheckedState.Parent = Me.btnSteam
        Me.btnSteam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSteam.CustomImages.Parent = Me.btnSteam
        Me.HideAnimasyon.SetDecoration(Me.btnSteam, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnSteam, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnSteam.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSteam.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!)
        Me.btnSteam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnSteam.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSteam.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSteam.HoverState.Parent = Me.btnSteam
        Me.btnSteam.Location = New System.Drawing.Point(991, 165)
        Me.btnSteam.Name = "btnSteam"
        Me.btnSteam.PressedDepth = 0
        Me.btnSteam.ShadowDecoration.Parent = Me.btnSteam
        Me.btnSteam.Size = New System.Drawing.Size(78, 24)
        Me.btnSteam.TabIndex = 10
        Me.btnSteam.Text = "STEAM"
        Me.btnSteam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSteam.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnSteam.Visible = False
        '
        'btnGame
        '
        Me.btnGame.Animated = True
        Me.btnGame.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnGame.CheckedState.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnGame.CheckedState.Parent = Me.btnGame
        Me.btnGame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGame.CustomImages.Parent = Me.btnGame
        Me.HideAnimasyon.SetDecoration(Me.btnGame, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnGame, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnGame.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnGame.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!)
        Me.btnGame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnGame.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnGame.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnGame.HoverState.Parent = Me.btnGame
        Me.btnGame.Location = New System.Drawing.Point(921, 165)
        Me.btnGame.Name = "btnGame"
        Me.btnGame.PressedDepth = 0
        Me.btnGame.ShadowDecoration.Parent = Me.btnGame
        Me.btnGame.Size = New System.Drawing.Size(67, 24)
        Me.btnGame.TabIndex = 9
        Me.btnGame.Text = "GAME"
        Me.btnGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnGame.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnGame.Visible = False
        '
        'btnMenü
        '
        Me.btnMenü.Animated = True
        Me.btnMenü.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnMenü.Checked = True
        Me.btnMenü.CheckedState.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenü.CheckedState.Parent = Me.btnMenü
        Me.btnMenü.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenü.CustomImages.Parent = Me.btnMenü
        Me.HideAnimasyon.SetDecoration(Me.btnMenü, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnMenü, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnMenü.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnMenü.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!)
        Me.btnMenü.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnMenü.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnMenü.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnMenü.HoverState.Parent = Me.btnMenü
        Me.btnMenü.Location = New System.Drawing.Point(812, 165)
        Me.btnMenü.Name = "btnMenü"
        Me.btnMenü.PressedDepth = 0
        Me.btnMenü.ShadowDecoration.Parent = Me.btnMenü
        Me.btnMenü.Size = New System.Drawing.Size(106, 24)
        Me.btnMenü.TabIndex = 8
        Me.btnMenü.Text = "KULLANICI"
        Me.btnMenü.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMenü.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnMenü.Visible = False
        '
        'userNameID
        '
        Me.userNameID.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.userNameID, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.userNameID, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.userNameID.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.userNameID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.userNameID.Location = New System.Drawing.Point(76, 23)
        Me.userNameID.Name = "userNameID"
        Me.userNameID.Size = New System.Drawing.Size(268, 32)
        Me.userNameID.TabIndex = 15
        Me.userNameID.Text = "Kullanıcı"
        Me.userNameID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'profilEditPanel
        '
        Me.profilEditPanel.BackColor = System.Drawing.Color.Transparent
        Me.profilEditPanel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.profilEditPanel.Controls.Add(Me.btnImageUpload)
        Me.profilEditPanel.Controls.Add(Me.btnMenü)
        Me.profilEditPanel.Controls.Add(Me.btnGame)
        Me.profilEditPanel.Controls.Add(Me.btnSteam)
        Me.profilEditPanel.Controls.Add(Me.Guna2Separator1)
        Me.profilEditPanel.Controls.Add(Me.Label1)
        Me.profilEditPanel.Controls.Add(Me.Guna2Separator2)
        Me.profilEditPanel.Controls.Add(Me.Label2)
        Me.profilEditPanel.Controls.Add(Me.GunaElipsePanel2)
        Me.profilEditPanel.Controls.Add(Me.uyarıLabel)
        Me.profilEditPanel.Controls.Add(Me.btnİptal)
        Me.profilEditPanel.Controls.Add(Me.userMailText)
        Me.profilEditPanel.Controls.Add(Me.userNameText)
        Me.profilEditPanel.Controls.Add(Me.GunaLabel2)
        Me.profilEditPanel.Controls.Add(Me.btnOnayla)
        Me.profilEditPanel.Controls.Add(Me.GunaLabel1)
        Me.ShowAnimasyon.SetDecoration(Me.profilEditPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.profilEditPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.profilEditPanel.Location = New System.Drawing.Point(0, -7)
        Me.profilEditPanel.Name = "profilEditPanel"
        Me.profilEditPanel.Size = New System.Drawing.Size(1140, 509)
        Me.profilEditPanel.TabIndex = 160
        Me.profilEditPanel.Visible = False
        '
        'btnImageUpload
        '
        Me.btnImageUpload.Animated = True
        Me.btnImageUpload.AnimationHoverSpeed = 0.07!
        Me.btnImageUpload.AnimationSpeed = 0.07!
        Me.btnImageUpload.BackColor = System.Drawing.Color.Transparent
        Me.btnImageUpload.BaseColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnImageUpload.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnImageUpload.BorderSize = 1
        Me.btnImageUpload.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnImageUpload.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnImageUpload.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnImageUpload.CheckedImage = Nothing
        Me.btnImageUpload.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnImageUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.btnImageUpload, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnImageUpload, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnImageUpload.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnImageUpload.FocusedColor = System.Drawing.Color.Empty
        Me.btnImageUpload.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnImageUpload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnImageUpload.Image = Nothing
        Me.btnImageUpload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnImageUpload.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnImageUpload.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.btnImageUpload.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnImageUpload.Location = New System.Drawing.Point(33, 399)
        Me.btnImageUpload.Name = "btnImageUpload"
        Me.btnImageUpload.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnImageUpload.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnImageUpload.OnHoverForeColor = System.Drawing.Color.White
        Me.btnImageUpload.OnHoverImage = Nothing
        Me.btnImageUpload.OnHoverLineColor = System.Drawing.Color.Empty
        Me.btnImageUpload.OnPressedColor = System.Drawing.Color.Black
        Me.btnImageUpload.OnPressedDepth = 0
        Me.btnImageUpload.Radius = 1
        Me.btnImageUpload.Size = New System.Drawing.Size(130, 29)
        Me.btnImageUpload.TabIndex = 170
        Me.btnImageUpload.Text = "YÜKLE"
        Me.btnImageUpload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2Separator1
        '
        Me.HideAnimasyon.SetDecoration(Me.Guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2Separator1.FillThickness = 2
        Me.Guna2Separator1.Location = New System.Drawing.Point(14, 237)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1112, 10)
        Me.Guna2Separator1.TabIndex = 171
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.ShowAnimasyon.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "Profil Özelleştirme"
        '
        'Guna2Separator2
        '
        Me.HideAnimasyon.SetDecoration(Me.Guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Separator2.FillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2Separator2.FillThickness = 2
        Me.Guna2Separator2.Location = New System.Drawing.Point(14, 44)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(1112, 10)
        Me.Guna2Separator2.TabIndex = 169
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.ShowAnimasyon.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 170
        Me.Label2.Text = "Profil"
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaElipsePanel2.Controls.Add(Me.userImage2)
        Me.ShowAnimasyon.SetDecoration(Me.GunaElipsePanel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.GunaElipsePanel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(33, 260)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(130, 130)
        Me.GunaElipsePanel2.TabIndex = 166
        '
        'userImage2
        '
        Me.userImage2.BackColor = System.Drawing.Color.Transparent
        Me.userImage2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.userImage2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.userImage2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.userImage2.Image = Global.GMP_Downloader.My.Resources.Resources.user
        Me.userImage2.Location = New System.Drawing.Point(24, 26)
        Me.userImage2.Name = "userImage2"
        Me.userImage2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.userImage2.ShadowDecoration.Parent = Me.userImage2
        Me.userImage2.Size = New System.Drawing.Size(80, 80)
        Me.userImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.userImage2.TabIndex = 169
        Me.userImage2.TabStop = False
        Me.userImage2.UseTransparentBackground = True
        '
        'uyarıLabel
        '
        Me.uyarıLabel.AutoSize = True
        Me.uyarıLabel.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.uyarıLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.uyarıLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.uyarıLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.uyarıLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.uyarıLabel.Location = New System.Drawing.Point(29, 65)
        Me.uyarıLabel.Name = "uyarıLabel"
        Me.uyarıLabel.Size = New System.Drawing.Size(594, 20)
        Me.uyarıLabel.TabIndex = 166
        Me.uyarıLabel.Text = "E-Posta adresinizi girmeniz zorunlu değildir, herhangi bir posta bilgisi verilmem" &
    "ektedir."
        '
        'btnİptal
        '
        Me.btnİptal.Animated = True
        Me.btnİptal.AnimationHoverSpeed = 0.07!
        Me.btnİptal.AnimationSpeed = 0.07!
        Me.btnİptal.BackColor = System.Drawing.Color.Transparent
        Me.btnİptal.BaseColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnİptal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnİptal.BorderSize = 1
        Me.btnİptal.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnİptal.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnİptal.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnİptal.CheckedImage = Nothing
        Me.btnİptal.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnİptal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.btnİptal, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnİptal, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnİptal.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnİptal.FocusedColor = System.Drawing.Color.Empty
        Me.btnİptal.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnİptal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnİptal.Image = Nothing
        Me.btnİptal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnİptal.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnİptal.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.btnİptal.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnİptal.Location = New System.Drawing.Point(1018, 447)
        Me.btnİptal.Name = "btnİptal"
        Me.btnİptal.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnİptal.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnİptal.OnHoverForeColor = System.Drawing.Color.White
        Me.btnİptal.OnHoverImage = Nothing
        Me.btnİptal.OnHoverLineColor = System.Drawing.Color.Empty
        Me.btnİptal.OnPressedColor = System.Drawing.Color.Black
        Me.btnİptal.OnPressedDepth = 0
        Me.btnİptal.Radius = 1
        Me.btnİptal.Size = New System.Drawing.Size(87, 29)
        Me.btnİptal.TabIndex = 165
        Me.btnİptal.Text = "İPTAL"
        Me.btnİptal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userMailText
        '
        Me.userMailText.Animated = True
        Me.userMailText.BorderRadius = 1
        Me.userMailText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HideAnimasyon.SetDecoration(Me.userMailText, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.userMailText, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.userMailText.DefaultText = ""
        Me.userMailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.userMailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.userMailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.userMailText.DisabledState.Parent = Me.userMailText
        Me.userMailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.userMailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userMailText.FocusedState.Parent = Me.userMailText
        Me.userMailText.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.userMailText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userMailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userMailText.HoverState.Parent = Me.userMailText
        Me.userMailText.Location = New System.Drawing.Point(137, 154)
        Me.userMailText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.userMailText.Name = "userMailText"
        Me.userMailText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.userMailText.PlaceholderText = ""
        Me.userMailText.SelectedText = ""
        Me.userMailText.ShadowDecoration.Parent = Me.userMailText
        Me.userMailText.Size = New System.Drawing.Size(219, 27)
        Me.userMailText.TabIndex = 168
        '
        'userNameText
        '
        Me.userNameText.AcceptsReturn = True
        Me.userNameText.Animated = True
        Me.userNameText.BorderRadius = 1
        Me.userNameText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HideAnimasyon.SetDecoration(Me.userNameText, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.userNameText, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.userNameText.DefaultText = ""
        Me.userNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.userNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.userNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.userNameText.DisabledState.Parent = Me.userNameText
        Me.userNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.userNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userNameText.FocusedState.Parent = Me.userNameText
        Me.userNameText.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.userNameText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userNameText.HoverState.Parent = Me.userNameText
        Me.userNameText.Location = New System.Drawing.Point(137, 117)
        Me.userNameText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.userNameText.Name = "userNameText"
        Me.userNameText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.userNameText.PlaceholderText = ""
        Me.userNameText.SelectedText = ""
        Me.userNameText.ShadowDecoration.Parent = Me.userNameText
        Me.userNameText.Size = New System.Drawing.Size(219, 27)
        Me.userNameText.TabIndex = 164
        '
        'GunaLabel2
        '
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(65, 156)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(65, 23)
        Me.GunaLabel2.TabIndex = 167
        Me.GunaLabel2.Text = "E-Posta"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
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
        Me.HideAnimasyon.SetDecoration(Me.btnOnayla, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnOnayla, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnOnayla.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOnayla.FocusedColor = System.Drawing.Color.Empty
        Me.btnOnayla.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnOnayla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnOnayla.Image = Nothing
        Me.btnOnayla.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnOnayla.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnOnayla.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.btnOnayla.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnOnayla.Location = New System.Drawing.Point(885, 447)
        Me.btnOnayla.Name = "btnOnayla"
        Me.btnOnayla.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOnayla.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOnayla.OnHoverForeColor = System.Drawing.Color.White
        Me.btnOnayla.OnHoverImage = Nothing
        Me.btnOnayla.OnHoverLineColor = System.Drawing.Color.Empty
        Me.btnOnayla.OnPressedColor = System.Drawing.Color.Black
        Me.btnOnayla.OnPressedDepth = 0
        Me.btnOnayla.Radius = 1
        Me.btnOnayla.Size = New System.Drawing.Size(119, 29)
        Me.btnOnayla.TabIndex = 163
        Me.btnOnayla.Text = "ONAYLA"
        Me.btnOnayla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(29, 118)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(108, 23)
        Me.GunaLabel1.TabIndex = 165
        Me.GunaLabel1.Text = "Kullanıcı Adı"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'btnEdit
        '
        Me.btnEdit.Animated = True
        Me.btnEdit.AnimationHoverSpeed = 0.07!
        Me.btnEdit.AnimationSpeed = 0.07!
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnEdit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnEdit.BorderSize = 1
        Me.btnEdit.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnEdit.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnEdit.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnEdit.CheckedImage = Nothing
        Me.btnEdit.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.btnEdit, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnEdit, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEdit.FocusedColor = System.Drawing.Color.Empty
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnEdit.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnEdit.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.btnEdit.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(1037, 25)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnEdit.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnEdit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEdit.OnHoverImage = Nothing
        Me.btnEdit.OnHoverLineColor = System.Drawing.Color.Empty
        Me.btnEdit.OnPressedColor = System.Drawing.Color.Black
        Me.btnEdit.OnPressedDepth = 0
        Me.btnEdit.Radius = 1
        Me.btnEdit.Size = New System.Drawing.Size(82, 29)
        Me.btnEdit.TabIndex = 164
        Me.btnEdit.Text = "EDİT"
        Me.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnEdit.UseTransfarantBackground = True
        '
        'Tool
        '
        Me.Tool.StripAmpersands = True
        Me.Tool.Style = MetroFramework.MetroColorStyle.Black
        Me.Tool.StyleManager = Nothing
        Me.Tool.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.Guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(1008, 29)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 166
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Tool.SetToolTip(Me.Guna2CirclePictureBox1, "Tek Yıldız")
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.Label3)
        Me.GunaElipsePanel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.GunaElipsePanel1.Controls.Add(Me.btnEdit)
        Me.GunaElipsePanel1.Controls.Add(Me.userNameID)
        Me.GunaElipsePanel1.Controls.Add(Me.userImage)
        Me.ShowAnimasyon.SetDecoration(Me.GunaElipsePanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.GunaElipsePanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(31, 22)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(1140, 79)
        Me.GunaElipsePanel1.TabIndex = 165
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.ShowAnimasyon.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(955, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 174
        Me.Label3.Text = "RANK"
        '
        'userImage
        '
        Me.userImage.BackColor = System.Drawing.Color.Transparent
        Me.userImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.userImage, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.userImage, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.userImage.Image = Global.GMP_Downloader.My.Resources.Resources.user
        Me.userImage.Location = New System.Drawing.Point(16, 12)
        Me.userImage.Name = "userImage"
        Me.userImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.userImage.ShadowDecoration.Parent = Me.userImage
        Me.userImage.Size = New System.Drawing.Size(55, 55)
        Me.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.userImage.TabIndex = 14
        Me.userImage.TabStop = False
        '
        'GunaVScrollBar1
        '
        Me.GunaVScrollBar1.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaVScrollBar1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaVScrollBar1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaVScrollBar1.LargeChange = 10
        Me.GunaVScrollBar1.Location = New System.Drawing.Point(1186, 92)
        Me.GunaVScrollBar1.Maximum = 100
        Me.GunaVScrollBar1.Name = "GunaVScrollBar1"
        Me.GunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GunaVScrollBar1.Size = New System.Drawing.Size(10, 501)
        Me.GunaVScrollBar1.TabIndex = 171
        Me.GunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.GunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaVScrollBar1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.profilEditPanel)
        Me.HideAnimasyon.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(31, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1140, 502)
        Me.Panel2.TabIndex = 174
        '
        'ShowAnimasyon
        '
        Me.ShowAnimasyon.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.ShowAnimasyon.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 1.0!
        Me.ShowAnimasyon.DefaultAnimation = Animation2
        Me.ShowAnimasyon.Interval = 1
        Me.ShowAnimasyon.MaxAnimationTime = 1000
        Me.ShowAnimasyon.TimeStep = 0.04!
        '
        'HideAnimasyon
        '
        Me.HideAnimasyon.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.HideAnimasyon.Cursor = Nothing
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
        Me.HideAnimasyon.DefaultAnimation = Animation1
        Me.HideAnimasyon.Interval = 1
        Me.HideAnimasyon.MaxAnimationTime = 1000
        Me.HideAnimasyon.TimeStep = 0.04!
        '
        'profilDetay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GunaVScrollBar1)
        Me.ShowAnimasyon.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Name = "profilDetay"
        Me.Size = New System.Drawing.Size(1202, 665)
        Me.profilEditPanel.ResumeLayout(False)
        Me.profilEditPanel.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        CType(Me.userImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        CType(Me.userImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSteam As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGame As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMenü As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents userImage As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents userNameID As Guna.UI.WinForms.GunaLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents profilEditPanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents uyarıLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents userMailText As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents userNameText As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnOnayla As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnEdit As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnİptal As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Tool As MetroFramework.Components.MetroToolTip
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnImageUpload As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents userImage2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaVScrollBar1 As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents HideAnimasyon As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents ShowAnimasyon As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Label3 As Label
End Class
