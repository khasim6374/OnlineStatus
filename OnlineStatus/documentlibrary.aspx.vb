Imports DevExpress.Web
Imports System.IO
Imports System.Data.SqlClient

Public Class documentlibrary
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sqlDb As New SqlDb
        Session("dbName") = SqlDb.GetUserDataBase().ToString()
        If (IsPostBack) Then Return
        SqlDocumentLib.SelectParameters.Add("database", Session("dbName"))
        SqlDocumentLib.DataBind()
    End Sub

    Protected Sub grdDocumentLib_RowInserting(sender As Object, e As DevExpress.Web.Data.ASPxDataInsertingEventArgs) Handles grdDocumentLib.RowInserting
        Dim strUrl As String
        If Session("FileName") = Nothing Then
            strUrl = "nothing"
        Else
            strUrl = Session("FileName")
            Session.Remove("FileName")
        End If
        Dim sqldb1 As New SqlDb
        sqldb1.GetDataSet("ORInsertDocumentLibrary", New SqlParameter("@DocType", e.NewValues("DocType")), New SqlParameter("@URL", strUrl), New SqlParameter("@crtd_dttm", DateTime.Now.ToString()), New SqlParameter("@database", Session("dbName").ToString()))
        e.Cancel = False
        Dim sqlDb2 As New SqlDb
        sqlDb2.GetDataSet("ORupdateDocumentLibraryLog", New SqlParameter("@Database", Session("dbName").ToString()), New SqlParameter("@Status", "Insert"), New SqlParameter("@UserId", Context.User.Identity.Name), New SqlParameter("@Description", "Doc Type : " + e.NewValues("DocType").ToString()))
    End Sub


    Protected Sub grdDocumentLib_RowUpdating(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles grdDocumentLib.RowUpdating
        Try
            Dim strUrl As String
            If Session("FileName") = Nothing Then
                strUrl = "nothing"
            Else
                strUrl = Session("FileName")
                Session.Remove("FileName")
                If (Not IsDBNull(e.OldValues("URL"))) Then
                    If File.Exists(Server.MapPath(e.OldValues("URL"))) Then
                        File.Delete(Server.MapPath(e.OldValues("URL")))
                    End If
                End If
            End If
            Dim sqldb1 As New SqlDb
            sqldb1.GetDataSet("ORUpdateDocumentLibrary", New SqlParameter("@DocType", e.NewValues("DocType")), New SqlParameter("@URL", strUrl), New SqlParameter("@crtd_dttm", DateTime.Now.ToString()), New SqlParameter("@database", Session("dbName").ToString()), New SqlParameter("@ID", e.NewValues("ID").ToString()))
            e.Cancel = False
            Dim sqlDb2 As New SqlDb
            sqlDb2.GetDataSet("ORupdateDocumentLibraryLog", New SqlParameter("@Database", Session("dbName").ToString()), New SqlParameter("@Status", "Update"), New SqlParameter("@UserId", Context.User.Identity.Name), New SqlParameter("@Description", "Doc Type : " + e.NewValues("DocType").ToString()))
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub uploader_FileUploadComplete(sender As Object, e As DevExpress.Web.FileUploadCompleteEventArgs)
        Dim upload As ASPxUploadControl = sender
        If (Not Directory.Exists(Server.MapPath("Docs"))) Then
            Directory.CreateDirectory(Server.MapPath("Docs"))
        End If
        Dim filePath As String = Server.MapPath("Docs")
        If upload.IsValid Then
            Dim fileName As String = Regex.Replace(Path.GetFileNameWithoutExtension(upload.FileName), "[^A-Za-z0-9]", "") + Path.GetExtension(upload.FileName)
            If File.Exists(filePath + "/" + fileName) Then
                e.IsValid = False
                e.ErrorText = "File: " + fileName + " already exists, please try with another file."
                Return
            End If
            upload.SaveAs(filePath + "/" + fileName)
            Session("FileName") = "~/Docs/" + fileName
        End If
    End Sub
    Public Function GetFileName(url As String) As String
        Return Path.GetFileName(url)
    End Function
    Public Function GetUrl(url As String) As String
        Return Server.MapPath(url)
    End Function
End Class