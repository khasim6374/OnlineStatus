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
        KeyFieldName="Invoice_Number" ClientIDMode="Static"
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
            <dx:ASPxSummaryItem DisplayFormat="Total: {0:C2}"
                FieldName="Recovery Amount" ShowInColumn="Recovery Amount"
                SummaryType="Sum" />
              <dx:ASPxSummaryItem DisplayFormat="Total: {0:C2}" 
                 FieldName="Invoice Amount" SummaryType="Sum" />
            <%-- <dx:ASPxSummaryItem DisplayFormat="Total Incentive Amount={0:C2}" 
                 FieldName="Incentive Amount" SummaryType="Sum"  ShowInColumn="URL" />--%>
        </TotalSummary>
        <Columns>
            <dx:GridViewCommandColumn ShowEditButton="true" ShowCancelButton="true" ShowUpdateButton="true" VisibleIndex="11" Width="60px"
                Caption="Edit">
                <%--<EditButton Visible="True">
                    <Image Url="~/images/edit.png">
                    </Image>
                </EditButton>
                <CancelButton>
                    <Image Url="~/images/cancelsmall.png">
                    </Image>
                </CancelButton>
                <UpdateButton>
                    <Image Url="~/images/updatesmall.png">
                    </Image>
                </UpdateButton>--%>
                <%--<CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="myButton" Text="Edit">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>--%>
            </dx:GridViewCommandColumn>

            <%--<dx:GridViewCommandColumn ShowDeleteButton="true" Caption=" " VisibleIndex="0">
            </dx:GridViewCommandColumn>
            <dx:GridViewCommandColumn ShowNewButtonInHeader="true" Caption=" " VisibleIndex="1">
                <CustomButtons>
                        <dx:GridViewCommandColumnCustomButton ID="myButton" Text="Edit">
                        </dx:GridViewCommandColumnCustomButton>
                    </CustomButtons>
            </dx:GridViewCommandColumn>--%>

            <dx:GridViewDataTextColumn FieldName="Invoice_Number" ReadOnly="True"
                VisibleIndex="0" Width="120px" Caption="Invoice Number">
                <EditCellStyle HorizontalAlign="Center">
                </EditCellStyle>
                <EditItemTemplate>
                    <dx:ASPxLabel ID="ASPxLabel1" runat="server"
                        Text='<%# Eval("Invoice_Number") %>'>
                    </dx:ASPxLabel>
                </EditItemTemplate>
                <CellStyle HorizontalAlign="Center">
                </CellStyle>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="Invoice Date" VisibleIndex="1">
                <EditCellStyle HorizontalAlign="Center">
                </EditCellStyle>
                <EditItemTemplate>
                    <dx:ASPxLabel ID="ASPxLabel2" runat="server"
                        Text='<%# Eval("[Invoice Date]", "{0:d}") %>'>
                    </dx:ASPxLabel>
                </EditItemTemplate>
                <CellStyle HorizontalAlign="Center">
                </CellStyle>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="Recovery Amount" VisibleIndex="2">
                <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="C2">
                </PropertiesTextEdit>
                <EditCellStyle HorizontalAlign="Right">
                </EditCellStyle>
                <EditItemTemplate>
                    <dx:ASPxLabel ID="ASPxLabel4" runat="server"
                        Text='<%# Eval("[Recovery Amount]", "{0:C2}") %>'>
                    </dx:ASPxLabel>
                </EditItemTemplate>
                <CellStyle HorizontalAlign="Right">
                </CellStyle>
            </dx:GridViewDataTextColumn>
              <dx:GridViewDataTextColumn FieldName="Invoice Amount" VisibleIndex="2">
                <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="C2">
                </PropertiesTextEdit>
                <EditCellStyle HorizontalAlign="Right">
                </EditCellStyle>
                <EditItemTemplate>
                    <dx:ASPxLabel ID="ASPxLabel4" runat="server"
                        Text='<%# Eval("[Invoice Amount]", "{0:C2}") %>'>
                    </dx:ASPxLabel>
                </EditItemTemplate>
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
            <dx:GridViewDataTextColumn FieldName="Check Number" VisibleIndex="3"
                Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="Check Date" VisibleIndex="4"
                Visible="False">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataHyperLinkColumn FieldName="URL" VisibleIndex="6">
                <PropertiesHyperLinkEdit Target="_blank" TextField="FileName" NavigateUrlFormatString="/{0}">
                </PropertiesHyperLinkEdit>
                <EditCellStyle HorizontalAlign="Center">
                </EditCellStyle>
                <EditItemTemplate>
                    <dx:ASPxHyperLink ID="ASPxHyperLink1" runat="server"
                        NavigateUrl='<%# Eval("URL") %>' Text='<%# Eval("FileName") %>' />
                </EditItemTemplate>
                <CellStyle HorizontalAlign="Center">
                </CellStyle>
            </dx:GridViewDataHyperLinkColumn>
            <dx:GridViewDataTextColumn FieldName="Status" VisibleIndex="7">
                <EditCellStyle HorizontalAlign="Center">
                </EditCellStyle>
                <EditItemTemplate>
                    <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text='<%# Eval("Status") %>'>
                    </dx:ASPxLabel>
                </EditItemTemplate>
                <CellStyle HorizontalAlign="Center">
                </CellStyle>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Customer" VisibleIndex="8"
                Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Comments" VisibleIndex="10"
                Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataMemoColumn Caption="Remarks" FieldName="Remarks"
                VisibleIndex="9">
                <EditCellStyle HorizontalAlign="Center">
                </EditCellStyle>
            </dx:GridViewDataMemoColumn>
        </Columns>
        <SettingsCommandButton>
            <EditButton ButtonType="Image">
                    <Image Url="~/images/edit.png">
                    </Image>
                </EditButton>
                <CancelButton ButtonType="Image">
                    <Image Url="~/images/cancelsmall.png">
                    </Image>
                </CancelButton>
                <UpdateButton ButtonType="Image">
                    <Image Url="~/images/updatesmall.png">
                    </Image>
                </UpdateButton>
        </SettingsCommandButton>
        <SettingsBehavior ColumnResizeMode="Control" />
        <SettingsPager Mode="ShowAllRecords" PageSize="15" RenderMode="Lightweight">
            </SettingsPager>
        <SettingsEditing Mode="Inline" />
        <Settings ShowFilterBar="Auto" ShowFilterRowMenu="True" ShowHeaderFilterButton="True"
            ShowVerticalScrollBar="True" VerticalScrollableHeight="600"
            VerticalScrollBarStyle="Virtual" ShowFooter="True" />
        <SettingsCookies CookiesID="grdInvoiceSubmission12" />
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
        SelectCommand="ORSelectInvoices" SelectCommandType="StoredProcedure"
        UpdateCommand="ORUpdateInvoices" UpdateCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="hdnDatabase" Name="database"
                PropertyName="Value" Type="String" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="Invoice_Number" Type="String" />
            <asp:Parameter Name="Remarks" Type="String" />
            <asp:ControlParameter ControlID="hdnDatabase" Name="database" PropertyName="Value" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:HiddenField ID="hdnDatabase" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SubContent" runat="server">
</asp:Content>
