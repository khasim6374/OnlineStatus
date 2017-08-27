Public Class ClaimDetails
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (IsPostBack) Then Return

        Dim claimsubmitdate, category, Rootcause, businessUnit, status, process As String
        claimsubmitdate = String.Empty
        category = String.Empty
        Rootcause = String.Empty
        businessUnit = String.Empty
        status = String.Empty
        Dim sqlDb As New SqlDb
        SqlDS.SelectParameters.Add("database", sqlDb.GetUserDataBase())
        If Request.QueryString("sdate") <> "" Then
            claimsubmitdate = Request.QueryString("sdate")
            SqlDS.SelectParameters.Add("claimsubmitdate", claimsubmitdate)
        End If
        If Request.QueryString("cstatus") <> "" Then
            status = Request.QueryString("cstatus")
            SqlDS.SelectParameters.Add("status", status)
        End If
        If Request.QueryString("category") <> "" Then
            category = Request.QueryString("category")
            SqlDS.SelectParameters.Add("category", category)
        End If
        If Request.QueryString("rcause") <> "" Then
            Rootcause = Request.QueryString("rcause")
            SqlDS.SelectParameters.Add("Rootcause", Rootcause)
        End If
        If Request.QueryString("bunit") <> "" Then
            businessUnit = Request.QueryString("bunit")
            SqlDS.SelectParameters.Add("businessUnit", businessUnit)
        End If
        If Request.QueryString("process") <> "" Then
            Process = Request.QueryString("process")
            SqlDS.SelectParameters.Add("process", Process)
        End If
        SqlDS.DataBind()
    End Sub
End Class