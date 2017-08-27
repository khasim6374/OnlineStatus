Imports System.Data.SqlClient
Imports System.Drawing

Public Class auditprogress
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim sqlDb As New SqlDb
            Dim dtSet As New DataSet
            dtSet = sqlDb.GetDataSet("ORAuditProgress_sp", New SqlParameter("@database", sqlDb.GetUserDataBase()))
            Dim dt As DataTable
            Dim dr As DataRow
            Dim valCoulumn As DataColumn
            Dim nameCoulumn As DataColumn
            dt = New DataTable()
            nameCoulumn = New DataColumn("Name", Type.GetType("System.String"))
            valCoulumn = New DataColumn("Val", Type.GetType("System.String"))
            dt.Columns.Add(nameCoulumn)
            dt.Columns.Add(valCoulumn)
            dr = dt.NewRow()
            dr("Name") = "Received"
            dr("Val") = dtSet.Tables(0).Rows(0)(1)
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("Name") = "Not Received"
            dr("Val") = dtSet.Tables(0).Rows(0)(0)
            dt.Rows.Add(dr)
            crtVendorCount.DataSource = dt
            crtVendorCount.Series("Series1").XValueMember = "Name"
            crtVendorCount.Series("Series1").YValueMembers = "val"
            lblReceived1.Text = Convert.ToDouble(dtSet.Tables(0).Rows(0)(1)).ToString("N0")
            lblScope1.Text = Convert.ToDouble(dtSet.Tables(0).Rows(0)(1) + dtSet.Tables(0).Rows(0)(0)).ToString("N0")
            lblCompliance1.Text = Convert.ToDouble((dtSet.Tables(0).Rows(0)(1) * 100) / (lblScope1.Text)).ToString(".") & "%"


            dt = New DataTable()
            nameCoulumn = New DataColumn("Name", Type.GetType("System.String"))
            valCoulumn = New DataColumn("Val", Type.GetType("System.String"))
            dt.Columns.Add(nameCoulumn)
            dt.Columns.Add(valCoulumn)
            dr = dt.NewRow()
            dr("Name") = "Received"
            dr("Val") = dtSet.Tables(0).Rows(0)(3)
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("Name") = "Not Received"
            dr("Val") = dtSet.Tables(0).Rows(0)(2)
            dt.Rows.Add(dr)
            crtTotalSpend.DataSource = dt
            crtTotalSpend.Series("Series1").XValueMember = "Name"
            crtTotalSpend.Series("Series1").YValueMembers = "val"
            lblReceived2.Text = Convert.ToDouble(dtSet.Tables(0).Rows(0)(3)).ToString("C0")
            lblScope2.Text = Convert.ToDouble(dtSet.Tables(0).Rows(0)(3) + dtSet.Tables(0).Rows(0)(2)).ToString("C0")
            lblCompliance2.Text = Convert.ToDouble((dtSet.Tables(0).Rows(0)(3) * 100) / (lblScope2.Text)).ToString(".") & "%"

            dt = New DataTable()
            nameCoulumn = New DataColumn("Name", Type.GetType("System.String"))
            valCoulumn = New DataColumn("Val", Type.GetType("System.String"))
            dt.Columns.Add(nameCoulumn)
            dt.Columns.Add(valCoulumn)
            dr = dt.NewRow()
            dr("Name") = "Received"
            dr("Val") = dtSet.Tables(0).Rows(0)(5)
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("Name") = "Not Received"
            dr("Val") = dtSet.Tables(0).Rows(0)(4)
            dt.Rows.Add(dr)
            crtTotalTransaction.DataSource = dt
            crtTotalTransaction.Series("Series1").XValueMember = "Name"
            crtTotalTransaction.Series("Series1").YValueMembers = "val"
            crtTotalTransaction.Series("Series1").YValueType = DataVisualization.Charting.ChartValueType.Double
            lblReceived3.Text = (Convert.ToDouble(dtSet.Tables(0).Rows(0)(5))).ToString("N0")
            lblScope3.Text = (Convert.ToDouble(dtSet.Tables(0).Rows(0)(5) + dtSet.Tables(0).Rows(0)(4))).ToString("N0")
            lblCompliance3.Text = Convert.ToDouble((dtSet.Tables(0).Rows(0)(5) * 100) / (lblScope3.Text)).ToString(".") & "%"

            crtVendorCount.DataBind()
            crtTotalSpend.DataBind()
            crtTotalTransaction.DataBind()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub crtVendorCount_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles crtVendorCount.PreRender
        'crtTotalSpend.Series("Series1").Points(0).Color = ColorTranslator.FromHtml("#93a9cf")
        'crtTotalSpend.Series("Series1").Points(1).Color = ColorTranslator.FromHtml("#4572a7")
        'crtTotalTransaction.Series("Series1").Points(0).Color = ColorTranslator.FromHtml("#93a9cf")
        'crtTotalTransaction.Series("Series1").Points(1).Color = ColorTranslator.FromHtml("#4572a7")
        'crtVendorCount.Series("Series1").Points(0).Color = ColorTranslator.FromHtml("#93a9cf")
        'crtVendorCount.Series("Series1").Points(1).Color = ColorTranslator.FromHtml("#4572a7")
    End Sub
End Class