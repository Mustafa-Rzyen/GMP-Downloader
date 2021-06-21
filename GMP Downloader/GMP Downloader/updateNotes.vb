Public Class updateNotes
    Private Sub updateNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(Panel1, GunaVScrollBar1, True)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If Form1.btnAnaMenü.Checked = True Then
            HideAnimasyon.HideSync(Form1.UpdateNotes1)
            HideAnimasyon.HideSync(Form1.GameMenü1)
            HideAnimasyon.HideSync(Form1.IndirmeleriYönet1)
            HideAnimasyon.HideSync(Form1.BekleyenGüncellemeler1)
            HideAnimasyon.HideSync(Form1.ProfilDetay1)
            HideAnimasyon.HideSync(Form1.AyarlarMenü2)
            HideAnimasyon.HideSync(Form1.Panel4)
            ShowAnimasyon.ShowSync(Form1.Haberler1)
        Else

        End If

        If Form1.btnMenü.Checked = True Then
            HideAnimasyon.HideSync(Form1.UpdateNotes1)
            HideAnimasyon.HideSync(Form1.GameMenü1)
            HideAnimasyon.HideSync(Form1.IndirmeleriYönet1)
            HideAnimasyon.HideSync(Form1.BekleyenGüncellemeler1)
            HideAnimasyon.HideSync(Form1.ProfilDetay1)
            HideAnimasyon.HideSync(Form1.AyarlarMenü2)
            HideAnimasyon.HideSync(Form1.Haberler1)
            ShowAnimasyon.ShowSync(Form1.Panel4)
        Else

        End If

        If Form1.btnAyarlar.Checked = True Then
            HideAnimasyon.HideSync(Form1.UpdateNotes1)
            HideAnimasyon.HideSync(Form1.Panel4)
            HideAnimasyon.HideSync(Form1.IndirmeleriYönet1)
            HideAnimasyon.HideSync(Form1.BekleyenGüncellemeler1)
            HideAnimasyon.HideSync(Form1.ProfilDetay1)
            HideAnimasyon.HideSync(Form1.GameMenü1)
            HideAnimasyon.HideSync(Form1.Haberler1)
            ShowAnimasyon.ShowSync(Form1.AyarlarMenü2)
        Else

        End If

        If Form1.btnGüncellemePaketleri.Checked = True Then
            HideAnimasyon.HideSync(Form1.UpdateNotes1)
            HideAnimasyon.HideSync(Form1.Panel4)
            HideAnimasyon.HideSync(Form1.IndirmeleriYönet1)
            HideAnimasyon.HideSync(Form1.AyarlarMenü2)
            HideAnimasyon.HideSync(Form1.ProfilDetay1)
            HideAnimasyon.HideSync(Form1.GameMenü1)
            HideAnimasyon.HideSync(Form1.Haberler1)
            ShowAnimasyon.ShowSync(Form1.BekleyenGüncellemeler1)
        Else

        End If

        If Form1.btnİndirmeleriYönet.Checked = True Then
            HideAnimasyon.HideSync(Form1.UpdateNotes1)
            HideAnimasyon.HideSync(Form1.Panel4)
            HideAnimasyon.HideSync(Form1.BekleyenGüncellemeler1)
            HideAnimasyon.HideSync(Form1.AyarlarMenü2)
            HideAnimasyon.HideSync(Form1.ProfilDetay1)
            HideAnimasyon.HideSync(Form1.GameMenü1)
            HideAnimasyon.HideSync(Form1.Haberler1)
            ShowAnimasyon.ShowSync(Form1.IndirmeleriYönet1)
        Else

        End If
    End Sub
End Class
