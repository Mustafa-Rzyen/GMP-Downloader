Public Class adminForm
    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If My.Computer.Network.IsAvailable = True Then
                Timer1.Start()
            Else
                Select Case MessageBox.Show("Mevcut bağlantınızda sorun bulunuyor.

Lütfen bu adımları uygulayın,

-Ağ Bağlantı ayarlarını sıfırlayın.
-DNS Ayarlarınızı kontrol edin.
-Modem ayarlarınızı sıfırlayın.
-Bağlantı ayarlarını gözden geçirin.

Bu adımları uygulamanız sorununuza çözüm olacaktır
Çevrim dışı mod aktif kullanılacak.", "Bağlantı Problemi", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case DialogResult.OK
                        Timer1.Start()
                        Me.Show()
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
                Me.Hide()
                Form1.Show()
            Else
                Label3.Text = "Hata Kodu : 0x14c8q2"
                animated.HideSync(Panel4)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim procStartInfo As New ProcessStartInfo
        Dim procExecuting As New Process

        With procStartInfo
            .UseShellExecute = True
            .FileName = "GMP Downloader.exe"
            .WindowStyle = ProcessWindowStyle.Normal
            .Verb = "runas" 'add this to prompt for elevation
        End With
        procExecuting = Process.Start(procStartInfo)
        End
    End Sub

    Private Sub GunaAdvenceButton11_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton11.Click
        Me.Close()
    End Sub

    Private Sub adminCheck_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class