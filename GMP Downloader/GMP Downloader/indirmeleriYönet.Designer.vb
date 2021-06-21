<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class indirmeleriYönet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(indirmeleriYönet))
        Me.downloadPanel = New System.Windows.Forms.Panel()
        Me.downloadVersionLabel = New Guna.UI.WinForms.GunaLabel()
        Me.DownloadProgress = New DevExpress.XtraEditors.ProgressBarControl()
        Me.downloadSpeedLabel = New Guna.UI.WinForms.GunaLabel()
        Me.downloadImageId = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BoyutLabel = New Guna.UI.WinForms.GunaLabel()
        Me.durumDownload = New System.Windows.Forms.PictureBox()
        Me.durumBox1 = New System.Windows.Forms.PictureBox()
        Me.downloadNameId = New Guna.UI.WinForms.GunaLabel()
        Me.panelTimer = New System.Windows.Forms.Timer(Me.components)
        Me.bilgiLabel = New Guna.UI.WinForms.GunaLabel()
        Me.downloadPanel.SuspendLayout()
        CType(Me.DownloadProgress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.durumDownload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.durumBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'downloadPanel
        '
        Me.downloadPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.downloadPanel.Controls.Add(Me.downloadVersionLabel)
        Me.downloadPanel.Controls.Add(Me.DownloadProgress)
        Me.downloadPanel.Controls.Add(Me.downloadSpeedLabel)
        Me.downloadPanel.Controls.Add(Me.downloadImageId)
        Me.downloadPanel.Controls.Add(Me.BoyutLabel)
        Me.downloadPanel.Controls.Add(Me.durumDownload)
        Me.downloadPanel.Controls.Add(Me.durumBox1)
        Me.downloadPanel.Controls.Add(Me.downloadNameId)
        Me.downloadPanel.Location = New System.Drawing.Point(-3, -1)
        Me.downloadPanel.Name = "downloadPanel"
        Me.downloadPanel.Size = New System.Drawing.Size(1205, 120)
        Me.downloadPanel.TabIndex = 3
        Me.downloadPanel.Visible = False
        '
        'downloadVersionLabel
        '
        Me.downloadVersionLabel.AutoSize = True
        Me.downloadVersionLabel.BackColor = System.Drawing.Color.Transparent
        Me.downloadVersionLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.downloadVersionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.downloadVersionLabel.Location = New System.Drawing.Point(152, 39)
        Me.downloadVersionLabel.Name = "downloadVersionLabel"
        Me.downloadVersionLabel.Size = New System.Drawing.Size(0, 20)
        Me.downloadVersionLabel.TabIndex = 14
        Me.downloadVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DownloadProgress
        '
        Me.DownloadProgress.AllowDrop = True
        Me.DownloadProgress.Location = New System.Drawing.Point(157, 100)
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
        Me.DownloadProgress.Size = New System.Drawing.Size(1032, 10)
        Me.DownloadProgress.TabIndex = 11
        '
        'downloadSpeedLabel
        '
        Me.downloadSpeedLabel.BackColor = System.Drawing.Color.Transparent
        Me.downloadSpeedLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.downloadSpeedLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.downloadSpeedLabel.Location = New System.Drawing.Point(823, 27)
        Me.downloadSpeedLabel.Name = "downloadSpeedLabel"
        Me.downloadSpeedLabel.Size = New System.Drawing.Size(93, 20)
        Me.downloadSpeedLabel.TabIndex = 13
        Me.downloadSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.downloadSpeedLabel.Visible = False
        '
        'downloadImageId
        '
        Me.downloadImageId.Animated = True
        Me.downloadImageId.BackColor = System.Drawing.Color.Transparent
        Me.downloadImageId.BorderColor = System.Drawing.Color.Empty
        Me.downloadImageId.CheckedState.Parent = Me.downloadImageId
        Me.downloadImageId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.downloadImageId.CustomImages.Parent = Me.downloadImageId
        Me.downloadImageId.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.downloadImageId.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.downloadImageId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.downloadImageId.ForeColor = System.Drawing.Color.White
        Me.downloadImageId.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.downloadImageId.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.downloadImageId.HoverState.Parent = Me.downloadImageId
        Me.downloadImageId.ImageSize = New System.Drawing.Size(50, 50)
        Me.downloadImageId.Location = New System.Drawing.Point(3, -1)
        Me.downloadImageId.Name = "downloadImageId"
        Me.downloadImageId.PressedDepth = 0
        Me.downloadImageId.ShadowDecoration.BorderRadius = 0
        Me.downloadImageId.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.downloadImageId.ShadowDecoration.Depth = 15
        Me.downloadImageId.ShadowDecoration.Enabled = True
        Me.downloadImageId.ShadowDecoration.Parent = Me.downloadImageId
        Me.downloadImageId.Size = New System.Drawing.Size(139, 123)
        Me.downloadImageId.TabIndex = 9
        Me.downloadImageId.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'BoyutLabel
        '
        Me.BoyutLabel.BackColor = System.Drawing.Color.Transparent
        Me.BoyutLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!)
        Me.BoyutLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BoyutLabel.Location = New System.Drawing.Point(151, 74)
        Me.BoyutLabel.Name = "BoyutLabel"
        Me.BoyutLabel.Size = New System.Drawing.Size(809, 20)
        Me.BoyutLabel.TabIndex = 12
        Me.BoyutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'durumDownload
        '
        Me.durumDownload.BackColor = System.Drawing.Color.Transparent
        Me.durumDownload.Image = Global.GMP_Downloader.My.Resources.Resources.downloadingImage
        Me.durumDownload.Location = New System.Drawing.Point(1164, 44)
        Me.durumDownload.Name = "durumDownload"
        Me.durumDownload.Size = New System.Drawing.Size(25, 21)
        Me.durumDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.durumDownload.TabIndex = 11
        Me.durumDownload.TabStop = False
        Me.durumDownload.Visible = False
        '
        'durumBox1
        '
        Me.durumBox1.BackColor = System.Drawing.Color.Transparent
        Me.durumBox1.Image = CType(resources.GetObject("durumBox1.Image"), System.Drawing.Image)
        Me.durumBox1.Location = New System.Drawing.Point(1164, 44)
        Me.durumBox1.Name = "durumBox1"
        Me.durumBox1.Size = New System.Drawing.Size(25, 21)
        Me.durumBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.durumBox1.TabIndex = 10
        Me.durumBox1.TabStop = False
        Me.durumBox1.Visible = False
        '
        'downloadNameId
        '
        Me.downloadNameId.BackColor = System.Drawing.Color.Transparent
        Me.downloadNameId.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.downloadNameId.ForeColor = System.Drawing.Color.LightGray
        Me.downloadNameId.Location = New System.Drawing.Point(151, 14)
        Me.downloadNameId.Name = "downloadNameId"
        Me.downloadNameId.Size = New System.Drawing.Size(775, 24)
        Me.downloadNameId.TabIndex = 9
        Me.downloadNameId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.downloadNameId.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'panelTimer
        '
        Me.panelTimer.Enabled = True
        '
        'bilgiLabel
        '
        Me.bilgiLabel.BackColor = System.Drawing.Color.Transparent
        Me.bilgiLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.bilgiLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.bilgiLabel.Location = New System.Drawing.Point(5, 306)
        Me.bilgiLabel.Name = "bilgiLabel"
        Me.bilgiLabel.Size = New System.Drawing.Size(1197, 24)
        Me.bilgiLabel.TabIndex = 8
        Me.bilgiLabel.Text = "Hiç indirme yok"
        Me.bilgiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'indirmeleriYönet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Controls.Add(Me.bilgiLabel)
        Me.Controls.Add(Me.downloadPanel)
        Me.Name = "indirmeleriYönet"
        Me.Size = New System.Drawing.Size(1202, 665)
        Me.downloadPanel.ResumeLayout(False)
        Me.downloadPanel.PerformLayout()
        CType(Me.DownloadProgress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.durumDownload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.durumBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents downloadPanel As Panel
    Friend WithEvents DownloadProgress As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents durumDownload As PictureBox
    Friend WithEvents downloadNameId As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BoyutLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents durumBox1 As PictureBox
    Friend WithEvents panelTimer As Timer
    Friend WithEvents bilgiLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents downloadImageId As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents downloadSpeedLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents downloadVersionLabel As Guna.UI.WinForms.GunaLabel
End Class
