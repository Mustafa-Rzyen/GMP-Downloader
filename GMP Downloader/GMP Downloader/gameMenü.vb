Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Linq

Public Class gameMenü

    Private Sub gameMenü_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(Panel1, GunaVScrollBar1, True)
    End Sub
End Class
