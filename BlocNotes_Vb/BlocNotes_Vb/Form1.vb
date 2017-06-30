Imports System.IO
Imports System.Text

Public Class Form1

    Private Sub SélectionnerToutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SélectionnerToutToolStripMenuItem.Click
        TextBox1.SelectAll()

    End Sub

    Private Sub HeureDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HeureDateToolStripMenuItem.Click
        TextBox1.AppendText(Date.Now)

    End Sub

    Private Sub CopierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub CollerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollerToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        TextBox1.SelectedText = ""
    End Sub

    Private Sub AnnulerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnulerToolStripMenuItem.Click
        TextBox1.Undo()
    End Sub

    Private Sub PoliceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoliceToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        TextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub RetourAutomatiqueÀLaLigneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetourAutomatiqueÀLaLigneToolStripMenuItem.Click
        If RetourAutomatiqueÀLaLigneToolStripMenuItem.Checked = False Then
            TextBox1.WordWrap = True
            RetourAutomatiqueÀLaLigneToolStripMenuItem.Checked = True
            TextBox1.ScrollBars = ScrollBars.Vertical
        Else
            TextBox1.WordWrap = False
            RetourAutomatiqueÀLaLigneToolStripMenuItem.Checked = False
            TextBox1.ScrollBars = ScrollBars.Both
        End If

    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click

        If TextBox1.Text = "" Then
            Me.Close()
        Else
            Dim reponse As DialogResult = MsgBox("Voulez vous enregistrer les modifications?", vbQuestion + vbYesNo,
                                                    "Quitter")
            If reponse = DialogResult.Yes Then

                If SaveFileDialog1.ShowDialog = 1 Then
                    ' Create or overwrite the file.
                    Dim fs As FileStream = File.Create(SaveFileDialog1.FileName)

                    ' Add text to the file.
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(TextBox1.Text)
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                End If
                Me.Close()
            End If

        End If

    End Sub

    Private Sub ImprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimerToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem.Click
        If TextBox1.Text <> "" Then
            Dim reponse As DialogResult = MessageBox.Show("Voulez vous enregistrer les modifications effectuées ?",
                   "Nouveau",
                    MessageBoxButtons.YesNo)
            Select Case reponse
                Case DialogResult.Yes
                    If SaveFileDialog1.ShowDialog = 1 Then
                        subSave(SaveFileDialog1.FileName)
                    End If
                    TextBox1.Clear()
                Case DialogResult.No
                    TextBox1.Clear()
            End Select
        Else
            TextBox1.Clear()
        End If
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        If TextBox1.Text = "" Then
            If OpenFileDialog1.ShowDialog() = 1 Then
                subOpen(OpenFileDialog1.FileName)
            End If
        Else
            Dim reponse As DialogResult = MessageBox.Show("Voulez vous enregistrer les modifications effectuées ?",
                  "Ouvrir",
                   MessageBoxButtons.YesNo)
            Select Case reponse
                Case DialogResult.Yes
                    'SaveFileDialog1.ShowDialog()
                    If SaveFileDialog1.ShowDialog = 1 Then
                        subSave(SaveFileDialog1.FileName)
                    End If
                    TextBox1.Clear()
                    If OpenFileDialog1.ShowDialog() = 1 Then
                        subOpen(OpenFileDialog1.FileName)
                    End If
                Case DialogResult.No
                    TextBox1.Clear()
                    OpenFileDialog1.ShowDialog()
                    If OpenFileDialog1.ShowDialog() = 1 Then
                        subOpen(OpenFileDialog1.FileName)
                    End If
            End Select

        End If
    End Sub
    Private Sub subSave(path As String)
        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)
        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(TextBox1.Text)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
    Private Sub subOpen(path As String)
        Try
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(path, System.Text.Encoding.UTF8)
            TextBox1.Text = fileReader
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub RechercherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RechercherToolStripMenuItem.Click
        FrmRecherche.Show()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        MsgBox("Réalisé par Yasser sbai le 30/10/2016", vbInformation + vbOK, "yasser_sbai1@yahoo.fr")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SaveFileDialog1.Filter = "Text File |*.txt"
        SaveFileDialog1.Title = "Enregistrement du fichier"

        OpenFileDialog1.Filter = "Text File |*.txt"
        OpenFileDialog1.Title = "Enregistrement du fichier"
        OpenFileDialog1.Multiselect = False
    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog() = 1 Then
            subSave(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub AtteindreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtteindreToolStripMenuItem.Click
        Dim text As String = InputBox("Entrer le texte que vous voulez atteindre", "Atteindre")
        Dim val As Integer = InStr(1, TextBox1.Text, text)
        If val <> 0 Then
            Me.TextBox1.Select(val - 1, text.Length)
        End If
    End Sub
End Class
