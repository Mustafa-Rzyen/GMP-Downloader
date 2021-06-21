<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2GradientCircleButton1 = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.bildirimUyarıBtn = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.btnEdit = New Guna.UI.WinForms.GunaLinkLabel()
        Me.userImage = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pcID = New Guna.UI.WinForms.GunaLabel()
        Me.btnİndirmeleriYönet = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGüncellemePaketleri = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAyarlar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGame = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMenü = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAnaMenü = New Guna.UI2.WinForms.Guna2Button()
        Me.gamePanel = New System.Windows.Forms.Panel()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.procressDurumLabel = New Guna.UI.WinForms.GunaLabel()
        Me.procressIDLabel = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.updateLabel = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.controlPanel = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.downloadProgressTime = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GunaVScrollBar1 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnDownloadSteam = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel6 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnNews3 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnDownloadOverspeed = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Tool = New MetroFramework.Components.MetroToolTip()
        Me.fileTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.animasyonTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ShowAnimasyon = New Guna.UI2.WinForms.Guna2Transition()
        Me.HideAnimasyon = New Guna.UI2.WinForms.Guna2Transition()
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.ProcressStart = New System.Windows.Forms.Timer(Me.components)
        Me.ProcressStop = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuDragControl3 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl4 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.EthernetTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenüLoad2 = New GMP_Downloader.menüLoad()
        Me.Haberler1 = New GMP_Downloader.Haberler()
        Me.AyarlarMenü2 = New GMP_Downloader.ayarlarMenü()
        Me.UpdateNotes1 = New GMP_Downloader.updateNotes()
        Me.GameMenü1 = New GMP_Downloader.gameMenü()
        Me.BekleyenGüncellemeler1 = New GMP_Downloader.bekleyenGüncellemeler()
        Me.IndirmeleriYönet1 = New GMP_Downloader.indirmeleriYönet()
        Me.ProfilDetay1 = New GMP_Downloader.profilDetay()
        Me.Panel1.SuspendLayout()
        Me.gamePanel.SuspendLayout()
        Me.controlPanel.SuspendLayout()
        CType(Me.downloadProgressTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel6.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2GradientCircleButton1)
        Me.Panel1.Controls.Add(Me.bildirimUyarıBtn)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.userImage)
        Me.Panel1.Controls.Add(Me.pcID)
        Me.Panel1.Controls.Add(Me.btnİndirmeleriYönet)
        Me.Panel1.Controls.Add(Me.btnGüncellemePaketleri)
        Me.Panel1.Controls.Add(Me.btnAyarlar)
        Me.Panel1.Controls.Add(Me.btnGame)
        Me.Panel1.Controls.Add(Me.btnMenü)
        Me.Panel1.Controls.Add(Me.btnAnaMenü)
        Me.HideAnimasyon.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(0, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 77)
        Me.Panel1.TabIndex = 0
        '
        'Guna2GradientCircleButton1
        '
        Me.Guna2GradientCircleButton1.Animated = True
        Me.Guna2GradientCircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientCircleButton1.BorderColor = System.Drawing.Color.SpringGreen
        Me.Guna2GradientCircleButton1.CheckedState.Parent = Me.Guna2GradientCircleButton1
        Me.Guna2GradientCircleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientCircleButton1.CustomImages.Parent = Me.Guna2GradientCircleButton1
        Me.HideAnimasyon.SetDecoration(Me.Guna2GradientCircleButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Guna2GradientCircleButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientCircleButton1.FillColor = System.Drawing.Color.SpringGreen
        Me.Guna2GradientCircleButton1.FillColor2 = System.Drawing.Color.SpringGreen
        Me.Guna2GradientCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientCircleButton1.HoverState.FillColor = System.Drawing.Color.SpringGreen
        Me.Guna2GradientCircleButton1.HoverState.FillColor2 = System.Drawing.Color.SpringGreen
        Me.Guna2GradientCircleButton1.HoverState.Parent = Me.Guna2GradientCircleButton1
        Me.Guna2GradientCircleButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientCircleButton1.ImageOffset = New System.Drawing.Point(8, 8)
        Me.Guna2GradientCircleButton1.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2GradientCircleButton1.Location = New System.Drawing.Point(1063, 18)
        Me.Guna2GradientCircleButton1.Name = "Guna2GradientCircleButton1"
        Me.Guna2GradientCircleButton1.PressedColor = System.Drawing.Color.SpringGreen
        Me.Guna2GradientCircleButton1.PressedDepth = 1
        Me.Guna2GradientCircleButton1.ShadowDecoration.BorderRadius = 0
        Me.Guna2GradientCircleButton1.ShadowDecoration.Color = System.Drawing.Color.SpringGreen
        Me.Guna2GradientCircleButton1.ShadowDecoration.Enabled = True
        Me.Guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2GradientCircleButton1.ShadowDecoration.Parent = Me.Guna2GradientCircleButton1
        Me.Guna2GradientCircleButton1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.Guna2GradientCircleButton1.Size = New System.Drawing.Size(8, 8)
        Me.Guna2GradientCircleButton1.TabIndex = 166
        '
        'bildirimUyarıBtn
        '
        Me.bildirimUyarıBtn.Animated = True
        Me.bildirimUyarıBtn.BackColor = System.Drawing.Color.Transparent
        Me.bildirimUyarıBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bildirimUyarıBtn.CheckedState.Parent = Me.bildirimUyarıBtn
        Me.bildirimUyarıBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bildirimUyarıBtn.CustomImages.Parent = Me.bildirimUyarıBtn
        Me.HideAnimasyon.SetDecoration(Me.bildirimUyarıBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.bildirimUyarıBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.bildirimUyarıBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bildirimUyarıBtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bildirimUyarıBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bildirimUyarıBtn.ForeColor = System.Drawing.Color.White
        Me.bildirimUyarıBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bildirimUyarıBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bildirimUyarıBtn.HoverState.Parent = Me.bildirimUyarıBtn
        Me.bildirimUyarıBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bildirimUyarıBtn.ImageOffset = New System.Drawing.Point(8, 8)
        Me.bildirimUyarıBtn.ImageSize = New System.Drawing.Size(50, 50)
        Me.bildirimUyarıBtn.Location = New System.Drawing.Point(336, 20)
        Me.bildirimUyarıBtn.Name = "bildirimUyarıBtn"
        Me.bildirimUyarıBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bildirimUyarıBtn.PressedDepth = 0
        Me.bildirimUyarıBtn.ShadowDecoration.BorderRadius = 0
        Me.bildirimUyarıBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.bildirimUyarıBtn.ShadowDecoration.Depth = 4
        Me.bildirimUyarıBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.bildirimUyarıBtn.ShadowDecoration.Parent = Me.bildirimUyarıBtn
        Me.bildirimUyarıBtn.Size = New System.Drawing.Size(8, 8)
        Me.bildirimUyarıBtn.TabIndex = 165
        Me.bildirimUyarıBtn.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.ActiveLinkColor = System.Drawing.Color.White
        Me.btnEdit.AutoSize = True
        Me.HideAnimasyon.SetDecoration(Me.btnEdit, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnEdit, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnEdit.LinkColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(1077, 43)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(88, 17)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.TabStop = True
        Me.btnEdit.Text = "Profil Düzenle"
        Me.btnEdit.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'userImage
        '
        Me.userImage.Animated = True
        Me.userImage.BackColor = System.Drawing.Color.Transparent
        Me.userImage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userImage.BorderRadius = 2
        Me.userImage.BorderThickness = 2
        Me.userImage.CheckedState.Parent = Me.userImage
        Me.userImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.userImage.CustomImages.Parent = Me.userImage
        Me.ShowAnimasyon.SetDecoration(Me.userImage, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.userImage, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.userImage.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.userImage.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.userImage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.userImage.ForeColor = System.Drawing.Color.White
        Me.userImage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userImage.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.userImage.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.userImage.HoverState.Image = CType(resources.GetObject("userImage.HoverState.Image"), System.Drawing.Image)
        Me.userImage.HoverState.Parent = Me.userImage
        Me.userImage.Image = CType(resources.GetObject("userImage.Image"), System.Drawing.Image)
        Me.userImage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.userImage.ImageOffset = New System.Drawing.Point(-8, 0)
        Me.userImage.ImageSize = New System.Drawing.Size(35, 35)
        Me.userImage.Location = New System.Drawing.Point(1029, 21)
        Me.userImage.Name = "userImage"
        Me.userImage.PressedDepth = 0
        Me.userImage.ShadowDecoration.BorderRadius = 2
        Me.userImage.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userImage.ShadowDecoration.Depth = 5
        Me.userImage.ShadowDecoration.Parent = Me.userImage
        Me.userImage.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.userImage.Size = New System.Drawing.Size(40, 40)
        Me.userImage.TabIndex = 7
        Me.userImage.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'pcID
        '
        Me.HideAnimasyon.SetDecoration(Me.pcID, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.pcID, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pcID.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.pcID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.pcID.Location = New System.Drawing.Point(1075, 20)
        Me.pcID.Name = "pcID"
        Me.pcID.Size = New System.Drawing.Size(112, 23)
        Me.pcID.TabIndex = 4
        Me.pcID.Text = "Kullanıcı"
        Me.pcID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnİndirmeleriYönet
        '
        Me.btnİndirmeleriYönet.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnİndirmeleriYönet.CheckedState.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnİndirmeleriYönet.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnİndirmeleriYönet.CheckedState.Parent = Me.btnİndirmeleriYönet
        Me.btnİndirmeleriYönet.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnİndirmeleriYönet.CustomImages.Parent = Me.btnİndirmeleriYönet
        Me.HideAnimasyon.SetDecoration(Me.btnİndirmeleriYönet, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnİndirmeleriYönet, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnİndirmeleriYönet.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnİndirmeleriYönet.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnİndirmeleriYönet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnİndirmeleriYönet.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnİndirmeleriYönet.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnİndirmeleriYönet.HoverState.Parent = Me.btnİndirmeleriYönet
        Me.btnİndirmeleriYönet.Location = New System.Drawing.Point(420, 27)
        Me.btnİndirmeleriYönet.Name = "btnİndirmeleriYönet"
        Me.btnİndirmeleriYönet.PressedDepth = 0
        Me.btnİndirmeleriYönet.ShadowDecoration.Parent = Me.btnİndirmeleriYönet
        Me.btnİndirmeleriYönet.Size = New System.Drawing.Size(91, 24)
        Me.btnİndirmeleriYönet.TabIndex = 17
        Me.btnİndirmeleriYönet.Text = "İndirmeler"
        Me.btnİndirmeleriYönet.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'btnGüncellemePaketleri
        '
        Me.btnGüncellemePaketleri.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnGüncellemePaketleri.CheckedState.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGüncellemePaketleri.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnGüncellemePaketleri.CheckedState.Parent = Me.btnGüncellemePaketleri
        Me.btnGüncellemePaketleri.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnGüncellemePaketleri.CustomImages.Parent = Me.btnGüncellemePaketleri
        Me.HideAnimasyon.SetDecoration(Me.btnGüncellemePaketleri, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnGüncellemePaketleri, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnGüncellemePaketleri.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnGüncellemePaketleri.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGüncellemePaketleri.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnGüncellemePaketleri.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnGüncellemePaketleri.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGüncellemePaketleri.HoverState.Parent = Me.btnGüncellemePaketleri
        Me.btnGüncellemePaketleri.Location = New System.Drawing.Point(337, 27)
        Me.btnGüncellemePaketleri.Name = "btnGüncellemePaketleri"
        Me.btnGüncellemePaketleri.PressedDepth = 0
        Me.btnGüncellemePaketleri.ShadowDecoration.Parent = Me.btnGüncellemePaketleri
        Me.btnGüncellemePaketleri.Size = New System.Drawing.Size(80, 24)
        Me.btnGüncellemePaketleri.TabIndex = 13
        Me.btnGüncellemePaketleri.Text = "Yamalar"
        Me.btnGüncellemePaketleri.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'btnAyarlar
        '
        Me.btnAyarlar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnAyarlar.CheckedState.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAyarlar.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnAyarlar.CheckedState.Parent = Me.btnAyarlar
        Me.btnAyarlar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnAyarlar.CustomImages.Parent = Me.btnAyarlar
        Me.HideAnimasyon.SetDecoration(Me.btnAyarlar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnAyarlar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnAyarlar.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAyarlar.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAyarlar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnAyarlar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAyarlar.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAyarlar.HoverState.Parent = Me.btnAyarlar
        Me.btnAyarlar.Location = New System.Drawing.Point(252, 27)
        Me.btnAyarlar.Name = "btnAyarlar"
        Me.btnAyarlar.PressedDepth = 0
        Me.btnAyarlar.ShadowDecoration.Parent = Me.btnAyarlar
        Me.btnAyarlar.Size = New System.Drawing.Size(82, 24)
        Me.btnAyarlar.TabIndex = 11
        Me.btnAyarlar.Text = "Ayarlar"
        Me.btnAyarlar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'btnGame
        '
        Me.btnGame.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnGame.CheckedState.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGame.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnGame.CheckedState.Parent = Me.btnGame
        Me.btnGame.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnGame.CustomImages.Parent = Me.btnGame
        Me.HideAnimasyon.SetDecoration(Me.btnGame, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnGame, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnGame.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnGame.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnGame.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnGame.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGame.HoverState.Parent = Me.btnGame
        Me.btnGame.Location = New System.Drawing.Point(180, 27)
        Me.btnGame.Name = "btnGame"
        Me.btnGame.PressedDepth = 0
        Me.btnGame.ShadowDecoration.Parent = Me.btnGame
        Me.btnGame.Size = New System.Drawing.Size(69, 24)
        Me.btnGame.TabIndex = 10
        Me.btnGame.Text = "Oyunlar"
        Me.btnGame.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'btnMenü
        '
        Me.btnMenü.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnMenü.CheckedState.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenü.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnMenü.CheckedState.Parent = Me.btnMenü
        Me.btnMenü.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnMenü.CustomImages.Parent = Me.btnMenü
        Me.HideAnimasyon.SetDecoration(Me.btnMenü, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnMenü, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnMenü.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnMenü.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenü.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnMenü.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnMenü.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMenü.HoverState.Parent = Me.btnMenü
        Me.btnMenü.Location = New System.Drawing.Point(119, 27)
        Me.btnMenü.Name = "btnMenü"
        Me.btnMenü.PressedDepth = 0
        Me.btnMenü.ShadowDecoration.Parent = Me.btnMenü
        Me.btnMenü.Size = New System.Drawing.Size(58, 24)
        Me.btnMenü.TabIndex = 9
        Me.btnMenü.Text = "Menü"
        Me.btnMenü.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'btnAnaMenü
        '
        Me.btnAnaMenü.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnAnaMenü.Checked = True
        Me.btnAnaMenü.CheckedState.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnaMenü.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnAnaMenü.CheckedState.Parent = Me.btnAnaMenü
        Me.btnAnaMenü.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnAnaMenü.CustomImages.Parent = Me.btnAnaMenü
        Me.HideAnimasyon.SetDecoration(Me.btnAnaMenü, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnAnaMenü, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnAnaMenü.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAnaMenü.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnaMenü.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnAnaMenü.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAnaMenü.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnaMenü.HoverState.Parent = Me.btnAnaMenü
        Me.btnAnaMenü.Location = New System.Drawing.Point(27, 27)
        Me.btnAnaMenü.Name = "btnAnaMenü"
        Me.btnAnaMenü.PressedDepth = 0
        Me.btnAnaMenü.ShadowDecoration.Color = System.Drawing.Color.White
        Me.btnAnaMenü.ShadowDecoration.Depth = 15
        Me.btnAnaMenü.ShadowDecoration.Parent = Me.btnAnaMenü
        Me.btnAnaMenü.Size = New System.Drawing.Size(89, 24)
        Me.btnAnaMenü.TabIndex = 8
        Me.btnAnaMenü.Text = "Ana menü"
        Me.btnAnaMenü.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'gamePanel
        '
        Me.gamePanel.Controls.Add(Me.Guna2Separator2)
        Me.gamePanel.Controls.Add(Me.procressDurumLabel)
        Me.gamePanel.Controls.Add(Me.procressIDLabel)
        Me.gamePanel.Controls.Add(Me.Guna2GradientButton2)
        Me.HideAnimasyon.SetDecoration(Me.gamePanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.gamePanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.gamePanel.Location = New System.Drawing.Point(500, 445)
        Me.gamePanel.Name = "gamePanel"
        Me.gamePanel.Size = New System.Drawing.Size(223, 109)
        Me.gamePanel.TabIndex = 6
        Me.gamePanel.Visible = False
        '
        'Guna2Separator2
        '
        Me.HideAnimasyon.SetDecoration(Me.Guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Separator2.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2Separator2.Location = New System.Drawing.Point(0, -5)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(223, 10)
        Me.Guna2Separator2.TabIndex = 18
        '
        'procressDurumLabel
        '
        Me.procressDurumLabel.AutoSize = True
        Me.HideAnimasyon.SetDecoration(Me.procressDurumLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.procressDurumLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.procressDurumLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.procressDurumLabel.ForeColor = System.Drawing.Color.SpringGreen
        Me.procressDurumLabel.Location = New System.Drawing.Point(86, 62)
        Me.procressDurumLabel.Name = "procressDurumLabel"
        Me.procressDurumLabel.Size = New System.Drawing.Size(65, 20)
        Me.procressDurumLabel.TabIndex = 7
        Me.procressDurumLabel.Text = "Çalışıyor"
        '
        'procressIDLabel
        '
        Me.HideAnimasyon.SetDecoration(Me.procressIDLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.procressIDLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.procressIDLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.procressIDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.procressIDLabel.Location = New System.Drawing.Point(85, 23)
        Me.procressIDLabel.Name = "procressIDLabel"
        Me.procressIDLabel.Size = New System.Drawing.Size(125, 35)
        Me.procressIDLabel.TabIndex = 6
        Me.procressIDLabel.Text = "Downloader"
        Me.procressIDLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.Animated = True
        Me.Guna2GradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton2.BorderRadius = 3
        Me.Guna2GradientButton2.CheckedState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientButton2.CustomImages.Parent = Me.Guna2GradientButton2
        Me.ShowAnimasyon.SetDecoration(Me.Guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.Guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2GradientButton2.HoverState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.ImageSize = New System.Drawing.Size(90, 90)
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(10, 10)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.PressedDepth = 0
        Me.Guna2GradientButton2.ShadowDecoration.BorderRadius = 3
        Me.Guna2GradientButton2.ShadowDecoration.Depth = 50
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(75, 90)
        Me.Guna2GradientButton2.TabIndex = 18
        '
        'updateLabel
        '
        Me.updateLabel.AutoSize = True
        Me.HideAnimasyon.SetDecoration(Me.updateLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.updateLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.updateLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.updateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.updateLabel.Location = New System.Drawing.Point(157, 6)
        Me.updateLabel.Name = "updateLabel"
        Me.updateLabel.Size = New System.Drawing.Size(140, 19)
        Me.updateLabel.TabIndex = 4
        Me.updateLabel.Text = "Update Version Label"
        Me.updateLabel.Visible = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel2.Font = New System.Drawing.Font("Ubisoft Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(48, 6)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(94, 19)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Downloader"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Ubisoft Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(6, 6)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(44, 19)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "GMP"
        '
        'controlPanel
        '
        Me.controlPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.controlPanel.Controls.Add(Me.Guna2ControlBox2)
        Me.controlPanel.Controls.Add(Me.Guna2ControlBox1)
        Me.controlPanel.Controls.Add(Me.GunaLabel1)
        Me.controlPanel.Controls.Add(Me.GunaLabel2)
        Me.controlPanel.Controls.Add(Me.updateLabel)
        Me.controlPanel.Controls.Add(Me.downloadProgressTime)
        Me.HideAnimasyon.SetDecoration(Me.controlPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.controlPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.controlPanel.Location = New System.Drawing.Point(0, -2)
        Me.controlPanel.Name = "controlPanel"
        Me.controlPanel.Size = New System.Drawing.Size(1203, 30)
        Me.controlPanel.TabIndex = 0
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.HideAnimasyon.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DarkGray
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1118, -2)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.PressedColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Guna2ControlBox2.PressedDepth = 0
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(42, 37)
        Me.Guna2ControlBox2.TabIndex = 9
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HideAnimasyon.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DarkGray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1160, -2)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Guna2ControlBox1.PressedDepth = 0
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(42, 37)
        Me.Guna2ControlBox1.TabIndex = 8
        '
        'downloadProgressTime
        '
        Me.downloadProgressTime.AllowDrop = True
        Me.HideAnimasyon.SetDecoration(Me.downloadProgressTime, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.downloadProgressTime, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.downloadProgressTime.Location = New System.Drawing.Point(347, 12)
        Me.downloadProgressTime.Name = "downloadProgressTime"
        Me.downloadProgressTime.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.[True]
        Me.downloadProgressTime.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.downloadProgressTime.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.downloadProgressTime.Properties.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.downloadProgressTime.Properties.FlowAnimationDelay = 0
        Me.downloadProgressTime.Properties.FlowAnimationDuration = 0
        Me.downloadProgressTime.Properties.FlowAnimationEnabled = True
        Me.downloadProgressTime.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.downloadProgressTime.Properties.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.downloadProgressTime.ShowProgressInTaskBar = True
        Me.downloadProgressTime.Size = New System.Drawing.Size(102, 5)
        Me.downloadProgressTime.TabIndex = 13
        Me.downloadProgressTime.Visible = False
        '
        'GunaVScrollBar1
        '
        Me.GunaVScrollBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.HideAnimasyon.SetDecoration(Me.GunaVScrollBar1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaVScrollBar1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaVScrollBar1.LargeChange = 10
        Me.GunaVScrollBar1.Location = New System.Drawing.Point(1193, 105)
        Me.GunaVScrollBar1.Maximum = 100
        Me.GunaVScrollBar1.Name = "GunaVScrollBar1"
        Me.GunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GunaVScrollBar1.Size = New System.Drawing.Size(10, 662)
        Me.GunaVScrollBar1.TabIndex = 4
        Me.GunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.GunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.GunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(98, Byte), Integer))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.GunaVScrollBar1)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Haberler1)
        Me.Panel2.Controls.Add(Me.AyarlarMenü2)
        Me.Panel2.Controls.Add(Me.UpdateNotes1)
        Me.Panel2.Controls.Add(Me.GameMenü1)
        Me.Panel2.Controls.Add(Me.BekleyenGüncellemeler1)
        Me.Panel2.Controls.Add(Me.IndirmeleriYönet1)
        Me.Panel2.Controls.Add(Me.ProfilDetay1)
        Me.HideAnimasyon.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1205, 767)
        Me.Panel2.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel4.Controls.Add(Me.GunaElipsePanel1)
        Me.Panel4.Controls.Add(Me.GunaElipsePanel6)
        Me.Panel4.Controls.Add(Me.gamePanel)
        Me.HideAnimasyon.SetDecoration(Me.Panel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Panel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(3, 103)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1200, 665)
        Me.Panel4.TabIndex = 1
        Me.Panel4.Visible = False
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.BunifuImageButton3)
        Me.GunaElipsePanel1.Controls.Add(Me.Guna2ImageButton1)
        Me.GunaElipsePanel1.Controls.Add(Me.btnDownloadSteam)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel4)
        Me.ShowAnimasyon.SetDecoration(Me.GunaElipsePanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.GunaElipsePanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(405, 22)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 10
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(339, 300)
        Me.GunaElipsePanel1.TabIndex = 8
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.BunifuImageButton3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.BunifuImageButton3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(22, 264)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 8
        Me.BunifuImageButton3.TabStop = False
        Me.Tool.SetToolTip(Me.BunifuImageButton3, "Kullanım için hazır değil")
        Me.BunifuImageButton3.Zoom = 6
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.AllowDrop = True
        Me.Guna2ImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.Guna2ImageButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Guna2ImageButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ImageButton1.HoverState.Image = CType(resources.GetObject("Guna2ImageButton1.HoverState.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(345, 202)
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(341, 198)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.Image = CType(resources.GetObject("Guna2ImageButton1.PressedState.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(345, 202)
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(341, 198)
        Me.Guna2ImageButton1.TabIndex = 0
        '
        'btnDownloadSteam
        '
        Me.btnDownloadSteam.Animated = True
        Me.btnDownloadSteam.BackColor = System.Drawing.Color.Transparent
        Me.btnDownloadSteam.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnDownloadSteam.BorderRadius = 2
        Me.btnDownloadSteam.BorderThickness = 2
        Me.btnDownloadSteam.CheckedState.Parent = Me.btnDownloadSteam
        Me.btnDownloadSteam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownloadSteam.CustomImages.Parent = Me.btnDownloadSteam
        Me.ShowAnimasyon.SetDecoration(Me.btnDownloadSteam, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.btnDownloadSteam, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnDownloadSteam.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnDownloadSteam.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnDownloadSteam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDownloadSteam.ForeColor = System.Drawing.Color.White
        Me.btnDownloadSteam.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownloadSteam.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownloadSteam.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownloadSteam.HoverState.Image = Global.GMP_Downloader.My.Resources.Resources.downloadWhite
        Me.btnDownloadSteam.HoverState.Parent = Me.btnDownloadSteam
        Me.btnDownloadSteam.Image = Global.GMP_Downloader.My.Resources.Resources.downloadGreen
        Me.btnDownloadSteam.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDownloadSteam.Location = New System.Drawing.Point(272, 211)
        Me.btnDownloadSteam.Name = "btnDownloadSteam"
        Me.btnDownloadSteam.PressedDepth = 0
        Me.btnDownloadSteam.ShadowDecoration.BorderRadius = 2
        Me.btnDownloadSteam.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDownloadSteam.ShadowDecoration.Depth = 10
        Me.btnDownloadSteam.ShadowDecoration.Enabled = True
        Me.btnDownloadSteam.ShadowDecoration.Parent = Me.btnDownloadSteam
        Me.btnDownloadSteam.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btnDownloadSteam.Size = New System.Drawing.Size(50, 45)
        Me.btnDownloadSteam.TabIndex = 0
        Me.btnDownloadSteam.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'GunaLabel4
        '
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(15, 211)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(239, 50)
        Me.GunaLabel4.TabIndex = 18
        Me.GunaLabel4.Text = "STEAM KÜTÜĞHANE DESTEĞİ"
        '
        'GunaElipsePanel6
        '
        Me.GunaElipsePanel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaElipsePanel6.Controls.Add(Me.BunifuImageButton1)
        Me.GunaElipsePanel6.Controls.Add(Me.btnNews3)
        Me.GunaElipsePanel6.Controls.Add(Me.btnDownloadOverspeed)
        Me.GunaElipsePanel6.Controls.Add(Me.GunaLabel12)
        Me.ShowAnimasyon.SetDecoration(Me.GunaElipsePanel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.GunaElipsePanel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaElipsePanel6.Location = New System.Drawing.Point(14, 22)
        Me.GunaElipsePanel6.Name = "GunaElipsePanel6"
        Me.GunaElipsePanel6.Radius = 10
        Me.GunaElipsePanel6.Size = New System.Drawing.Size(339, 300)
        Me.GunaElipsePanel6.TabIndex = 7
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.BunifuImageButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.BunifuImageButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(22, 264)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 8
        Me.BunifuImageButton1.TabStop = False
        Me.Tool.SetToolTip(Me.BunifuImageButton1, "Kullanım için hazır değil")
        Me.BunifuImageButton1.Zoom = 6
        '
        'btnNews3
        '
        Me.btnNews3.AllowDrop = True
        Me.btnNews3.BackColor = System.Drawing.Color.Transparent
        Me.btnNews3.CheckedState.Parent = Me.btnNews3
        Me.btnNews3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.btnNews3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnNews3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnNews3.HoverState.Image = CType(resources.GetObject("btnNews3.HoverState.Image"), System.Drawing.Image)
        Me.btnNews3.HoverState.ImageSize = New System.Drawing.Size(345, 202)
        Me.btnNews3.HoverState.Parent = Me.btnNews3
        Me.btnNews3.Image = CType(resources.GetObject("btnNews3.Image"), System.Drawing.Image)
        Me.btnNews3.ImageSize = New System.Drawing.Size(341, 198)
        Me.btnNews3.Location = New System.Drawing.Point(0, 0)
        Me.btnNews3.Name = "btnNews3"
        Me.btnNews3.PressedState.Image = CType(resources.GetObject("btnNews3.PressedState.Image"), System.Drawing.Image)
        Me.btnNews3.PressedState.ImageSize = New System.Drawing.Size(345, 202)
        Me.btnNews3.PressedState.Parent = Me.btnNews3
        Me.btnNews3.Size = New System.Drawing.Size(341, 198)
        Me.btnNews3.TabIndex = 0
        '
        'btnDownloadOverspeed
        '
        Me.btnDownloadOverspeed.Animated = True
        Me.btnDownloadOverspeed.BackColor = System.Drawing.Color.Transparent
        Me.btnDownloadOverspeed.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnDownloadOverspeed.BorderRadius = 2
        Me.btnDownloadOverspeed.BorderThickness = 2
        Me.btnDownloadOverspeed.CheckedState.Parent = Me.btnDownloadOverspeed
        Me.btnDownloadOverspeed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownloadOverspeed.CustomImages.Parent = Me.btnDownloadOverspeed
        Me.ShowAnimasyon.SetDecoration(Me.btnDownloadOverspeed, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.btnDownloadOverspeed, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnDownloadOverspeed.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnDownloadOverspeed.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnDownloadOverspeed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDownloadOverspeed.ForeColor = System.Drawing.Color.White
        Me.btnDownloadOverspeed.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownloadOverspeed.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownloadOverspeed.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownloadOverspeed.HoverState.Image = Global.GMP_Downloader.My.Resources.Resources.downloadWhite
        Me.btnDownloadOverspeed.HoverState.Parent = Me.btnDownloadOverspeed
        Me.btnDownloadOverspeed.Image = Global.GMP_Downloader.My.Resources.Resources.downloadGreen
        Me.btnDownloadOverspeed.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDownloadOverspeed.Location = New System.Drawing.Point(272, 211)
        Me.btnDownloadOverspeed.Name = "btnDownloadOverspeed"
        Me.btnDownloadOverspeed.PressedDepth = 0
        Me.btnDownloadOverspeed.ShadowDecoration.BorderRadius = 2
        Me.btnDownloadOverspeed.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDownloadOverspeed.ShadowDecoration.Depth = 10
        Me.btnDownloadOverspeed.ShadowDecoration.Enabled = True
        Me.btnDownloadOverspeed.ShadowDecoration.Parent = Me.btnDownloadOverspeed
        Me.btnDownloadOverspeed.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btnDownloadOverspeed.Size = New System.Drawing.Size(50, 45)
        Me.btnDownloadOverspeed.TabIndex = 0
        Me.btnDownloadOverspeed.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'GunaLabel12
        '
        Me.GunaLabel12.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel12, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel12, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel12.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel12.Location = New System.Drawing.Point(15, 211)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(239, 50)
        Me.GunaLabel12.TabIndex = 18
        Me.GunaLabel12.Text = "OVERSPEED GAMES LİBRARY"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.controlPanel
        Me.BunifuDragControl1.Vertical = True
        '
        'Tool
        '
        Me.Tool.StripAmpersands = True
        Me.Tool.Style = MetroFramework.MetroColorStyle.Black
        Me.Tool.StyleManager = Nothing
        Me.Tool.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'fileTimer
        '
        Me.fileTimer.Interval = 4000
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'OpenFileDialog1
        '
        '
        'animasyonTimer
        '
        Me.animasyonTimer.Enabled = True
        Me.animasyonTimer.Interval = 8000
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
        Me.HideAnimasyon.MaxAnimationTime = 1000
        Me.HideAnimasyon.TimeStep = 0.04!
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Nothing
        Me.BunifuDragControl2.Vertical = True
        '
        'ProcressStart
        '
        Me.ProcressStart.Interval = 1000
        '
        'ProcressStop
        '
        Me.ProcressStop.Interval = 1000
        '
        'BunifuDragControl3
        '
        Me.BunifuDragControl3.Fixed = True
        Me.BunifuDragControl3.Horizontal = True
        Me.BunifuDragControl3.TargetControl = Me.GunaLabel1
        Me.BunifuDragControl3.Vertical = True
        '
        'BunifuDragControl4
        '
        Me.BunifuDragControl4.Fixed = True
        Me.BunifuDragControl4.Horizontal = True
        Me.BunifuDragControl4.TargetControl = Me.GunaLabel2
        Me.BunifuDragControl4.Vertical = True
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER
        Me.GunaAnimateWindow1.Interval = 100
        Me.GunaAnimateWindow1.TargetControl = Me
        '
        'EthernetTimer
        '
        Me.EthernetTimer.Enabled = True
        Me.EthernetTimer.Interval = 2000
        '
        'MenüLoad2
        '
        Me.MenüLoad2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ShowAnimasyon.SetDecoration(Me.MenüLoad2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.MenüLoad2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MenüLoad2.Location = New System.Drawing.Point(-1, 0)
        Me.MenüLoad2.Name = "MenüLoad2"
        Me.MenüLoad2.Size = New System.Drawing.Size(1205, 766)
        Me.MenüLoad2.TabIndex = 7
        '
        'Haberler1
        '
        Me.Haberler1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ShowAnimasyon.SetDecoration(Me.Haberler1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.Haberler1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Haberler1.Location = New System.Drawing.Point(0, 103)
        Me.Haberler1.Name = "Haberler1"
        Me.Haberler1.Size = New System.Drawing.Size(1202, 665)
        Me.Haberler1.TabIndex = 7
        '
        'AyarlarMenü2
        '
        Me.AyarlarMenü2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ShowAnimasyon.SetDecoration(Me.AyarlarMenü2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.AyarlarMenü2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.AyarlarMenü2.Location = New System.Drawing.Point(-1, 103)
        Me.AyarlarMenü2.Name = "AyarlarMenü2"
        Me.AyarlarMenü2.Size = New System.Drawing.Size(1202, 665)
        Me.AyarlarMenü2.TabIndex = 166
        Me.AyarlarMenü2.Visible = False
        '
        'UpdateNotes1
        '
        Me.UpdateNotes1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ShowAnimasyon.SetDecoration(Me.UpdateNotes1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.UpdateNotes1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.UpdateNotes1.Location = New System.Drawing.Point(3, 103)
        Me.UpdateNotes1.Name = "UpdateNotes1"
        Me.UpdateNotes1.Size = New System.Drawing.Size(1204, 665)
        Me.UpdateNotes1.TabIndex = 10
        Me.UpdateNotes1.Visible = False
        '
        'GameMenü1
        '
        Me.GameMenü1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ShowAnimasyon.SetDecoration(Me.GameMenü1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.GameMenü1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GameMenü1.Location = New System.Drawing.Point(0, 103)
        Me.GameMenü1.Name = "GameMenü1"
        Me.GameMenü1.Size = New System.Drawing.Size(1202, 665)
        Me.GameMenü1.TabIndex = 7
        Me.GameMenü1.Visible = False
        '
        'BekleyenGüncellemeler1
        '
        Me.BekleyenGüncellemeler1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ShowAnimasyon.SetDecoration(Me.BekleyenGüncellemeler1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.BekleyenGüncellemeler1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BekleyenGüncellemeler1.Location = New System.Drawing.Point(0, 103)
        Me.BekleyenGüncellemeler1.Name = "BekleyenGüncellemeler1"
        Me.BekleyenGüncellemeler1.Size = New System.Drawing.Size(1202, 665)
        Me.BekleyenGüncellemeler1.TabIndex = 10
        Me.BekleyenGüncellemeler1.Visible = False
        '
        'IndirmeleriYönet1
        '
        Me.IndirmeleriYönet1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ShowAnimasyon.SetDecoration(Me.IndirmeleriYönet1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.IndirmeleriYönet1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.IndirmeleriYönet1.Location = New System.Drawing.Point(1, 103)
        Me.IndirmeleriYönet1.Name = "IndirmeleriYönet1"
        Me.IndirmeleriYönet1.Size = New System.Drawing.Size(1202, 665)
        Me.IndirmeleriYönet1.TabIndex = 10
        Me.IndirmeleriYönet1.Visible = False
        '
        'ProfilDetay1
        '
        Me.ProfilDetay1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ShowAnimasyon.SetDecoration(Me.ProfilDetay1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.ProfilDetay1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ProfilDetay1.Location = New System.Drawing.Point(1, 103)
        Me.ProfilDetay1.Name = "ProfilDetay1"
        Me.ProfilDetay1.Size = New System.Drawing.Size(1202, 665)
        Me.ProfilDetay1.TabIndex = 10
        Me.ProfilDetay1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 766)
        Me.Controls.Add(Me.MenüLoad2)
        Me.Controls.Add(Me.controlPanel)
        Me.Controls.Add(Me.Panel2)
        Me.ShowAnimasyon.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Movable = False
        Me.Name = "Form1"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Text = "GMP Downloader"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gamePanel.ResumeLayout(False)
        Me.gamePanel.PerformLayout()
        Me.controlPanel.ResumeLayout(False)
        Me.controlPanel.PerformLayout()
        CType(Me.downloadProgressTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GunaElipsePanel1.ResumeLayout(False)
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel6.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents controlPanel As Panel
    Friend WithEvents GunaVScrollBar1 As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Tool As MetroFramework.Components.MetroToolTip
    Friend WithEvents updateLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents fileTimer As Timer
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnAnaMenü As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAyarlar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGame As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMenü As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGüncellemePaketleri As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents MenüLoad1 As menüLoad
    Friend WithEvents pcID As Guna.UI.WinForms.GunaLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnİndirmeleriYönet As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents AyarlarMenü1 As ayarlarMenü
    Friend WithEvents animasyonTimer As Timer
    Friend WithEvents HideAnimasyon As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents ShowAnimasyon As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnDownloadSteam As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnDownloadOverspeed As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gamePanel As Panel
    Friend WithEvents procressDurumLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents procressIDLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ProcressStart As Timer
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents ProcressStop As Timer
    Friend WithEvents downloadProgressTime As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents MenüLoad2 As menüLoad
    Friend WithEvents GameMenü1 As gameMenü
    Friend WithEvents BekleyenGüncellemeler1 As bekleyenGüncellemeler
    Friend WithEvents IndirmeleriYönet1 As indirmeleriYönet
    Friend WithEvents ProfilDetay1 As profilDetay
    Friend WithEvents UpdateNotes1 As updateNotes
    Friend WithEvents BunifuDragControl3 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl4 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents userImage As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents bildirimUyarıBtn As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents Haberler1 As Haberler
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents GunaElipsePanel6 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnNews3 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents EthernetTimer As Timer
    Friend WithEvents AyarlarMenü2 As ayarlarMenü
    Friend WithEvents Guna2GradientCircleButton1 As Guna.UI2.WinForms.Guna2GradientCircleButton
End Class
