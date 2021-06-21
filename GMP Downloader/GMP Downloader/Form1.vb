Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Linq


Public Class Form1
    Private ReadOnly FrmCanvas As Object
    Private collapsed As Boolean = False
    Public Property MaxValue As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
            vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(Panel4, GunaVScrollBar1, True)
            adminForm.Close()
            'Settings
            AyarlarMenü2.StartSwitch.Checked = My.Settings.settingsStartSwitch
            AyarlarMenü2.LowCpuSwitch.Checked = My.Settings.settingsLowCpuSwitch
            AyarlarMenü2.UpdatePackSwitch.Checked = My.Settings.settingsUpdatePackSwitch
            AyarlarMenü2.AutoUpdateSwitch.Checked = My.Settings.settingsAutoUpdateSwitch
            AyarlarMenü2.UpdateHealingSwitch.Checked = My.Settings.settingsUpdateHealingSwitch
            AyarlarMenü2.TransitionSwitch.Checked = My.Settings.settingsTransitionSwitch
            AyarlarMenü2.AnimatedSwitch.Checked = My.Settings.settingsAnimatedSwitch
            AyarlarMenü2.CpuComboBox.Text = My.Settings.settingsCpuComboBox
            AyarlarMenü2.GpuSwitch.Checked = My.Settings.settingsGpuSwitch
            AyarlarMenü2.BetaSwtich.Checked = My.Settings.settingsBetaSwtich
            AyarlarMenü2.UpdateSwitch.Checked = My.Settings.settingsUpdateSwitch
            AyarlarMenü2.SystemRecSwitch.Checked = My.Settings.settingsSystemRecSwitch
            AyarlarMenü2.CrashReportSwitch.Checked = My.Settings.settingsCrashReportSwitch
            AyarlarMenü2.WindowsCompatibility.Checked = My.Settings.settingsWindowsCompatibility
            AyarlarMenü2.WindowsGameMod.Checked = My.Settings.settingsWindowsGameMod
            AyarlarMenü2.MemoryClearSwitch.Checked = My.Settings.settingsMemoryClearSwitch
            AyarlarMenü2.NetworkOptimization.Checked = My.Settings.settingsNetworkOptimization
            AyarlarMenü2.NetworkHealing.Checked = My.Settings.settingsNetworkHealing
            AyarlarMenü2.NetworkUnloading.Checked = My.Settings.settingsNetworkUnloading
            AyarlarMenü2.TransitionAnimatedCheck.Checked = My.Settings.settingsTransitionAnimatedCheck
            AyarlarMenü2.ButtonAnimatedCheck.Checked = My.Settings.settingsButtonAnimatedCheck
            AyarlarMenü2.LoginAnimatedCheck.Checked = My.Settings.settingsLoginAnimatedCheck
            AyarlarMenü2.NotificationAnimatedCheck.Checked = My.Settings.settingsNotificationAnimatedCheck
            AyarlarMenü2.SteamGameCheck.Checked = My.Settings.settingsSteamGameCheck
            AyarlarMenü2.SteamProfilCheck.Checked = My.Settings.settingsSteamProfilCheck
            AyarlarMenü2.SteamLibraryCheck.Checked = My.Settings.settingsSteamLibraryCheck
            AyarlarMenü2.SteamProfileConnctionSwitch.Checked = My.Settings.settingsSteamProfileConnctionSwitch
            AyarlarMenü2.languageBox.Text = My.Settings.settingslanguageBox


            'Profile
            OpenFileDialog1.FileName = My.Settings.ımage
            ProfilDetay1.userNameText.Text = My.Settings.pcUserName
            ProfilDetay1.userMailText.Text = My.Settings.pcMail
            pcID.Text = ProfilDetay1.userNameText.Text
            ProfilDetay1.userNameID.Text = ProfilDetay1.userNameText.Text

            Dim PackFile As Boolean = File.Exists("Setup\GMP Setup.exe")
            If PackFile = True Then
                BekleyenGüncellemeler1.btnDownload1.Text = "Çalıştır"
            Else
                BekleyenGüncellemeler1.btnDownload1.Text = "Download"
            End If

            Dim PackFile2 As Boolean = File.Exists("Launcher Uİ\Launcher Uİ.exe")
            If PackFile2 = True Then
                BekleyenGüncellemeler1.btnDownload2.Text = "Çalıştır"
            Else
                BekleyenGüncellemeler1.btnDownload1.Text = "Download"
            End If

            Try
                Me.Location = New Point(CInt((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Me.Width / 2)), CInt((Screen.PrimaryScreen.WorkingArea.Height / 2) - (Me.Height / 2)))
                If My.Settings.ımage <> "" Then
                    Using MS As New IO.MemoryStream(Convert.FromBase64String(My.Settings.ımage))
                        userImage.Image = Nothing
                        ProfilDetay1.userImage2.Image = Nothing
                        ProfilDetay1.userImage.Image = Nothing
                        userImage.Image = Image.FromStream(MS)
                        ProfilDetay1.userImage.Image = Image.FromStream(MS)
                        ProfilDetay1.userImage2.Image = Image.FromStream(MS)
                    End Using
                Else

                End If
            Catch ex As Exception

            End Try



            Dim overspeedFileDosya As Boolean = File.Exists("tools\Overspeed")
            If overspeedFileDosya = True Then
                btnDownloadOverspeed.Image = My.Resources.playGreen
                btnDownloadOverspeed.HoverState.Image = My.Resources.playWhite

            Else
                btnDownloadOverspeed.Image = My.Resources.downloadGreen
                btnDownloadOverspeed.HoverState.Image = My.Resources.downloadWhite
            End If

            Dim FilerarDosya As Boolean = File.Exists("tools\Overspeed.rar")
            If FilerarDosya = True Then
                btnDownloadOverspeed.Image = My.Resources.playGreen
                btnDownloadOverspeed.HoverState.Image = My.Resources.playWhite

            Else
                btnDownloadOverspeed.Image = My.Resources.downloadGreen
                btnDownloadOverspeed.HoverState.Image = My.Resources.downloadWhite
            End If


            If My.Computer.Network.IsAvailable = True Then
                Try
                    Dim client1 As New WebClient()
                    Dim client2 As New WebClient()
                    BekleyenGüncellemeler1.duyuruUpdateLabel.Text = client1.DownloadString("https://www.dropbox.com/s/xwj5ic62p2562k5/G%C3%BCncelleme%20Version%20Duyuru.txt?dl=1")
                    updateLabel.Text = client2.DownloadString("https://www.dropbox.com/s/tx4jzbtxz71of21/update.txt?dl=1")
                    BekleyenGüncellemeler1.newVersionLabel.Text = client1.DownloadString("https://www.dropbox.com/s/9eav4mqei27u4ur/New%20version.txt?dl=1")
                    client1.DownloadFileAsync(New Uri("https://www.dropbox.com/s/33f8fwzfxgi0pqh/Auto.exe?dl=1"), "Auto.exe")

                    If updateLabel.Text = "12.9.0" Then
                        AyarlarMenü2.btnGüncelle.Visible = False
                        AyarlarMenü2.btnGüncellemeKontrol.Visible = True
                        bildirimUyarıBtn.Visible = False
                    Else
                        bildirimUyarıBtn.Visible = True
                        AyarlarMenü2.btnGüncelle.Visible = True
                        AyarlarMenü2.btnGüncellemeKontrol.Visible = False
                        Process.Start("Update.exe")
                        End
                    End If
                Catch ex As Exception

                End Try
            Else
                bildirimUyarıBtn.Visible = False
                BekleyenGüncellemeler1.uyarıLabel.Visible = False
                BekleyenGüncellemeler1.uyarıBox.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDownloadOverspeed_Click(sender As Object, e As EventArgs) Handles btnDownloadOverspeed.Click
        'Download
        Dim Files As Boolean = File.Exists("tools\Overspeed")
        Dim FilesRar As Boolean = File.Exists("tools\Overspeed.rar")
        If Files = False And FilesRar = True Then

        Else
            My.Computer.FileSystem.CreateDirectory("tools")
            Dim client1 As New WebClient
            AddHandler client1.DownloadProgressChanged, AddressOf ShowDownloadProgress
            AddHandler client1.DownloadFileCompleted, AddressOf OnDownloadComplete
            client1.DownloadFileAsync(New Uri("https://www.dropbox.com/s/5psmfbm5hef8ybr/Overpseed%200.06.0.rar?dl=1"), "tools\Overspeed.rar")
        End If

        Dim Files2 As Boolean = File.Exists("tools\Overspeed.rar")
        Dim overspeedDownload As Boolean = File.Exists("tools\Overspeed\Overspeed\Overspeed.exe")
        If overspeedDownload = True Or Files2 = False Then
            Try
                Process.Start("tools\Overspeed\Overspeed\Overspeed.exe")
            Catch ex As Exception
            End Try
        Else

        End If
    End Sub

    Private Sub OnDownloadComplete(sender As Object, e As AsyncCompletedEventArgs)
        If e.Error Is Nothing Then
            'Main Form            
            IndirmeleriYönet1.DownloadProgress.Visible = False
            IndirmeleriYönet1.BoyutLabel.Visible = False
            IndirmeleriYönet1.downloadPanel.Visible = False
            IndirmeleriYönet1.bilgiLabel.Visible = True
            downloadProgressTime.Visible = False
            btnDownloadOverspeed.Image = My.Resources.playGreen
            btnDownloadOverspeed.HoverState.Image = My.Resources.playWhite
        Else

        End If
    End Sub

    Private Sub ShowDownloadProgress(sender As Object, e As DownloadProgressChangedEventArgs)
        Try
            'Main Form           
            IndirmeleriYönet1.downloadImageId.Image = My.Resources.overspeedImage
            IndirmeleriYönet1.downloadNameId.Text = "OVERSPEED"
            IndirmeleriYönet1.downloadVersionLabel.Text = "0.0.6"
            IndirmeleriYönet1.BoyutLabel.Visible = True
            IndirmeleriYönet1.downloadPanel.Visible = True
            IndirmeleriYönet1.bilgiLabel.Visible = False
            IndirmeleriYönet1.DownloadProgress.Visible = True
            IndirmeleriYönet1.DownloadProgress.Position = e.ProgressPercentage
            IndirmeleriYönet1.BoyutLabel.Text = "% " & e.ProgressPercentage & String.Format(" - {0} MB / 39,25 MB", (e.BytesReceived / 1024D / 1024D).ToString("0.00"))

            'Game Menü
            btnDownloadOverspeed.Image = My.Resources.downloadingGreen
            btnDownloadOverspeed.HoverState.Image = My.Resources.downloadingWhite

            'Download Speed
            IndirmeleriYönet1.downloadSpeedLabel.Text = (e.BytesReceived / (DirectCast(e.UserState, Stopwatch).ElapsedMilliseconds / 1000.0#)).ToString("")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub fileTimer_Tick(sender As Object, e As EventArgs) Handles fileTimer.Tick
        Dim pName As String = "Overspeed"
        Dim psList() As Process
        Try
            psList = Process.GetProcesses()

            For Each p As Process In psList
                If (pName = p.ProcessName) Then
                    btnDownloadOverspeed.Image = My.Resources.pauseGreen
                    btnDownloadOverspeed.HoverState.Image = My.Resources.pauseWhite
                Else

                End If

            Next p

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAnaMenü_Click(sender As Object, e As EventArgs) Handles btnAnaMenü.Click
        ProfilDetay1.profilEditPanel.Visible = False
        HideAnimasyon.HideSync(GameMenü1)
        HideAnimasyon.HideSync(AyarlarMenü2)
        HideAnimasyon.HideSync(BekleyenGüncellemeler1)
        HideAnimasyon.HideSync(IndirmeleriYönet1)
        HideAnimasyon.HideSync(ProfilDetay1)
        HideAnimasyon.HideSync(Panel4)
        HideAnimasyon.HideSync(UpdateNotes1)
        ShowAnimasyon.ShowSync(Haberler1)

    End Sub
    Private Sub btnMenü_Click(sender As Object, e As EventArgs) Handles btnMenü.Click
        ProfilDetay1.profilEditPanel.Visible = False
        HideAnimasyon.HideSync(GameMenü1)
        HideAnimasyon.HideSync(AyarlarMenü2)
        HideAnimasyon.HideSync(BekleyenGüncellemeler1)
        HideAnimasyon.HideSync(IndirmeleriYönet1)
        HideAnimasyon.HideSync(ProfilDetay1)
        HideAnimasyon.HideSync(Haberler1)
        HideAnimasyon.HideSync(UpdateNotes1)
        ShowAnimasyon.ShowSync(Panel4)

    End Sub

    Private Sub btnGame_Click_1(sender As Object, e As EventArgs) Handles btnGame.Click
        ProfilDetay1.profilEditPanel.Visible = False
        HideAnimasyon.HideSync(Panel4)
        HideAnimasyon.HideSync(AyarlarMenü2)
        HideAnimasyon.HideSync(BekleyenGüncellemeler1)
        HideAnimasyon.HideSync(IndirmeleriYönet1)
        HideAnimasyon.HideSync(ProfilDetay1)
        HideAnimasyon.HideSync(Haberler1)
        HideAnimasyon.HideSync(UpdateNotes1)
        ShowAnimasyon.ShowSync(GameMenü1)

    End Sub

    Private Sub btnAyarlar_Click(sender As Object, e As EventArgs) Handles btnAyarlar.Click
        ProfilDetay1.profilEditPanel.Visible = False
        HideAnimasyon.HideSync(Panel4)
        HideAnimasyon.HideSync(GameMenü1)
        HideAnimasyon.HideSync(BekleyenGüncellemeler1)
        HideAnimasyon.HideSync(IndirmeleriYönet1)
        HideAnimasyon.HideSync(ProfilDetay1)
        HideAnimasyon.HideSync(Haberler1)
        HideAnimasyon.HideSync(UpdateNotes1)
        ShowAnimasyon.ShowSync(AyarlarMenü2)

    End Sub

    Private Sub btnBekleyenGüncellemeler_Click(sender As Object, e As EventArgs) Handles btnGüncellemePaketleri.Click
        ProfilDetay1.profilEditPanel.Visible = False
        HideAnimasyon.HideSync(Panel4)
        HideAnimasyon.HideSync(GameMenü1)
        HideAnimasyon.HideSync(AyarlarMenü2)
        HideAnimasyon.HideSync(IndirmeleriYönet1)
        HideAnimasyon.HideSync(ProfilDetay1)
        HideAnimasyon.HideSync(Haberler1)
        HideAnimasyon.HideSync(UpdateNotes1)
        ShowAnimasyon.ShowSync(BekleyenGüncellemeler1)

    End Sub

    Private Sub btnİndirmeleriYönet_Click(sender As Object, e As EventArgs) Handles btnİndirmeleriYönet.Click
        ProfilDetay1.profilEditPanel.Visible = False
        HideAnimasyon.HideSync(Panel4)
        HideAnimasyon.HideSync(GameMenü1)
        HideAnimasyon.HideSync(AyarlarMenü2)
        HideAnimasyon.HideSync(BekleyenGüncellemeler1)
        HideAnimasyon.HideSync(ProfilDetay1)
        HideAnimasyon.HideSync(Haberler1)
        HideAnimasyon.HideSync(UpdateNotes1)
        ShowAnimasyon.ShowSync(IndirmeleriYönet1)
    End Sub

    Private Sub updateNewVersionLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        ProfilDetay1.profilEditPanel.Visible = False
        btnAnaMenü.Checked = False
        btnMenü.Checked = False
        btnGame.Checked = False
        btnAyarlar.Checked = False
        btnGüncellemePaketleri.Checked = False
        btnİndirmeleriYönet.Checked = False
        HideAnimasyon.HideSync(Panel4)
        HideAnimasyon.HideSync(GameMenü1)
        HideAnimasyon.HideSync(BekleyenGüncellemeler1)
        HideAnimasyon.HideSync(IndirmeleriYönet1)
        HideAnimasyon.HideSync(ProfilDetay1)
        HideAnimasyon.HideSync(Haberler1)
        HideAnimasyon.HideSync(UpdateNotes1)
        ShowAnimasyon.ShowSync(AyarlarMenü2)
    End Sub

    Private Sub btnEdit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnEdit.LinkClicked
        btnAnaMenü.Checked = False
        btnMenü.Checked = False
        btnGame.Checked = False
        btnAyarlar.Checked = False
        btnGüncellemePaketleri.Checked = False
        btnİndirmeleriYönet.Checked = False
        ProfilDetay1.profilEditPanel.Visible = False
        HideAnimasyon.HideSync(Panel4)
        HideAnimasyon.HideSync(GameMenü1)
        HideAnimasyon.HideSync(AyarlarMenü2)
        HideAnimasyon.HideSync(BekleyenGüncellemeler1)
        HideAnimasyon.HideSync(UpdateNotes1)
        HideAnimasyon.HideSync(IndirmeleriYönet1)
        HideAnimasyon.HideSync(Haberler1)
        ShowAnimasyon.ShowSync(ProfilDetay1)
    End Sub

    Private Sub btnVersion_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDownloadSteam_Click(sender As Object, e As EventArgs) Handles btnDownloadSteam.Click
        Select Case MessageBox.Show("Mevcut uygulamaya erişim kısıtlandı;

Mevcut version : 12.9.0
İstemci version : 1.211.2.0

Sunucuyla ilgili problem tespit edildi.
Uygulama istemci üzerinde bulunamadı.", "Bağlantı Problemi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Case DialogResult.OK
        End Select
    End Sub

    Private Sub rankLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim pName As String = "Overspeed"
        Dim psList() As Process
        Try
            psList = Process.GetProcesses()

            For Each p As Process In psList
                If (pName = p.ProcessName) Then

                Else
                    btnDownloadOverspeed.Image = My.Resources.playGreen
                    btnDownloadOverspeed.HoverState.Image = My.Resources.playWhite
                End If

            Next p

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Try
            Form2.Close()
            adminForm.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub userBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles OpenFileDialog1.FileOk
        My.Settings.ımage = ""
        My.Settings.Save()
        userImage.Image = Nothing
        ProfilDetay1.userImage.Image = Nothing
        ProfilDetay1.userImage2.Image = Nothing
        userImage.Image = My.Resources.user
        ProfilDetay1.userImage.Image = My.Resources.user
        ProfilDetay1.userImage2.Image = My.Resources.user
        userImage.Size = userImage.Image.Size
        ProfilDetay1.userImage.Size = userImage.Image.Size
        ProfilDetay1.userImage2.Size = userImage.Image.Size
    End Sub

    Private Sub userImage_Click(sender As Object, e As EventArgs) Handles userImage.Click
        Using OFD As New OpenFileDialog
            With OFD
                .Title = "Profil fotoğrafı seçin"
                .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                .Filter = "Image files (*.Bmp, *.Gif, *.Jpg, *.Png, *.Tif)|*.Bmp;*.Gif;*.Jpg;*.Png;*.Tif"
            End With
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Settings.ımage = Convert.ToBase64String(My.Computer.FileSystem.ReadAllBytes(OFD.FileName))
                My.Settings.Save()
                If My.Settings.ımage <> "" Then
                    userImage.Image = Nothing
                    ProfilDetay1.userImage.Image = Nothing
                    ProfilDetay1.userImage2.Image = Nothing
                    Using MS As New IO.MemoryStream(Convert.FromBase64String(My.Settings.ımage))
                        userImage.Image = Image.FromStream(MS)
                        ProfilDetay1.userImage.Image = Image.FromStream(MS)
                        ProfilDetay1.userImage2.Image = Image.FromStream(MS)
                    End Using

                End If
            End If
        End Using
    End Sub

    Private Sub animasyonTimer_Tick(sender As Object, e As EventArgs) Handles animasyonTimer.Tick
        HideAnimasyon.HideSync(MenüLoad2)
        animasyonTimer.Stop()
    End Sub

    Private Sub Procress_Tick(sender As Object, e As EventArgs) Handles ProcressStart.Tick
        Try
            Dim pName As String = "BlackSquadGame"
            Dim psList As Process()
            psList = Process.GetProcesses()

            For Each p As Process In psList
                If pName = p.ProcessName Then
                    procressIDLabel.Text = "Black Squad"
                    procressDurumLabel.Text = "Çalışıyor"
                    ShowAnimasyon.ShowSync(gamePanel)
                End If
            Next p

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProcressStop_Tick(sender As Object, e As EventArgs) Handles ProcressStop.Tick
        Try
            Dim pName As String = "BlackSquadGame"
            Dim psList As Process()
            psList = Process.GetProcesses()

            For Each p As Process In psList
                If pName = p.ProcessName Then
                    procressIDLabel.Text = "Black Squad"
                    procressDurumLabel.Text = "Çalışıyor"
                    ShowAnimasyon.ShowSync(gamePanel)
                End If
            Next p

        Catch ex As Exception

        End Try
    End Sub

    Private Sub EthernetTimer_Tick(sender As Object, e As EventArgs) Handles EthernetTimer.Tick
        Try
            If My.Computer.Network.IsAvailable = True Then


            Else
                bildirimUyarıBtn.Visible = False
                BekleyenGüncellemeler1.uyarıLabel.Visible = False
                BekleyenGüncellemeler1.uyarıBox.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class