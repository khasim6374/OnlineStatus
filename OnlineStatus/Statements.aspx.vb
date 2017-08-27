Public Class Statements
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (IsPostBack) Then Return
        Dim sqlDb As New SqlDb
        SqlDS.SelectParameters.Add("database", sqlDb.GetUserDataBase())
        SqlDS.DataBind()
        grdResponded.FilterExpression = "[Column1] = 'Responded'"
        grdNotResponded.FilterExpression = "[Column1] = 'Not Responded'"
    End Sub

    Protected Sub btnXls_Click(sender As Object, e As EventArgs) Handles btnXls.Click
        Response.Redirect("~/Report/export.aspx?print=statements&t=" & ASPxPageControl1.ActiveTabIndex)
    End Sub
End Class