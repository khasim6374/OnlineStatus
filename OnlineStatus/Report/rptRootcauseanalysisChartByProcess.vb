Imports DevExpress.XtraCharts
Public Class rptRootcauseanalysisChartByProcess

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ORprocess_spTableAdapter.GetData((New SqlDb).GetUserDataBase())
        CType(XrChart1.Series("Series 1").Label, PieSeriesLabel).Position = PieSeriesLabelPosition.Inside
        CType(XrChart1.Series("Series 1").Label, PieSeriesLabel).TextColor = Drawing.Color.Black
    End Sub

End Class