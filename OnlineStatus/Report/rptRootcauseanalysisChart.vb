Imports DevExpress.XtraCharts
Public Class rptRootcauseanalysisChart

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ORRootcause_spTableAdapter.GetData((New SqlDb).GetUserDataBase())
        CType(XrChart1.Series("Series 1").Label, PieSeriesLabel).Position = PieSeriesLabelPosition.Inside
        CType(XrChart1.Series("Series 1").Label, PieSeriesLabel).TextColor = Drawing.Color.White
    End Sub

End Class