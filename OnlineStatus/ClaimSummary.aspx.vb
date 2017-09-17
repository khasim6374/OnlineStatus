Imports System.Data.SqlClient

Public Class ClaimSummary1
    Inherits System.Web.UI.Page
    Dim TotClaimCount As Double
    Dim TotGross As Double
    Dim TotRealized As Double
    Dim TotOutstanding As Double
    Dim TotGainShare As Double
    Dim TotPerfomance As Double
    Dim TotNet As Double
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then Return
        LoadClaimSummary(String.Empty)
    End Sub
    Public Sub LoadClaimSummary(ByVal strSort As String)

        Try
            Dim sqlDb As New SqlDb
            Dim dtSet As New DataSet
            Dim DataBaseName = sqlDb.GetUserDataBase()
            dtSet = sqlDb.GetDataSet("ORClaimSummary_sp", New SqlParameter("@database", DataBaseName))
            If (strSort <> String.Empty) Then
                dtSet.Tables(0).DefaultView.Sort = strSort
            End If
            grdClaimSummary.DataSourceID = Nothing
            grdClaimSummary.DataSource = dtSet
            grdClaimSummary.DataBind()

            Dim sqlDb1 As New SqlDb
            Dim dtSet1 As New DataSet
            Dim ClaimSummaryCount = grdClaimSummary.Rows.Count
            Dim RootCauseCount = If((sqlDb1.GetDataSet("ORRootcause_sp", New SqlParameter("@database", DataBaseName))) Is Nothing, 0, (sqlDb1.GetDataSet("ORRootcause_sp", New SqlParameter("@database", DataBaseName))).Tables(0).Rows.Count)
            Dim BusinessUnitCount = If((sqlDb1.GetDataSet("OREntity_sp", New SqlParameter("@database", DataBaseName))) Is Nothing, 0, (sqlDb1.GetDataSet("OREntity_sp", New SqlParameter("@database", DataBaseName))).Tables(0).Rows.Count)
            Dim CurrentItemsCount = If((sqlDb1.GetDataSet("ORItemsUnderReview_SP", New SqlParameter("@database", DataBaseName))) Is Nothing, 0, (sqlDb1.GetDataSet("ORItemsUnderReview_SP", New SqlParameter("@database", DataBaseName))).Tables(0).Rows.Count)
            If ClaimSummaryCount < 1 And RootCauseCount < 1 And BusinessUnitCount < 1 And CurrentItemsCount < 1 Then Response.Redirect("~/claimsubmission.aspx")
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetSortDirection(ByVal column As String) As String

        ' By default, set the sort direction to ascending.
        Dim sortDirection = "ASC"

        ' Retrieve the last column that was sorted.
        Dim sortExpression = TryCast(ViewState("SortExpression"), String)

        If sortExpression IsNot Nothing Then
            ' Check if the same column is being sorted.
            ' Otherwise, the default value can be returned.
            If sortExpression = column Then
                Dim lastDirection = TryCast(ViewState("SortDirection"), String)
                If lastDirection IsNot Nothing _
                  AndAlso lastDirection = "ASC" Then

                    sortDirection = "DESC"

                End If
            End If
        End If

        ' Save new values in ViewState.
        ViewState("SortDirection") = sortDirection
        ViewState("SortExpression") = column

        Return sortDirection

    End Function
    Enum grdCols
        SubmissionDate = 0
        ClaimCount = 1
        Gross = 2
        Realized = 3
        Outstanding = 4
        RevenewFees = 5
        Net = 6
        Credit_Status = 7
    End Enum
    Protected Sub grdClaimSummary_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grdClaimSummary.RowDataBound
        If e.Row.Cells.Count = 8 Then
            e.Row.Cells(grdCols.Credit_Status).Visible = False
        End If
        If e.Row.RowType = DataControlRowType.Header Then
            e.Row.CssClass = "grdHeaderBg"
            e.Row.Cells(grdCols.RevenewFees).Text = "Revenew Fees"
        End If
        If e.Row.Cells.Count = 8 Then
            e.Row.Cells(grdCols.Gross).CssClass = "rgtBordr"
            e.Row.Cells(grdCols.Outstanding).CssClass = "rgtBordr"
        End If

        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.Cells.Count = 8 Then
                'e.Row.CssClass = "rgtBordr"
                Try
                    e.Row.Cells(grdCols.SubmissionDate).Text = Convert.ToDateTime(e.Row.Cells(grdCols.SubmissionDate).Text).ToString("MM/dd/yyyy")
                Catch ex As Exception

                End Try

                e.Row.Cells(grdCols.SubmissionDate).HorizontalAlign = HorizontalAlign.Center

                TotClaimCount += Convert.ToDouble(e.Row.Cells(grdCols.ClaimCount).Text)
                e.Row.Cells(grdCols.ClaimCount).HorizontalAlign = HorizontalAlign.Center
                Dim lnkClaim = New HyperLink()
                lnkClaim.Text = e.Row.Cells(grdCols.ClaimCount).Text
                lnkClaim.NavigateUrl = "Javascript:void();"
                lnkClaim.Attributes("onclick") = "ShowClaimSummaryPopup('" + e.Row.Cells(grdCols.SubmissionDate).Text + "','" + e.Row.Cells(grdCols.Credit_Status).Text + "')"
                e.Row.Cells(grdCols.ClaimCount).Controls.Add(lnkClaim)

                TotGross += Convert.ToDouble(e.Row.Cells(grdCols.Gross).Text)
                e.Row.Cells(grdCols.Gross).Text = Convert.ToDouble(e.Row.Cells(grdCols.Gross).Text).ToString("C0")
                e.Row.Cells(grdCols.Gross).HorizontalAlign = HorizontalAlign.Right

                TotRealized += Convert.ToDouble(e.Row.Cells(grdCols.Realized).Text)
                e.Row.Cells(grdCols.Realized).Text = Convert.ToDouble(e.Row.Cells(grdCols.Realized).Text).ToString("C0")
                e.Row.Cells(grdCols.Realized).HorizontalAlign = HorizontalAlign.Right

                TotOutstanding += Convert.ToDouble(e.Row.Cells(grdCols.Outstanding).Text)
                e.Row.Cells(grdCols.Outstanding).Text = Convert.ToDouble(e.Row.Cells(grdCols.Outstanding).Text).ToString("C0")
                e.Row.Cells(grdCols.Outstanding).HorizontalAlign = HorizontalAlign.Right

                'TotGainShare += Convert.ToDouble(e.Row.Cells(grdCols.Gain).Text)
                'e.Row.Cells(grdCols.Gain).Text = Convert.ToDouble(e.Row.Cells(grdCols.Gain).Text).ToString("C0")
                'e.Row.Cells(grdCols.Gain).HorizontalAlign = HorizontalAlign.Right

                TotPerfomance += Convert.ToDouble(e.Row.Cells(grdCols.RevenewFees).Text)
                e.Row.Cells(grdCols.RevenewFees).Text = Convert.ToDouble(e.Row.Cells(grdCols.RevenewFees).Text).ToString("C0")
                e.Row.Cells(grdCols.RevenewFees).HorizontalAlign = HorizontalAlign.Right

                TotNet += Convert.ToDouble(e.Row.Cells(grdCols.Net).Text)
                e.Row.Cells(grdCols.Net).Text = Convert.ToDouble(e.Row.Cells(grdCols.Net).Text).ToString("C0")
                e.Row.Cells(grdCols.Net).HorizontalAlign = HorizontalAlign.Right

            End If
        End If
        If e.Row.RowType = DataControlRowType.Footer Then
            If e.Row.Cells.Count = 8 Then
                e.Row.Cells(grdCols.SubmissionDate).Text = "Totals"
                e.Row.Cells(grdCols.SubmissionDate).CssClass = "topBorder"
                e.Row.Cells(grdCols.ClaimCount).HorizontalAlign = HorizontalAlign.Center
                e.Row.Cells(grdCols.ClaimCount).Text = TotClaimCount
                e.Row.Cells(grdCols.ClaimCount).CssClass = "topBorder"
                e.Row.Cells(grdCols.Gross).Text = TotGross.ToString("C0")
                e.Row.Cells(grdCols.Gross).CssClass = "toprightBorder"
                e.Row.Cells(grdCols.Gross).HorizontalAlign = HorizontalAlign.Right
                e.Row.Cells(grdCols.Realized).Text = TotRealized.ToString("C0")
                e.Row.Cells(grdCols.Realized).CssClass = "topBorder"
                e.Row.Cells(grdCols.Realized).HorizontalAlign = HorizontalAlign.Right
                e.Row.Cells(grdCols.Outstanding).Text = TotOutstanding.ToString("C0")
                e.Row.Cells(grdCols.Outstanding).CssClass = "toprightBorder"
                e.Row.Cells(grdCols.Outstanding).HorizontalAlign = HorizontalAlign.Right
                'e.Row.Cells(grdCols.Gain).Text = TotGainShare.ToString("C0")
                'e.Row.Cells(grdCols.Gain).CssClass = "topBorder"
                'e.Row.Cells(grdCols.Gain).HorizontalAlign = HorizontalAlign.Right
                e.Row.Cells(grdCols.RevenewFees).Text = TotPerfomance.ToString("C0")
                e.Row.Cells(grdCols.RevenewFees).CssClass = "topBorder"
                e.Row.Cells(grdCols.RevenewFees).HorizontalAlign = HorizontalAlign.Right
                e.Row.Cells(grdCols.Net).Text = TotNet.ToString("C0")
                e.Row.Cells(grdCols.Net).CssClass = "topBorder"
                e.Row.Cells(grdCols.Net).HorizontalAlign = HorizontalAlign.Right
                e.Row.Font.Bold = True
                e.Row.CssClass = "topBorder"
            End If
        End If
    End Sub

    Protected Sub grdClaimSummary_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles grdClaimSummary.PreRender

    End Sub

    Protected Sub grdClaimSummary_Sorting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSortEventArgs) Handles grdClaimSummary.Sorting
        LoadClaimSummary("[" & e.SortExpression & "] " & GetSortDirection(e.SortExpression))
    End Sub
End Class