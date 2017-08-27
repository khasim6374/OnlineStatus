<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master"
    CodeBehind="invoicesubmission.aspx.vb" Inherits="OnlineStatus.invoicesubmission" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent1" runat="server">
     <script language="javascript" type="text/javascript">
         function adjustSize() {
             var height = Math.max(0, document.documentElement.clientHeight);
             grdInvoiceSubmission.SetHeight(height - 185);
         }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent1" runat="server">
     <div class="pageHeader">
            Invoice Submissions
        </div>
    <dx:ASPxGridView ID="grdInvoiceSubmission" runat="server" 
        AutoGenerateColumns="False" DataSourceID="SqlInvoice"
        KeyFieldName="Invoice Number" ClientIDMode="Static" 
        ClientInstanceName="grdInvoiceSubmission" Width="100%">
         <ClientSideEvents Init="function(s, e) {
                       adjustSize();
	
}"
                ColumnMoving="function(s, e) {
	adjustSize();
}"
                ColumnResized="function(s, e) {
	adjustSize();
}"
                ColumnSorting="function(s, e) {
	adjustSize();
}"
                EndCallback="function(s, e) {
	adjustSize();
}" />
         <TotalSummary>
             <dx:ASPxSummaryItem DisplayFormat="Total Recovery Amount={0:C2}" 
                 FieldName="Recovery Amount" ShowInColumn="Recovery Amount"
                                  SummaryType="Sum" />
           <%--  <dx:ASPxSummaryItem DisplayFormat="Total Invoice Amount={0:C2}" 
                 FieldName="Invoice Amount" SummaryType="Sum" />
             <dx:ASPxSummaryItem DisplayFormat="Total Incentive Amount={0:C2}" 
                 FieldName="Incentive Amount" SummaryType="Sum"  ShowInColumn="URL" />--%>
         </TotalSummary>
        <Columns>
            <dx:GridViewDataTextColumn FieldName="Invoice Number" ReadOnly="True" 
                VisibleIndex="0" Width="120px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="Invoice Date" VisibleIndex="1">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="Recovery Amount" VisibleIndex="2">
                <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="C2">
                </PropertiesTextEdit>
                <CellStyle HorizontalAlign="Right">
                </CellStyle>
            </dx:GridViewDataTextColumn>
      <%--      <dx:GridViewDataTextColumn FieldName="Invoice Amount" VisibleIndex="3">
                <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="C2">
                </PropertiesTextEdit>
                <CellStyle HorizontalAlign="Right">
                </CellStyle>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Incentive Amount" VisibleIndex="4">
                <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="C2">
                </PropertiesTextEdit>
                <CellStyle HorizontalAlign="Right">
                </CellStyle>
            </dx:GridViewDataTextColumn>--%>
            <dx:GridViewDataTextColumn FieldName="Check Number" VisibleIndex="5" 
                Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="Check Date" VisibleIndex="6" 
                Visible="False">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="Check Amount" VisibleIndex="7" 
                Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataHyperLinkColumn FieldName="URL" VisibleIndex="8">
                <PropertiesHyperLinkEdit Target="_blank" NavigateUrlFormatString="showfile.aspx?file={0}">
                </PropertiesHyperLinkEdit>
            </dx:GridViewDataHyperLinkColumn>
            <dx:GridViewDataTextColumn FieldName="Status" VisibleIndex="9">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Customer" VisibleIndex="10" 
                Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Comments" VisibleIndex="11" 
                Visible="False">
            </dx:GridViewDataTextColumn>
        </Columns>
        <SettingsBehavior ColumnResizeMode="Control" />
        <Settings ShowFilterBar="Auto" ShowFilterRowMenu="True" ShowHeaderFilterButton="True"
            ShowVerticalScrollBar="True" VerticalScrollableHeight="600" 
             VerticalScrollBarStyle="Virtual" ShowFooter="True" />
        <SettingsCookies Enabled="True" CookiesID="grdInvoiceSubmission1" />
        <Styles>
            <Header Wrap="True" HorizontalAlign="Center">
                <BackgroundImage ImageUrl="~/images/bgBig.png" Repeat="RepeatX" />
            </Header>
            <AlternatingRow Enabled="True">
            </AlternatingRow>
            <Cell Wrap="True" HorizontalAlign="Center">
            </Cell>
            <Footer Font-Bold="True">
            </Footer>
        </Styles>
    </dx:ASPxGridView>
    <asp:SqlDataSource ID="SqlInvoice" runat="server" 
        ConnectionString="<%$ ConnectionStrings:connectionString %>" 
        SelectCommand="ORSelectInvoices" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SubContent" runat="server">
</asp:Content>
