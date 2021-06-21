Imports System.Net

Public Class ayarlarMenü
    Private Sub ayarlarMenü_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(Panel1, GunaVScrollBar1, True)
    End Sub

    Private Sub StartSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles StartSwitch.CheckedChanged
        My.Settings.settingsStartSwitch = StartSwitch.Checked
    End Sub

    Private Sub LowCpuSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles LowCpuSwitch.CheckedChanged
        My.Settings.settingsLowCpuSwitch = LowCpuSwitch.Checked
    End Sub

    Private Sub UpdatePackSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles UpdatePackSwitch.CheckedChanged
        My.Settings.settingsUpdatePackSwitch = UpdatePackSwitch.Checked
    End Sub

    Private Sub AutoUpdateSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles AutoUpdateSwitch.CheckedChanged
        My.Settings.settingsAutoUpdateSwitch = AutoUpdateSwitch.Checked
    End Sub

    Private Sub UpdateHealingSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles UpdateHealingSwitch.CheckedChanged
        My.Settings.settingsUpdateHealingSwitch = UpdateHealingSwitch.Checked
    End Sub

    Private Sub TransitionSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles TransitionSwitch.CheckedChanged
        My.Settings.settingsTransitionSwitch = TransitionSwitch.Checked
    End Sub

    Private Sub AnimatedSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles AnimatedSwitch.CheckedChanged

    End Sub
    Private Sub CpuComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        My.Settings.settingsCpuComboBox = CpuComboBox.Text
    End Sub

    Private Sub GpuSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles GpuSwitch.CheckedChanged
        My.Settings.settingsGpuSwitch = GpuSwitch.Checked
    End Sub

    Private Sub BetaSwtich_CheckedChanged(sender As Object, e As EventArgs) Handles BetaSwtich.CheckedChanged
        My.Settings.settingsBetaSwtich = BetaSwtich.Checked
    End Sub

    Private Sub UpdateSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles UpdateSwitch.CheckedChanged
        My.Settings.settingsUpdateSwitch = UpdateSwitch.Checked
    End Sub

    Private Sub SystemRecSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles SystemRecSwitch.CheckedChanged
        My.Settings.settingsSystemRecSwitch = SystemRecSwitch.Checked
    End Sub

    Private Sub CrashReportSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles CrashReportSwitch.CheckedChanged
        My.Settings.settingsCrashReportSwitch = CrashReportSwitch.Checked
    End Sub

    Private Sub WindowsCompatibility_CheckedChanged(sender As Object, e As EventArgs) Handles WindowsCompatibility.CheckedChanged
        My.Settings.settingsWindowsCompatibility = WindowsCompatibility.Checked
    End Sub

    Private Sub WindowsGameMod_CheckedChanged(sender As Object, e As EventArgs) Handles WindowsGameMod.CheckedChanged
        My.Settings.settingsWindowsGameMod = WindowsGameMod.Checked
    End Sub

    Private Sub MemoryClearSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles MemoryClearSwitch.CheckedChanged
        My.Settings.settingsMemoryClearSwitch = MemoryClearSwitch.Checked
    End Sub

    Private Sub NetworkOptimization_CheckedChanged(sender As Object, e As EventArgs) Handles NetworkOptimization.CheckedChanged
        My.Settings.settingsNetworkOptimization = NetworkOptimization.Checked
    End Sub

    Private Sub NetworkHealing_CheckedChanged(sender As Object, e As EventArgs) Handles NetworkHealing.CheckedChanged
        My.Settings.settingsNetworkHealing = NetworkHealing.Checked
    End Sub

    Private Sub NetworkUnloading_CheckedChanged(sender As Object, e As EventArgs) Handles NetworkUnloading.CheckedChanged
        My.Settings.settingsNetworkUnloading = NetworkUnloading.Checked
    End Sub

    Private Sub checkUpdateTimer_Tick(sender As Object, e As EventArgs) Handles checkUpdateTimer.Tick
        If My.Computer.Network.IsAvailable = True Then
            Try
                Dim client1 As New WebClient
                Form1.updateLabel.Text = client1.DownloadString("https://www.dropbox.com/s/tx4jzbtxz71of21/update.txt?dl=1")
                If Form1.updateLabel.Text = "12.9.0" Then
                    updateVersionLabel.Visible = False
                    btnGüncelle.Visible = False
                    btnGüncellemeKontrol.Visible = True
                    Form1.bildirimUyarıBtn.Visible = False
                    checkUpdateTimer.Stop()
                    Select Case MessageBox.Show("Mevcut sürüm güncel, yeni güncelleme bulunamadı.", "Güncelleme Bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Case DialogResult.OK
                    End Select
                Else
                    updateVersionLabel.Text = Form1.updateLabel.Text & " Yeni version"
                    updateVersionLabel.Visible = True
                    btnGüncelle.Visible = True
                    btnGüncellemeKontrol.Visible = False
                    Form1.bildirimUyarıBtn.Visible = True
                End If
            Catch ex As Exception

            End Try
        Else
            checkUpdateTimer.Stop()
            Select Case MessageBox.Show("Güncellemeler kontrol edilirken bir hata oluştu.", "Bağlantı Problemi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Case DialogResult.OK
            End Select
        End If
        checkUpdateTimer.Stop()
        btnGüncellemeKontrol.Enabled = True
    End Sub

    Private Sub btnGüncellemeKontrol_Click(sender As Object, e As EventArgs) Handles btnGüncellemeKontrol.Click
        checkUpdateTimer.Start()
        btnGüncellemeKontrol.Enabled = False
    End Sub

    Private Sub btnGüncelle_Click(sender As Object, e As EventArgs) Handles btnGüncelle.Click
        Process.Start("Update.exe")
        End
    End Sub

    Private Sub CpuComboBox_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CpuComboBox.SelectedIndexChanged
        My.Settings.settingsCpuComboBox = CpuComboBox.Text
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub

    Private Sub steamTimer_Tick(sender As Object, e As EventArgs) Handles steamTimer.Tick
        My.Settings.settingsSteamGameCheck = SteamGameCheck.Checked
        My.Settings.settingsSteamProfilCheck = SteamProfilCheck.Checked
        My.Settings.settingsSteamLibraryCheck = SteamLibraryCheck.Checked
        My.Settings.settingsSteamProfileConnctionSwitch = SteamProfileConnctionSwitch.Checked
        If SteamGameCheck.Checked = True Or SteamProfilCheck.Checked = True Or SteamLibraryCheck.Checked = True Or SteamProfileConnctionSwitch.Checked = True Then
            SteamSwitch.Checked = True
        Else
            SteamSwitch.Checked = False
        End If
    End Sub

    Private Sub animatedTimer_Tick(sender As Object, e As EventArgs) Handles animatedTimer.Tick
        My.Settings.settingsAnimatedSwitch = AnimatedSwitch.Checked
        My.Settings.settingsTransitionAnimatedCheck = TransitionAnimatedCheck.Checked
        My.Settings.settingsButtonAnimatedCheck = ButtonAnimatedCheck.Checked
        My.Settings.settingsLoginAnimatedCheck = LoginAnimatedCheck.Checked
        My.Settings.settingsNotificationAnimatedCheck = NotificationAnimatedCheck.Checked
        If TransitionAnimatedCheck.Checked = True Or ButtonAnimatedCheck.Checked = True Or LoginAnimatedCheck.Checked = True Or NotificationAnimatedCheck.Checked = True Then
            AnimatedSwitch.Checked = True
        Else
            AnimatedSwitch.Checked = False
        End If
    End Sub

    Private Sub languageBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles languageBox.SelectedIndexChanged
        My.Settings.settingslanguageBox = languageBox.Text
    End Sub
End Class
