Imports System.Data.SqlClient

Public Class rptclaimsubmission
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        OrClaimsList_spTableAdapter1.GetData((New SqlDb).GetUserDataBase())
        lblPrinted.Text = "Printed by " + HttpContext.Current.User.Identity.Name
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
End Class