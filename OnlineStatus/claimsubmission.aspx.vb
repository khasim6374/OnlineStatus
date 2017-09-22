Imports DevExpress.XtraPrinting
Imports System.IO
Imports System.Drawing
Imports System.Data.SqlClient
Imports DevExpress.Web
Imports System.Net
Imports System.Xml

Public Class claimsubmission
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sqlDb As New SqlDb
        hdnDatabase.Value = sqlDb.GetUserDataBase()
        If (IsPostBack) Then Return
        hdnFile.Add("attachement", "")
        popEmail.JSProperties("cpStatus") = "load"
    End Sub

    'Protected Sub grdClaimSubmission_Sorting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSortEventArgs) Handles grdClaimSubmission.Sorting
    '    'LoadData("[" & e.SortExpression & "] " & GetSortDirection(e.SortExpression))
    'End Sub
    Protected Sub LoadData(ByVal strSort As String)
        Dim sqlDb As New SqlDb
        Dim dtSet As New DataSet
        '  dtSet = sqlDb.GetDataSet("ORClaimsList_sp", New SqlParameter("@database", sqlDb.GetUserDataBase()))
        ' If (strSort <> String.Empty) Then
        '     dtSet.Tables(0).DefaultView.Sort = strSort
        ' End If
        ' grdClaimSubmission.DataSource = dtSet.Tables(0).DefaultView
        ' grdClaimSubmission.DataBind()
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

    'Protected Sub grdClaimSubmission_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles grdClaimSubmission.PageIndexChanging
    '    Dim strSort As String = String.Empty

    '    If Not String.IsNullOrEmpty(ViewState("SortExpression")) Then
    '        strSort = "[" & ViewState("SortExpression") & "] " & ViewState("SortDirection")
    '    End If
    '    grdClaimSubmission.PageIndex = e.NewPageIndex
    '    LoadData(strSort)
    'End Sub

    'Protected Sub grdClaimSubmission_BeforePerformDataSelect(ByVal sender As Object, ByVal e As EventArgs) Handles grdClaimSubmission.BeforePerformDataSelect
    '    'SqlDS.SelectParameters.Add("database", "demo")
    'End Sub




    Protected Sub grdClaimSubmission_RowValidating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataValidationEventArgs) Handles grdClaimSubmission.RowValidating, grdClaimSubmissionPending.RowValidating
        If e.NewValues("Status") = 2 And Trim(e.NewValues("Remarks")) = "" Then
            e.RowError = "Please, fill remarks."
        End If
    End Sub

    Protected Sub grdClaimSubmission_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles grdClaimSubmission.RowUpdating, grdClaimSubmissionPending.RowUpdating
        Dim usermail = grdClaimSubmission.GetRowValuesByKeyValue(e.NewValues("Claim_ID"), "LeadAuditorEmail")
        Dim toAddress = String.Empty
        Dim sqlDb As New SqlDb
        Dim dtSet As New DataSet
        Dim dtSet1 As New DataSet
        If e.NewValues("Status") <> 3 Then
            If (Not IsDBNull(usermail)) Then
                If (usermail <> "" And e.NewValues("Status") > 0) Then
                    Dim msg As String
                    If (e.NewValues("Status") = 1) Then msg = "accepted" Else msg = "rejected(" + e.NewValues("Remarks") + ") "
                    Dim objMail As New SendMail()
                    objMail.SentEmail(usermail, "Claim Status from Revenew", "Claim ID " & e.NewValues("Claim_ID") & " has " & msg, "")
                End If
            End If
            If (e.NewValues("Status") = 2) Then
                dtSet = sqlDb.GetDataSet("GetRevenewEmail_sp", New SqlParameter("@UserName", Context.User.Identity.Name))
                If (dtSet.Tables(0).Rows.Count > 0) Then
                    toAddress = dtSet.Tables(0).Rows(0)(0)
                End If
                If (Not IsDBNull(toAddress)) Then
                    Dim message As String
                    Dim subject As String
                    Dim UserName As String
                    UserName = HttpContext.Current.User.Identity.Name
                    subject = "Claim Rejection  " + UserName
                    message = UserName + " rejected claim #" + e.NewValues("Claim_ID").ToString() + " posted on the online reporting portal. Please check the claim."
                    Dim objMail As New SendMail()
                    objMail.SentEmail(toAddress, subject, message, "")
                End If
            End If
        End If
        Dim sqlDb1 As New SqlDb
        dtSet1 = sqlDb1.GetDataSet("spORStatusUpdate", New SqlParameter("@ClaimID", e.NewValues("Claim_ID")), New SqlParameter("@Database", sqlDb.GetUserDataBase()), New SqlParameter("@Status", getStatus(e.NewValues("Status"))), New SqlParameter("@UserId", Context.User.Identity.Name), New SqlParameter("@Description", e.NewValues("Remarks")))
    End Sub
    Protected Function getStatus(ByVal status As String) As String
        If status = 1 Then
            Return "Accepted"
        ElseIf status = 2 Then
            Return "Rejected"
        ElseIf status = 3 Then
            Return "Pending"
        Else
            Return "Nothing"
        End If
    End Function

    Protected Sub btnPdf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPdf.Click
        Response.Redirect("~/Report/export.aspx?print=claim&type=pdf")
        'grdClaimSubmission.Columns(1).Visible = False
        'grdClaimSubmission.Columns(2).Visible = False
        'exportGrd.GridViewID = "grdClaimSubmission"
        'exportGrd.Styles.Cell.BorderColor = ColorTranslator.FromHtml("#9f9f9f")
        'exportGrd.Styles.Default.BorderColor = ColorTranslator.FromHtml("#9f9f9f")
        'exportGrd.Styles.AlternatingRowCell.BorderColor = ColorTranslator.FromHtml("#9f9f9f")
        'Dim link1 As New DevExpress.Web.Export.GridViewLink(exportGrd)
        'AddHandler link1.CreateMarginalHeaderArea, AddressOf header_CreateDetailArea
        'Dim phf As PageHeaderFooter = link1.PageHeaderFooter
        'phf.Header.Content.Clear()
        'phf.Header.Content.AddRange(New String() {"", "Claim Submissions", ""})
        'phf.Footer.Content.AddRange(New String() {Now, "[Page # of Pages #]", "Printed By: " + Context.User.Identity.Name})
        'phf.Header.LineAlignment = BrickAlignment.Center
        'phf.Footer.LineAlignment = BrickAlignment.Center
        'phf.Header.Font = New Font("Arial", 12, FontStyle.Bold)
        'Dim ps As DevExpress.XtraPrinting.PrintingSystemBase = link1.CreatePS()
        'ps.PageSettings.Landscape = True
        'ps.PageSettings.LeftMargin = 1.5
        'ps.PageSettings.RightMargin = 1.5
        'ps.PageSettings.Margins.Top = 500
        'ps.PageSettings.PaperKind = Printing.PaperKind.A4
        'Dim stream As New MemoryStream()
        'ps.ExportToPdf(stream)
        'WriteToResponse("Claim Submission on " + Now, True, "pdf", stream)
        'ps.Dispose()
    End Sub

    Protected Sub btnXls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnXls.Click
        Response.Redirect("~/Report/export.aspx?print=claim&type=xls")
        'exportGrd.Styles.Cell.BorderColor = ColorTranslator.FromHtml("#9f9f9f")
        'exportGrd.Styles.Default.BorderColor = ColorTranslator.FromHtml("#9f9f9f")
        'exportGrd.Styles.AlternatingRowCell.BorderColor = ColorTranslator.FromHtml("#9f9f9f")
        'Dim link1 As New DevExpress.Web.Export.GridViewLink(exportGrd)
        'AddHandler link1.CreateMarginalHeaderArea, AddressOf header_CreateDetailArea
        'Dim phf As PageHeaderFooter = link1.PageHeaderFooter
        'phf.Header.Content.Clear()
        'phf.Header.Content.AddRange(New String() {"", "Claim Submissions", ""})
        'phf.Footer.Content.AddRange(New String() {Now, "[Page # of Pages #]", "Printed By: " + Context.User.Identity.Name})
        'phf.Header.LineAlignment = BrickAlignment.Center
        'phf.Footer.LineAlignment = BrickAlignment.Center
        'phf.Header.Font = New Font("Arial", 12, FontStyle.Bold)
        'Dim ps As DevExpress.XtraPrinting.PrintingSystemBase = link1.CreatePS()
        'ps.PageSettings.Landscape = True
        'ps.PageSettings.LeftMargin = 1.5
        'ps.PageSettings.RightMargin = 1.5
        'ps.PageSettings.Margins.Top = 500
        'ps.PageSettings.PaperKind = Printing.PaperKind.A4
        'Dim stream As New MemoryStream()
        'ps.ExportToCsv(stream)
        'WriteToResponse("Claim Submission on " + Now, True, "csv", stream)
        'ps.Dispose()
    End Sub

    Private Sub header_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
        e.Graph.BorderWidth = 0
        Dim headerImage As Image = Image.FromFile(Server.MapPath("~\images\mainlogo.png"))
        e.Graph.DrawImage(headerImage, New Rectangle(0, 0, 232, 48))
        'Dim r As New Rectangle(0, 90, 400, 30)
        'e.Graph.DrawString("Additional Header information here....", r)
    End Sub
    Private Sub WriteToResponse(ByVal fileName As String, ByVal saveAsFile As Boolean, ByVal fileFormat As String, ByVal stream As MemoryStream)
        If Page Is Nothing OrElse Page.Response Is Nothing Then
            Return
        End If
        Dim disposition As String
        If saveAsFile Then
            disposition = "attachment"
        Else
            disposition = "inline"
        End If
        Page.Response.Clear()
        Page.Response.Buffer = False
        Page.Response.AppendHeader("Content-Type", String.Format("application/{0}", fileFormat))
        Page.Response.AppendHeader("Content-Transfer-Encoding", "binary")
        Page.Response.AppendHeader("Content-Disposition", String.Format("{0}; filename={1}.{2}", disposition, fileName, fileFormat))
        Page.Response.BinaryWrite(stream.GetBuffer())
        Page.Response.End()
    End Sub

    Protected Sub grdClaimSubmission_HtmlRowCreated(sender As Object, e As DevExpress.Web.ASPxGridViewTableRowEventArgs)

    End Sub

    Protected Sub grdClaimSubmission_DataBound(sender As Object, e As EventArgs) Handles grdClaimSubmission.DataBound
        Try
            If (String.IsNullOrEmpty(grdClaimSubmission.GetRowValues(0, "Vendor Source"))) Then
                grdClaimSubmission.Columns("Vendor Source").Visible = False
            Else
                grdClaimSubmission.Columns("Vendor Source").Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    
    Protected Sub grdClaimSubmission_PreRender(sender As Object, e As EventArgs) Handles grdClaimSubmission.PreRender
        CType(sender, ASPxGridView).FilterExpression = "[Status] In (2,3)"
    End Sub

    
    Protected Sub grdClaimSubmissionPending_PreRender(sender As Object, e As EventArgs) Handles grdClaimSubmissionPending.PreRender
        CType(sender, ASPxGridView).FilterExpression = "[Status] In (0)"
    End Sub

    Protected Sub grdClaimSubmissionAccepted_PreRender(sender As Object, e As EventArgs) Handles grdClaimSubmissionAccepted.PreRender
        CType(sender, ASPxGridView).FilterExpression = "[Status] In (1)"
    End Sub

    Protected Sub popEmail_WindowCallback(source As Object, e As DevExpress.Web.PopupWindowCallbackArgs) Handles popEmail.WindowCallback
        Dim pop As ASPxPopupControl = source
        Dim Details = e.Parameter.Split("|")
        If Details.Count() > 1 Then
            Dim status As String
            If (Details(1) = "0") Then
                status = "New"
            ElseIf (Details(1) = "1") Then
                status = "Accepted"
            ElseIf (Details(1) = "2") Then
                status = "Rejected"
            ElseIf (Details(1) = "3") Then
                status = "Pending"
            End If
            txtTo.Text = ""
            txtSubject.Text = "Claim ID: " & Details(0)
            hdnFile.Set("attachement", Details(5))
            txtBody.Html = String.Format("Claim_ID: {0}<br/>Status: {1}<br/>Remarks: {2}<br/>Claim Submit Date: {3}<br/>Vendor Name: {4}<br/>", Details(0), status, Details(2), Convert.ToDateTime(Details(3)).ToString("MM/dd/yyyy"), Details(4))
            lblAttachment.Text = Path.GetFileName(Details(5))
            popEmail.JSProperties("cpStatus") = "mail"
        Else
            lblAttachment.Text = System.IO.Path.GetFileName(hdnFile.Get("attachement"))
            Dim path As String = Server.MapPath(hdnFile.Get("attachement"))
            Dim file As System.IO.FileInfo = New System.IO.FileInfo(path)
            If file.Exists Then
                Dim objMail As New SendMail()
                objMail.SentEmail(txtTo.Text, txtSubject.Text, txtBody.Html, path)
                popEmail.JSProperties("cpStatus") = "success"
            Else
                popEmail.JSProperties("cpStatus") = "failed"
            End If
        End If
    End Sub

    Protected Sub grdClaimSubmissionAccepted_RowUpdating(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles grdClaimSubmissionAccepted.RowUpdating
        Dim sqlDb1 As New SqlDb
        Dim dtSet1 As New DataSet
        dtSet1 = sqlDb1.GetDataSet("spORStatusUpdate", New SqlParameter("@ClaimID", e.NewValues("Claim_ID")), New SqlParameter("@Database", sqlDb1.GetUserDataBase()), New SqlParameter("@Status", getStatus(e.NewValues("Status"))), New SqlParameter("@UserId", Context.User.Identity.Name), New SqlParameter("@Description", e.NewValues("Remarks")))
    End Sub

    Protected Sub grdClaimSubmissionAll_PreRender(sender As Object, e As EventArgs) Handles grdClaimSubmissionAll.PreRender
        CType(sender, ASPxGridView).FilterExpression = ""
    End Sub

    Protected Sub grdClaimSubmissionPending_HtmlDataCellPrepared(sender As Object, e As ASPxGridViewTableDataCellEventArgs)
        If e.DataColumn.FieldName.Equals("CreditStatus") And e.CellValue IsNot System.DBNull.Value Then
            If e.CellValue.Contains("Taken") Then
                e.Cell.Text = "Recovered"
            End If
            If e.CellValue.Contains("Booked") Then
                e.Cell.Text = "Pending"
            End If
            If e.CellValue.Contains("Not Booked or Null") Then
                e.Cell.Text = "Not Entered"
            End If
        End If
    End Sub
    Protected Sub grdClaimSubmission_HtmlDataCellPrepared(sender As Object, e As ASPxGridViewTableDataCellEventArgs)
        If e.DataColumn.FieldName.Equals("CreditStatus") And e.CellValue IsNot System.DBNull.Value Then
            If e.CellValue.Contains("Taken") Then
                e.Cell.Text = "Recovered"
            End If
            If e.CellValue.Contains("Booked") Then
                e.Cell.Text = "Pending"
            End If
            If e.CellValue.Contains("Not Booked or Null") Then
                e.Cell.Text = "Not Entered"
            End If
        End If
    End Sub
    Protected Sub grdClaimSubmissionAccepted_HtmlDataCellPrepared(sender As Object, e As ASPxGridViewTableDataCellEventArgs)
        If e.DataColumn.FieldName.Equals("CreditStatus") And e.CellValue IsNot System.DBNull.Value Then
            If e.CellValue.Contains("Taken") Then
                e.Cell.Text = "Recovered"
            End If
            If e.CellValue.Contains("Booked") Then
                e.Cell.Text = "Pending"
            End If
            If e.CellValue.Contains("Not Booked or Null") Then
                e.Cell.Text = "Not Entered"
            End If
        End If
    End Sub
    Protected Sub grdClaimSubmissionAll_HtmlDataCellPrepared(sender As Object, e As ASPxGridViewTableDataCellEventArgs)
        If e.DataColumn.FieldName.Equals("CreditStatus") And e.CellValue IsNot System.DBNull.Value Then
            If e.CellValue.Contains("Taken") Then
                e.Cell.Text = "Recovered"
            End If
            If e.CellValue.Contains("Booked") Then
                e.Cell.Text = "Pending"
            End If
            If e.CellValue.Contains("Not Booked or Null") Then
                e.Cell.Text = "Not Entered"
            End If
        End If
    End Sub
    Protected Sub grdClaimSubmissionPending_StartRowEditing(sender As Object, e As DevExpress.Web.Data.ASPxStartRowEditingEventArgs)
        Dim lst As Object() = TryCast(grdClaimSubmissionPending.GetRowValuesByKeyValue(e.EditingKeyValue, New String() {"Claim_ID", "CreditStatus"}), Object())
        If lst(1).ToString().Contains("Taken") Then
            'e.Cancel = True
        End If
    End Sub
End Class