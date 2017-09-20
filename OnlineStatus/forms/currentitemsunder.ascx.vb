Imports System.Data.SqlClient

Public Class currentitemsunder
    Inherits System.Web.UI.UserControl
    Dim _IssueCountAmt As Double
    Dim _OppAmt As Double
    Dim _IssueCountAmt2 As Double
    Dim _OppAmt2 As Double
    Dim _Probability As Double
    Dim _ProjectedAmt As Double
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Try
                LoadCurrentItems()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Public Sub LoadCurrentItems()
        Dim sqlDb As New SqlDb
        grdCurrentItems.DataSourceID = Nothing
        grdCurrentItems.DataSource = sqlDb.GetDataSet("ORWorkInProgress_SP", New SqlParameter("@database", sqlDb.GetUserDataBase()))
        'grdCurrentItems.DataBind()
    End Sub

    Protected Sub grdCurrentItems_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grdCurrentItems.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.Cells.Count > 1 Then
                If DataBinder.Eval(e.Row.DataItem, "Issue Count") IsNot Nothing And DataBinder.Eval(e.Row.DataItem, "Issue Count") IsNot "" Then
                    _IssueCountAmt += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Issue Count"))
                End If
                If DataBinder.Eval(e.Row.DataItem, "Opportunity Amount") IsNot Nothing And DataBinder.Eval(e.Row.DataItem, "Opportunity Amount") IsNot "" Then
                    _OppAmt += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Opportunity Amount"))
                End If
                If DataBinder.Eval(e.Row.DataItem, "Issue Count2") IsNot Nothing And DataBinder.Eval(e.Row.DataItem, "Issue Count2") IsNot "" Then
                    _IssueCountAmt2 += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Issue Count2"))
                End If
                If DataBinder.Eval(e.Row.DataItem, "Opportunity Amount2") IsNot Nothing And DataBinder.Eval(e.Row.DataItem, "Opportunity Amount2") IsNot "" Then
                    _OppAmt2 += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Opportunity Amount2"))
                End If
                If DataBinder.Eval(e.Row.DataItem, "Probability") IsNot Nothing And DataBinder.Eval(e.Row.DataItem, "Probability") IsNot "" Then
                    _Probability += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Probability"))
                End If
                If DataBinder.Eval(e.Row.DataItem, "Projected Amount") IsNot Nothing And DataBinder.Eval(e.Row.DataItem, "Projected Amount") IsNot "" Then
                    _ProjectedAmt += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Projected Amount"))
                End If
            End If
        End If
        If e.Row.RowType = DataControlRowType.Footer Then
            'If e.Row.Cells.Count > 4 Then
            '    e.Row.Cells(0).Text = ""
            '    'e.Row.Cells(0).ColumnSpan = 5
            '    e.Row.Cells(0).CssClass = "topBorder"
            '    e.Row.Cells(0).HorizontalAlign = HorizontalAlign.Right
            '    'e.Row.Cells(0).Text = "Probabilistic Amount of Current Pipeline: " + _totProAmt.ToString("C0")
            '    e.Row.Cells(0).CssClass = "topBorder"
            '    'e.Row.Cells(1).CssClass = "topBorder"
            '    'e.Row.Cells(0).HorizontalAlign = HorizontalAlign.Right
            '    e.Row.Cells(2).CssClass = "topBorder"
            '    e.Row.Font.Bold = True
            '    e.Row.CssClass = "topBorder"
            'Dim lblamount As Label = DirectCast(e.Row.FindControl("lblIssueCount"), Label)
            'Assign the total value to footer label control
            'lblamount.Text = "Total Value is : " + totalvalue.ToString()
            'End If
            If e.Row.Cells.Count > 6 Then
                e.Row.Cells(0).Text = "Totals"
                e.Row.Cells(0).Font.Bold = True
                e.Row.Cells(1).Text = _IssueCountAmt
                e.Row.Cells(1).Font.Bold = True
                e.Row.Cells(2).Text = _OppAmt.ToString("C0")
                e.Row.Cells(2).Font.Bold = True
                e.Row.Cells(3).Text = _IssueCountAmt2
                e.Row.Cells(3).Font.Bold = True
                e.Row.Cells(4).Text = _OppAmt2.ToString("C0")
                e.Row.Cells(4).Font.Bold = True
                e.Row.Cells(5).Text = _Probability.ToString() + "%"
                e.Row.Cells(5).Font.Bold = True
                e.Row.Cells(6).Text = _ProjectedAmt.ToString("C0")
                e.Row.Cells(6).Font.Bold = True
            End If
        End If
        'If e.Row.RowType = DataControlRowType.Header Then
        '    e.Row.Cells(2).HorizontalAlign = HorizontalAlign.Right
        '    e.Row.Cells(3).HorizontalAlign = HorizontalAlign.Right
        '    e.Row.Cells(4).HorizontalAlign = HorizontalAlign.Right
        '    e.Row.Cells(5).HorizontalAlign = HorizontalAlign.Left
        'End If
    End Sub
End Class