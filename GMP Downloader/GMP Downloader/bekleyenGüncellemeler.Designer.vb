<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bekleyenGüncellemeler
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
        Dim Animation5 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bekleyenGüncellemeler))
        Dim Animation6 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Me.uyarıLabel = New Guna.UI.WinForms.GunaLabel()
        Me.duyuruUpdateLabel = New Guna.UI.WinForms.GunaLabel()
        Me.uyarıBox = New System.Windows.Forms.PictureBox()
        Me.Tool = New MetroFramework.Components.MetroToolTip()
        Me.newVersionLabel = New Guna.UI.WinForms.GunaLabel()
        Me.ShowAnimasyon = New Guna.UI2.WinForms.Guna2Transition()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.btnDownload1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BoyutLabel = New Guna.UI.WinForms.GunaLabel()
        Me.notLink1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.DownloadProgress = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaVSeparator2 = New Guna.UI.WinForms.GunaVSeparator()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.yüzeLabel = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel6 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnUpdateNote = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.yüzeLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnDownload2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BoyutLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.DownloadProgress2 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.HideAnimasyon = New Guna.UI2.WinForms.Guna2Transition()
        Me.fileTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.uyarıBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DownloadProgress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel6.SuspendLayout()
        CType(Me.DownloadProgress2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'uyarıLabel
        '
        Me.uyarıLabel.AutoSize = True
        Me.uyarıLabel.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.uyarıLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.uyarıLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.uyarıLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.uyarıLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.uyarıLabel.Location = New System.Drawing.Point(36, 8)
        Me.uyarıLabel.Name = "uyarıLabel"
        Me.uyarıLabel.Size = New System.Drawing.Size(555, 20)
        Me.uyarıLabel.TabIndex = 8
        Me.uyarıLabel.Text = "Paketlerde bulunan sorunlardan haberdarız. En kısa sürede çözüm oluşturuyoruz."
        Me.uyarıLabel.Visible = False
        '
        'duyuruUpdateLabel
        '
        Me.duyuruUpdateLabel.AutoSize = True
        Me.duyuruUpdateLabel.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.duyuruUpdateLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.duyuruUpdateLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.duyuruUpdateLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.duyuruUpdateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.duyuruUpdateLabel.Location = New System.Drawing.Point(948, 8)
        Me.duyuruUpdateLabel.Name = "duyuruUpdateLabel"
        Me.duyuruUpdateLabel.Size = New System.Drawing.Size(17, 20)
        Me.duyuruUpdateLabel.TabIndex = 9
        Me.duyuruUpdateLabel.Text = "0"
        Me.duyuruUpdateLabel.Visible = False
        '
        'uyarıBox
        '
        Me.ShowAnimasyon.SetDecoration(Me.uyarıBox, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.uyarıBox, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.uyarıBox.Image = CType(resources.GetObject("uyarıBox.Image"), System.Drawing.Image)
        Me.uyarıBox.Location = New System.Drawing.Point(9, 8)
        Me.uyarıBox.Name = "uyarıBox"
        Me.uyarıBox.Size = New System.Drawing.Size(25, 21)
        Me.uyarıBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.uyarıBox.TabIndex = 7
        Me.uyarıBox.TabStop = False
        Me.uyarıBox.Visible = False
        '
        'Tool
        '
        Me.Tool.StripAmpersands = True
        Me.Tool.Style = MetroFramework.MetroColorStyle.Black
        Me.Tool.StyleManager = Nothing
        Me.Tool.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'newVersionLabel
        '
        Me.newVersionLabel.AutoSize = True
        Me.newVersionLabel.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.newVersionLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.newVersionLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.newVersionLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.newVersionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.newVersionLabel.Location = New System.Drawing.Point(925, 8)
        Me.newVersionLabel.Name = "newVersionLabel"
        Me.newVersionLabel.Size = New System.Drawing.Size(17, 20)
        Me.newVersionLabel.TabIndex = 10
        Me.newVersionLabel.Text = "0"
        Me.newVersionLabel.Visible = False
        '
        'ShowAnimasyon
        '
        Me.ShowAnimasyon.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.ShowAnimasyon.Cursor = Nothing
        Animation5.AnimateOnlyDifferences = True
        Animation5.BlindCoeff = CType(resources.GetObject("Animation5.BlindCoeff"), System.Drawing.PointF)
        Animation5.LeafCoeff = 0!
        Animation5.MaxTime = 1.0!
        Animation5.MinTime = 0!
        Animation5.MosaicCoeff = CType(resources.GetObject("Animation5.MosaicCoeff"), System.Drawing.PointF)
        Animation5.MosaicShift = CType(resources.GetObject("Animation5.MosaicShift"), System.Drawing.PointF)
        Animation5.MosaicSize = 0
        Animation5.Padding = New System.Windows.Forms.Padding(0)
        Animation5.RotateCoeff = 0!
        Animation5.RotateLimit = 0!
        Animation5.ScaleCoeff = CType(resources.GetObject("Animation5.ScaleCoeff"), System.Drawing.PointF)
        Animation5.SlideCoeff = CType(resources.GetObject("Animation5.SlideCoeff"), System.Drawing.PointF)
        Animation5.TimeCoeff = 0!
        Animation5.TransparencyCoeff = 1.0!
        Me.ShowAnimasyon.DefaultAnimation = Animation5
        Me.ShowAnimasyon.TimeStep = 0.04!
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(146, 267)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(115, 30)
        Me.GunaLabel3.TabIndex = 18
        Me.GunaLabel3.Text = "GMP Setup"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDownload1
        '
        Me.btnDownload1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDownload1.Animated = True
        Me.btnDownload1.BackColor = System.Drawing.Color.Transparent
        Me.btnDownload1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownload1.BorderRadius = 2
        Me.btnDownload1.BorderThickness = 2
        Me.btnDownload1.CheckedState.Parent = Me.btnDownload1
        Me.btnDownload1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownload1.CustomImages.Parent = Me.btnDownload1
        Me.ShowAnimasyon.SetDecoration(Me.btnDownload1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.btnDownload1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnDownload1.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownload1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownload1.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDownload1.ForeColor = System.Drawing.Color.White
        Me.btnDownload1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownload1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownload1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownload1.HoverState.Parent = Me.btnDownload1
        Me.btnDownload1.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDownload1.Location = New System.Drawing.Point(16, 258)
        Me.btnDownload1.Name = "btnDownload1"
        Me.btnDownload1.PressedDepth = 0
        Me.btnDownload1.ShadowDecoration.BorderRadius = 2
        Me.btnDownload1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDownload1.ShadowDecoration.Depth = 10
        Me.btnDownload1.ShadowDecoration.Enabled = True
        Me.btnDownload1.ShadowDecoration.Parent = Me.btnDownload1
        Me.btnDownload1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btnDownload1.Size = New System.Drawing.Size(110, 45)
        Me.btnDownload1.TabIndex = 0
        Me.btnDownload1.Text = "Download"
        Me.btnDownload1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'BoyutLabel
        '
        Me.BoyutLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BoyutLabel.BackColor = System.Drawing.Color.White
        Me.HideAnimasyon.SetDecoration(Me.BoyutLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.BoyutLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BoyutLabel.Font = New System.Drawing.Font("Gilroy", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BoyutLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BoyutLabel.Location = New System.Drawing.Point(256, 201)
        Me.BoyutLabel.Name = "BoyutLabel"
        Me.BoyutLabel.Size = New System.Drawing.Size(79, 20)
        Me.BoyutLabel.TabIndex = 12
        Me.BoyutLabel.Text = "%0"
        Me.BoyutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BoyutLabel.Visible = False
        '
        'notLink1
        '
        Me.notLink1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.notLink1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.notLink1.AutoSize = True
        Me.notLink1.BackColor = System.Drawing.Color.Transparent
        Me.notLink1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.notLink1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.notLink1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.notLink1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.notLink1.LinkArea = New System.Windows.Forms.LinkArea(0, 18)
        Me.notLink1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.notLink1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.notLink1.Location = New System.Drawing.Point(267, 273)
        Me.notLink1.Name = "notLink1"
        Me.notLink1.Size = New System.Drawing.Size(50, 24)
        Me.notLink1.TabIndex = 6
        Me.notLink1.TabStop = True
        Me.notLink1.Text = "Notes"
        Me.notLink1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        Me.notLink1.UseCompatibleTextRendering = True
        Me.notLink1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(230, Byte), Integer))
        '
        'DownloadProgress
        '
        Me.DownloadProgress.AllowDrop = True
        Me.DownloadProgress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HideAnimasyon.SetDecoration(Me.DownloadProgress, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.DownloadProgress, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DownloadProgress.Location = New System.Drawing.Point(0, 225)
        Me.DownloadProgress.Name = "DownloadProgress"
        Me.DownloadProgress.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.[True]
        Me.DownloadProgress.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DownloadProgress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DownloadProgress.Properties.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DownloadProgress.Properties.FlowAnimationDelay = 0
        Me.DownloadProgress.Properties.FlowAnimationDuration = 0
        Me.DownloadProgress.Properties.FlowAnimationEnabled = True
        Me.DownloadProgress.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.DownloadProgress.Properties.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DownloadProgress.ShowProgressInTaskBar = True
        Me.DownloadProgress.Size = New System.Drawing.Size(341, 5)
        Me.DownloadProgress.TabIndex = 11
        Me.DownloadProgress.Visible = False
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(9, 6)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(94, 20)
        Me.GunaLabel5.TabIndex = 9
        Me.GunaLabel5.Text = "13 Haz, 2021"
        '
        'GunaVSeparator2
        '
        Me.GunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HideAnimasyon.SetDecoration(Me.GunaVSeparator2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaVSeparator2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaVSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaVSeparator2.Location = New System.Drawing.Point(132, 258)
        Me.GunaVSeparator2.Name = "GunaVSeparator2"
        Me.GunaVSeparator2.Size = New System.Drawing.Size(8, 45)
        Me.GunaVSeparator2.TabIndex = 16
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(294, 7)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(39, 20)
        Me.GunaLabel1.TabIndex = 15
        Me.GunaLabel1.Text = "1.2.8"
        '
        'yüzeLabel
        '
        Me.yüzeLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.yüzeLabel.BackColor = System.Drawing.Color.White
        Me.HideAnimasyon.SetDecoration(Me.yüzeLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.yüzeLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.yüzeLabel.Font = New System.Drawing.Font("Gilroy", 11.25!, System.Drawing.FontStyle.Bold)
        Me.yüzeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.yüzeLabel.Location = New System.Drawing.Point(6, 201)
        Me.yüzeLabel.Name = "yüzeLabel"
        Me.yüzeLabel.Size = New System.Drawing.Size(104, 20)
        Me.yüzeLabel.TabIndex = 11
        Me.yüzeLabel.Text = "%0"
        Me.yüzeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.yüzeLabel.Visible = False
        '
        'GunaElipsePanel6
        '
        Me.GunaElipsePanel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaElipsePanel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaElipsePanel6.Controls.Add(Me.yüzeLabel)
        Me.GunaElipsePanel6.Controls.Add(Me.GunaLabel1)
        Me.GunaElipsePanel6.Controls.Add(Me.GunaVSeparator2)
        Me.GunaElipsePanel6.Controls.Add(Me.GunaLabel5)
        Me.GunaElipsePanel6.Controls.Add(Me.DownloadProgress)
        Me.GunaElipsePanel6.Controls.Add(Me.notLink1)
        Me.GunaElipsePanel6.Controls.Add(Me.BoyutLabel)
        Me.GunaElipsePanel6.Controls.Add(Me.btnDownload1)
        Me.GunaElipsePanel6.Controls.Add(Me.GunaLabel3)
        Me.GunaElipsePanel6.Controls.Add(Me.btnUpdateNote)
        Me.ShowAnimasyon.SetDecoration(Me.GunaElipsePanel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.GunaElipsePanel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaElipsePanel6.Location = New System.Drawing.Point(24, 36)
        Me.GunaElipsePanel6.Name = "GunaElipsePanel6"
        Me.GunaElipsePanel6.Radius = 10
        Me.GunaElipsePanel6.Size = New System.Drawing.Size(341, 333)
        Me.GunaElipsePanel6.TabIndex = 13
        '
        'btnUpdateNote
        '
        Me.btnUpdateNote.AllowDrop = True
        Me.btnUpdateNote.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateNote.CheckedState.Parent = Me.btnUpdateNote
        Me.btnUpdateNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.btnUpdateNote, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnUpdateNote, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnUpdateNote.HoverState.ImageSize = New System.Drawing.Size(345, 202)
        Me.btnUpdateNote.HoverState.Parent = Me.btnUpdateNote
        Me.btnUpdateNote.Image = CType(resources.GetObject("btnUpdateNote.Image"), System.Drawing.Image)
        Me.btnUpdateNote.ImageSize = New System.Drawing.Size(341, 198)
        Me.btnUpdateNote.Location = New System.Drawing.Point(0, 30)
        Me.btnUpdateNote.Name = "btnUpdateNote"
        Me.btnUpdateNote.PressedState.ImageSize = New System.Drawing.Size(345, 202)
        Me.btnUpdateNote.PressedState.Parent = Me.btnUpdateNote
        Me.btnUpdateNote.Size = New System.Drawing.Size(341, 198)
        Me.btnUpdateNote.TabIndex = 15
        '
        'GunaLabel10
        '
        Me.GunaLabel10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel10.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel10, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel10, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel10.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel10.Location = New System.Drawing.Point(146, 267)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(151, 30)
        Me.GunaLabel10.TabIndex = 18
        Me.GunaLabel10.Text = "Launcher Uİ"
        Me.GunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'yüzeLabel2
        '
        Me.yüzeLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.yüzeLabel2.BackColor = System.Drawing.Color.White
        Me.HideAnimasyon.SetDecoration(Me.yüzeLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.yüzeLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.yüzeLabel2.Font = New System.Drawing.Font("Gilroy", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yüzeLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.yüzeLabel2.Location = New System.Drawing.Point(6, 201)
        Me.yüzeLabel2.Name = "yüzeLabel2"
        Me.yüzeLabel2.Size = New System.Drawing.Size(104, 20)
        Me.yüzeLabel2.TabIndex = 11
        Me.yüzeLabel2.Text = "%0"
        Me.yüzeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.yüzeLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        Me.yüzeLabel2.Visible = False
        '
        'btnDownload2
        '
        Me.btnDownload2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDownload2.Animated = True
        Me.btnDownload2.BackColor = System.Drawing.Color.Transparent
        Me.btnDownload2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownload2.BorderRadius = 2
        Me.btnDownload2.BorderThickness = 2
        Me.btnDownload2.CheckedState.Parent = Me.btnDownload2
        Me.btnDownload2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownload2.CustomImages.Parent = Me.btnDownload2
        Me.ShowAnimasyon.SetDecoration(Me.btnDownload2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.btnDownload2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnDownload2.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownload2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownload2.Font = New System.Drawing.Font("Gilroy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDownload2.ForeColor = System.Drawing.Color.White
        Me.btnDownload2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownload2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownload2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDownload2.HoverState.Parent = Me.btnDownload2
        Me.btnDownload2.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDownload2.Location = New System.Drawing.Point(16, 258)
        Me.btnDownload2.Name = "btnDownload2"
        Me.btnDownload2.PressedDepth = 0
        Me.btnDownload2.ShadowDecoration.BorderRadius = 2
        Me.btnDownload2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDownload2.ShadowDecoration.Depth = 10
        Me.btnDownload2.ShadowDecoration.Enabled = True
        Me.btnDownload2.ShadowDecoration.Parent = Me.btnDownload2
        Me.btnDownload2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btnDownload2.Size = New System.Drawing.Size(110, 45)
        Me.btnDownload2.TabIndex = 0
        Me.btnDownload2.Text = "Download"
        Me.btnDownload2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'BoyutLabel2
        '
        Me.BoyutLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BoyutLabel2.BackColor = System.Drawing.Color.White
        Me.HideAnimasyon.SetDecoration(Me.BoyutLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.BoyutLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BoyutLabel2.Font = New System.Drawing.Font("Gilroy", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BoyutLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BoyutLabel2.Location = New System.Drawing.Point(247, 201)
        Me.BoyutLabel2.Name = "BoyutLabel2"
        Me.BoyutLabel2.Size = New System.Drawing.Size(88, 20)
        Me.BoyutLabel2.TabIndex = 12
        Me.BoyutLabel2.Text = "%0"
        Me.BoyutLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BoyutLabel2.Visible = False
        '
        'DownloadProgress2
        '
        Me.DownloadProgress2.AllowDrop = True
        Me.HideAnimasyon.SetDecoration(Me.DownloadProgress2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.DownloadProgress2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DownloadProgress2.Location = New System.Drawing.Point(0, 225)
        Me.DownloadProgress2.Name = "DownloadProgress2"
        Me.DownloadProgress2.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.[True]
        Me.DownloadProgress2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DownloadProgress2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DownloadProgress2.Properties.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DownloadProgress2.Properties.FlowAnimationDelay = 0
        Me.DownloadProgress2.Properties.FlowAnimationDuration = 0
        Me.DownloadProgress2.Properties.FlowAnimationEnabled = True
        Me.DownloadProgress2.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.DownloadProgress2.Properties.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DownloadProgress2.ShowProgressInTaskBar = True
        Me.DownloadProgress2.Size = New System.Drawing.Size(341, 5)
        Me.DownloadProgress2.TabIndex = 11
        Me.DownloadProgress2.Visible = False
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(9, 6)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(94, 20)
        Me.GunaLabel4.TabIndex = 9
        Me.GunaLabel4.Text = "21 Haz, 2021"
        '
        'GunaVSeparator1
        '
        Me.GunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HideAnimasyon.SetDecoration(Me.GunaVSeparator1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaVSeparator1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaVSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaVSeparator1.Location = New System.Drawing.Point(132, 258)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(8, 45)
        Me.GunaVSeparator1.TabIndex = 15
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(294, 6)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(39, 20)
        Me.GunaLabel2.TabIndex = 16
        Me.GunaLabel2.Text = "1.2.1"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaVSeparator1)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaElipsePanel1.Controls.Add(Me.DownloadProgress2)
        Me.GunaElipsePanel1.Controls.Add(Me.BoyutLabel2)
        Me.GunaElipsePanel1.Controls.Add(Me.btnDownload2)
        Me.GunaElipsePanel1.Controls.Add(Me.yüzeLabel2)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel10)
        Me.GunaElipsePanel1.Controls.Add(Me.Guna2ImageButton1)
        Me.ShowAnimasyon.SetDecoration(Me.GunaElipsePanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.GunaElipsePanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(397, 36)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 10
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(341, 333)
        Me.GunaElipsePanel1.TabIndex = 14
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.AllowDrop = True
        Me.Guna2ImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.Guna2ImageButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Guna2ImageButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(345, 202)
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(341, 198)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(0, 30)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(345, 202)
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(341, 198)
        Me.Guna2ImageButton1.TabIndex = 16
        '
        'HideAnimasyon
        '
        Me.HideAnimasyon.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.HideAnimasyon.Cursor = Nothing
        Animation6.AnimateOnlyDifferences = True
        Animation6.BlindCoeff = CType(resources.GetObject("Animation6.BlindCoeff"), System.Drawing.PointF)
        Animation6.LeafCoeff = 0!
        Animation6.MaxTime = 1.0!
        Animation6.MinTime = 0!
        Animation6.MosaicCoeff = CType(resources.GetObject("Animation6.MosaicCoeff"), System.Drawing.PointF)
        Animation6.MosaicShift = CType(resources.GetObject("Animation6.MosaicShift"), System.Drawing.PointF)
        Animation6.MosaicSize = 0
        Animation6.Padding = New System.Windows.Forms.Padding(0)
        Animation6.RotateCoeff = 0!
        Animation6.RotateLimit = 0!
        Animation6.ScaleCoeff = CType(resources.GetObject("Animation6.ScaleCoeff"), System.Drawing.PointF)
        Animation6.SlideCoeff = CType(resources.GetObject("Animation6.SlideCoeff"), System.Drawing.PointF)
        Animation6.TimeCoeff = 0!
        Animation6.TransparencyCoeff = 1.0!
        Me.HideAnimasyon.DefaultAnimation = Animation6
        Me.HideAnimasyon.TimeStep = 0.04!
        '
        'fileTimer
        '
        Me.fileTimer.Enabled = True
        '
        'bekleyenGüncellemeler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.GunaElipsePanel6)
        Me.Controls.Add(Me.newVersionLabel)
        Me.Controls.Add(Me.duyuruUpdateLabel)
        Me.Controls.Add(Me.uyarıLabel)
        Me.Controls.Add(Me.uyarıBox)
        Me.ShowAnimasyon.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DoubleBuffered = True
        Me.Name = "bekleyenGüncellemeler"
        Me.Size = New System.Drawing.Size(1202, 665)
        CType(Me.uyarıBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DownloadProgress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel6.ResumeLayout(False)
        Me.GunaElipsePanel6.PerformLayout()
        CType(Me.DownloadProgress2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uyarıBox As PictureBox
    Friend WithEvents uyarıLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents duyuruUpdateLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Tool As MetroFramework.Components.MetroToolTip
    Friend WithEvents newVersionLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents HideAnimasyon As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents ShowAnimasyon As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents fileTimer As Timer
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnDownload1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BoyutLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents notLink1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents DownloadProgress As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaVSeparator2 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents yüzeLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipsePanel6 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents yüzeLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnDownload2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BoyutLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DownloadProgress2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnUpdateNote As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
End Class
