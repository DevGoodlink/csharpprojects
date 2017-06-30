Public Class Form1
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtDesignation.Text = ""
        txtPu.Text = ""
        txtQte.Text = ""
        lstDesignation.Items.Clear()
        lstPt.Items.Clear()
        LstQte.Items.Clear()
        lstPu.Items.Clear()
        txtDesignation.Select()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim tva As Double


        If rbNormal.Checked Then
            tva = 1.2
        Else
            tva = 1.055
        End If
        If Not IsNumeric(txtPu.Text) Or Not IsNumeric(txtQte.Text) Then
        Else
            lstDesignation.Items.Add(txtDesignation.Text)
            lstPu.Items.Add(txtPu.Text)
            LstQte.Items.Add(txtQte.Text)
            lstPt.Items.Add((Convert.ToDouble(txtPu.Text) * Convert.ToDouble(txtQte.Text)) * tva)
            lblTotalFacture.Text = Convert.ToDouble(IIf(lblTotalFacture.Text = "", 0, lblTotalFacture.Text)) + lstPt.Items.Item(lstPt.Items.Count - 1)
        End If
    End Sub



    Private Sub txtPu_Leave(sender As Object, e As EventArgs) Handles txtPu.Leave
        If Not check(txtPu) And txtPu.Text <> "" Then
            'MsgBox(check(txtPu))

            MsgBox("Veuillez entrer des valeurs numériques", vbOK + vbExclamation, "Erreur")
            txtPu.Text = ""
        End If
    End Sub
    Private Function check(txt As TextBox) As Boolean
        If Not IsNumeric(txt.Text) Then
            check = False
        Else
            check = True
        End If
    End Function

    Private Sub txtQte_Leave(sender As Object, e As EventArgs) Handles txtQte.Leave
        If Not check(txtQte) And txtQte.Text <> "" Then
            MsgBox("Veuillez entrer des valeurs numériques", vbOK + vbExclamation, "Erreur")
            txtQte.Text = ""
        End If
    End Sub

    Private Sub txtDesignation_Leave(sender As Object, e As EventArgs) Handles txtDesignation.Leave
        If txtDesignation.Text = "" And txtPu.Text <> "" And txtQte.Text <> "" Then
            MsgBox("Veuillez entrer une désignation svp!!", vbOK + vbInformation, "Erreur de désignation")
            txtDesignation.Select()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Voulez vous vraiment quitter?", vbYesNo + vbQuestion, "Fermeture") = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
