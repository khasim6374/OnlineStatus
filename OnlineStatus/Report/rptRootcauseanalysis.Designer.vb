<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptRootcauseanalysis
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrGroupSortingSummary1 As DevExpress.XtraReports.UI.XRGroupSortingSummary = New DevExpress.XtraReports.UI.XRGroupSortingSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.StatusDS1 = New OnlineStatus.StatusDS()
        Me.ORRootcause_spTableAdapter = New OnlineStatus.StatusDSTableAdapters.ORRootcause_spTableAdapter()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5})
        Me.Detail.HeightF = 21.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable5
        '
        Me.XrTable5.EvenStyleName = "XrControlStyle1"
        Me.XrTable5.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.XrTable5.KeepTogether = True
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 0.0!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(500.0!, 21.0!)
        Me.XrTable5.StylePriority.UseFont = False
        Me.XrTable5.StylePriority.UseTextAlignment = False
        Me.XrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell25, Me.XrTableCell26, Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell30})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 11.5R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell25.Weight = 1.5547787493610745R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.Root Cause")})
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.StylePriority.UseTextAlignment = False
        Me.XrTableCell26.Text = "[Root Cause]"
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell26.Weight = 2.6898893731945019R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.Claim Count")})
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.StylePriority.UseTextAlignment = False
        Me.XrTableCell27.Text = "XrTableCell3"
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell27.Weight = 1.5529773901873245R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.Total Claim", "{0:n1}%")})
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        Me.XrTableCell28.Text = "XrTableCell4"
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell28.Weight = 1.1898887398194191R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.Gross Recoveries", "{0:c0}")})
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.StylePriority.UseTextAlignment = False
        Me.XrTableCell29.Text = "XrTableCell5"
        Me.XrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell29.Weight = 2.5893857726029434R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.TotalGross", "{0:n1}%")})
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell30.StylePriority.UsePadding = False
        Me.XrTableCell30.StylePriority.UseTextAlignment = False
        Me.XrTableCell30.Text = "XrTableCell6"
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell30.Weight = 1.2307726581280047R
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
        Me.BottomMargin.HeightF = 6.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'StatusDS1
        '
        Me.StatusDS1.DataSetName = "StatusDS"
        Me.StatusDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ORRootcause_spTableAdapter
        '
        Me.ORRootcause_spTableAdapter.ClearBeforeFill = True
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrTable2})
        Me.ReportHeader.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.ReportHeader.HeightF = 36.0!
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.StylePriority.UseFont = False
        Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.KeepTogether = True
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(322.9167!, 15.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Root Cause Analysis"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTable2
        '
        Me.XrTable2.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.XrTable2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable2.KeepTogether = True
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 15.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(500.0!, 21.0!)
        Me.XrTable2.StylePriority.UseBackColor = False
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell10, Me.XrTableCell8, Me.XrTableCell11, Me.XrTableCell9, Me.XrTableCell12})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "Category"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell7.Weight = 0.38869488879773739R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "Root Cause"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell10.Weight = 0.67247222057696354R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "Claim Count"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell8.Weight = 0.38824430409267796R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "% Total"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell11.Weight = 0.2974719696590421R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Gross Recoveries"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell9.Weight = 0.64734708092856708R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UsePadding = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "% Total"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell12.Weight = 0.30769270676832933R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.ReportFooter.HeightF = 25.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTable3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable3.KeepTogether = True
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(500.0001!, 25.0!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell13, Me.XrTableCell16, Me.XrTableCell14, Me.XrTableCell17, Me.XrTableCell15, Me.XrTableCell18})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseBorders = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "Totals"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell13.Weight = 0.3886948220019984R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell16.Weight = 0.67247223935401479R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.Claim Count")})
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell14.Summary = XrSummary1
        Me.XrTableCell14.Text = "XrTableCell14"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell14.Weight = 0.38824447764885389R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.Total Claim")})
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n1}%"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell17.Summary = XrSummary2
        Me.XrTableCell17.Text = "XrTableCell17"
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell17.Weight = 0.29747182547854628R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.Gross Recoveries")})
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:c0}"
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell15.Summary = XrSummary3
        Me.XrTableCell15.Text = "XrTableCell15"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell15.Weight = 0.64734720475784491R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.TotalGross")})
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell18.StylePriority.UseBorders = False
        Me.XrTableCell18.StylePriority.UsePadding = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:n1}%"
        XrSummary4.IgnoreNullValues = True
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell18.Summary = XrSummary4
        Me.XrTableCell18.Text = "XrTableCell18"
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell18.Weight = 0.30769254560307674R
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Category", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 8.0!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        XrGroupSortingSummary1.FieldName = "Claim Count"
        Me.GroupHeader1.SortingSummary = XrGroupSortingSummary1
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.Category")})
        Me.XrLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(239.6441!, 8.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrControlStyle1.Name = "XrControlStyle1"
        Me.XrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4})
        Me.GroupFooter1.HeightF = 21.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrTable4
        '
        Me.XrTable4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTable4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable4.KeepTogether = True
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(71.9293!, 0.0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(428.0708!, 21.0!)
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        Me.XrTable4.StylePriority.UseTextAlignment = False
        Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell22, Me.XrTableCell20, Me.XrTableCell23, Me.XrTableCell21, Me.XrTableCell24})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        Me.XrTableCell22.Text = "Sub-Total"
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell22.Weight = 0.67247224739023737R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.Claim Count")})
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        XrSummary5.IgnoreNullValues = True
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell20.Summary = XrSummary5
        Me.XrTableCell20.Text = "XrTableCell20"
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell20.Weight = 0.38824432601589715R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.Total Claim")})
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:n1}%"
        XrSummary6.IgnoreNullValues = True
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell23.Summary = XrSummary6
        Me.XrTableCell23.Text = "XrTableCell23"
        Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell23.Weight = 0.29747212822856406R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.Gross Recoveries")})
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:c0}"
        XrSummary7.IgnoreNullValues = True
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell21.Summary = XrSummary7
        Me.XrTableCell21.Text = "XrTableCell21"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell21.Weight = 0.6473469223590449R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORRootcause_sp.TotalGross")})
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell24.StylePriority.UsePadding = False
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0:n1}%"
        XrSummary8.IgnoreNullValues = True
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell24.Summary = XrSummary8
        Me.XrTableCell24.Text = "XrTableCell24"
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell24.Weight = 0.3076927419809195R
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'rptRootcauseanalysis
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter, Me.GroupHeader1, Me.GroupFooter1})
        Me.DataAdapter = Me.ORRootcause_spTableAdapter
        Me.DataMember = "ORRootcause_sp"
        Me.DataSource = Me.StatusDS1
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
        Me.Margins = New System.Drawing.Printing.Margins(1, 257, 0, 6)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        Me.Version = "15.1"
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents StatusDS1 As OnlineStatus.StatusDS
    Friend WithEvents ORRootcause_spTableAdapter As OnlineStatus.StatusDSTableAdapters.ORRootcause_spTableAdapter
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
End Class
