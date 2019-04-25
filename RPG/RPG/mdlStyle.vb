Module mdlStyle
    Public Function Style_label_Hover(ByVal lbl As Label)
        lbl.Font = New Font(lbl.Font.FontFamily, lbl.Font.Size, FontStyle.Underline)
    End Function

    Public Function Style_label_Leave(ByVal lbl As Label)
        lbl.Font = New Font(lbl.Font.FontFamily, lbl.Font.Size, FontStyle.Regular)
    End Function

    Public Function Style_label_CreateGG(ByVal changedLBL As Label, ByVal lbl As Label, ByVal lbl2 As Label)




        frmCreateGG.GGClass = changedLBL.Text
        changedLBL.ForeColor = Color.White

        lbl.ForeColor = Color.Black

        lbl2.ForeColor = Color.Black

    End Function
End Module
