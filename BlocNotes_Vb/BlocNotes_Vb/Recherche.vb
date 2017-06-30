Public Class FrmRecherche
    Dim occurence As New List(Of Integer)
    Dim i As Integer = 0
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim chaine As String
        Dim origine As String
        If IsNothing(txtRecherche.Text) Or IsNothing(Form1.TextBox1.Text) Then
            MsgBox("Veuillez entrer du texte dans les champs correspondants pour pouvoir effectuer la recherche", vbOK, "Recherche")
            Exit Sub
        End If
        If chkBxCasse.Checked Then
            chaine = txtRecherche.Text
            origine = Form1.TextBox1.Text
        Else
            chaine = txtRecherche.Text.ToLower
            origine = Form1.TextBox1.Text.ToLower
        End If

        If occurence.Count > 0 And i <= occurence.Count Then
            If Not i >= occurence.Count Then
                Form1.TextBox1.Select()
                Form1.TextBox1.Select(occurence(i) - 1, chaine.Length)
                i += 1
            Else
                occurence.Clear()
            End If
            Exit Sub
        Else
            If InStr(origine, chaine) = 0 Then
                MsgBox("Recherche infructueuse", vbOK, "Essayer encore!")
                Exit Sub
            Else
                stockerLesOccurences(chaine, origine)
                btnNext_Click(sender, e)
            End If
        End If
    End Sub
    Sub stockerLesOccurences(chaine As String, origine As String)
        Dim position As Integer = InStr(1, origine, chaine)
        While InStr(position, origine, chaine) <> 0
            occurence.Add(InStr(position, origine, chaine))
            position = occurence.Last + chaine.Length
        End While
    End Sub
End Class