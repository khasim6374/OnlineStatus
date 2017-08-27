Public Class ActionItem
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (IsPostBack) Then Return
        Dim sqlDb As New SqlDb
        sqlActionItem.SelectParameters.Add("database", sqlDb.GetUserDataBase())
        sqlActionItem.DataBind()
    End Sub

    Protected Sub grdActionItems_RowInserting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataInsertingEventArgs) Handles grdActionItems.RowInserting
        Dim sqlDb As New SqlDb
        e.NewValues("database") = SqlDb.GetUserDataBase()
    End Sub

    Protected Sub grdActionItems_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles grdActionItems.RowUpdating
        Dim sqlDb As New SqlDb
        e.NewValues("database") = sqlDb.GetUserDataBase()
    End Sub
End Class