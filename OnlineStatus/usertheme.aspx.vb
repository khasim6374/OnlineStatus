Imports System.Data.SqlClient
Public Class usertheme
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Request.QueryString("t") = "" Then
                lblStatus.Text = "Theme changed successfully."
            End If
            If Not IsPostBack Then
                Dim sqlDb As New SqlDb
                Dim dtSet As New DataSet
                dtSet = sqlDb.GetDataSet("GetMyTheme", New SqlParameter("@UserName", HttpContext.Current.User.Identity.Name))
                If dtSet.Tables(0).Rows.Count > 0 And Not IsDBNull(dtSet.Tables(0).Rows(0)(0)) Then
                    rblThemes.DataBind()
                    If dtSet.Tables(0).Rows(0)(0).ToString().Trim() <> "" Then rblThemes.Items.FindByValue(dtSet.Tables(0).Rows(0)(0)).Selected = True
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Protected Sub rblThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rblThemes.SelectedIndexChanged
        Dim sqlDb As New SqlDb
        sqlDb.GetDataSet("SaveMyTheme", New SqlParameter("@UserName", Context.User.Identity.Name), New SqlParameter("@Theme", rblThemes.SelectedItem.Value))
        Response.Redirect("~/usertheme.aspx?t=s")
    End Sub
End Class