Public Class frmAccueil

    Dim i As Integer = 0
    Dim save As Boolean = False



    Sub mouvement(i As Integer)
        TextBox1.Text = objetDataTable.Rows(i).Item(0) 'immatriculation
        TextBox2.Text = objetDataTable.Rows(i).Item(1) 'modele
        TextBox3.Text = objetDataTable.Rows(i).Item(2) 'couleur
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mouvement(0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If i = objetDataTable.Rows.Count - 1 Then
            MsgBox("Vous avez atteint la fin de la liste", vbInformation, "Fin de la liste")
        Else
            i += 1
            mouvement(i)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If i = 0 Then
            MsgBox("Vous avez atteint la début de la liste", vbInformation, "Début de la liste")
        Else
            i -= 1
            mouvement(i)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        mouvement(objetDataTable.Rows.Count - 1)
    End Sub

    Private Sub frmAccueil_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData("VEHICULE")
        'la table véhicule est chargé dans objetDataTable
        mouvement(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox1.BackColor = Color.White
        TextBox2.Text = ""
        TextBox2.BackColor = Color.White
        TextBox3.Text = ""
        TextBox3.BackColor = Color.White
        save = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If save Then
            If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then
                If runSql("insert into VEHICULE values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')") Then
                    MsgBox("Mise à jour effectuée avec succées", vbExclamation, "Mise à jour")
                    TextBox1.BackColor = Color.Gray
                    TextBox2.BackColor = Color.Gray
                    TextBox3.BackColor = Color.Gray
                    save = False
                End If

            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim listeVehicules = New Form3()
        listeVehicules.MdiParent = Form2
        listeVehicules.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If MsgBox("Voulez vous supprimer les informations sur ce véhicule?", vbQuestion + vbYesNo, "Suppression") = vbYes Then
            runSql("delete from vehicule where numImma = '" & TextBox1.Text & "'")
            loadData("vehicule")
            mouvement(i)
        End If
    End Sub
End Class
