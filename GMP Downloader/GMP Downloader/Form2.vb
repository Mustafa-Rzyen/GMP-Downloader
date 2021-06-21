Public Class Form2
    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub

    Private Sub btnOnayla_Click(sender As Object, e As EventArgs) Handles btnOnayla.Click
        If keyText.Text = "GMPKEY+ij+SqbedBimwpLpjj9wTkzC20F3RJ7Ls1NU" Then
            Select Case MessageBox.Show("Tebrikler, Adminlik anahtarın başarıyla aktif edildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Case DialogResult.OK
                    My.Settings.textSave = keyText.Text
                    Panel4.Visible = True
            End Select
        Else
            Select Case MessageBox.Show("The key you entered is in invalid state", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Case DialogResult.OK
            End Select
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        keyText.Text = My.Settings.textSave
        If keyText.Text = "GMPKEY+ij+SqbedBimwpLpjj9wTkzC20F3RJ7Ls1NU" Then
            Label1.Text = "GMPKEY+ij+SqbedBimwpLpjj9wTkzC20F3RJ7Ls1NU"
            Panel4.Visible = True
        Else
            Panel4.Visible = False
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub btnKapat2_Click(sender As Object, e As EventArgs) Handles btnKapat2.Click
        Me.Close()
    End Sub

    Private Sub btnOnayla2_Click(sender As Object, e As EventArgs) Handles btnOnayla2.Click
        Panel4.Visible = False
    End Sub
End Class