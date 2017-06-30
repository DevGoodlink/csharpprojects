Public Class Form2
    Dim frmVehicule, frmEleves1

    'Public connexion As SqlClient.SqlConnection

    Private Sub NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NToolStripMenuItem.Click
        If ConnexionToolStripMenuItem.Checked Then
            frmVehicule = New frmAccueil()
            frmVehicule.MdiParent = Me
            frmVehicule.Show()
        End If

    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Dispose()

    End Sub

    Private Sub ConnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnexionToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        If connect() = True Then
            ConnexionToolStripMenuItem.Checked = True
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        If ConnexionToolStripMenuItem.Checked Then
            frmEleves1 = New frmEleves()
            frmEleves1.MdiParent = Me
            frmEleves1.Show()
        End If

    End Sub
End Class