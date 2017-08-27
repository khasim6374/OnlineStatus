Imports System.Data.SqlClient

Public Class businessunitanalysis
    Inherits System.Web.UI.UserControl
    Dim _totClaimCount As Double
    Dim _totPer As Double
    Dim _totGross As Double
    Dim _totNet As Double
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            LoadBusinessUnitAnalysis()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub LoadBusinessUnitAnalysis()
        Dim sqlDb As New SqlDb
        Dim dtSet As New DataSet
        dtSet = sqlDb.GetDataSet("OREntity_sp", New SqlParameter("@database", sqlDb.GetUserDataBase()))
        grdBusinessUnit.DataSourceID = Nothing
        grdBusinessUnit.DataSource = dtSet
        grdBusinessUnit.DataBind()
        Dim takeCount = 9
        Dim showOthers = True
        crtBusinessUnit.Series("Series1").XValueMember = "Source"
        crtBusinessUnit.Series("Series1").YValueMembers = "Recoveries"
        If (dtSet.Tables(0).Rows.Count = takeCount + 1) Then
            takeCount += 1
            showOthers = False
        End If
        Dim dbChart = dtSet.Tables(0).Rows.Cast(Of DataRow)().OrderByDescending(Function(r) r("Recoveries")).Take(takeCount)
        Dim claims As List(Of ORClaim) = New List(Of ORClaim)()
        For Each dbrow As DataRow In dbChart
            Dim claim As ORClaim = New ORClaim
            claim.Source = Convert.ToString(dbrow("Source"))
            claim.Claims = Convert.ToInt32(dbrow("Claims"))
            claim.Recoveries = Convert.ToDecimal(dbrow("Recoveries"))
            claim.ClaimsTotal = Convert.ToInt32(dbrow("ClaimsTotal"))
            claim.RecoveriesTotal = Convert.ToInt32(dbrow("RecoveriesTotal"))
            claims.Add(claim)
        Next
        If (showOthers) Then
            Dim dbChart1 = dtSet.Tables(0).Rows.Cast(Of DataRow)().OrderByDescending(Function(r) r("Recoveries")).Skip(takeCount).Take(dtSet.Tables(0).Rows.Count - takeCount)
            Dim claim1 As ORClaim = New ORClaim
            claim1.Source = "Other"
            For Each dbrow As DataRow In dbChart1
                claim1.Claims += Convert.ToInt32(dbrow("Claims"))
                claim1.Recoveries += Convert.ToDecimal(dbrow("Recoveries"))
                claim1.ClaimsTotal += Convert.ToInt32(dbrow("ClaimsTotal"))
                claim1.RecoveriesTotal += Convert.ToInt32(dbrow("RecoveriesTotal"))
            Next
            claims.Add(claim1)
        End If

        crtBusinessUnit.DataSource = claims
    End Sub

    Protected Sub grdBusinessUnit_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grdBusinessUnit.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.Cells.Count > 3 Then
                _totClaimCount += e.Row.Cells(1).Text
                _totPer += e.Row.Cells(2).Text
                _totGross += e.Row.Cells(3).Text
                _totNet += e.Row.Cells(4).Text
                e.Row.Cells(2).Text = Convert.ToDouble(e.Row.Cells(2).Text).ToString(".0") & "%"
                e.Row.Cells(4).Text = Convert.ToDouble(e.Row.Cells(4).Text).ToString(".0") & "%"
                Dim lnkClaim = New HyperLink()
                lnkClaim.Text = e.Row.Cells(1).Text
                lnkClaim.NavigateUrl = "Javascript:void();"
                lnkClaim.Attributes("onclick") = "ShowbusinessunitanalysisPopup('" + e.Row.Cells(0).Text + "')"
                e.Row.Cells(1).Controls.Add(lnkClaim)
            End If
        End If
        If e.Row.RowType = DataControlRowType.Header Then
            e.Row.Cells(0).HorizontalAlign = HorizontalAlign.Left
            e.Row.Cells(2).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(3).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(4).HorizontalAlign = HorizontalAlign.Right
        End If
        If e.Row.RowType = DataControlRowType.Footer Then
            If e.Row.Cells.Count > 3 Then
                e.Row.Cells(0).Text = "Totals"
                e.Row.Cells(0).CssClass = "topBorder"
                e.Row.Cells(1).HorizontalAlign = HorizontalAlign.Center
                e.Row.Cells(1).Text = _totClaimCount
                e.Row.Cells(1).CssClass = "topBorder"
                e.Row.Cells(2).Text = _totPer.ToString(".0") & "%"
                e.Row.Cells(2).CssClass = "topBorder"
                e.Row.Cells(2).HorizontalAlign = HorizontalAlign.Right
                e.Row.Cells(3).Text = _totGross.ToString("C0")
                e.Row.Cells(3).CssClass = "topBorder"
                e.Row.Cells(3).HorizontalAlign = HorizontalAlign.Right
                e.Row.Cells(4).Text = _totNet.ToString(".0") & "%"
                e.Row.Cells(4).CssClass = "topBorder"
                e.Row.Cells(4).HorizontalAlign = HorizontalAlign.Right

                e.Row.Font.Bold = True
                e.Row.CssClass = "topBorder"
            End If
        End If
    End Sub
End Class
Public Class ORClaim
    Private _source As String
    Private _claims As Integer
    Private _recoveries As Decimal
    Private _claimstotal As Decimal
    Private _recoveriestotal As Decimal

    Public Property Source() As String
        Get
            Return _source
        End Get
        Set(value As String)
            _source = value
        End Set
    End Property

    Public Property Claims() As String
        Get
            Return _claims
        End Get
        Set(value As String)
            _claims = value
        End Set
    End Property

    Public Property Recoveries() As String
        Get
            Return _recoveries
        End Get
        Set(value As String)
            _recoveries = value
        End Set
    End Property

    Public Property ClaimsTotal() As String
        Get
            Return _claimstotal
        End Get
        Set(value As String)
            _claimstotal = value
        End Set
    End Property

    Public Property RecoveriesTotal() As String
        Get
            Return _recoveriestotal
        End Get
        Set(value As String)
            _recoveriestotal = value
        End Set
    End Property
End Class
