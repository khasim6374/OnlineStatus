Imports System.Data.SqlClient
Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sqlDb As New SqlDb
        Dim dtSet As New DataSet
        Dim contData = sqlDb.GetDataSet("USP_Check_AuditShow", New SqlParameter("@Username", Context.User.Identity.Name))
        If Not contData Is Nothing Then
            If contData.Tables.Count > 0 Then
                If contData.Tables(0).Rows.Count > 0 Then
                    Dim isdt = contData.Tables(0).Rows(0)(0)
                    If isdt = 1 Then
                        nbMain.Groups(5).Visible = False
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub btnPdf_Click(sender As Object, e As EventArgs) Handles btnPdf.Click
        Response.Redirect("~/Report/export.aspx?print=status")
    End Sub



End Class