<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptBusinessunitanalysisChart
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim PointOptions2 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart()
        Me.OREntity_spTableAdapter = New OnlineStatus.StatusDSTableAdapters.OREntity_spTableAdapter()
        Me.StatusDS1 = New OnlineStatus.StatusDS()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 23.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrChart1
        '
        Me.XrChart1.AppearanceNameSerializable = "Light"
        Me.XrChart1.BorderColor = System.Drawing.Color.Black
        Me.XrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart1.DataAdapter = Me.OREntity_spTableAdapter
        Me.XrChart1.DataMember = "OREntity_sp"
        Me.XrChart1.DataSource = Me.StatusDS1
        XyDiagram1.AxisX.Label.Angle = 45
        XyDiagram1.AxisX.Label.Font = New System.Drawing.Font("Calibri", 7.0!)
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Currency
        XyDiagram1.AxisY.NumericOptions.Precision = 0
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart1.Diagram = XyDiagram1
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 8.333344!)
        Me.XrChart1.Name = "XrChart1"
        Me.XrChart1.PaletteBaseColorNumber = 3
        Me.XrChart1.PaletteName = "Default"
        Series1.ArgumentDataMember = "Source"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        SideBySideBarSeriesLabel1.LineVisible = True
        PointOptions1.Pattern = "{C0}"
        SideBySideBarSeriesLabel1.PointOptions = PointOptions1
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        PointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Currency
        Series1.LegendPointOptions = PointOptions2
        Series1.Name = "Series 1"
        Series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
        Series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
        Series1.ShowInLegend = False
        Series1.SynchronizePointOptions = False
        Series1.ValueDataMembersSerializable = "Recoveries"
        SideBySideBarSeriesView1.BarWidth = 0.7R
        SideBySideBarSeriesView1.Border.Color = System.Drawing.Color.White
        SideBySideBarSeriesView1.Border.Visible = False
        SideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(13, Byte), Integer))
        SideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
        Series1.View = SideBySideBarSeriesView1
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        SideBySideBarSeriesLabel2.LineVisible = True
        Me.XrChart1.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        Me.XrChart1.SideBySideEqualBarWidth = True
        Me.XrChart1.SizeF = New System.Drawing.SizeF(307.0!, 272.2933!)
        ChartTitle1.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        ChartTitle1.Text = "Gross Recoveries by Business Unit"
        Me.XrChart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'OREntity_spTableAdapter
        '
        Me.OREntity_spTableAdapter.ClearBeforeFill = True
        '
        'StatusDS1
        '
        Me.StatusDS1.DataSetName = "StatusDS"
        Me.StatusDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChart1})
        Me.ReportHeader.HeightF = 280.6266!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'rptBusinessunitanalysisChart
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "12.2"
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents OREntity_spTableAdapter As OnlineStatus.StatusDSTableAdapters.OREntity_spTableAdapter
    Friend WithEvents StatusDS1 As OnlineStatus.StatusDS
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
End Class
