<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConnection
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
        Me.btnAccess = New System.Windows.Forms.Button()
        Me.btnSqlServer = New System.Windows.Forms.Button()
        Me.btnMysql = New System.Windows.Forms.Button()
        Me.btnOdbc = New System.Windows.Forms.Button()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAccess
        '
        Me.btnAccess.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccess.Location = New System.Drawing.Point(192, 108)
        Me.btnAccess.Name = "btnAccess"
        Me.btnAccess.Size = New System.Drawing.Size(179, 40)
        Me.btnAccess.TabIndex = 0
        Me.btnAccess.Text = "Access"
        Me.btnAccess.UseVisualStyleBackColor = True
        '
        'btnSqlServer
        '
        Me.btnSqlServer.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSqlServer.Location = New System.Drawing.Point(192, 163)
        Me.btnSqlServer.Name = "btnSqlServer"
        Me.btnSqlServer.Size = New System.Drawing.Size(179, 40)
        Me.btnSqlServer.TabIndex = 1
        Me.btnSqlServer.Text = "SQL Server"
        Me.btnSqlServer.UseVisualStyleBackColor = True
        '
        'btnMysql
        '
        Me.btnMysql.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMysql.Location = New System.Drawing.Point(192, 218)
        Me.btnMysql.Name = "btnMysql"
        Me.btnMysql.Size = New System.Drawing.Size(179, 40)
        Me.btnMysql.TabIndex = 2
        Me.btnMysql.Text = "MySQL"
        Me.btnMysql.UseVisualStyleBackColor = True
        '
        'btnOdbc
        '
        Me.btnOdbc.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOdbc.Location = New System.Drawing.Point(192, 273)
        Me.btnOdbc.Name = "btnOdbc"
        Me.btnOdbc.Size = New System.Drawing.Size(179, 40)
        Me.btnOdbc.TabIndex = 3
        Me.btnOdbc.Text = "ODBC"
        Me.btnOdbc.UseVisualStyleBackColor = True
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnection.Location = New System.Drawing.Point(189, 33)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(182, 23)
        Me.lblConnection.TabIndex = 4
        Me.lblConnection.Text = "Choisir une connexion"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.Red
        Me.lblState.Location = New System.Drawing.Point(189, 343)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(208, 23)
        Me.lblState.TabIndex = 5
        Me.lblState.Text = "Aucune connexion établie"
        '
        'FrmConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 403)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.btnOdbc)
        Me.Controls.Add(Me.btnMysql)
        Me.Controls.Add(Me.btnSqlServer)
        Me.Controls.Add(Me.btnAccess)
        Me.Name = "FrmConnection"
        Me.Text = "Connexion au serveur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAccess As Button
    Friend WithEvents btnSqlServer As Button
    Friend WithEvents btnMysql As Button
    Friend WithEvents btnOdbc As Button
    Friend WithEvents lblConnection As Label
    Friend WithEvents lblState As Label
End Class
