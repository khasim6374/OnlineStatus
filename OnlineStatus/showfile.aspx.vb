Public Class showfile
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strRequest As String = Request.QueryString("file")
        If String.IsNullOrEmpty(strRequest) Then
            Response.Write("Please provide a file to download.")
            Return
        End If
        Dim path As String = strRequest.Replace("\", "/")
        Dim file As System.IO.FileInfo = New System.IO.FileInfo(path)
        If file.Exists Then
            Response.Clear()
            Response.AddHeader("Content-Disposition", "attachment; filename=" & file.Name)
            Response.AddHeader("Content-Length", file.Length.ToString())
            Response.ContentType = "application/octet-stream"
            Response.WriteFile(file.FullName)
            Response.End()
        Else
            Response.Write("This file does not exist.")
        End If

        ''Dim fileName = strRequest.Split("|")(0)
        'Dim file = strRequest.Replace("\", "/")
        ''Dim folders = file.Split("/")
        ''If (folders.Length > 2) Then
        ''    Dim cutPos = file.IndexOf(folders(1))
        ''    cutPos += folders(1).Length
        ''    file = file.Substring(cutPos)
        ''End If
        'Response.Clear()
        'Response.AddHeader("Content-Disposition", "attachment; filename=" & file)
        'Response.AddHeader("Content-Length", file.Length.ToString())
        'Response.ContentType = "application/octet-stream"
        ''Response.WriteFile(file.FullName)

        Response.End()
        'Try 'for relative path downloading
        '    Dim path As String = Server.MapPath(strRequest)
        '    Dim file As System.IO.FileInfo = New System.IO.FileInfo(path)
        '    If file.Exists Then
        'Response.Clear()
        'Response.AddHeader("Content-Disposition", "attachment; filename=" & file.Name)
        'Response.AddHeader("Content-Length", file.Length.ToString())
        'Response.ContentType = "application/octet-stream"
        'Response.WriteFile(file.FullName)
        'Response.End()
        '    Else
        '        Response.Write("This file does not exist.")
        '    End If
        'Catch ex As Exception
        '    Try 'for absolute path downloading
        '        Dim path As String = strRequest
        '        Dim file As System.IO.FileInfo = New System.IO.FileInfo(path)
        '        If file.Exists Then
        '            Response.Clear()
        '            Response.AddHeader("Content-Disposition", "attachment; filename=" & file.Name)
        '            Response.AddHeader("Content-Length", file.Length.ToString())
        '            Response.ContentType = "application/octet-stream"
        '            Response.WriteFile(file.FullName)
        '            Response.End()
        '        Else
        '            Response.Write("This file does not exist.")
        '        End If
        '    Catch ex1 As Exception
        '        Response.Write("This file does not exist.")
        '    End Try
        'End Try
    End Sub

End Class