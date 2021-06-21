Public Class Haberler
    Private Sub Haberler_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(Panel1, GunaVScrollBar1, True)
    End Sub

    Private Sub btnNews1_Click(sender As Object, e As EventArgs) Handles btnNews1.Click
        Process.Start("https://www.youtube.com/watch?v=UwJAAy7tPhE")
    End Sub

    Private Sub btnNews2_Click(sender As Object, e As EventArgs) Handles btnNews2.Click
        Process.Start("https://www.youtube.com/watch?v=O3V4UBZmC9o")
    End Sub

    Private Sub btnNews3_Click(sender As Object, e As EventArgs) Handles btnNews3.Click
        Process.Start("https://www.youtube.com/watch?v=VbF6REQyel4")
    End Sub

    Private Sub btnNews4_Click(sender As Object, e As EventArgs) 
        Process.Start("")
    End Sub

    Private Sub btnNews5_Click(sender As Object, e As EventArgs) 
        Process.Start("")
    End Sub

    Private Sub btnUpdateNote_Click(sender As Object, e As EventArgs) Handles btnUpdateNote.Click
        HideAnimasyon.HideSync(Form1.Panel4)
        HideAnimasyon.HideSync(Form1.GameMenü1)
        HideAnimasyon.HideSync(Form1.IndirmeleriYönet1)
        HideAnimasyon.HideSync(Form1.ProfilDetay1)
        HideAnimasyon.HideSync(Form1.AyarlarMenü2)
        HideAnimasyon.HideSync(Form1.Haberler1)
        ShowAnimasyon.ShowSync(Form1.UpdateNotes1)
    End Sub
End Class
