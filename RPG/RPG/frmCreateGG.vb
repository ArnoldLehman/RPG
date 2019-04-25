Public Class frmCreateGG
    Public GGClass As String

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Style_label_CreateGG(Label2, Label1, Label3)
    End Sub

    Private Sub Label2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseHover
        Style_label_Hover(Label2)
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Style_label_Leave(Label2)
    End Sub



    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Style_label_CreateGG(Label1, Label3, Label2)
    End Sub

    Private Sub Label1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseHover
        Style_label_Hover(Label1)
    End Sub

    Private Sub Label1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Style_label_Leave(Label1)
    End Sub



    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Style_label_CreateGG(Label3, Label1, Label2)
    End Sub

    Private Sub Label3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseHover
        Style_label_Hover(Label3)
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Style_label_Leave(Label3)
    End Sub



    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click


        frmGGStats.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class