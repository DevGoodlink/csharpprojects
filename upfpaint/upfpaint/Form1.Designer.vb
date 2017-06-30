<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rbLibre = New System.Windows.Forms.RadioButton()
        Me.rbCercle = New System.Windows.Forms.RadioButton()
        Me.rbRectangle = New System.Windows.Forms.RadioButton()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rayon = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hauteur = New System.Windows.Forms.NumericUpDown()
        Me.largeur = New System.Windows.Forms.NumericUpDown()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnSAve = New System.Windows.Forms.Button()
        Me.btnErase = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblThick = New System.Windows.Forms.Label()
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.rayon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hauteur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.largeur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbLibre
        '
        Me.rbLibre.AutoSize = True
        Me.rbLibre.Checked = True
        Me.rbLibre.Location = New System.Drawing.Point(352, 32)
        Me.rbLibre.Name = "rbLibre"
        Me.rbLibre.Size = New System.Drawing.Size(48, 17)
        Me.rbLibre.TabIndex = 24
        Me.rbLibre.TabStop = True
        Me.rbLibre.Text = "Libre"
        Me.rbLibre.UseVisualStyleBackColor = True
        '
        'rbCercle
        '
        Me.rbCercle.AutoSize = True
        Me.rbCercle.Location = New System.Drawing.Point(417, 32)
        Me.rbCercle.Name = "rbCercle"
        Me.rbCercle.Size = New System.Drawing.Size(55, 17)
        Me.rbCercle.TabIndex = 21
        Me.rbCercle.Text = "Cercle"
        Me.rbCercle.UseVisualStyleBackColor = True
        '
        'rbRectangle
        '
        Me.rbRectangle.AutoSize = True
        Me.rbRectangle.Location = New System.Drawing.Point(500, 32)
        Me.rbRectangle.Name = "rbRectangle"
        Me.rbRectangle.Size = New System.Drawing.Size(74, 17)
        Me.rbRectangle.TabIndex = 20
        Me.rbRectangle.Text = "Rectangle"
        Me.rbRectangle.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(624, 32)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.rayon)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.hauteur)
        Me.GroupBox1.Controls.Add(Me.largeur)
        Me.GroupBox1.Controls.Add(Me.btnOpen)
        Me.GroupBox1.Controls.Add(Me.btnSAve)
        Me.GroupBox1.Controls.Add(Me.btnErase)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbLibre)
        Me.GroupBox1.Controls.Add(Me.lblThick)
        Me.GroupBox1.Controls.Add(Me.lbl8)
        Me.GroupBox1.Controls.Add(Me.rbCercle)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.rbRectangle)
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
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1137, 138)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Outils"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.upfpaint.My.Resources.Resources.fill
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(886, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 104)
        Me.Button1.TabIndex = 36
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rayon
        '
        Me.rayon.Location = New System.Drawing.Point(437, 86)
        Me.rayon.Name = "rayon"
        Me.rayon.Size = New System.Drawing.Size(49, 20)
        Me.rayon.TabIndex = 35
        Me.rayon.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.rayon.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(440, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Rayon"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(520, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Hauteur"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(349, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Largeur"
        Me.Label4.Visible = False
        '
        'hauteur
        '
        Me.hauteur.Location = New System.Drawing.Point(525, 86)
        Me.hauteur.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.hauteur.Name = "hauteur"
        Me.hauteur.Size = New System.Drawing.Size(49, 20)
        Me.hauteur.TabIndex = 32
        Me.hauteur.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.hauteur.Visible = False
        '
        'largeur
        '
        Me.largeur.Location = New System.Drawing.Point(348, 86)
        Me.largeur.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.largeur.Name = "largeur"
        Me.largeur.Size = New System.Drawing.Size(49, 20)
        Me.largeur.TabIndex = 31
        Me.largeur.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.largeur.Visible = False
        '
        'btnOpen
        '
        Me.btnOpen.BackgroundImage = Global.upfpaint.My.Resources.Resources.open
        Me.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOpen.Location = New System.Drawing.Point(114, 17)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(108, 104)
        Me.btnOpen.TabIndex = 30
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnSAve
        '
        Me.btnSAve.BackgroundImage = Global.upfpaint.My.Resources.Resources.save
        Me.btnSAve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSAve.Location = New System.Drawing.Point(6, 17)
        Me.btnSAve.Name = "btnSAve"
        Me.btnSAve.Size = New System.Drawing.Size(108, 104)
        Me.btnSAve.TabIndex = 29
        Me.btnSAve.UseVisualStyleBackColor = True
        '
        'btnErase
        '
        Me.btnErase.BackgroundImage = Global.upfpaint.My.Resources.Resources.eraser
        Me.btnErase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnErase.Location = New System.Drawing.Point(222, 17)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(108, 104)
        Me.btnErase.TabIndex = 28
        Me.btnErase.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(767, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Couleurs"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(621, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Taille"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(434, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Formes"
        '
        'lblThick
        '
        Me.lblThick.BackColor = System.Drawing.Color.Black
        Me.lblThick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThick.Location = New System.Drawing.Point(623, 62)
        Me.lblThick.Name = "lblThick"
        Me.lblThick.Size = New System.Drawing.Size(50, 1)
        Me.lblThick.TabIndex = 13
        '
        'lbl8
        '
        Me.lbl8.BackColor = System.Drawing.Color.Gray
        Me.lbl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl8.Location = New System.Drawing.Point(845, 83)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(25, 25)
        Me.lbl8.TabIndex = 11
        '
        'lbl4
        '
        Me.lbl4.BackColor = System.Drawing.Color.Lime
        Me.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl4.Location = New System.Drawing.Point(845, 45)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(25, 25)
        Me.lbl4.TabIndex = 11
        '
        'lbl7
        '
        Me.lbl7.BackColor = System.Drawing.Color.Fuchsia
        Me.lbl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl7.Location = New System.Drawing.Point(814, 83)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(25, 25)
        Me.lbl7.TabIndex = 10
        '
        'lbl6
        '
        Me.lbl6.BackColor = System.Drawing.Color.Blue
        Me.lbl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl6.Location = New System.Drawing.Point(785, 83)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(25, 25)
        Me.lbl6.TabIndex = 11
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.Yellow
        Me.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3.Location = New System.Drawing.Point(814, 45)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(25, 25)
        Me.lbl3.TabIndex = 10
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2.Location = New System.Drawing.Point(785, 45)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(25, 25)
        Me.lbl2.TabIndex = 11
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.Color.Cyan
        Me.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl5.Location = New System.Drawing.Point(754, 83)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(25, 25)
        Me.lbl5.TabIndex = 10
        '
        'lblBlack
        '
        Me.lblBlack.BackColor = System.Drawing.Color.Black
        Me.lblBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlack.Location = New System.Drawing.Point(723, 45)
        Me.lblBlack.Name = "lblBlack"
        Me.lblBlack.Size = New System.Drawing.Size(25, 25)
        Me.lblBlack.TabIndex = 11
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Red
        Me.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1.Location = New System.Drawing.Point(754, 45)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(25, 25)
        Me.lbl1.TabIndex = 10
        '
        'lblWhite
        '
        Me.lblWhite.BackColor = System.Drawing.Color.White
        Me.lblWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWhite.Location = New System.Drawing.Point(723, 83)
        Me.lblWhite.Name = "lblWhite"
        Me.lblWhite.Size = New System.Drawing.Size(25, 25)
        Me.lblWhite.TabIndex = 10
        '
        'btnColor
        '
        Me.btnColor.BackColor = System.Drawing.Color.White
        Me.btnColor.BackgroundImage = Global.upfpaint.My.Resources.Resources.complementary
        Me.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnColor.Location = New System.Drawing.Point(1000, 14)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(108, 104)
        Me.btnColor.TabIndex = 9
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1137, 288)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Fichiers png|*.png|Fichiers bmp|*.bmp|Fichiers jpg|*.jpg"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Fichiers png|*.png|Fichiers bmp|*.bmp|Fichiers jpg|*.jpg"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 426)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "UPF Paint"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.rayon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hauteur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.largeur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbLibre As RadioButton
    Friend WithEvents rbCercle As RadioButton
    Friend WithEvents rbRectangle As RadioButton
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
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblThick As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnSAve As Button
    Friend WithEvents btnErase As Button
    Friend WithEvents hauteur As NumericUpDown
    Friend WithEvents largeur As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rayon As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
