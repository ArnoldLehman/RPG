Imports System.Data.OleDb
Imports System.Data

Public Class frmGGStats

    'Атрибуты
    Public Strength As Integer
    Public Agility As Integer
    Public Endurance As Integer
    Public Vera As Integer
    Public Cunning As Integer

    'Характеристики
    Public Attack As Integer
    Public Evasion As Integer
    Public FizDef As Integer

    Public NickName As String


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        frmCreateGG.Show()
        Me.Close()
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        NickName = TextBox1.Text

        Try
            Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb")
            Dim insert As String = "Insert into GG values('" & frmCreateGG.GGClass & "','" & NickName & "');"
            Dim cmd As New OleDbCommand(insert, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        frmFight_in_Arena.Show()
        frmCreateGG.Close()
        Me.Close()
    End Sub

    Private Sub frmGGStats_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If frmCreateGG.GGClass = "Монах" Then
            Strength = 3
            Agility = 5
            Endurance = 3
            Vera = 7
            'TODO: Что делать с "Хитростью" у монахов и верой у Знати

            lblSila.Text = Strength
            lblLovk.Text = Agility
            lblVin.Text = Endurance
            lblHorV.Text = Vera

            lblStatHorV.Text = "Вера"
        ElseIf frmCreateGG.GGClass = "Знать" Then
            Strength = 2
            Agility = 7
            Endurance = 3
            Cunning = 6

            lblSila.Text = Strength
            lblLovk.Text = Agility
            lblVin.Text = Endurance
            lblHorV.Text = Cunning

            lblStatHorV.Text = "Хитрость"
        ElseIf frmCreateGG.GGClass = "Чернь" Then
            Strength = 3
            Agility = 3
            Endurance = 3
            Cunning = 3

            lblSila.Text = Strength
            lblLovk.Text = Agility
            lblVin.Text = Endurance
            lblHorV.Text = Cunning

            lblStatHorV.Text = "Хитрость"
        End If
    End Sub
End Class