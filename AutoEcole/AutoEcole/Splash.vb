Public Class Splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Interval = 4000 Then
            Timer1.Stop()
        Else

            If Label1.Text = "Connexion..." Then
                Label1.Text = "Connexion"
            Else
                Label1.Text = Label1.Text & "."
            End If
        End If
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        'frmAccueil.ActiveForm.Show()
    End Sub

    Private Sub Splash_Click(sender As Object, e As EventArgs) Handles Me.Click
        OnClosed(e)


    End Sub

    Private Sub Splash_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmAccueil.ActiveForm.Show()
    End Sub
End Class