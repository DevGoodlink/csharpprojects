Public Class Form1
    Private Sub chkBMutli_CheckedChanged(sender As Object, e As EventArgs) Handles chkBMutli.CheckedChanged
        If chkBMutli.Checked Then
            lstRight.SelectionMode = SelectionMode.MultiSimple
            lstLeft.SelectionMode = SelectionMode.MultiSimple
        Else
            lstRight.SelectionMode = SelectionMode.One
            lstLeft.SelectionMode = SelectionMode.One
        End If
    End Sub

    Private Sub btnToLeft_Click(sender As Object, e As EventArgs) Handles btnToLeft.Click
        If lstRight.SelectedIndex <> -1 Then
            lstLeft.Items.Add(lstRight.SelectedItem)


        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtValeur.Text <> "" Then
            lstLeft.Items.Add(txtValeur.Text)
        End If
    End Sub

    Private Sub btnToRight_Click(sender As Object, e As EventArgs) Handles btnToRight.Click
        Dim index = lstLeft.SelectedIndex
        'Dim elt As String
        If index <> -1 Then
            If lstLeft.SelectedItems.Count > 1 Then
                'For i = 0 To lstLeft.SelectedItems.Count - 1
                '    lstRight.Items.Add(lstLeft.SelectedItems(i))
                '    lstLeft.Items.Remove(lstLeft.SelectedItems(i))
                'Next i
                'For Each elt In lstLeft.SelectedItems
                'lstRight.Items.Add(elt)

                'lstLeft.Items.Remove()
                ' Next
                Dim temp(lstLeft.SelectedItems.Count) As String
                Dim i = 0
                For Each elt In lstLeft.SelectedItems
                    lstRight.Items.Add(elt)

                    temp(i) = elt
                    i += 1
                Next
                lstRight.Items.Add(temp)
            Else

                lstRight.Items.Add(lstLeft.SelectedItem)

                lstLeft.Items.Remove(lstLeft.SelectedItems)


            End If
        Else
            MsgBox("Veuillez sélectionner au moins un élément")

        End If



    End Sub
    Private Sub toRight(tabValeur As String)
        lstRight.Items.Add(tabValeur)
    End Sub
End Class
