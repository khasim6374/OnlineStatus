Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.Web
Imports System.IO
Public Class export
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Select Case Request.QueryString("print").ToString()
            Case "status"
                printStatusReport()
            Case "claim"
                printClaimReport()
            Case "statements"
                printStatementReport()
            Case Else
        End Select


    End Sub
    Protected Sub printStatementReport()
        Dim type = Request.QueryString("t").ToString()
        Dim objStatus As New rptStatements
        If type = 0 Then
            objStatus.Type.Value = "Responded"
        Else
            objStatus.Type.Value = "Not Responded"
        End If
        Dim rptViewer As New ReportViewer()
        Dim ms As New MemoryStream()
        rptViewer.Report = objStatus
        objStatus.CreateDocument()
        Dim xlsExpo As New XlsExportOptions()
        objStatus.ExportToXls(ms, xlsExpo)
        ms.Seek(0, SeekOrigin.Begin)
        Dim reportData = ms.ToArray()
        Dim FileName As String = "Statement_Report_on_" & DateTime.Now.ToString().Replace(":", "_").Replace(" ", "_") & ".xls"
        Response.Clear()
        Response.AddHeader("Content-Disposition", "attachment; filename=" & FileName)
        Response.AddHeader("Content-Length", reportData.Length.ToString())
        Response.ContentType = "application/xls"
        Response.BinaryWrite(reportData)
    End Sub
    Protected Sub printStatusReport()
        Dim objStatus As New rptStatus()
        Dim rptViewer As New ReportViewer()
        Dim ms As New MemoryStream()
        rptViewer.Report = objStatus
        objStatus.Landscape = False
        objStatus.CreateDocument()
        Dim pdfExpo As New PdfExportOptions()
        pdfExpo.ImageQuality = PdfJpegImageQuality.Highest
        objStatus.ExportToPdf(ms, pdfExpo)
        ms.Seek(0, SeekOrigin.Begin)
        Dim reportData = ms.ToArray()
        Dim FileName As String = "Supplier_Payment_Review_Status_Report_on_" & DateTime.Now.ToString().Replace(":", "_").Replace(" ", "_") & ".pdf"
        Response.Clear()
        Response.AddHeader("Content-Disposition", "attachment; filename=" & FileName)
        Response.AddHeader("Content-Length", reportData.Length.ToString())
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(reportData)
    End Sub
    Protected Sub printClaimReport()
        Dim type = Request.QueryString("type").ToString()
        If type = "xls" Then
            Dim objStatus As New rptclaimsubmission
            Dim rptViewer As New ReportViewer()
            Dim ms As New MemoryStream()
            rptViewer.Report = objStatus
            objStatus.CreateDocument()
            Dim xlsExpo As New XlsExportOptions()
            objStatus.ExportToXls(ms, xlsExpo)
            ms.Seek(0, SeekOrigin.Begin)
            Dim reportData = ms.ToArray()
            Dim FileName As String = "Claim_Submission_Report_on_" & DateTime.Now.ToString().Replace(":", "_").Replace(" ", "_") & ".xls"
            Response.Clear()
            Response.AddHeader("Content-Disposition", "attachment; filename=" & FileName)
            Response.AddHeader("Content-Length", reportData.Length.ToString())
            Response.ContentType = "application/xls"
            Response.BinaryWrite(reportData)
        Else
            Dim objStatus As New rptclaimsubmission
            Dim rptViewer As New ReportViewer()
            Dim ms As New MemoryStream()
            rptViewer.Report = objStatus
            objStatus.CreateDocument()
            Dim pdfExpo As New PdfExportOptions()
            objStatus.ExportToPdf(ms, pdfExpo)
            ms.Seek(0, SeekOrigin.Begin)
            Dim reportData = ms.ToArray()
            Dim FileName As String = "Claim_Submission_Report_on_" & DateTime.Now.ToString().Replace(":", "_").Replace(" ", "_") & ".pdf"
            Response.Clear()
            Response.AddHeader("Content-Disposition", "attachment; filename=" & FileName)
            Response.AddHeader("Content-Length", reportData.Length.ToString())
            Response.ContentType = "application/pdf"
            Response.BinaryWrite(reportData)
        End If
    End Sub
   
End Class