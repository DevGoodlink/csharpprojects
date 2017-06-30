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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerSousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercherLeSuivantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemplacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtteindreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SélectionnerToutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeureDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetourAutomatiqueÀLaLigneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoliceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.EditionToolStripMenuItem, Me.FormatToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(857, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.OuvrirToolStripMenuItem, Me.EnregistrerToolStripMenuItem, Me.EnregistrerSousToolStripMenuItem, Me.ImprimerToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "&Fichier"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NouveauToolStripMenuItem.Text = "&Nouveau"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.OuvrirToolStripMenuItem.Text = "&Ouvrir"
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.EnregistrerToolStripMenuItem.Text = "&Enregistrer"
        '
        'EnregistrerSousToolStripMenuItem
        '
        Me.EnregistrerSousToolStripMenuItem.Name = "EnregistrerSousToolStripMenuItem"
        Me.EnregistrerSousToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.EnregistrerSousToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.EnregistrerSousToolStripMenuItem.Text = "Enregistrer &sous"
        '
        'ImprimerToolStripMenuItem
        '
        Me.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
        Me.ImprimerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimerToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ImprimerToolStripMenuItem.Text = "&Imprimer"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.QuitterToolStripMenuItem.Text = "&Quitter"
        '
        'EditionToolStripMenuItem
        '
        Me.EditionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnnulerToolStripMenuItem, Me.CopierToolStripMenuItem, Me.CollerToolStripMenuItem, Me.SupprimerToolStripMenuItem, Me.RechercherToolStripMenuItem, Me.RechercherLeSuivantToolStripMenuItem, Me.RemplacerToolStripMenuItem, Me.AtteindreToolStripMenuItem, Me.SélectionnerToutToolStripMenuItem, Me.HeureDateToolStripMenuItem})
        Me.EditionToolStripMenuItem.Name = "EditionToolStripMenuItem"
        Me.EditionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.EditionToolStripMenuItem.Text = "&Edition"
        '
        'AnnulerToolStripMenuItem
        '
        Me.AnnulerToolStripMenuItem.Name = "AnnulerToolStripMenuItem"
        Me.AnnulerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.AnnulerToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AnnulerToolStripMenuItem.Text = "&Annuler"
        '
        'CopierToolStripMenuItem
        '
        Me.CopierToolStripMenuItem.Name = "CopierToolStripMenuItem"
        Me.CopierToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopierToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CopierToolStripMenuItem.Text = "&Copier"
        '
        'CollerToolStripMenuItem
        '
        Me.CollerToolStripMenuItem.Name = "CollerToolStripMenuItem"
        Me.CollerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.CollerToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CollerToolStripMenuItem.Text = "C&oller"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SupprimerToolStripMenuItem.Text = "&Supprimer"
        '
        'RechercherToolStripMenuItem
        '
        Me.RechercherToolStripMenuItem.Name = "RechercherToolStripMenuItem"
        Me.RechercherToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.RechercherToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.RechercherToolStripMenuItem.Text = "&Rechercher"
        '
        'RechercherLeSuivantToolStripMenuItem
        '
        Me.RechercherLeSuivantToolStripMenuItem.Name = "RechercherLeSuivantToolStripMenuItem"
        Me.RechercherLeSuivantToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.RechercherLeSuivantToolStripMenuItem.Text = "Recherche&r le suivant"
        '
        'RemplacerToolStripMenuItem
        '
        Me.RemplacerToolStripMenuItem.Name = "RemplacerToolStripMenuItem"
        Me.RemplacerToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.RemplacerToolStripMenuItem.Text = "Re&mplacer"
        '
        'AtteindreToolStripMenuItem
        '
        Me.AtteindreToolStripMenuItem.Name = "AtteindreToolStripMenuItem"
        Me.AtteindreToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AtteindreToolStripMenuItem.Text = "A&tteindre"
        '
        'SélectionnerToutToolStripMenuItem
        '
        Me.SélectionnerToutToolStripMenuItem.Name = "SélectionnerToutToolStripMenuItem"
        Me.SélectionnerToutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SélectionnerToutToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SélectionnerToutToolStripMenuItem.Text = "Sélectionner &tout"
        '
        'HeureDateToolStripMenuItem
        '
        Me.HeureDateToolStripMenuItem.Name = "HeureDateToolStripMenuItem"
        Me.HeureDateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HeureDateToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.HeureDateToolStripMenuItem.Text = "&Heure/Date"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetourAutomatiqueÀLaLigneToolStripMenuItem, Me.PoliceToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'RetourAutomatiqueÀLaLigneToolStripMenuItem
        '
        Me.RetourAutomatiqueÀLaLigneToolStripMenuItem.Name = "RetourAutomatiqueÀLaLigneToolStripMenuItem"
        Me.RetourAutomatiqueÀLaLigneToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RetourAutomatiqueÀLaLigneToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.RetourAutomatiqueÀLaLigneToolStripMenuItem.Text = "&Retour automatique à la ligne"
        '
        'PoliceToolStripMenuItem
        '
        Me.PoliceToolStripMenuItem.Name = "PoliceToolStripMenuItem"
        Me.PoliceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.PoliceToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.PoliceToolStripMenuItem.Text = "&Police"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "&?"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 24)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(857, 369)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.WordWrap = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 393)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Bloc notes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrerSousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnnulerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RechercherLeSuivantToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemplacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtteindreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SélectionnerToutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HeureDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetourAutomatiqueÀLaLigneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PoliceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
