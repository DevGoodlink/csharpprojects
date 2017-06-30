Public Class dessin
    Dim pd As Point
    Dim mypen As New Pen(Color.Red)
    Dim shape As Integer = 0



    Private Sub pb_MouseDown(sender As Object, e As MouseEventArgs)

        pd.X = e.X
        pd.Y = e.Y
        'MsgBox(e.X & e.Y)
    End Sub

    Private Sub pb_MouseMove(sender As Object, e As MouseEventArgs)
        Dim g As Graphics = Me.pb.CreateGraphics()
        Dim pa As New Point(e.X, e.Y)
        If pb.Capture Then
            If shape = 0 Then

                g.DrawLine(mypen, pd, pa)
                pd = pa
            End If
            'If shape = 1 Then
            '    Dim r As New Rectangle(pd.X, pd.Y, pa.X - pd.X, pa.Y - pd.Y)
            '    Dim mypen2 As New Pen(Color.White, 2)
            '    g.DrawEllipse(mypen, r)
            '    g.DrawEllipse(mypen2, r)
            '    'Case shape = 2
            '    'Exit Select
            '    'Case shape = 3
            '    'Exit Select
            '    'Case shape = 4
            '    'Exit Select

            'End If
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ColorDialog1.ShowDialog()
        mypen.Color = ColorDialog1.Color
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)
        lblThick.Height = NumericUpDown1.Value
        mypen.Width = NumericUpDown1.Value
    End Sub

    Private Sub lblWhite_Click(sender As Object, e As EventArgs)
        changerCouleur(lblWhite)
    End Sub
    Private Sub changerCouleur(l As Label)
        mypen.Color = l.BackColor
    End Sub
    Private Sub changerCouleur(c As Color)
        mypen.Color = c
    End Sub

    Private Sub lblBlack_Click(sender As Object, e As EventArgs)
        changerCouleur(lblBlack)
    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs)
        changerCouleur(lbl1)
    End Sub

    Private Sub lbl2_Click(sender As Object, e As EventArgs)
        changerCouleur(lbl2)
    End Sub

    Private Sub lbl3_Click(sender As Object, e As EventArgs)
        changerCouleur(lbl3)
    End Sub

    Private Sub lbl4_Click(sender As Object, e As EventArgs)
        changerCouleur(lbl4)
    End Sub

    Private Sub lbl5_Click(sender As Object, e As EventArgs)
        changerCouleur(lbl5)
    End Sub

    Private Sub lbl6_Click(sender As Object, e As EventArgs)
        changerCouleur(lbl6)
    End Sub

    Private Sub lbl7_Click(sender As Object, e As EventArgs)
        changerCouleur(lbl7)
    End Sub

    Private Sub lbl8_Click(sender As Object, e As EventArgs)
        changerCouleur(lbl8)
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs)
        ColorDialog1.ShowDialog()
        changerCouleur(ColorDialog1.Color)
    End Sub

    Private Sub r2_CheckedChanged(sender As Object, e As EventArgs)
        shape = 1
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        shape = 0
    End Sub

    Private Sub r3_CheckedChanged(sender As Object, e As EventArgs)
        shape = 2
    End Sub

    Private Sub r4_CheckedChanged(sender As Object, e As EventArgs)
        shape = 3
    End Sub

    Private Sub r1_CheckedChanged(sender As Object, e As EventArgs)
        shape = 4
    End Sub

    Private Sub dessin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class