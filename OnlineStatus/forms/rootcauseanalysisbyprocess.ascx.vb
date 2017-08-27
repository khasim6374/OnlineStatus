Imports System.Data.SqlClient
Public Class rootcauseanalysisbyprocess
    Inherits System.Web.UI.UserControl
    Dim TotClaim As Double
    Dim TotPerClaim As Double
    Dim TotGross As Double
    Dim TotPerGross As Double
    Dim CrntRowVal As String
    Dim nxtRowVal As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadRootCauseSummary()
    End Sub
    Public Sub LoadRootCauseSummary()
        Try
            Dim sqlDb As New SqlDb
            Dim dtSet As New DataSet
            dtSet = sqlDb.GetDataSet("ORprocess_sp", New SqlParameter("@database", sqlDb.GetUserDataBase()))
            grdRootCause.DataSourceID = Nothing
            grdRootCause.DataSource = dtSet
            grdRootCause.DataBind()
            crtRootCause.DataSource = dtSet
            crtRootCause.Series("Series1").XValueMember = "Process"
            crtRootCause.Series("Series1").YValueMembers = "TotalGross"
            crtRootCause.DataBind()
        Catch ex As Exception

        End Try
    End Sub
    Enum grdCols
        Category = 0
        ClaimCount = 1
        TotalClaim = 2
        GrossRecoveries = 3
        TotalGross = 4
    End Enum

    Protected Sub grdRootCause_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grdRootCause.RowDataBound
        If e.Row.RowType = DataControlRowType.Header Then
            e.Row.CssClass = "grdHeaderBg"
            e.Row.Cells(grdCols.TotalGross).Text = "% Total"
            e.Row.Cells(grdCols.TotalClaim).Text = "% Total"
        End If
        If e.Row.RowType = DataControlRowType.Header Then
            e.Row.Cells(0).HorizontalAlign = HorizontalAlign.Left
            e.Row.Cells(2).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(3).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(4).HorizontalAlign = HorizontalAlign.Right
        End If
        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.Cells.Count > 3 Then
                TotClaim += e.Row.Cells(1).Text
                TotPerClaim += e.Row.Cells(2).Text
                TotGross += e.Row.Cells(3).Text
                TotPerGross += e.Row.Cells(4).Text
                e.Row.Cells(2).Text = Convert.ToDouble(e.Row.Cells(2).Text).ToString(".0") & "%"
                e.Row.Cells(4).Text = Convert.ToDouble(e.Row.Cells(4).Text).ToString(".0") & "%"
                e.Row.Cells(3).Text = Convert.ToDouble(e.Row.Cells(3).Text).ToString("C0")


                e.Row.Cells(1).HorizontalAlign = HorizontalAlign.Center
                e.Row.Cells(2).HorizontalAlign = HorizontalAlign.Right
                e.Row.Cells(3).HorizontalAlign = HorizontalAlign.Right
                e.Row.Cells(4).HorizontalAlign = HorizontalAlign.Right

                Dim lnkClaim = New HyperLink()
                lnkClaim.Text = e.Row.Cells(1).Text
                lnkClaim.NavigateUrl = "Javascript:void();"
                lnkClaim.Attributes("onclick") = "ShowrootcauseanalysisByprocessPopup('" + e.Row.Cells(0).Text + "')"
                e.Row.Cells(1).Controls.Add(lnkClaim)
            End If
        End If
        If e.Row.RowType = DataControlRowType.Footer Then
            If e.Row.Cells.Count > 3 Then
                e.Row.Cells(0).Text = "Totals"
                e.Row.Cells(0).CssClass = "topBorder"
                e.Row.Cells(1).HorizontalAlign = HorizontalAlign.Center
                e.Row.Cells(1).Text = TotClaim
                e.Row.Cells(1).CssClass = "topBorder"
                e.Row.Cells(2).Text = TotPerClaim.ToString("N1") & "%"
                e.Row.Cells(2).CssClass = "topBorder"
                e.Row.Cells(2).HorizontalAlign = HorizontalAlign.Right
                e.Row.Cells(3).Text = TotGross.ToString("C0")
                e.Row.Cells(3).CssClass = "topBorder"
                e.Row.Cells(3).HorizontalAlign = HorizontalAlign.Right
                e.Row.Cells(4).Text = TotPerGross.ToString("N1") & "%"
                e.Row.Cells(4).CssClass = "topBorder"
                e.Row.Cells(4).HorizontalAlign = HorizontalAlign.Right

                e.Row.Font.Bold = True
                e.Row.CssClass = "topBorder"
            End If
        End If
    End Sub


    Protected Sub grdRootCause_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles grdRootCause.PreRender
        If grdRootCause.Rows.Count < 1 Then Return

        'Dim isLast As Boolean = False
        'Dim insertedRows As Integer = 0
        'Dim rowcount As Integer = 0

        'Dim TotalClaimCount As Double
        'Dim TotalClaimCountPer As Double
        'Dim TotalGrossRec As Double
        'Dim TotalGrossRecPer As Double
        'Dim ExtraRows = 0
        'While rowcount > -1
        '    CrntRowVal = grdRootCause.Rows(rowcount).Cells(0).Text
        '    If (rowcount + 1) >= grdRootCause.Rows.Count Then
        '        nxtRowVal = ""
        '        isLast = True
        '    Else
        '        nxtRowVal = grdRootCause.Rows(rowcount + 1).Cells(0).Text
        '    End If
        '    rowcount += 1
        '    If CrntRowVal = nxtRowVal Then
        '        TotClaim += grdRootCause.Rows(rowcount - 1).Cells(grdCols.ClaimCount).Text
        '        TotPerClaim += grdRootCause.Rows(rowcount - 1).Cells(grdCols.TotalClaim).Text
        '        TotGross += grdRootCause.Rows(rowcount - 1).Cells(grdCols.GrossRecoveries).Text
        '        TotPerGross += grdRootCause.Rows(rowcount - 1).Cells(grdCols.TotalGross).Text
        '        Continue While
        '    Else
        '        insertedRows += 1
        '        ExtraRows += 1
        '        'Dim subTotalRow As GridViewRow = New GridViewRow(0, 0, DataControlRowType.DataRow, DataControlRowState.Insert)

        '        'Dim dummycol As TableCell = New TableCell()
        '        'dummycol.CssClass = "SubTotalwithoutborder"
        '        'dummycol.Text = ""
        '        'dummycol.HorizontalAlign = HorizontalAlign.Left


        '        'Dim HeaderCell As TableCell = New TableCell()
        '        'HeaderCell.Text = "Sub-Total"
        '        'HeaderCell.CssClass = "SubTotal"
        '        'HeaderCell.HorizontalAlign = HorizontalAlign.Right
        '        ''subTotalRow.Cells.Add(dummycol)
        '        'subTotalRow.Cells.Add(HeaderCell)


        '        TotClaim += grdRootCause.Rows(rowcount - 1).Cells(grdCols.ClaimCount).Text
        '        'Dim totalClaim1 As TableCell = New TableCell()
        '        'totalClaim1.Text = TotClaim
        '        'totalClaim1.CssClass = "SubTotal"
        '        'totalClaim1.HorizontalAlign = HorizontalAlign.Center
        '        'subTotalRow.Cells.Add(totalClaim1)
        '        TotalClaimCount += TotClaim


        '        TotPerClaim += grdRootCause.Rows(rowcount - 1).Cells(grdCols.TotalClaim).Text
        '        'Dim totalPerClaim1 As TableCell = New TableCell()
        '        'totalPerClaim1.CssClass = "SubTotal"
        '        'totalPerClaim1.Text = TotPerClaim.ToString(".0") & "%"
        '        'totalPerClaim1.HorizontalAlign = HorizontalAlign.Right
        '        'subTotalRow.Cells.Add(totalPerClaim1)
        '        TotalClaimCountPer += TotPerClaim

        '        TotGross += grdRootCause.Rows(rowcount - 1).Cells(grdCols.GrossRecoveries).Text
        '        'Dim TotGrossCol1 As TableCell = New TableCell()
        '        'TotGrossCol1.CssClass = "SubTotal"
        '        'TotGrossCol1.Text = TotGross.ToString("C0")
        '        'TotGrossCol1.HorizontalAlign = HorizontalAlign.Right
        '        'subTotalRow.Cells.Add(TotGrossCol1)
        '        TotalGrossRec += TotGross

        '        TotPerGross += grdRootCause.Rows(rowcount - 1).Cells(grdCols.TotalGross).Text
        '        'Dim TotPerGrossCol1 As TableCell = New TableCell()
        '        'TotPerGrossCol1.CssClass = "SubTotal"
        '        'TotPerGrossCol1.Text = TotPerGross.ToString(".0") & "%"
        '        'TotPerGrossCol1.HorizontalAlign = HorizontalAlign.Right
        '        'subTotalRow.Cells.Add(TotPerGrossCol1)
        '        TotalGrossRecPer += TotPerGross

        '        'grdRootCause.Controls(0).Controls.AddAt(rowcount + insertedRows, subTotalRow)
        '        TotClaim = 0
        '        TotPerClaim = 0
        '        TotGross = 0
        '        TotPerGross = 0
        '        If (isLast) Then Exit While
        '    End If
        'End While

        'Dim dummycol1 As TableCell = New TableCell()
        'dummycol1.Text = ""
        'dummycol1.CssClass = "TopBorderWithoutGray"
        'dummycol1.HorizontalAlign = HorizontalAlign.Left


        'Dim subTotalRow1 As GridViewRow = New GridViewRow(0, 0, DataControlRowType.DataRow, DataControlRowState.Insert)
        'subTotalRow1.Font.Bold = True
        'subTotalRow1.CssClass = "GrandTotal"
        'Dim HeaderCell1 As TableCell = New TableCell()
        'HeaderCell1.Text = "Totals"
        'HeaderCell1.HorizontalAlign = HorizontalAlign.Left

        'subTotalRow1.Cells.Add(HeaderCell1)
        ''subTotalRow1.Cells.Add(dummycol1)
        'Dim totalClaim As TableCell = New TableCell()
        'totalClaim.Text = TotalClaimCount
        'totalClaim.HorizontalAlign = HorizontalAlign.Center
        'subTotalRow1.Cells.Add(totalClaim)

        'Dim totalPerClaim As TableCell = New TableCell()
        'totalPerClaim.Text = TotalClaimCountPer.ToString(".0") & "%"
        'totalPerClaim.HorizontalAlign = HorizontalAlign.Right
        'subTotalRow1.Cells.Add(totalPerClaim)


        'Dim TotGrossCol As TableCell = New TableCell()
        'TotGrossCol.Text = TotalGrossRec.ToString("C0")
        'TotGrossCol.HorizontalAlign = HorizontalAlign.Right
        'subTotalRow1.Cells.Add(TotGrossCol)

        'Dim TotPerGrossCol As TableCell = New TableCell()
        'TotPerGrossCol.Text = TotalGrossRecPer.ToString(".0") & "%"
        'TotPerGrossCol.HorizontalAlign = HorizontalAlign.Right
        'subTotalRow1.Cells.Add(TotPerGrossCol)


        ''grdRootCause.Controls(0).Controls.AddAt(rowcount + insertedRows + 1, subTotalRow1)




        ''For rowIndex = ((grdRootCause.Rows.Count) - 2) To 0 Step -1
        ''    Dim fst As GridViewRow = grdRootCause.Rows(0)
        ''    fst.Cells(grdCols.Category).CssClass = "GroupCategory"
        ''    fst.Cells(grdCols.Category).Font.Bold = True
        ''    fst.Cells(grdCols.Category).VerticalAlign = VerticalAlign.Top
        ''    Dim row As GridViewRow = grdRootCause.Rows(rowIndex)
        ''    Dim prevtRow As GridViewRow = grdRootCause.Rows(rowIndex + 1)
        ''    If row.Cells(grdCols.Category).Text = prevtRow.Cells(grdCols.Category).Text Then
        ''        row.Cells(grdCols.Category).RowSpan = If(prevtRow.Cells(grdCols.Category).RowSpan < 2, 2, prevtRow.Cells(grdCols.Category).RowSpan + 1)
        ''        row.Cells(grdCols.Category).CssClass = "GroupCategory"
        ''        row.Cells(grdCols.Category).Font.Bold = True
        ''        row.Cells(grdCols.Category).VerticalAlign = VerticalAlign.Top
        ''        prevtRow.Cells(grdCols.Category).Visible = False
        ''    End If
        ''    prevtRow.Cells(grdCols.Category).CssClass = "GroupCategory"
        ''    prevtRow.Cells(grdCols.Category).Font.Bold = True
        ''    prevtRow.Cells(grdCols.Category).VerticalAlign = VerticalAlign.Top
        ''Next




        'For i = 0 To grdRootCause.Rows.Count - 1
        '    grdRootCause.Rows(i).Cells(grdCols.TotalClaim).Text = Convert.ToDouble(grdRootCause.Rows(i).Cells(grdCols.TotalClaim).Text).ToString(".0") & "%"
        '    grdRootCause.Rows(i).Cells(grdCols.TotalClaim).HorizontalAlign = HorizontalAlign.Right
        '    grdRootCause.Rows(i).Cells(grdCols.TotalGross).Text = Convert.ToDouble(grdRootCause.Rows(i).Cells(grdCols.TotalGross).Text).ToString(".0") & "%"
        '    grdRootCause.Rows(i).Cells(grdCols.TotalGross).HorizontalAlign = HorizontalAlign.Right

        '    grdRootCause.Rows(i).Cells(grdCols.GrossRecoveries).Text = Convert.ToDouble(grdRootCause.Rows(i).Cells(grdCols.GrossRecoveries).Text).ToString("C0")
        '    grdRootCause.Rows(i).Cells(grdCols.GrossRecoveries).HorizontalAlign = HorizontalAlign.Right

        '    grdRootCause.Rows(i).Cells(grdCols.ClaimCount).HorizontalAlign = HorizontalAlign.Center

        'Next

        'If grdRootCause.Columns.Count > 0 Then grdRootCause.Columns(grdCols.Category).ControlStyle.Font.Bold = True

    End Sub


    Protected Sub grdRootCause_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grdRootCause.RowCreated
        'CrntRowVal = e.Row.Cells(grdCols.Category).Text
        'NextPrevFormat = e.Row.Cells(grdCols.Category + 1).Text
        'If CrntRowVal = NextPrevFormat Then
        '    TotClaim += e.Row.Cells(grdCols.ClaimCount).Text
        'End If

        'Dim HeaderCell As TableCell = New TableCell()
        'HeaderCell.Text = "Sub-Total"
        'HeaderCell.HorizontalAlign = HorizontalAlign.Left
        'e.Row.Cells.Add(HeaderCell)
    End Sub

    Protected Sub crtRootCause_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles crtRootCause.PreRender
        'crtRootCause.Series("Series1").Points(0)("Exploded") = True
        'crtRootCause.Series("Series1").Points(1)("Exploded") = True
        'crtRootCause.Series("Series1").Points(2)("Exploded") = True
        'crtRootCause.Series("Series1").Points(3)("Exploded") = True
        'crtRootCause.Series("Series1").Points(4)("Exploded") = True
        'crtRootCause.Series("Series1").Points(5)("Exploded") = True
        'crtRootCause.Series("Series1").Points(6)("Exploded") = True
    End Sub
End Class