Imports System
Imports System.Net
Imports System.Net.Mail
Public Class SendMail
    Public Function SentEmail(ByVal username As String, ByVal subject As String, ByVal message As String, ByVal attachmentFile As String) As Integer
        Try
            Dim myMail = New MailMessage()
            Dim smtp = New SmtpClient()
            myMail.From = New MailAddress("noreply@gmail.com", "Online Reporting")
            myMail.Subject = subject
            Dim toUserName As String = username.Replace(";", ",").ToString()
            Dim strEmail As String() = toUserName.Split(",")
            For Each sEmail As String In strEmail
                myMail.To.Add(New MailAddress(sEmail))
            Next
            myMail.Body = message
            myMail.IsBodyHtml = True
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.EnableSsl = True
            Dim nwCredential = New NetworkCredential()
            nwCredential.UserName = "noreply00000000000000@gmail.com"
            nwCredential.Password = "noreply123#"
            smtp.UseDefaultCredentials = True
            smtp.Credentials = nwCredential
            If attachmentFile <> "" Then
                Dim attachment = New Attachment(attachmentFile)
                myMail.Attachments.Add(attachment)
            End If
            smtp.Send(myMail)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
  End Class
