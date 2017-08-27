Imports System.Web.SessionState
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Web.Routing
Imports System.Web
Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_PostMapRequestHandler(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If Not HttpContext.Current.User.Identity.Name = Nothing Then
                Dim activePage = TryCast(HttpContext.Current.Handler, Page)
                If IsNothing(activePage) Then
                    Return
                End If
                Dim sqlDb As New SqlDb
                Dim dtSet As New DataSet
                dtSet = sqlDb.GetDataSet("GetMyTheme", New SqlParameter("@UserName", HttpContext.Current.User.Identity.Name))
                If dtSet.Tables(0).Rows.Count > 0 Then
                    activePage.Theme = IIf(IsDBNull(dtSet.Tables(0).Rows(0)(0)), "Revenew", dtSet.Tables(0).Rows(0)(0).ToString())
                Else
                    activePage.Theme = "Revenew"
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started

    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)

        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

End Class