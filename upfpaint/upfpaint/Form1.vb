Public Class Form1
    Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Black)
    Dim g As Graphics
    Dim r, l, h As Integer
    Dim clicked As Boolean = False
    Dim bmp As Bitmap

    Private Sub DrawEllipse(x As Integer, y As Integer)
        If r > 1 Then
            g.DrawEllipse(myPen, x, y, r, r)
        End If
    End Sub

    Private Sub DrawRectangle(x As Integer, y As Integer)
        If l > 1 And h > 1 Then
            g.DrawRectangle(myPen, New Rectangle(x, y, l, h))
            PictureBox1.Image = bmp
        End If
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        ColorDialog1.ShowDialog()
        myPen.Color = ColorDialog1.Color
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If clicked Then
            If rbLibre.Checked Then
                Static dp As New Point(e.X, e.Y)
                g.DrawLine(myPen, dp, New Point(e.X, e.Y))
                dp = New Point(e.X, e.Y)
            End If
            PictureBox1.Image = bmp
        End If
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        'g.Clear(Color.AliceBlue)
        PictureBox1.Image = bmp
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        clicked = False

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        clicked = True
        If rbRectangle.Checked Then
            DrawRectangle(e.X, e.Y)
        End If
        If rbCercle.Checked Then
            DrawEllipse(e.X, e.Y)
        End If
        PictureBox1.Image = bmp
    End Sub

    Private Sub btnErase_Click(sender As Object, e As EventArgs) Handles btnErase.Click
        g.Clear(Color.White)
        PictureBox1.Image = bmp
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles largeur.ValueChanged
        l = largeur.Value
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles hauteur.ValueChanged
        h = hauteur.Value
    End Sub

    Private Sub rbRectangle_CheckedChanged(sender As Object, e As EventArgs) Handles rbRectangle.CheckedChanged
        If rbRectangle.Checked Then
            Label4.Visible = True
            Label5.Visible = True
            largeur.Visible = True
            hauteur.Visible = True
        Else
            Label4.Visible = False
            Label5.Visible = False
            largeur.Visible = False
            hauteur.Visible = False
        End If
    End Sub

    Private Sub lblBlack_Click(sender As Object, e As EventArgs) Handles lblBlack.Click
        myPen.Color = lblBlack.BackColor
    End Sub

    Private Sub lblWhite_Click(sender As Object, e As EventArgs) Handles lblWhite.Click
        myPen.Color = lblWhite.BackColor
    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click
        myPen.Color = lbl1.BackColor
    End Sub

    Private Sub lbl5_Click(sender As Object, e As EventArgs) Handles lbl5.Click
        myPen.Color = lbl5.BackColor
    End Sub

    Private Sub lbl2_Click(sender As Object, e As EventArgs) Handles lbl2.Click
        myPen.Color = lbl2.BackColor
    End Sub

    Private Sub lbl6_Click(sender As Object, e As EventArgs) Handles lbl6.Click
        myPen.Color = lbl6.BackColor
    End Sub

    Private Sub lbl3_Click(sender As Object, e As EventArgs) Handles lbl3.Click
        myPen.Color = lbl3.BackColor
    End Sub

    Private Sub lbl7_Click(sender As Object, e As EventArgs) Handles lbl7.Click
        myPen.Color = lbl7.BackColor
    End Sub

    Private Sub lbl4_Click(sender As Object, e As EventArgs) Handles lbl4.Click
        myPen.Color = lbl4.BackColor
    End Sub

    Private Sub lbl8_Click(sender As Object, e As EventArgs) Handles lbl8.Click
        myPen.Color = lbl8.BackColor
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        myPen.Width = NumericUpDown1.Value
        lblThick.Height = NumericUpDown1.Value
    End Sub

    Private Sub rayon_ValueChanged(sender As Object, e As EventArgs) Handles rayon.ValueChanged
        r = rayon.Value
    End Sub

    Private Sub btnSAve_Click(sender As Object, e As EventArgs) Handles btnSAve.Click
        If SaveFileDialog1.ShowDialog = 1 Then
            Dim bitmap As New Bitmap(PictureBox1.Width, PictureBox1.Height)

            Dim path As String = SaveFileDialog1.FileName

            PictureBox1.DrawToBitmap(bitmap, PictureBox1.ClientRectangle)

            Dim extension As String = Mid(SaveFileDialog1.FileName, SaveFileDialog1.FileName.Length - 2, 3)
            g.DrawImage(bitmap, PictureBox1.Width, PictureBox1.Height)


            Select Case extension
                Case "png"
                    bitmap.Save(path, Imaging.ImageFormat.Png)
                    Exit Select
                Case "bmp"
                    bitmap.Save(path, Imaging.ImageFormat.Bmp)
                    Exit Select
                Case "jpg"
                    bitmap.Save(path, Imaging.ImageFormat.Jpeg)
                    Exit Select

                Case Else
                    MsgBox("L'extension que vous avez choisi n'est pas supportée!", vbInformation, "Enregistrement annulé")

            End Select
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        g.Clear(myPen.Color)
        PictureBox1.Image = bmp
    End Sub

    Private Sub rbCercle_CheckedChanged(sender As Object, e As EventArgs) Handles rbCercle.CheckedChanged
        If rbCercle.Checked = True Then
            Label6.Visible = True
            rayon.Visible = True
        Else
            Label6.Visible = False
            rayon.Visible = False
        End If
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If OpenFileDialog1.ShowDialog() = 1 Then
            'If Mid(SaveFileDialog1.FileName, SaveFileDialog1.FileName.Length - 2, 3) = "jpg" _
            '    Or Mid(SaveFileDialog1.FileName, SaveFileDialog1.FileName.Length - 2, 3) = "png" _
            '    Or Mid(SaveFileDialog1.FileName, SaveFileDialog1.FileName.Length - 2, 3) = "bmp" Then
            Try
                Dim image As Image
                image = Image.FromFile(OpenFileDialog1.FileName)
                PictureBox1.Image = image
            Catch ex As Exception
                MsgBox(ex.Message, vbInformation, "Erreur d'extension")

            End Try
            'End If
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        bmp = New Bitmap(5000, 5000)
        g = Graphics.FromImage(bmp)
        'g = PictureBox1.CreateGraphics
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' bmp = New Bitmap(bmp, PictureBox1.Width, PictureBox1.Height)
    End Sub
End Class
