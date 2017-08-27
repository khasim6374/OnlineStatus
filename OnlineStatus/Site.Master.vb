Imports System.Data.SqlClient

Public Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Request.Url.PathAndQuery.Contains("account/login.aspx")) Then
            If Not Context.User.Identity.IsAuthenticated Then
                Response.Redirect("~/account/login.aspx")
            End If
        End If
        Dim sqlDb As New SqlDb
        If Not IsPostBack And Not String.IsNullOrEmpty(Context.User.Identity.Name) And Not lstDb Is Nothing Then
            lstDb.DataSource = sqlDb.GetDataSet("getUserDBList", New SqlParameter("@userName", Context.User.Identity.Name))
            lstDb.DataBind()
            If lstDb.Items.Count <= 0 Then
                auditdb.Visible = False
            Else
                If Not Request.Cookies("userdb") Is Nothing Then
                    Dim itm = lstDb.Items.FindByValue(Request.Cookies("userdb").Value)
                    If Not itm Is Nothing Then
                        itm.Selected = True
                    End If
                Else
                    Dim it = lstDb.Items.FindByText("Current Audit")
                    If Not it Is Nothing Then
                        it.Selected = True
                    ElseIf lstDb.Items.Count > 1 Then
                        lstDb.Items(0).Selected = True
                    End If
                End If
            End If
        End If

        Dim dtSet As New DataSet
        dtSet = sqlDb.GetDataSet("GetUserLogo_sp", New SqlParameter("@UserName", Context.User.Identity.Name))
        If Not dtSet Is Nothing Then
            If (dtSet.Tables(0).Rows.Count > 0) Then
                imgUserLogo.ImageUrl = dtSet.Tables(0).Rows(0)(0)
            End If
        End If

        Dim contData = sqlDb.GetDataSet("USP_Check_AuditShow", New SqlParameter("@Username", Context.User.Identity.Name))
        If Not contData Is Nothing Then
            If contData.Tables.Count > 0 Then
                If contData.Tables(0).Rows.Count > 0 Then
                    Dim isdt = contData.Tables(0).Rows(0)(0)
                    If isdt = 1 Then
                        stMenu.Visible = False
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub lstDb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDb.SelectedIndexChanged
        If Not lstDb.SelectedItem Is Nothing Then
            If Request.Cookies.AllKeys.Contains("userdb") Then
                Request.Cookies.Remove("userdb")
            End If
            Response.Cookies.Add(New HttpCookie("userdb", lstDb.SelectedItem.Value))
            lstDb.SelectedItem.Selected = True
            Response.Redirect(Request.Url.AbsolutePath)
        End If
    End Sub
End Class