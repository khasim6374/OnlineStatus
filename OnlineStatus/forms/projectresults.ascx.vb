Imports System.Data.SqlClient

Public Class projectresults
    Inherits System.Web.UI.UserControl
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim sqlDb As New SqlDb
            Dim dtSet As New DataSet
            dtSet = sqlDb.GetDataSet("ORTitleClaimSummary_sp", New SqlParameter("@database", sqlDb.GetUserDataBase()))
            Dim x As String() = New String(dtSet.Tables(0).Rows.Count - 1) {}
            Dim y As Integer() = New Integer(dtSet.Tables(0).Rows.Count - 1) {}
            For i As Integer = 0 To dtSet.Tables(0).Rows.Count - 1
                ClaimCount.Text = dtSet.Tables(0).Rows(i)(0).ToString() + " Claims"
                ClaimCount.NavigateUrl = "Javascript:void();"
                ClaimCount.Attributes("onclick") = "ShowClaimSummaryPopup2()"
                GrossTotal.Text = String.Format("{0:c}", dtSet.Tables(0).Rows(i)(1))
                NetTotal.Text = String.Format("{0:c}", dtSet.Tables(0).Rows(i)(2))
            Next
            LoadBenchmark()
            LoadRecoveryStatus()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub LoadBenchmark()
        Dim sqlDb As New SqlDb
        Dim dtSet As New DataSet
        dtSet = sqlDb.GetDataSet("ORBenchMark", New SqlParameter("@database", sqlDb.GetUserDataBase()))
        Dim x As String() = New String(dtSet.Tables(0).Rows.Count - 1) {}
        Dim y As Integer() = New Integer(dtSet.Tables(0).Rows.Count - 1) {}
        For i As Integer = 0 To dtSet.Tables(0).Rows.Count - 1
            x(i) = dtSet.Tables(0).Rows(i)(0).ToString()
            y(i) = Convert.ToInt32(dtSet.Tables(0).Rows(i)(1))
        Next
        'crtProjectResults.ChartAreas("Default").AxisY.LabelStyle.Format = "C"
        crtProjectResults.Series(0).Points.DataBindXY(x, y)
    End Sub

    Public Sub LoadRecoveryStatus()
        Try
            Dim sqlDb As New SqlDb
            Dim dt As New DataSet
            dt = sqlDb.GetDataSet("ORRecoverystatus_sp", New SqlParameter("@database", sqlDb.GetUserDataBase()))
            Dim x As String() = New String(dt.Tables(0).Rows.Count - 1) {}
            Dim y As Integer() = New Integer(dt.Tables(0).Rows.Count - 1) {}
            For i As Integer = 0 To dt.Tables(0).Rows.Count - 1
                x(i) = dt.Tables(0).Rows(i)(0).ToString()
                y(i) = Convert.ToInt32(dt.Tables(0).Rows(i)(1))
            Next
            crtRecoveryStatus.Series(0).Points.DataBindXY(x, y)
        Catch ex As Exception

        End Try
    End Sub
End Class
