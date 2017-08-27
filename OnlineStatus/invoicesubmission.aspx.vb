Public Class invoicesubmission
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hdnDatabase.Value = New SqlDb().GetUserDataBase()
    End Sub
End Class