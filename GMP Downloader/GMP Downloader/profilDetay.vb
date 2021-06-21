Public Class profilDetay
    Dim vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Private Sub profilDetay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(Panel2, GunaVScrollBar1, True)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub userImage_Click(sender As Object, e As EventArgs) Handles userImage.Click

    End Sub

    Private Sub btnOnayla_Click(sender As Object, e As EventArgs) Handles btnOnayla.Click
        Try
            userNameID.Text = userNameText.Text
            Form1.pcID.Text = userNameText.Text
            My.Settings.pcUserName = userNameText.Text
            My.Settings.pcMail = userMailText.Text
            HideAnimasyon.HideSync(profilEditPanel)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ShowAnimasyon.ShowSync(profilEditPanel)

    End Sub

    Private Sub btnİptal_Click(sender As Object, e As EventArgs) Handles btnİptal.Click
        HideAnimasyon.HideSync(profilEditPanel)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) 
        Form2.Show()
    End Sub

    Private Sub btnImageUpload_Click(sender As Object, e As EventArgs) Handles btnImageUpload.Click
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
                    userImage2.Image = Nothing
                    Form1.userImage.Image = Nothing
                    Using MS As New IO.MemoryStream(Convert.FromBase64String(My.Settings.ımage))
                        userImage.Image = Image.FromStream(MS)
                        userImage2.Image = Image.FromStream(MS)
                        Form1.userImage.Image = Image.FromStream(MS)
                    End Using

                End If
            End If
        End Using
    End Sub
End Class
