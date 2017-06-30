<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecherche
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecherche = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbDown = New System.Windows.Forms.RadioButton()
        Me.rbUp = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkBxCasse = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rechercher :"
        '
        'txtRecherche
        '
        Me.txtRecherche.Location = New System.Drawing.Point(95, 18)
        Me.txtRecherche.Name = "txtRecherche"
        Me.txtRecherche.Size = New System.Drawing.Size(188, 20)
        Me.txtRecherche.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbDown)
        Me.GroupBox1.Controls.Add(Me.rbUp)
        Me.GroupBox1.Location = New System.Drawing.Point(163, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 47)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Direction"
        '
        'rbDown
        '
        Me.rbDown.AutoSize = True
        Me.rbDown.Location = New System.Drawing.Point(60, 19)
        Me.rbDown.Name = "rbDown"
        Me.rbDown.Size = New System.Drawing.Size(43, 17)
        Me.rbDown.TabIndex = 1
        Me.rbDown.TabStop = True
        Me.rbDown.Text = "Bas"
        Me.rbDown.UseVisualStyleBackColor = True
        '
        'rbUp
        '
        Me.rbUp.AutoSize = True
        Me.rbUp.Location = New System.Drawing.Point(6, 19)
        Me.rbUp.Name = "rbUp"
        Me.rbUp.Size = New System.Drawing.Size(48, 17)
        Me.rbUp.TabIndex = 0
        Me.rbUp.TabStop = True
        Me.rbUp.Text = "Haut"
        Me.rbUp.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(309, 12)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(95, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Suivant"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(309, 41)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkBxCasse
        '
        Me.chkBxCasse.AutoSize = True
        Me.chkBxCasse.Location = New System.Drawing.Point(23, 81)
        Me.chkBxCasse.Name = "chkBxCasse"
        Me.chkBxCasse.Size = New System.Drawing.Size(117, 17)
        Me.chkBxCasse.TabIndex = 5
        Me.chkBxCasse.Text = "Respecter la casse"
        Me.chkBxCasse.UseVisualStyleBackColor = True
        '
        'FrmRecherche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(429, 114)
        Me.Controls.Add(Me.chkBxCasse)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRecherche)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRecherche"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Recherche"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRecherche As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbDown As RadioButton
    Friend WithEvents rbUp As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkBxCasse As CheckBox
End Class
