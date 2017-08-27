<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptStatus))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.XrSubauditprogress = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrSubbusinessunitanalysisChart = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrSubbusinessunitanalysis = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrSubrootcauseanalysischart = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrSubrootcauseanalysis = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrSubclaimsummary = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrSubcurrentitemsunder = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrSubRootcauseanalysisbyprocess = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrSubRootcauseanalysisbyprocessChart = New DevExpress.XtraReports.UI.XRSubreport()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.imgClient = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.Parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.StatusDS1 = New OnlineStatus.StatusDS()
        CType(Me.StatusDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageBreak1, Me.XrSubauditprogress, Me.XrSubbusinessunitanalysisChart, Me.XrSubbusinessunitanalysis, Me.XrSubrootcauseanalysischart, Me.XrSubrootcauseanalysis, Me.XrSubclaimsummary, Me.XrSubcurrentitemsunder, Me.XrSubRootcauseanalysisbyprocess, Me.XrSubRootcauseanalysisbyprocessChart})
        Me.Detail.HeightF = 221.25!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseFont = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageBreak1
        '
        Me.XrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 104.0!)
        Me.XrPageBreak1.Name = "XrPageBreak1"
        '
        'XrSubauditprogress
        '
        Me.XrSubauditprogress.CanShrink = True
        Me.XrSubauditprogress.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 198.25!)
        Me.XrSubauditprogress.Name = "XrSubauditprogress"
        Me.XrSubauditprogress.SizeF = New System.Drawing.SizeF(807.0!, 23.0!)
        '
        'XrSubbusinessunitanalysisChart
        '
        Me.XrSubbusinessunitanalysisChart.CanShrink = True
        Me.XrSubbusinessunitanalysisChart.LocationFloat = New DevExpress.Utils.PointFloat(499.1667!, 119.5416!)
        Me.XrSubbusinessunitanalysisChart.Name = "XrSubbusinessunitanalysisChart"
        Me.XrSubbusinessunitanalysisChart.SizeF = New System.Drawing.SizeF(307.8333!, 23.0!)
        '
        'XrSubbusinessunitanalysis
        '
        Me.XrSubbusinessunitanalysis.CanShrink = True
        Me.XrSubbusinessunitanalysis.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 119.5416!)
        Me.XrSubbusinessunitanalysis.Name = "XrSubbusinessunitanalysis"
        Me.XrSubbusinessunitanalysis.SizeF = New System.Drawing.SizeF(500.0!, 23.0!)
        '
        'XrSubrootcauseanalysischart
        '
        Me.XrSubrootcauseanalysischart.CanShrink = True
        Me.XrSubrootcauseanalysischart.LocationFloat = New DevExpress.Utils.PointFloat(499.1667!, 40.00002!)
        Me.XrSubrootcauseanalysischart.LockedInUserDesigner = True
        Me.XrSubrootcauseanalysischart.Name = "XrSubrootcauseanalysischart"
        Me.XrSubrootcauseanalysischart.SizeF = New System.Drawing.SizeF(307.8333!, 23.0!)
        '
        'XrSubrootcauseanalysis
        '
        Me.XrSubrootcauseanalysis.CanShrink = True
        Me.XrSubrootcauseanalysis.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 40.00002!)
        Me.XrSubrootcauseanalysis.Name = "XrSubrootcauseanalysis"
        Me.XrSubrootcauseanalysis.SizeF = New System.Drawing.SizeF(500.0!, 23.0!)
        '
        'XrSubclaimsummary
        '
        Me.XrSubclaimsummary.CanShrink = True
        Me.XrSubclaimsummary.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrSubclaimsummary.Name = "XrSubclaimsummary"
        Me.XrSubclaimsummary.SizeF = New System.Drawing.SizeF(807.0!, 22.99999!)
        '
        'XrSubcurrentitemsunder
        '
        Me.XrSubcurrentitemsunder.CanShrink = True
        Me.XrSubcurrentitemsunder.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 158.5416!)
        Me.XrSubcurrentitemsunder.Name = "XrSubcurrentitemsunder"
        Me.XrSubcurrentitemsunder.SizeF = New System.Drawing.SizeF(807.0!, 23.0!)
        '
        'XrSubRootcauseanalysisbyprocess
        '
        Me.XrSubRootcauseanalysisbyprocess.CanShrink = True
        Me.XrSubRootcauseanalysisbyprocess.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 79.0!)
        Me.XrSubRootcauseanalysisbyprocess.Name = "XrSubRootcauseanalysisbyprocess"
        Me.XrSubRootcauseanalysisbyprocess.SizeF = New System.Drawing.SizeF(500.0!, 23.0!)
        '
        'XrSubRootcauseanalysisbyprocessChart
        '
        Me.XrSubRootcauseanalysisbyprocessChart.CanShrink = True
        Me.XrSubRootcauseanalysisbyprocessChart.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 79.0!)
        Me.XrSubRootcauseanalysisbyprocessChart.Name = "XrSubRootcauseanalysisbyprocessChart"
        Me.XrSubRootcauseanalysisbyprocessChart.SizeF = New System.Drawing.SizeF(307.0!, 23.0!)
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 2.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 10.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrPageInfo1, Me.XrLine1, Me.imgClient, Me.XrPictureBox1})
        Me.ReportHeader.HeightF = 118.4583!
        Me.ReportHeader.KeepTogether = True
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 82.79167!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(807.0!, 2.083328!)
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrPageInfo1.Format = "Supplier Payment Review Status Report on  {0:dddd, MMMM dd, yyyy}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0.000007947286!, 85.87497!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(716.6668!, 17.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UsePadding = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 102.875!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(807.0!, 2.0!)
        '
        'imgClient
        '
        Me.imgClient.LocationFloat = New DevExpress.Utils.PointFloat(604.9166!, 10.0!)
        Me.imgClient.Name = "imgClient"
        Me.imgClient.SizeF = New System.Drawing.SizeF(200.0!, 63.0!)
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 16.0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(241.6667!, 50.0!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        '
        'Parameter1
        '
        Me.Parameter1.Description = "Parameter1"
        Me.Parameter1.Name = "Parameter1"
        Me.Parameter1.Type = GetType(Integer)
        Me.Parameter1.ValueInfo = "0"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2})
        Me.PageFooter.HeightF = 23.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(0.000007947286!, 0.0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(807.0!, 23.0!)
        Me.XrPageInfo2.StylePriority.UseBorders = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'StatusDS1
        '
        Me.StatusDS1.DataSetName = "StatusDS"
        Me.StatusDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptStatus
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageFooter})
        Me.DefaultPrinterSettingsUsing.UseLandscape = True
        Me.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(10, 10, 2, 10)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Parameter1})
        Me.Version = "13.2"
        CType(Me.StatusDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Public WithEvents XrSubclaimsummary As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrSubrootcauseanalysis As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrSubrootcauseanalysischart As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents Parameter1 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrSubcurrentitemsunder As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrSubbusinessunitanalysisChart As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrSubbusinessunitanalysis As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents imgClient As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents StatusDS1 As OnlineStatus.StatusDS
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrSubauditprogress As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrSubRootcauseanalysisbyprocessChart As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrSubRootcauseanalysisbyprocess As DevExpress.XtraReports.UI.XRSubreport
End Class
