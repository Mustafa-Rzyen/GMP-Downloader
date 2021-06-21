Imports System.ComponentModel
Imports System.IO
Imports System.Net

Public Class bekleyenGüncellemeler
    Private Sub bekleyenGüncellemeler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable = True Then
            If duyuruUpdateLabel.Text = "1" Then
                uyarıLabel.Visible = True
                uyarıBox.Visible = True
            Else

            End If

            If newVersionLabel.Text = "8" Then

            Else
                uyarıLabel.Text = "Yeni kullanılabilir Kurulum mevcut lütfen en kısa sürede kurun."
                uyarıLabel.ForeColor = Color.SpringGreen
            End If
        Else
            uyarıLabel.Visible = False
            uyarıBox.Visible = False
        End If
    End Sub

    Private Sub notLink1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles notLink1.LinkClicked
        HideAnimasyon.HideSync(Form1.IndirmeleriYönet1)
        HideAnimasyon.HideSync(Form1.Panel4)
        HideAnimasyon.HideSync(Form1.BekleyenGüncellemeler1)
        HideAnimasyon.HideSync(Form1.AyarlarMenü2)
        HideAnimasyon.HideSync(Form1.ProfilDetay1)
        HideAnimasyon.HideSync(Form1.GameMenü1)
        HideAnimasyon.HideSync(Form1.Haberler1)
        ShowAnimasyon.ShowSync(Form1.UpdateNotes1)
    End Sub

    Private Sub OnDownloadComplete(sender As Object, e As AsyncCompletedEventArgs)
        If e.Error Is Nothing Then
            BoyutLabel.Visible = False
            yüzeLabel.Visible = False
            DownloadProgress.Visible = False
            btnDownload1.Enabled = True
        Else

        End If
    End Sub

    Private Sub ShowDownloadProgress(sender As Object, e As DownloadProgressChangedEventArgs)
        Try
            BoyutLabel.Visible = True
            yüzeLabel.Visible = True
            DownloadProgress.Visible = True
            btnDownload1.Enabled = False
            DownloadProgress.Position = e.ProgressPercentage
            yüzeLabel.Text = "% " & e.ProgressPercentage
            BoyutLabel.Text = String.Format("{0} MB", (e.BytesReceived / 1024D / 1024D).ToString("0.00"))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub versionLinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LauncherUİOnDownloadComplete(sender As Object, e As AsyncCompletedEventArgs)
        If e.Error Is Nothing Then
            BoyutLabel2.Visible = False
            yüzeLabel2.Visible = False
            DownloadProgress2.Visible = False
            btnDownload2.Enabled = True
        Else

        End If
    End Sub

    Private Sub LauncherUİDownloadProgress(sender As Object, e As DownloadProgressChangedEventArgs)
        Try
            BoyutLabel2.Visible = True
            yüzeLabel2.Visible = True
            DownloadProgress2.Visible = True
            btnDownload2.Enabled = False
            DownloadProgress2.Position = e.ProgressPercentage
            yüzeLabel2.Text = "% " & e.ProgressPercentage
            BoyutLabel2.Text = String.Format("{0} MB", (e.BytesReceived / 1024D / 1024D).ToString("0.00"))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDownload1_Click(sender As Object, e As EventArgs) Handles btnDownload1.Click
        Dim PackFile As Boolean = File.Exists("Setup\GMP Setup.exe")
        If PackFile = True Then
            If btnDownload1.Text = "Çalıştır" Then
                Try
                    Process.Start("Setup\GMP Setup.exe")
                Catch ex As Exception

                End Try
            Else
                btnDownload1.Text = "Download"
            End If
        Else
            My.Computer.FileSystem.CreateDirectory("Setup")
            Dim client1 As New WebClient
            AddHandler client1.DownloadProgressChanged, AddressOf ShowDownloadProgress
            AddHandler client1.DownloadFileCompleted, AddressOf OnDownloadComplete
            client1.DownloadFileAsync(New Uri("https://www.dropbox.com/s/1wg3xgb5n8hn0g6/GMP%20Setup.exe?dl=1"), "Setup\GMP Setup.exe")
        End If
    End Sub

    Private Sub btnDownload2_Click(sender As Object, e As EventArgs) Handles btnDownload2.Click
        Dim PackFile As Boolean = File.Exists("Launcher Uİ\Launcher Uİ.exe")
        If PackFile = True Then
            If btnDownload2.Text = "Çalıştır" Then
                Try
                    Process.Start("Launcher Uİ\Launcher Uİ.exe")
                Catch ex As Exception

                End Try
            Else
                btnDownload2.Text = "Download"
            End If
        Else
            My.Computer.FileSystem.CreateDirectory("Launcher Uİ")
            Dim client1 As New WebClient
            AddHandler client1.DownloadProgressChanged, AddressOf LauncherUİDownloadProgress
            AddHandler client1.DownloadFileCompleted, AddressOf LauncherUİOnDownloadComplete
            client1.DownloadFileAsync(New Uri("https://www.dropbox.com/s/t29f1uy1si20orn/Launcher%20U%C4%B0.exe?dl=1"), "Launcher Uİ\Launcher Uİ.exe")
        End If
    End Sub

    Private Sub fileTimer_Tick(sender As Object, e As EventArgs) Handles fileTimer.Tick
        Dim PackFile As Boolean = File.Exists("Setup\GMP Setup.exe")
        If PackFile = True Then
            btnDownload1.Text = "Çalıştır"
        Else
            btnDownload1.Text = "Download"
        End If

        Dim PackFile1 As Boolean = File.Exists("Launcher Uİ\Launcher Uİ.exe")
        If PackFile1 = True Then
            btnDownload2.Text = "Çalıştır"
        Else
            btnDownload2.Text = "Download"
        End If
    End Sub
End Class
