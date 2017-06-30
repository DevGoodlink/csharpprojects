Public Class frmEleves
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nom, prenom, adresse As String
        Dim dateins As DateTime
        Dim forfait As Integer
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox2.Text <> "" And cmbForfaitHoraire.SelectedIndex <> -1 Then
            If Convert.ToDateTime(DateTimePicker1.Value) > Now Then
                MsgBox("Veuillez corriger la date d'inscription", vbExclamation, "Date d'inscription supérieur")
            Else
                nom = TextBox1.Text
                prenom = TextBox2.Text
                adresse = TextBox3.Text
                dateins = Convert.ToDateTime(DateTimePicker1.Value)
                forfait = Convert.ToInt32(cmbForfaitHoraire.Text)
                connect()
                objetCommand = New SqlClient.SqlCommand("pEleve_INSERT", objetConnexion)
                objetCommand.CommandType = CommandType.StoredProcedure
                objetCommand.Parameters.Add("@nom", SqlDbType.NVarChar)
                objetCommand.Parameters("@nom").Direction = ParameterDirection.Input
                objetCommand.Parameters("@nom").Value = nom

                objetCommand.Parameters.Add("@dateInscription", SqlDbType.SmallDateTime)
                objetCommand.Parameters("@dateInscription").Direction = ParameterDirection.Input
                objetCommand.Parameters("@dateInscription").Value = dateins

                objetCommand.Parameters.Add("@prenom", SqlDbType.NVarChar)
                objetCommand.Parameters("@prenom").Direction = ParameterDirection.Input
                objetCommand.Parameters("@prenom").Value = prenom

                objetCommand.Parameters.Add("@adresse", SqlDbType.NVarChar)
                objetCommand.Parameters("@adresse").Direction = ParameterDirection.Input
                objetCommand.Parameters("@adresse").Value = adresse

                objetCommand.Parameters.Add("@creditHoraire", SqlDbType.Int)
                objetCommand.Parameters("@creditHoraire").Direction = ParameterDirection.Input
                objetCommand.Parameters("@creditHoraire").Value = forfait
                Dim rows As Integer = objetCommand.ExecuteNonQuery()
                If rows > 0 Then
                    MsgBox("Enregistrement avec succés", vbInformation, "Enregistrement")
                End If

            End If
        End If
    End Sub
End Class