Public Class FrmConnection

    Dim str As String = ""
    Dim connection As IDbConnection





    Public Sub connectionDb(type As Integer)
        Select Case type
            Case 1
                str = "Access"
                connection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;
                                                        Data Source=C:\Users\YASSALIE\Documents\atelier1.accdb;
                                                        Persist Security Info=False;")
                connection.Open()

                Select Case connection.State
                    Case ConnectionState.Connecting
                        lblState.Text = "Connexion en cours"
                        lblState.ForeColor = Color.Blue
                        lblState.BackColor = Color.White
                    Case ConnectionState.Open
                        lblState.Text = "Connexion ouverte avec la base de données"
                        lblState.ForeColor = Color.Red
                        lblState.BackColor = Color.Yellow
                End Select
                ' MsgBox("Connexion " &  & " sur " & str)
                connection.Close()

            Case 2
                connection = New System.Data.SqlClient.SqlConnection(" Server = POSTE20031;Database=Championat;User Id=Administrateur;
                                                Password = root;")
                Select Case connection.State
                    Case ConnectionState.Connecting
                        lblState.Text = "Connexion en cours"
                        lblState.ForeColor = Color.Blue
                        lblState.BackColor = Color.White
                    Case ConnectionState.Open
                        lblState.Text = "Connexion ouverte avec la base de données"
                        lblState.ForeColor = Color.Red
                        lblState.BackColor = Color.Yellow
                End Select
            Case 3
                str = "MySql"
                MsgBox("Connexion établie sur " & str)
            Case 4
                str = "ODBC"
                connection = New System.Data.Odbc.OdbcConnection("Driver={SQL Server Native Client 11.0};Server=(localdb)\v11.0")
        End Select

    End Sub

    Private Sub btnAccess_Click(sender As Object, e As EventArgs) Handles btnAccess.Click
        connectionDb(1)

    End Sub

    Private Sub btnSqlServer_Click(sender As Object, e As EventArgs) Handles btnSqlServer.Click
        connectionDb(2)
    End Sub

    Private Sub btnMysql_Click(sender As Object, e As EventArgs) Handles btnMysql.Click
        connectionDb(3)
    End Sub

    Private Sub btnOdbc_Click(sender As Object, e As EventArgs) Handles btnOdbc.Click
        connectionDb(4)
    End Sub
End Class
