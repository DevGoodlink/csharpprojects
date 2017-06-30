Imports System.ComponentModel

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData("VEHICULE")
        DataGridView1.DataSource = objetDataTable
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row As Integer
        Dim imm, modele, couleur As String
        Dim strSql As String
        row = DataGridView1.CurrentRow.Index
        imm = DataGridView1(0, row).Value
        modele = DataGridView1(1, row).Value
        couleur = DataGridView1(2, row).Value
        strSql = "insert into vehicule values('" & imm & "','" & modele & "','" & couleur & "')"
        runSql(strSql)
        loadData("vehicule")
        DataGridView1.DataSource = objetDataTable
    End Sub


End Class