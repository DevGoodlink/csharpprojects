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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbReduit = New System.Windows.Forms.RadioButton()
        Me.rbNormal = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQte = New System.Windows.Forms.TextBox()
        Me.txtPu = New System.Windows.Forms.TextBox()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstPt = New System.Windows.Forms.ListBox()
        Me.LstQte = New System.Windows.Forms.ListBox()
        Me.lstPu = New System.Windows.Forms.ListBox()
        Me.lstDesignation = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotalFacture = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtQte)
        Me.GroupBox1.Controls.Add(Me.txtPu)
        Me.GroupBox1.Controls.Add(Me.txtDesignation)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ligne Facture"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(312, 74)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(123, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Ajouter à la facture"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(33, 74)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(125, 23)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "&Nouvelle Facture"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbReduit)
        Me.GroupBox2.Controls.Add(Me.rbNormal)
        Me.GroupBox2.Location = New System.Drawing.Point(438, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 81)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Taux TVA"
        '
        'rbReduit
        '
        Me.rbReduit.AutoSize = True
        Me.rbReduit.Location = New System.Drawing.Point(18, 42)
        Me.rbReduit.Name = "rbReduit"
        Me.rbReduit.Size = New System.Drawing.Size(56, 17)
        Me.rbReduit.TabIndex = 1
        Me.rbReduit.TabStop = True
        Me.rbReduit.Text = "&Réduit"
        Me.rbReduit.UseVisualStyleBackColor = True
        '
        'rbNormal
        '
        Me.rbNormal.AutoSize = True
        Me.rbNormal.Location = New System.Drawing.Point(18, 19)
        Me.rbNormal.Name = "rbNormal"
        Me.rbNormal.Size = New System.Drawing.Size(58, 17)
        Me.rbNormal.TabIndex = 0
        Me.rbNormal.TabStop = True
        Me.rbNormal.Text = "N&ormal"
        Me.rbNormal.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(361, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quantité"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Prix unitaire"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Désignation"
        '
        'txtQte
        '
        Me.txtQte.Location = New System.Drawing.Point(364, 48)
        Me.txtQte.Name = "txtQte"
        Me.txtQte.Size = New System.Drawing.Size(63, 20)
        Me.txtQte.TabIndex = 2
        '
        'txtPu
        '
        Me.txtPu.Location = New System.Drawing.Point(297, 48)
        Me.txtPu.Name = "txtPu"
        Me.txtPu.Size = New System.Drawing.Size(63, 20)
        Me.txtPu.TabIndex = 1
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(33, 48)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(249, 20)
        Me.txtDesignation.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(524, 451)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Quitter"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lstPt)
        Me.GroupBox3.Controls.Add(Me.LstQte)
        Me.GroupBox3.Controls.Add(Me.lstPu)
        Me.GroupBox3.Controls.Add(Me.lstDesignation)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 158)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(587, 274)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Facture"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(455, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Prix total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(378, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Quantité"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Prix unitaire"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Désignation"
        '
        'lstPt
        '
        Me.lstPt.FormattingEnabled = True
        Me.lstPt.Location = New System.Drawing.Point(458, 49)
        Me.lstPt.Name = "lstPt"
        Me.lstPt.Size = New System.Drawing.Size(120, 134)
        Me.lstPt.TabIndex = 15
        '
        'LstQte
        '
        Me.LstQte.FormattingEnabled = True
        Me.LstQte.Location = New System.Drawing.Point(381, 49)
        Me.LstQte.Name = "LstQte"
        Me.LstQte.Size = New System.Drawing.Size(63, 134)
        Me.LstQte.TabIndex = 14
        '
        'lstPu
        '
        Me.lstPu.FormattingEnabled = True
        Me.lstPu.Location = New System.Drawing.Point(297, 49)
        Me.lstPu.Name = "lstPu"
        Me.lstPu.Size = New System.Drawing.Size(75, 134)
        Me.lstPu.TabIndex = 13
        '
        'lstDesignation
        '
        Me.lstDesignation.FormattingEnabled = True
        Me.lstDesignation.Location = New System.Drawing.Point(20, 49)
        Me.lstDesignation.Name = "lstDesignation"
        Me.lstDesignation.Size = New System.Drawing.Size(262, 134)
        Me.lstDesignation.TabIndex = 12
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotalFacture)
        Me.GroupBox4.Location = New System.Drawing.Point(412, 200)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(166, 68)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total Facture"
        '
        'lblTotalFacture
        '
        Me.lblTotalFacture.AutoSize = True
        Me.lblTotalFacture.Location = New System.Drawing.Point(108, 39)
        Me.lblTotalFacture.Name = "lblTotalFacture"
        Me.lblTotalFacture.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalFacture.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 486)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Facturation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbReduit As RadioButton
    Friend WithEvents rbNormal As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQte As TextBox
    Friend WithEvents txtPu As TextBox
    Friend WithEvents txtDesignation As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstPt As ListBox
    Friend WithEvents LstQte As ListBox
    Friend WithEvents lstPu As ListBox
    Friend WithEvents lstDesignation As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblTotalFacture As Label
End Class
