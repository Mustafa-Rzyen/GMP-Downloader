Public Class indirmeleriYönet
    Private Sub indirmeleriYönet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub panelTimer_Tick(sender As Object, e As EventArgs) Handles panelTimer.Tick
        If downloadPanel.Visible = True Then
            bilgiLabel.Visible = False
        Else
            bilgiLabel.Visible = True
        End If
    End Sub
End Class
