Imports System.Data.SqlClient
Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString("ReturnUrl"))
        If Not Request.Cookies("userdb") Is Nothing Then
            Request.Cookies.Remove("userdb")
        End If

    End Sub

    Protected Sub LoginButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim sqlDb As New SqlDb
        Dim dtSet As New DataSet
        Dim dtSet1 As New DataSet
        Dim sqlDb1 As New SqlDb
        dtSet = sqlDb.GetDataSet("Login_sp", New SqlParameter("@UserName", LoginUser.UserName), New SqlParameter("@Password", LoginUser.Password))
        If dtSet.Tables.Count > 0 Then
            If (dtSet.Tables(0).Rows.Count > 0) Then
                dtSet1 = sqlDb1.GetDataSet("spORportalAudit", New SqlParameter("@IPAddress", Request.UserHostAddress), New SqlParameter("@UserId", LoginUser.UserName), New SqlParameter("@Success", True), New SqlParameter("@Audit", ""))
                FormsAuthentication.RedirectFromLoginPage(LoginUser.UserName, False)
            Else
                dtSet1 = sqlDb1.GetDataSet("spORportalAudit", New SqlParameter("@IPAddress", Request.UserHostAddress), New SqlParameter("@UserId", LoginUser.UserName), New SqlParameter("@Success", False), New SqlParameter("@Audit", ""))
                LoginUser.FailureText = "Invalid Username and password"
            End If
        Else
            dtSet1 = sqlDb1.GetDataSet("spORportalAudit", New SqlParameter("@IPAddress", Request.UserHostAddress), New SqlParameter("@UserId", LoginUser.UserName), New SqlParameter("@Success", False), New SqlParameter("@Audit", ""))
            LoginUser.FailureText = "Invalid Username and password"
        End If
    End Sub
End Class