Public Class frmMain

    Private Sub Label1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseHover
        Style_label_Hover(Label1)
    End Sub

    Private Sub Label1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Style_label_Leave(Label1)
    End Sub

    Private Sub Label2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseHover
        Style_label_Hover(Label2)
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Style_label_Leave(Label2)
    End Sub

    Private Sub Label3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseHover
        Style_label_Hover(Label3)
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Style_label_Leave(Label3)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        frmCreateGG.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        End
    End Sub
End Class
