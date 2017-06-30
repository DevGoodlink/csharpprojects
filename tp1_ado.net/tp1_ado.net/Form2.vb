Imports System.Threading

Public Class Form2
    Private retour As Long = 0
    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        ColorDialog1.ShowDialog()
        TextBox1.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub btnLower_Click(sender As Object, e As EventArgs) Handles btnLower.Click
        TextBox1.Text = TextBox1.Text.ToLower()
    End Sub

    Private Sub btnPolice_Click(sender As Object, e As EventArgs) Handles btnPolice.Click
        FontDialog1.ShowDialog()
        TextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub btnUpper_Click(sender As Object, e As EventArgs) Handles btnUpper.Click
        TextBox1.Text = TextBox1.Text.ToUpper()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox(TextBox1.Text.Length())
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim chaine As String = InputBox("Entrer une valeur que vous chercher", "Recherche")
        Dim origine As String = TextBox1.Text

        Dim pos As Integer = InStr(TextBox1.Text, chaine)
        If pos = 0 Then
            MsgBox("Recherche infructueuse", "Essayer encore!")
            Exit Sub
        End If

        Dim position = pos
        While position <> 0
            retour = MessageBox.Show("Plusieurs occurences trouvées, afficher le suivant?", "Recherche", MessageBoxButtons.YesNo)
            If retour = vbNo Then
                Exit Sub
            Else
                TextBox1.Select()
                TextBox1.Select(position - 1, chaine.Length)
                position = InStr(position + chaine.Length, origine, chaine)
            End If
        End While

    End Sub

End Class