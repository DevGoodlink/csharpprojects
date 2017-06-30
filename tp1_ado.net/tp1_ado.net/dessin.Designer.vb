<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dessin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.r4 = New System.Windows.Forms.RadioButton()
        Me.r3 = New System.Windows.Forms.RadioButton()
        Me.r2 = New System.Windows.Forms.RadioButton()
        Me.r1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblThick = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lblBlack = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblWhite = New System.Windows.Forms.Label()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.r4)
        Me.GroupBox3.Controls.Add(Me.r3)
        Me.GroupBox3.Controls.Add(Me.r2)
        Me.GroupBox3.Controls.Add(Me.r1)
        Me.GroupBox3.Location = New System.Drawing.Point(451, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(152, 81)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Formes"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(17, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton1.TabIndex = 24
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Libre"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'r4
        '
        Me.r4.AutoSize = True
        Me.r4.Location = New System.Drawing.Point(78, 15)
        Me.r4.Name = "r4"
        Me.r4.Size = New System.Drawing.Size(63, 17)
        Me.r4.TabIndex = 23
        Me.r4.Text = "Triangle"
        Me.r4.UseVisualStyleBackColor = True
        '
        'r3
        '
        Me.r3.AutoSize = True
        Me.r3.Location = New System.Drawing.Point(17, 49)
        Me.r3.Name = "r3"
        Me.r3.Size = New System.Drawing.Size(53, 17)
        Me.r3.TabIndex = 22
        Me.r3.Text = "Elipse"
        Me.r3.UseVisualStyleBackColor = True
        '
        'r2
        '
        Me.r2.AutoSize = True
        Me.r2.Location = New System.Drawing.Point(17, 32)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(55, 17)
        Me.r2.TabIndex = 21
        Me.r2.Text = "Cercle"
        Me.r2.UseVisualStyleBackColor = True
        '
        'r1
        '
        Me.r1.AutoSize = True
        Me.r1.Location = New System.Drawing.Point(78, 32)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(50, 17)
        Me.r1.TabIndex = 20
        Me.r1.Text = "Carré"
        Me.r1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblThick)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Location = New System.Drawing.Point(609, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(77, 82)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Taille"
        '
        'lblThick
        '
        Me.lblThick.BackColor = System.Drawing.Color.Black
        Me.lblThick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThick.Location = New System.Drawing.Point(13, 54)
        Me.lblThick.Name = "lblThick"
        Me.lblThick.Size = New System.Drawing.Size(50, 1)
        Me.lblThick.TabIndex = 12
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(13, 21)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl8)
        Me.GroupBox1.Controls.Add(Me.lbl4)
        Me.GroupBox1.Controls.Add(Me.lbl7)
        Me.GroupBox1.Controls.Add(Me.lbl6)
        Me.GroupBox1.Controls.Add(Me.lbl3)
        Me.GroupBox1.Controls.Add(Me.lbl2)
        Me.GroupBox1.Controls.Add(Me.lbl5)
        Me.GroupBox1.Controls.Add(Me.lblBlack)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Controls.Add(Me.lblWhite)
        Me.GroupBox1.Controls.Add(Me.btnColor)
        Me.GroupBox1.Location = New System.Drawing.Point(692, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 82)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Couleurs"
        '
        'lbl8
        '
        Me.lbl8.BackColor = System.Drawing.Color.Gray
        Me.lbl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl8.Location = New System.Drawing.Point(172, 42)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(25, 25)
        Me.lbl8.TabIndex = 11
        '
        'lbl4
        '
        Me.lbl4.BackColor = System.Drawing.Color.Lime
        Me.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl4.Location = New System.Drawing.Point(172, 16)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(25, 25)
        Me.lbl4.TabIndex = 11
        '
        'lbl7
        '
        Me.lbl7.BackColor = System.Drawing.Color.Fuchsia
        Me.lbl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl7.Location = New System.Drawing.Point(141, 42)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(25, 25)
        Me.lbl7.TabIndex = 10
        '
        'lbl6
        '
        Me.lbl6.BackColor = System.Drawing.Color.Blue
        Me.lbl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl6.Location = New System.Drawing.Point(112, 42)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(25, 25)
        Me.lbl6.TabIndex = 11
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.Yellow
        Me.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3.Location = New System.Drawing.Point(141, 16)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(25, 25)
        Me.lbl3.TabIndex = 10
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2.Location = New System.Drawing.Point(112, 16)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(25, 25)
        Me.lbl2.TabIndex = 11
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.Color.Cyan
        Me.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl5.Location = New System.Drawing.Point(81, 42)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(25, 25)
        Me.lbl5.TabIndex = 10
        '
        'lblBlack
        '
        Me.lblBlack.BackColor = System.Drawing.Color.Black
        Me.lblBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlack.Location = New System.Drawing.Point(37, 16)
        Me.lblBlack.Name = "lblBlack"
        Me.lblBlack.Size = New System.Drawing.Size(25, 25)
        Me.lblBlack.TabIndex = 11
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Red
        Me.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1.Location = New System.Drawing.Point(81, 16)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(25, 25)
        Me.lbl1.TabIndex = 10
        '
        'lblWhite
        '
        Me.lblWhite.BackColor = System.Drawing.Color.White
        Me.lblWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWhite.Location = New System.Drawing.Point(6, 16)
        Me.lblWhite.Name = "lblWhite"
        Me.lblWhite.Size = New System.Drawing.Size(25, 25)
        Me.lblWhite.TabIndex = 10
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(203, 16)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(75, 51)
        Me.btnColor.TabIndex = 9
        Me.btnColor.Text = "Autre couleurs"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'pb
        '
        Me.pb.BackColor = System.Drawing.Color.White
        Me.pb.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pb.Location = New System.Drawing.Point(1, 97)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(943, 363)
        Me.pb.TabIndex = 24
        Me.pb.TabStop = False
        '
        'dessin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 506)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "dessin"
        Me.Text = "Paint"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents r4 As RadioButton
    Friend WithEvents r3 As RadioButton
    Friend WithEvents r2 As RadioButton
    Friend WithEvents r1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblThick As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl8 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lblBlack As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblWhite As Label
    Friend WithEvents btnColor As Button
    Friend WithEvents pb As PictureBox
End Class
