Public Class Form1

    Dim resultVAlue As Double = 0.0
    Dim lastValue As Double = 0.0
    Dim operation As String = ""
    Dim isOperationPrefomrd As Boolean = False





    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If ((txt.Text = "0") Or (isOperationPrefomrd)) Then
            txt.Clear()
        End If
        isOperationPrefomrd = False
        Dim btn As Button = sender
        If (btn.Text = ",") Then
            If (txt.Text.Contains(",") = False) Then
                txt.Text += btn.Text
            End If
        Else
            txt.Text += btn.Text
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If ((txt.Text = "0") Or (isOperationPrefomrd)) Then
            txt.Clear()
        End If
        isOperationPrefomrd = False
        Dim btn As Button = sender
        If (btn.Text = ",") Then
            If (txt.Text.Contains(",") = False) Then
                txt.Text += btn.Text
            End If
        Else
            txt.Text += btn.Text
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If ((txt.Text = "0") Or (isOperationPrefomrd)) Then
            txt.Clear()
        End If
        isOperationPrefomrd = False
        Dim btn As Button = sender
        If (btn.Text = ",") Then
            If (txt.Text.Contains(",") = False) Then
                txt.Text += btn.Text
            End If
        Else
            txt.Text += btn.Text
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If ((txt.Text = "0") Or (isOperationPrefomrd)) Then
            txt.Clear()
        End If
        isOperationPrefomrd = False
        Dim btn As Button = sender
        If (btn.Text = ",") Then
            If (txt.Text.Contains(",") = False) Then
                txt.Text += btn.Text
            End If
        Else
            txt.Text += btn.Text
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If ((txt.Text = "0") Or (isOperationPrefomrd)) Then
            txt.Clear()
        End If
        isOperationPrefomrd = False
        Dim btn As Button = sender
        If (btn.Text = ",") Then
            If (txt.Text.Contains(",") = False) Then
                txt.Text += btn.Text
            End If
        Else
            txt.Text += btn.Text
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If ((txt.Text = "0") Or (isOperationPrefomrd)) Then
            txt.Clear()
        End If
        isOperationPrefomrd = False
        Dim btn As Button = sender
        If (btn.Text = ",") Then
            If (txt.Text.Contains(",") = False) Then
                txt.Text += btn.Text
            End If
        Else
            txt.Text += btn.Text
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If ((txt.Text = "0") Or (isOperationPrefomrd)) Then
            txt.Clear()
        End If
        isOperationPrefomrd = False
        Dim btn As Button = sender
        If (btn.Text = ",") Then
            If (txt.Text.Contains(",") = False) Then
                txt.Text += btn.Text
            End If
        Else
            txt.Text += btn.Text
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If ((txt.Text = "0") Or (isOperationPrefomrd)) Then
            txt.Clear()
        End If
        isOperationPrefomrd = False
        Dim btn As Button = sender
        If (btn.Text = ",") Then
            If (txt.Text.Contains(",") = False) Then
                txt.Text += btn.Text
            End If
        Else
            txt.Text += btn.Text
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If ((txt.Text = "0") Or (isOperationPrefomrd)) Then
            txt.Clear()
        End If
        isOperationPrefomrd = False
        Dim btn As Button = sender
        If (btn.Text = ",") Then
            If (txt.Text.Contains(",") = False) Then
                txt.Text += btn.Text
            End If
        Else
            txt.Text += btn.Text
        End If
    End Sub

    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        If ((txt.Text = "0") Or (isOperationPrefomrd)) Then
            txt.Clear()
        End If
        isOperationPrefomrd = False
        Dim btn As Button = sender
        If (btn.Text = ",") Then
            If (txt.Text.Contains(",") = False) Then
                txt.Text += btn.Text
            End If
        Else
            txt.Text += btn.Text
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If ((txt.Text = "0") Or (isOperationPrefomrd)) Then
            txt.Clear()
        End If
        isOperationPrefomrd = False
        Dim btn As Button = sender
        If (btn.Text = ",") Then
            If (txt.Text.Contains(",") = False) Then
                txt.Text += btn.Text
            End If
        Else
            txt.Text += btn.Text
        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim btn As Button = sender
        txt.Text = txt.Text + btn.Text
        operation = btn.Text
        'Dim btn As Button = sender
        'If (resultVAlue <> 0) Then
        '    operation = btn.Text
        '    isOperationPrefomrd = True
        '    lastValue = resultVAlue
        '    calcul(operation)
        '    lbl.Text = "" + Convert.ToString(resultVAlue) + " " + operation

        'Else
        '    operation = btn.Text
        '    resultVAlue = Convert.ToDouble(txt.Text)
        '    isOperationPrefomrd = True
        '    lbl.Text = "" + Convert.ToString(resultVAlue) + " " + operation
        'End If

    End Sub

    Private Sub calcul(ByVal x As String)
        Select (operation)
            Case "+"
                resultVAlue = resultVAlue + Double.Parse(txt.Text)
            Case "-"
                resultVAlue = resultVAlue - Double.Parse(txt.Text)
            Case "*"
                resultVAlue = resultVAlue * Double.Parse(txt.Text)
            Case "/"
                resultVAlue = resultVAlue / Double.Parse(txt.Text)
        End Select
    End Sub

    Private Sub btnEgale_Click(sender As Object, e As EventArgs) Handles btnEgale.Click
        'txt.Text = "" + Convert.ToString(resultVAlue)
        Select Case (operation)
            Case "+"
                Dim eq() As String = txt.Text.Split("+")
                lbl.Text = txt.Text
                For i As Integer = 0 To eq.Length - 1
                    If eq(i) = "" Then
                        eq(i) = "0"
                    End If
                    resultVAlue += (Double.Parse(eq(i)))

                Next
                txt.Text = "" + Convert.ToString(resultVAlue)
                resultVAlue = 0
            Case "-"
                Dim eq() As String = txt.Text.Split("-")
                lbl.Text = txt.Text
                If eq(1) = "" Then
                    eq(1) = "0"
                End If
                resultVAlue = Double.Parse(eq(0)) - Double.Parse(eq(1))
                txt.Text = "" + Convert.ToString(resultVAlue)
                resultVAlue = 0
            Case "*"
                Dim eq() As String = txt.Text.Split("*")
                lbl.Text = txt.Text
                resultVAlue = 1
                For i As Integer = 0 To eq.Length - 1
                    If eq(i) = "" Then
                        eq(i) = "0"
                    End If
                    resultVAlue *= (Double.Parse(eq(i)))

                Next
                txt.Text = "" + Convert.ToString(resultVAlue)
                resultVAlue = 0
            Case "/"
                Dim eq() As String = txt.Text.Split("/")
                lbl.Text = txt.Text
                If eq(0) = "" Then
                    eq(0) = "0"
                End If

                If (Double.Parse(eq(1)) <> 0) Then
                    resultVAlue = Double.Parse(eq(0)) / Double.Parse(eq(1))
                    txt.Text = "" + Convert.ToString(resultVAlue)
                    resultVAlue = 0
                Else
                    txt.Text = Convert.ToString(resultVAlue)
                    lbl.Text = "La division sur 0 est impossible"

                End If
            Case "pow"
                lbl.Text = "pow(" + Convert.ToString(lastValue) + ")"
                resultVAlue = Math.Pow(Double.Parse(lastValue), 2)
                txt.Text = "" + Convert.ToString(resultVAlue)
                resultVAlue = 0
            Case "Sqrt"
                lbl.Text = "Sqrt(" + Convert.ToString(lastValue) + ")"
                resultVAlue = Math.Sqrt(Double.Parse(lastValue))
                txt.Text = "" + Convert.ToString(resultVAlue)
                resultVAlue = 0
            Case "log10"
                lbl.Text = "Log10(" + Convert.ToString(lastValue) + ")"
                resultVAlue = Math.Log10(Double.Parse(lastValue))
                txt.Text = "" + Convert.ToString(resultVAlue)
                resultVAlue = 0
            Case "^"
                Dim eq() As String = txt.Text.Split("^")
                lbl.Text = txt.Text
                If eq(1) = "" Then
                    eq(1) = "0"
                End If
                '  resultVAlue = Math.Pow(Double.Parse(eq(0)), Double.Parse(eq(1)))
                resultVAlue = Double.Parse(eq(0)) ^ Double.Parse(eq(1))
                txt.Text = "" + Convert.ToString(resultVAlue)
                resultVAlue = 0
            Case "e"
                lbl.Text = "e(" + Convert.ToString(lastValue) + ")"
                resultVAlue = Math.Exp(Double.Parse(lastValue))
                txt.Text = "" + Convert.ToString(resultVAlue)
                resultVAlue = 0
            Case "exp"
                Dim eq() As String = txt.Text.Split("p")
                lbl.Text = txt.Text
                If eq(1) = "" Then
                    eq(1) = "0"
                End If
                ' Dim a As Double = Double.Parse(eq(1))
                resultVAlue = Double.Parse(eq(0)) * (10 ^ Double.Parse(eq(1)))
                txt.Text = "" + Convert.ToString(resultVAlue)
                resultVAlue = 0


            Case Else
                txt.Text = "" + Convert.ToString(resultVAlue)
        End Select

    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim btn As Button = sender
        txt.Text = txt.Text + btn.Text
        operation = btn.Text
        'Dim btn As Button = sender
        'If (resultVAlue <> 0) Then

        '    operation = btn.Text
        '    isOperationPrefomrd = True
        '    btnEgale.PerformClick()
        '    lbl.Text = "" + Convert.ToString(resultVAlue)
        'Else
        '    operation = btn.Text
        '    resultVAlue = Convert.ToDouble(txt.Text)
        '    isOperationPrefomrd = True
        '    lbl.Text = "" + Convert.ToString(resultVAlue) + " " + operation
        'End If
    End Sub

    Private Sub btnSoustr_Click(sender As Object, e As EventArgs) Handles btnSoustr.Click
        Dim btn As Button = sender
        txt.Text = txt.Text + btn.Text
        operation = btn.Text
        'Dim btn As Button = sender
        'If (resultVAlue <> 0) Then
        '    operation = btn.Text
        '    isOperationPrefomrd = True
        '    lastValue = resultVAlue
        '    calcul(operation)
        '    lbl.Text = "" + Convert.ToString(resultVAlue) + " " + operation

        'Else
        '    operation = btn.Text
        '    resultVAlue = Convert.ToDouble(txt.Text)
        '    isOperationPrefomrd = True
        '    lbl.Text = "" + Convert.ToString(resultVAlue) + " " + operation
        'End If
    End Sub

    Private Sub btnMulty_Click(sender As Object, e As EventArgs) Handles btnMulty.Click
        Dim btn As Button = sender
        txt.Text = txt.Text + btn.Text
        operation = btn.Text
        'Dim btn As Button = sender
        'If (resultVAlue <> 0) Then

        '    operation = btn.Text
        '    isOperationPrefomrd = True
        '    btnEgale.PerformClick()
        '    lbl.Text = "" + Convert.ToString(resultVAlue)
        'Else
        '    operation = btn.Text
        '    resultVAlue = Convert.ToDouble(txt.Text)
        '    isOperationPrefomrd = True
        '    lbl.Text = "" + Convert.ToString(resultVAlue) + " " + operation
        'End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        resultVAlue = 0
        lastValue = 0
        operation = ""
        txt.Text = "0"
        lbl.Text = "0"
    End Sub

    Private Sub btnPow2_Click(sender As Object, e As EventArgs) Handles btnPow2.Click
        Dim btn As Button = sender
        lastValue = txt.Text
        txt.Text = "pow(" + txt.Text + ")"
        operation = "pow"
    End Sub

    Private Sub btnRacine2_Click(sender As Object, e As EventArgs) Handles btnRacine2.Click
        Dim btn As Button = sender
        lastValue = txt.Text
        txt.Text = "Sqrt(" + txt.Text + ")"
        operation = "Sqrt"

    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim btn As Button = sender
        lastValue = txt.Text
        txt.Text = "log10(" + txt.Text + ")"
        operation = "log10"

    End Sub

    Private Sub btnPowx_Click(sender As Object, e As EventArgs) Handles btnPowx.Click
        Dim btn As Button = sender
        lastValue = txt.Text
        txt.Text = txt.Text + "^"
        operation = "^"
    End Sub

    Private Sub btnRacinex_Click(sender As Object, e As EventArgs) Handles btnRacinex.Click
        Dim btn As Button = sender
        lastValue = txt.Text
        txt.Text = "e(" + txt.Text + ")"
        operation = "e"
    End Sub

    Private Sub btnLogx_Click(sender As Object, e As EventArgs) Handles btnLogx.Click
        Dim btn As Button = sender
        lastValue = txt.Text
        txt.Text = txt.Text + "p"
        operation = "exp"
    End Sub
End Class
