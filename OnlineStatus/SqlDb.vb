Imports System.Data.SqlClient
Public Class SqlDb
    Public Function GetDataSet(ByRef sqlCommnd As String, ParamArray sqlParameter() As SqlParameter) As DataSet
        Try
            Dim connString As String = Web.Configuration.WebConfigurationManager.ConnectionStrings("connectionString").ToString()
            Dim sqlConn As SqlConnection = New SqlConnection(connString)
            Dim sqlCmd As SqlCommand = sqlConn.CreateCommand()
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = sqlCommnd
            For Each Parameter As SqlParameter In sqlParameter
                sqlCmd.Parameters.Add(Parameter)
            Next
            sqlConn.Open()
            Dim sqlDa As New SqlDataAdapter(sqlCmd)
            Dim sqlDt As New DataSet()
            sqlDa.Fill(sqlDt)
            sqlConn.Close()
            Return sqlDt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetUserDataBase() As String
        If Not HttpContext.Current.Request.Cookies("userdb") Is Nothing Then
            Return HttpContext.Current.Request.Cookies("userdb").Value
            Exit Function
        End If
        Dim dtSet As DataSet
        dtSet = GetDataSet("ORUserDatabase_sp", New SqlParameter("@UserName", HttpContext.Current.User.Identity.Name))
        Dim dbName As String = String.Empty
        If (dtSet.Tables.Count > 0) Then
            If dtSet.Tables(0).Rows.Count > 0 Then
                dbName = dtSet.Tables(0).Rows(0)(0).ToString()
            End If
        End If
        If (String.IsNullOrEmpty(dbName)) Then
            dbName = "NA"
        End If
        Return dbName
    End Function
End Class
