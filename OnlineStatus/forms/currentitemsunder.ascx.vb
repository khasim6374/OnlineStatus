Imports System.Data.SqlClient

Public Class currentitemsunder
    Inherits System.Web.UI.UserControl
    Dim _totProAmt As Double
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            LoadCurrentItems()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub LoadCurrentItems()
        Dim sqlDb As New SqlDb
        grdCurrentItems.DataSourceID = Nothing
        grdCurrentItems.DataSource = sqlDb.GetDataSet("ORItemsUnderReview_SP", New SqlParameter("@database", sqlDb.GetUserDataBase()))
        grdCurrentItems.DataBind()
    End Sub

    Protected Sub grdCurrentItems_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grdCurrentItems.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.Cells.Count > 4 Then
                _totProAmt += e.Row.Cells(4).Text
            End If
        End If
        If e.Row.RowType = DataControlRowType.Footer Then
            If e.Row.Cells.Count > 4 Then
                e.Row.Cells(0).Text = ""
                e.Row.Cells(0).ColumnSpan = 5
                e.Row.Cells(0).CssClass = "topBorder"
                e.Row.Cells(0).HorizontalAlign = HorizontalAlign.Right
                e.Row.Cells(0).Text = "Probabilistic Amount of Current Pipeline: " + _totProAmt.ToString("C0")
                e.Row.Cells(0).CssClass = "topBorder"
                'e.Row.Cells(1).CssClass = "topBorder"
                e.Row.Cells(0).HorizontalAlign = HorizontalAlign.Right
                e.Row.Cells(2).CssClass = "topBorder"
                e.Row.Font.Bold = True
                e.Row.CssClass = "topBorder"
            End If
        End If
        If e.Row.RowType = DataControlRowType.Header Then
            e.Row.Cells(2).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(3).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(4).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(5).HorizontalAlign = HorizontalAlign.Left
        End If
    End Sub
End Class