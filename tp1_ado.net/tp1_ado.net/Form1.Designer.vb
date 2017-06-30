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
        Me.lstLeft = New System.Windows.Forms.ListBox()
        Me.lstRight = New System.Windows.Forms.ListBox()
        Me.chkBMutli = New System.Windows.Forms.CheckBox()
        Me.txtValeur = New System.Windows.Forms.TextBox()
        Me.btnToLeft = New System.Windows.Forms.Button()
        Me.btnToRight = New System.Windows.Forms.Button()
        Me.btnAllToLeft = New System.Windows.Forms.Button()
        Me.btnAllToRight = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstLeft
        '
        Me.lstLeft.FormattingEnabled = True
        Me.lstLeft.Items.AddRange(New Object() {"fraise", "cerise", "tomate", "tomate", "pomme de terre"})
        Me.lstLeft.Location = New System.Drawing.Point(38, 69)
        Me.lstLeft.Name = "lstLeft"
        Me.lstLeft.ScrollAlwaysVisible = True
        Me.lstLeft.Size = New System.Drawing.Size(205, 212)
        Me.lstLeft.TabIndex = 0
        '
        'lstRight
        '
        Me.lstRight.FormattingEnabled = True
        Me.lstRight.Location = New System.Drawing.Point(424, 69)
        Me.lstRight.Name = "lstRight"
        Me.lstRight.ScrollAlwaysVisible = True
        Me.lstRight.Size = New System.Drawing.Size(205, 212)
        Me.lstRight.TabIndex = 1
        '
        'chkBMutli
        '
        Me.chkBMutli.AutoSize = True
        Me.chkBMutli.Location = New System.Drawing.Point(38, 46)
        Me.chkBMutli.Name = "chkBMutli"
        Me.chkBMutli.Size = New System.Drawing.Size(144, 17)
        Me.chkBMutli.TabIndex = 2
        Me.chkBMutli.Text = "Autoriser la multisélection"
        Me.chkBMutli.UseVisualStyleBackColor = True
        '
        'txtValeur
        '
        Me.txtValeur.Location = New System.Drawing.Point(38, 298)
        Me.txtValeur.Name = "txtValeur"
        Me.txtValeur.Size = New System.Drawing.Size(205, 20)
        Me.txtValeur.TabIndex = 3
        '
        'btnToLeft
        '
        Me.btnToLeft.Location = New System.Drawing.Point(282, 76)
        Me.btnToLeft.Name = "btnToLeft"
        Me.btnToLeft.Size = New System.Drawing.Size(102, 32)
        Me.btnToLeft.TabIndex = 4
        Me.btnToLeft.Text = "A gauche"
        Me.btnToLeft.UseVisualStyleBackColor = True
        '
        'btnToRight
        '
        Me.btnToRight.Location = New System.Drawing.Point(282, 113)
        Me.btnToRight.Name = "btnToRight"
        Me.btnToRight.Size = New System.Drawing.Size(102, 32)
        Me.btnToRight.TabIndex = 5
        Me.btnToRight.Text = "A droite"
        Me.btnToRight.UseVisualStyleBackColor = True
        '
        'btnAllToLeft
        '
        Me.btnAllToLeft.Location = New System.Drawing.Point(282, 150)
        Me.btnAllToLeft.Name = "btnAllToLeft"
        Me.btnAllToLeft.Size = New System.Drawing.Size(102, 32)
        Me.btnAllToLeft.TabIndex = 6
        Me.btnAllToLeft.Text = "Tout à gauche"
        Me.btnAllToLeft.UseVisualStyleBackColor = True
        '
        'btnAllToRight
        '
        Me.btnAllToRight.Location = New System.Drawing.Point(282, 187)
        Me.btnAllToRight.Name = "btnAllToRight"
        Me.btnAllToRight.Size = New System.Drawing.Size(102, 32)
        Me.btnAllToRight.TabIndex = 7
        Me.btnAllToRight.Text = "Tout à droite"
        Me.btnAllToRight.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(282, 290)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(102, 28)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Ajouter"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(527, 298)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(102, 23)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "Quitter"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 392)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnAllToRight)
        Me.Controls.Add(Me.btnAllToLeft)
        Me.Controls.Add(Me.btnToRight)
        Me.Controls.Add(Me.btnToLeft)
        Me.Controls.Add(Me.txtValeur)
        Me.Controls.Add(Me.chkBMutli)
        Me.Controls.Add(Me.lstRight)
        Me.Controls.Add(Me.lstLeft)
        Me.Name = "Form1"
        Me.Text = "Inventaire de prévert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstLeft As ListBox
    Friend WithEvents lstRight As ListBox
    Friend WithEvents chkBMutli As CheckBox
    Friend WithEvents txtValeur As TextBox
    Friend WithEvents btnToLeft As Button
    Friend WithEvents btnToRight As Button
    Friend WithEvents btnAllToLeft As Button
    Friend WithEvents btnAllToRight As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnQuit As Button
End Class
