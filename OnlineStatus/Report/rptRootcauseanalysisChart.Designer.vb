<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptRootcauseanalysisChart
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
        Dim SimpleDiagram1 As DevExpress.XtraCharts.SimpleDiagram = New DevExpress.XtraCharts.SimpleDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PiePointOptions1 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
        Dim PiePointOptions2 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
        Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim PieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PiePointOptions3 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
        Dim PieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart()
        Me.ORRootcause_spTableAdapter = New OnlineStatus.StatusDSTableAdapters.ORRootcause_spTableAdapter()
        Me.StatusDS1 = New OnlineStatus.StatusDS()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        CType(Me.XrChart1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(SimpleDiagram1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StatusDS1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Expanded = false
        Me.Detail.HeightF = 200!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrChart1
        '
        Me.XrChart1.AppearanceNameSerializable = "Terracotta Pie"
        Me.XrChart1.BorderColor = System.Drawing.Color.Black
        Me.XrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart1.DataAdapter = Me.ORRootcause_spTableAdapter
        Me.XrChart1.DataMember = "ORRootcause_sp"
        Me.XrChart1.DataSource = Me.StatusDS1
        SimpleDiagram1.EqualPieSize = false
        Me.XrChart1.Diagram = SimpleDiagram1
        Me.XrChart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.XrChart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.XrChart1.Legend.BackColor = System.Drawing.Color.Transparent
        Me.XrChart1.Legend.Border.Visible = false
        Me.XrChart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.XrChart1.Legend.Font = New System.Drawing.Font("Calibri", 9!)
        Me.XrChart1.Legend.HorizontalIndent = 0
        Me.XrChart1.Legend.MarkerSize = New System.Drawing.Size(20, 10)
        Me.XrChart1.Legend.TextColor = System.Drawing.Color.Black
        Me.XrChart1.Legend.TextOffset = 6
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrChart1.Name = "XrChart1"
        Me.XrChart1.PaletteName = "MyStyle"
        Me.XrChart1.PaletteRepository.Add("MyStyle", New DevExpress.XtraCharts.Palette("MyStyle", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.ForestGreen, System.Drawing.Color.ForestGreen), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Blue, System.Drawing.Color.Blue), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Yellow, System.Drawing.Color.Yellow), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Maroon, System.Drawing.Color.Maroon), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Olive, System.Drawing.Color.Olive), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Aqua, System.Drawing.Color.Aqua), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Gray, System.Drawing.Color.Gray)}))
        Me.XrChart1.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.ForestGreen, System.Drawing.Color.ForestGreen), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Blue, System.Drawing.Color.Blue), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Yellow, System.Drawing.Color.Yellow), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Maroon, System.Drawing.Color.Maroon), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Aqua, System.Drawing.Color.Aqua), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Gray, System.Drawing.Color.Gray)}))
        Series1.ArgumentDataMember = "Root Cause"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        PieSeriesLabel1.BackColor = System.Drawing.Color.Transparent
        PieSeriesLabel1.Border.Visible = False
        PieSeriesLabel1.Font = New System.Drawing.Font("Calibri", 10.0!)
        PieSeriesLabel1.LineVisible = False
        PiePointOptions1.PercentOptions.PercentageAccuracy = 2
        PiePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent
        PiePointOptions1.ValueNumericOptions.Precision = 0
        PieSeriesLabel1.PointOptions = PiePointOptions1
        PieSeriesLabel1.TextAlignment = System.Drawing.StringAlignment.Near
        PieSeriesLabel1.TextColor = System.Drawing.Color.White
        Series1.Label = PieSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PiePointOptions2.PercentOptions.ValueAsPercent = False
        PiePointOptions2.PointView = DevExpress.XtraCharts.PointView.Argument
        PiePointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent
        PiePointOptions2.ValueNumericOptions.Precision = 0
        Series1.LegendPointOptions = PiePointOptions2
        Series1.Name = "Series 1"
        Series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
        Series1.SynchronizePointOptions = False
        Series1.TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.ThresholdValue
        Series1.ValueDataMembersSerializable = "TotalGross"
        PieSeriesView1.Border.Color = System.Drawing.Color.White
        PieSeriesView1.ExplodedDistancePercentage = 25.0R
        PieSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
        PieSeriesView1.RuntimeExploding = False
        Series1.View = PieSeriesView1
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.XrChart1.SeriesTemplate.ArgumentDataMember = "Root Cause"
        Me.XrChart1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Me.XrChart1.SeriesTemplate.CrosshairLabelVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PiePointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PieSeriesLabel2.PointOptions = PiePointOptions3
        Me.XrChart1.SeriesTemplate.Label = PieSeriesLabel2
        Me.XrChart1.SeriesTemplate.ValueDataMembersSerializable = "TotalGross"
        PieSeriesView2.RuntimeExploding = False
        Me.XrChart1.SeriesTemplate.View = PieSeriesView2
        Me.XrChart1.SizeF = New System.Drawing.SizeF(282.0!, 337.7099!)
        ChartTitle1.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        ChartTitle1.Text = "Gross Recoveries by Root Cause"
        Me.XrChart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'ORRootcause_spTableAdapter
        '
        Me.ORRootcause_spTableAdapter.ClearBeforeFill = True
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
        Me.ReportHeader.HeightF = 370.0016!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'rptRootcauseanalysisChart
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.DataAdapter = Me.ORRootcause_spTableAdapter
        Me.DataMember = "ORRootcause_sp"
        Me.DataSource = Me.StatusDS1
        Me.Margins = New System.Drawing.Printing.Margins(0, 541, 0, 0)
        Me.Version = "13.2"
        CType(SimpleDiagram1,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesLabel1,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series1,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesLabel2,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XrChart1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StatusDS1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents StatusDS1 As OnlineStatus.StatusDS
    Friend WithEvents ORRootcause_spTableAdapter As OnlineStatus.StatusDSTableAdapters.ORRootcause_spTableAdapter
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
End Class
