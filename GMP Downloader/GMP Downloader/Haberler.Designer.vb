<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Haberler
    Inherits System.Windows.Forms.UserControl

    'UserControl, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Haberler))
        Me.btnNews1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaElipsePanel6 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnNews3 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnUpdateNote = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnNews2 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaVScrollBar1 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.ShowAnimasyon = New Guna.UI2.WinForms.Guna2Transition()
        Me.HideAnimasyon = New Guna.UI2.WinForms.Guna2Transition()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GunaElipsePanel6.SuspendLayout()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNews1
        '
        Me.btnNews1.AllowDrop = True
        Me.btnNews1.BackColor = System.Drawing.Color.Transparent
        Me.btnNews1.CheckedState.Parent = Me.btnNews1
        Me.btnNews1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.btnNews1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnNews1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnNews1.HoverState.Image = CType(resources.GetObject("btnNews1.HoverState.Image"), System.Drawing.Image)
        Me.btnNews1.HoverState.ImageSize = New System.Drawing.Size(345, 202)
        Me.btnNews1.HoverState.Parent = Me.btnNews1
        Me.btnNews1.Image = CType(resources.GetObject("btnNews1.Image"), System.Drawing.Image)
        Me.btnNews1.ImageSize = New System.Drawing.Size(341, 198)
        Me.btnNews1.Location = New System.Drawing.Point(0, 0)
        Me.btnNews1.Name = "btnNews1"
        Me.btnNews1.PressedState.Image = CType(resources.GetObject("btnNews1.PressedState.Image"), System.Drawing.Image)
        Me.btnNews1.PressedState.ImageSize = New System.Drawing.Size(345, 202)
        Me.btnNews1.PressedState.Parent = Me.btnNews1
        Me.btnNews1.Size = New System.Drawing.Size(341, 198)
        Me.btnNews1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.HideAnimasyon.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 664)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GunaElipsePanel6)
        Me.Panel2.Controls.Add(Me.GunaElipsePanel3)
        Me.Panel2.Controls.Add(Me.GunaElipsePanel2)
        Me.Panel2.Controls.Add(Me.GunaElipsePanel1)
        Me.HideAnimasyon.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1182, 664)
        Me.Panel2.TabIndex = 2
        '
        'GunaElipsePanel6
        '
        Me.GunaElipsePanel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaElipsePanel6.Controls.Add(Me.btnNews3)
        Me.GunaElipsePanel6.Controls.Add(Me.GunaLabel11)
        Me.GunaElipsePanel6.Controls.Add(Me.GunaLabel12)
        Me.HideAnimasyon.SetDecoration(Me.GunaElipsePanel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaElipsePanel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaElipsePanel6.Location = New System.Drawing.Point(14, 347)
        Me.GunaElipsePanel6.Name = "GunaElipsePanel6"
        Me.GunaElipsePanel6.Radius = 10
        Me.GunaElipsePanel6.Size = New System.Drawing.Size(339, 300)
        Me.GunaElipsePanel6.TabIndex = 5
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
        'GunaLabel11
        '
        Me.GunaLabel11.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel11, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel11, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel11.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel11.Location = New System.Drawing.Point(15, 259)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(239, 32)
        Me.GunaLabel11.TabIndex = 19
        Me.GunaLabel11.Text = "28 May 2021"
        Me.GunaLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaLabel12
        '
        Me.GunaLabel12.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel12, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel12, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel12.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel12.Location = New System.Drawing.Point(15, 211)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(239, 60)
        Me.GunaLabel12.TabIndex = 18
        Me.GunaLabel12.Text = "Far Cry 6 - Official Gameplay Trailer"
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaElipsePanel3.Controls.Add(Me.btnUpdateNote)
        Me.GunaElipsePanel3.Controls.Add(Me.GunaLabel5)
        Me.GunaElipsePanel3.Controls.Add(Me.GunaLabel6)
        Me.HideAnimasyon.SetDecoration(Me.GunaElipsePanel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaElipsePanel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(405, 22)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Radius = 10
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(339, 300)
        Me.GunaElipsePanel3.TabIndex = 4
        '
        'btnUpdateNote
        '
        Me.btnUpdateNote.AllowDrop = True
        Me.btnUpdateNote.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateNote.CheckedState.Parent = Me.btnUpdateNote
        Me.btnUpdateNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.btnUpdateNote, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnUpdateNote, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnUpdateNote.HoverState.Image = CType(resources.GetObject("btnUpdateNote.HoverState.Image"), System.Drawing.Image)
        Me.btnUpdateNote.HoverState.ImageSize = New System.Drawing.Size(345, 202)
        Me.btnUpdateNote.HoverState.Parent = Me.btnUpdateNote
        Me.btnUpdateNote.Image = CType(resources.GetObject("btnUpdateNote.Image"), System.Drawing.Image)
        Me.btnUpdateNote.ImageSize = New System.Drawing.Size(341, 198)
        Me.btnUpdateNote.Location = New System.Drawing.Point(0, 0)
        Me.btnUpdateNote.Name = "btnUpdateNote"
        Me.btnUpdateNote.PressedState.Image = CType(resources.GetObject("btnUpdateNote.PressedState.Image"), System.Drawing.Image)
        Me.btnUpdateNote.PressedState.ImageSize = New System.Drawing.Size(345, 202)
        Me.btnUpdateNote.PressedState.Parent = Me.btnUpdateNote
        Me.btnUpdateNote.Size = New System.Drawing.Size(341, 198)
        Me.btnUpdateNote.TabIndex = 0
        '
        'GunaLabel5
        '
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(15, 259)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(239, 32)
        Me.GunaLabel5.TabIndex = 19
        Me.GunaLabel5.Text = "21 Haziran 2021"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaLabel6
        '
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel6.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(15, 211)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(239, 60)
        Me.GunaLabel6.TabIndex = 18
        Me.GunaLabel6.Text = "GMP Downloader - 12.9.0 Güncelleme Notları"
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaElipsePanel2.Controls.Add(Me.btnNews2)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel1)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel4)
        Me.HideAnimasyon.SetDecoration(Me.GunaElipsePanel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaElipsePanel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(794, 22)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 10
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(339, 300)
        Me.GunaElipsePanel2.TabIndex = 3
        '
        'btnNews2
        '
        Me.btnNews2.AllowDrop = True
        Me.btnNews2.BackColor = System.Drawing.Color.Transparent
        Me.btnNews2.CheckedState.Parent = Me.btnNews2
        Me.btnNews2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideAnimasyon.SetDecoration(Me.btnNews2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.btnNews2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnNews2.HoverState.Image = CType(resources.GetObject("btnNews2.HoverState.Image"), System.Drawing.Image)
        Me.btnNews2.HoverState.ImageSize = New System.Drawing.Size(345, 202)
        Me.btnNews2.HoverState.Parent = Me.btnNews2
        Me.btnNews2.Image = CType(resources.GetObject("btnNews2.Image"), System.Drawing.Image)
        Me.btnNews2.ImageSize = New System.Drawing.Size(341, 198)
        Me.btnNews2.Location = New System.Drawing.Point(-1, 0)
        Me.btnNews2.Name = "btnNews2"
        Me.btnNews2.PressedState.Image = CType(resources.GetObject("btnNews2.PressedState.Image"), System.Drawing.Image)
        Me.btnNews2.PressedState.ImageSize = New System.Drawing.Size(345, 202)
        Me.btnNews2.PressedState.Parent = Me.btnNews2
        Me.btnNews2.Size = New System.Drawing.Size(341, 198)
        Me.btnNews2.TabIndex = 0
        '
        'GunaLabel1
        '
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(15, 259)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(239, 32)
        Me.GunaLabel1.TabIndex = 19
        Me.GunaLabel1.Text = "14 Oca 2021"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaLabel4
        '
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel4.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(15, 211)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(239, 60)
        Me.GunaLabel4.TabIndex = 18
        Me.GunaLabel4.Text = "Cyberpunk 2077 - Our Commitment to Quality"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.btnNews1)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel3)
        Me.HideAnimasyon.SetDecoration(Me.GunaElipsePanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaElipsePanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(14, 22)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 10
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(339, 300)
        Me.GunaElipsePanel1.TabIndex = 2
        '
        'GunaLabel2
        '
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(15, 259)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(239, 32)
        Me.GunaLabel2.TabIndex = 19
        Me.GunaLabel2.Text = "27 May 2021"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaLabel3
        '
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.HideAnimasyon.SetDecoration(Me.GunaLabel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowAnimasyon.SetDecoration(Me.GunaLabel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(15, 211)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(239, 60)
        Me.GunaLabel3.TabIndex = 18
        Me.GunaLabel3.Text = "Dying Light 2 Stay Human - Official Gameplay Trailer"
        '
        'GunaVScrollBar1
        '
        Me.ShowAnimasyon.SetDecoration(Me.GunaVScrollBar1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me.GunaVScrollBar1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaVScrollBar1.LargeChange = 10
        Me.GunaVScrollBar1.Location = New System.Drawing.Point(1190, -2)
        Me.GunaVScrollBar1.Maximum = 100
        Me.GunaVScrollBar1.Name = "GunaVScrollBar1"
        Me.GunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GunaVScrollBar1.Size = New System.Drawing.Size(10, 663)
        Me.GunaVScrollBar1.TabIndex = 28
        Me.GunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.GunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
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
        Me.ShowAnimasyon.MaxAnimationTime = 2000
        Me.ShowAnimasyon.TimeStep = 0.03!
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
        Me.HideAnimasyon.MaxAnimationTime = 2000
        Me.HideAnimasyon.TimeStep = 0.03!
        '
        'Haberler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaVScrollBar1)
        Me.ShowAnimasyon.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HideAnimasyon.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Name = "Haberler"
        Me.Size = New System.Drawing.Size(1202, 665)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GunaElipsePanel6.ResumeLayout(False)
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNews1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnNews2 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnUpdateNote As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaVScrollBar1 As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents GunaElipsePanel6 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnNews3 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents HideAnimasyon As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents ShowAnimasyon As Guna.UI2.WinForms.Guna2Transition
End Class
