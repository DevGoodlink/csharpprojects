
Imports System.Configuration

Module Module1
    Public objetConnexion As SqlClient.SqlConnection
    Public objetCommand As SqlClient.SqlCommand
    Public objetDataAdapter As SqlClient.SqlDataAdapter
    Public objetDataTable As DataTable
    Public objetDataSet As DataSet
    Public objetDataRow As DataRow
    Public objectCommandBuilder As SqlClient.SqlCommandBuilder



    Public Function connect() As Boolean
        Dim success As Boolean = False
        objetConnexion = New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("sqlServerConnection").ConnectionString)
        Try
            objetConnexion.Open()
            If objetConnexion.State = ConnectionState.Open Then
                success = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Erreur procédure de connexion")
            success = False
        End Try
        Return success
    End Function
    Public Sub loadData(ByVal myTable As String)
        Dim strSql = "select * from " & myTable
        connect()
        Try
            objetDataAdapter = New SqlClient.SqlDataAdapter(strSql, objetConnexion)
            objetDataTable = New DataTable
            objetDataAdapter.Fill(objetDataTable)
            objetConnexion.Close()
            objetDataAdapter.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function runSql(sql As String) As Boolean
        Dim success As Boolean = False
        connect()
        Try
            objetCommand = New SqlClient.SqlCommand(sql, objetConnexion)
            objetCommand.CommandType = CommandType.Text
            objetCommand.ExecuteNonQuery()
            objetCommand.Dispose()
            objetConnexion.Close()
            success = True
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Problème de mise à jour")
        End Try
        Return success
    End Function
End Module
