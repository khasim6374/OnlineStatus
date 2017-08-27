Imports System.Data.SqlClient
Public Class rptStatus


    Private Sub XrSubreport1_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrSubclaimsummary.BeforePrint
        XrSubclaimsummary.ReportSource = New rptClaimSummary
        XrSubrootcauseanalysis.ReportSource = New rptRootcauseanalysis
        XrSubrootcauseanalysischart.ReportSource = New rptRootcauseanalysisChart
        XrSubbusinessunitanalysis.ReportSource = New rptBusinessunitanalysis
        XrSubcurrentitemsunder.ReportSource = New rptItemsUnderReview
        XrSubbusinessunitanalysisChart.ReportSource = New rptBusinessunitanalysisChart
        XrSubauditprogress.ReportSource = New rptAuditprogressChart1
        XrSubRootcauseanalysisbyprocess.ReportSource = New rptRootcauseanalysisbyprocess
        XrSubRootcauseanalysisbyprocessChart.ReportSource = New rptRootcauseanalysisChartByProcess
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim sqlDb As New SqlDb
        Dim dtSet As New DataSet
        dtSet = sqlDb.GetDataSet("GetUserLogo_sp", New SqlParameter("@UserName", HttpContext.Current.User.Identity.Name))
        If (dtSet.Tables(0).Rows.Count > 0) Then
            imgClient.ImageUrl = dtSet.Tables(0).Rows(0)(0)
            imgClient.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
            'imgClient.LocationF = New System.Drawing.PointF(800 - imgClient.WidthF, 6.5F)
        End If
        MyBase.Landscape = True
    End Sub

    Private Sub XrSubauditprogress_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrSubauditprogress.BeforePrint
        Dim sqlDb As New SqlDb
        Dim contData = SqlDb.GetDataSet("USP_Check_AuditShow", New SqlParameter("@Username", HttpContext.Current.User.Identity.Name))
        If Not contData Is Nothing Then
            If contData.Tables.Count > 0 Then
                If contData.Tables(0).Rows.Count > 0 Then
                    Dim isdt = contData.Tables(0).Rows(0)(0)
                    If isdt = 1 Then
                        XrSubauditprogress.Visible = False
                    End If
                End If
            End If
        End If
    End Sub
End Class