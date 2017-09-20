<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master"
    CodeBehind="claimsubmission.aspx.vb" Inherits="OnlineStatus.claimsubmission" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"    Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v15.1, Version=15.1.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"   Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>







<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v15.1, Version=15.1.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent1" runat="server">
    <script language="javascript" type="text/javascript">
        function adjustSize() {
            var height = Math.max(0, document.documentElement.clientHeight);
            grdClaimSubmission.SetHeight(height - 215);
            grdClaimSubmissionAccepted.SetHeight(height - 215);
            grdClaimSubmissionPending.SetHeight(height - 215);
        }
    </script>
    <style>
        .fntstyle {
            color:gray;
            padding:5px
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent1" runat="server">
    <div class="pageHeader">Claim Submission Summary</div>
    <div style="background-color: white">

        <div style="float: right; padding-right: 20px; position:absolute; right:0px">
            <table>
                <tr>                    
                    <td>
                        <dx:ASPxButton ID="btnPdf" runat="server" BackColor="Transparent"  Border-BorderWidth="0" BackgroundImage-ImageUrl="~/images/trans.gif" CssClass="NoStyle" Cursor="pointer"
                            EnableDefaultAppearance="False" EnableTheming="False" ToolTip="Export to Pdf">
                            <Image Url="~/images/pdf.png">
                            </Image>
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnXls" runat="server" BackColor="Transparent"  Border-BorderWidth="0" BackgroundImage-ImageUrl="~/images/trans.gif" CssClass="NoStyle" Cursor="pointer"
                            EnableDefaultAppearance="False" EnableTheming="False" ToolTip="Export to Excel">
                            <Image Url="~/images/excel.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                </tr>
            </table>
        </div>

        <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" 
            Width="100%">
            <TabPages>
                <dx:TabPage Text="New Claims">
                    <ContentCollection>
                        <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                            <dx:ASPxGridView ID="grdClaimSubmissionPending" runat="server" AutoGenerateColumns="False"
            DataSourceID="SqlDS" KeyFieldName="Claim_ID" ClientIDMode="Static" ClientInstanceName="grdClaimSubmissionPending"
            Width="100%">
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
                <dx:ASPxSummaryItem DisplayFormat="Total Claim ={0}" FieldName="Claim_ID"
                    SummaryType="Count" />
                <dx:ASPxSummaryItem DisplayFormat="Total Claim Amount ={0:c2}" FieldName="Claim Amount"
                    SummaryType="Sum" />
                <dx:ASPxSummaryItem DisplayFormat="Total Gain Share ={0:c2}" FieldName="Gain Share Amount"
                    SummaryType="Sum" />
            </TotalSummary>
            <Columns>
                <dx:GridViewCommandColumn ShowEditButton="true" ShowCancelButton="true" ShowUpdateButton="true" VisibleIndex="1" Width="60px" 
                    Caption="Edit" FixedStyle="Left">
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
                </dx:GridViewCommandColumn>
                <dx:GridViewDataDateColumn FieldName="Claim Submit Date" VisibleIndex="4"
                    ReadOnly="True" ExportWidth="80" ToolTip="Claim Submit Date">
                    <PropertiesDateEdit DisplayFormatInEditMode="True" DisplayFormatString="MM/dd/yyyy">
                    </PropertiesDateEdit>
                    <EditCellStyle HorizontalAlign="Center">
                    </EditCellStyle>
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("[Claim Submit Date]", "{0:MM/dd/yyyy}") %>'></asp:Label>
                    </EditItemTemplate>
                    <HeaderStyle Wrap="True" />
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataDateColumn>
                   <dx:GridViewDataTextColumn FieldName="Vendor Source" VisibleIndex="5" 
                    ExportWidth="100" ToolTip="Source">
                       <EditItemTemplate>
                            <asp:Label ID="Label11" runat="server" Text='<%# Eval("[Vendor Source]")%>'></asp:Label>
                       </EditItemTemplate>
                    <HeaderStyle Wrap="True" />
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataHyperLinkColumn Caption="Claim ID" FieldName="Claim_ID" ReadOnly="True"
                    VisibleIndex="6" Width="60px" ExportWidth="60">
                    <PropertiesHyperLinkEdit TextField="Claim_ID">
                    </PropertiesHyperLinkEdit>
                    <EditFormSettings Visible="True" />
                    <EditCellStyle HorizontalAlign="Center">
                    </EditCellStyle>
                    <DataItemTemplate>                       
                        <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl='<%# Eval("URL").ToString().Replace("\", "/")%>' Target="_blank"
                            Text='<%# Eval("Claim_ID") %>'></asp:HyperLink>
                    </DataItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Claim_ID") %>'></asp:Label>
                    </EditItemTemplate>
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataHyperLinkColumn>
                <dx:GridViewDataTextColumn FieldName="Vendor Name" VisibleIndex="8" ReadOnly="True"
                    Width="150px" ExportWidth="120" ToolTip="Vendor Name">
                    <EditItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("[Vendor Name]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Claim Reference Type" VisibleIndex="9"
                    ReadOnly="True" ExportWidth="75" ToolTip="Claim Reference Type">
                    <EditItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("[Recovery Type]") %>'></asp:Label>
                    </EditItemTemplate>
                    <HeaderStyle Wrap="True" />
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Claim Amount" VisibleIndex="10"
                    ReadOnly="True" ExportWidth="100" ToolTip="Claim Amount">
                    <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="c2">
                    </PropertiesTextEdit>
                    <EditItemTemplate>
                        <asp:Label ID="Label16" runat="server" Text='<%# Eval("[Claim Amount]", "{0:C2}") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Recovery Type" VisibleIndex="11"
                    ReadOnly="True" ExportWidth="80" ToolTip="Recovery Type">
                    <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="c2">
                    </PropertiesTextEdit>
                    <EditItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Eval("[Recovery Type]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Additional Comments" VisibleIndex="12"
                    ReadOnly="True" ExportWidth="100" ToolTip="Additional Comments">
                    <EditItemTemplate>
                        <asp:Label ID="Label9" runat="server" Text='<%# Eval("[Additional Comments]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Invoice Number" VisibleIndex="16"
                    ReadOnly="True" ExportWidth="85" Caption="Revenew Invoice" 
                    ToolTip="Invoice Number">
                    <EditItemTemplate>
                        <asp:Label ID="Label10" runat="server" Text='<%# Eval("[Additional Comments]") %>'></asp:Label>
                    </EditItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="Label11" runat="server" Text='<%# Eval("[Invoice Number]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="URL" VisibleIndex="20" ReadOnly="True" 
                    Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Entity" VisibleIndex="13"
                    ExportWidth="65" ToolTip="Entity">
                    <EditItemTemplate>
                        <asp:Label ID="Label15" runat="server" Text='<%# Eval("Entity") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataComboBoxColumn FieldName="Status" VisibleIndex="2" ExportWidth="60"
                    Caption="Review_Status  (Client Update)" 
                    ToolTip="Review Status (Client Update)">
                    <PropertiesComboBox ValueType="System.Int32">
                        <Items>
                            <dx:ListEditItem Text="----------" Value="0" />
                            <dx:ListEditItem Text="Accept" Value="1" />
                            <dx:ListEditItem Text="Reject" Value="2" />
                            <dx:ListEditItem Text="Pending" Value="3" />
                        </Items>
                    </PropertiesComboBox>
                    <Settings AllowHeaderFilter="False" />
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataMemoColumn FieldName="Remarks" VisibleIndex="3" Width="100px" 
                    Caption="Remarks (Client_Update)" ToolTip="Remarks (Client Update)">
			<cellstyle wrap="True">
			</cellstyle>
                </dx:GridViewDataMemoColumn>
                <dx:GridViewDataTextColumn FieldName="Claim Status" VisibleIndex="14" 
                    ToolTip="Revenew Status" Caption="Revenew Status">
                    <EditItemTemplate>
                        <asp:Label ID="Label17" runat="server" Text='<%# Eval("[Claim Status]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="LeadAuditorEmail" Visible="False" 
                    VisibleIndex="22">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn ShowInCustomizationForm="True" VisibleIndex="0" 
                    Caption="E-Mail" FixedStyle="Left" Width="50px">
                    <EditFormSettings Visible="False" />
                    <EditCellStyle HorizontalAlign="Center">
                    </EditCellStyle>
                    <DataItemTemplate>
                        <a href="javascript:void(0);" onclick="popEmail.PerformCallback('<%# Eval("[Claim_ID]")%>|<%# Eval("[Status]")%>|<%# Eval("[Remarks]")%>|<%# Eval("[Claim Submit Date]")%>|<%# Eval("[Vendor Name]")%>|<%# Eval("[URL]").ToString().Replace("\", "/")%>');"><img src="images/email.png" tooltip="Email"/></a>
                    </DataItemTemplate>
                    <EditItemTemplate>
                        <a href="javascript:void(0);" onclick="popEmail.PerformCallback('<%# Eval("[Claim_ID]")%>|<%# Eval("[Status]")%>|<%# Eval("[Remarks]")%>|<%# Eval("[Claim Submit Date]")%>|<%# Eval("[Vendor Name]")%>|<%# Eval("[URL]").ToString().Replace("\", "/")%>');"><img src="images/email.png" tooltip="Email"/></a>
                    </EditItemTemplate>
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataTextColumn>
                <%--<dx:GridViewDataTextColumn Caption="Process" FieldName="Dup or Statement" 
                    ShowInCustomizationForm="True" VisibleIndex="18">
                    <EditItemTemplate>
                        <dx:ASPxLabel ID="ASPxLabel176" runat="server" Text='<%# Eval("[Dup or Statement]")%>'>
                        </dx:ASPxLabel>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>--%>
                <dx:GridViewDataTextColumn FieldName="Vendor Number" 
                    ShowInCustomizationForm="True" VisibleIndex="7" ReadOnly="True">
                    <EditItemTemplate>
                         <dx:ASPxLabel ID="ASPxLabel176" runat="server" Text='<%# Eval("[Vendor Number]")%>'>
                        </dx:ASPxLabel>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
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
            <SettingsBehavior ColumnResizeMode="Control"></SettingsBehavior>
            <SettingsPager Mode="ShowAllRecords" PageSize="25" RenderMode="Lightweight">
            </SettingsPager>
            <SettingsEditing Mode="Inline" />
            <Settings ShowFilterRowMenu="True" ShowHeaderFilterButton="True"
                ShowVerticalScrollBar="True" VerticalScrollableHeight="600"
                ShowFooter="True" HorizontalScrollBarMode="Auto" ShowStatusBar="Hidden" />
            <SettingsCookies CookiesID="grdclaimPending0912" StoreControlWidth="True" Version="15" Enabled="True" />
            <Styles>
                <Header Wrap="True" HorizontalAlign="Center">                   
                </Header>
                <AlternatingRow Enabled="True">
                </AlternatingRow>
                <Cell Wrap="False">
                </Cell>
                <Footer Font-Bold="True">
                </Footer>
            </Styles>
        </dx:ASPxGridView>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="Pending Claims ">
                    <ContentCollection>
                        <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                            <dx:ASPxGridView ID="grdClaimSubmission" runat="server" AutoGenerateColumns="False"
            DataSourceID="SqlDS" KeyFieldName="Claim_ID" ClientIDMode="Static" ClientInstanceName="grdClaimSubmission"
            Width="100%">
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
                <dx:ASPxSummaryItem DisplayFormat="Total Claim ={0}" FieldName="Claim_ID"
                    SummaryType="Count" />
                <dx:ASPxSummaryItem DisplayFormat="Total Claim Amount ={0:c2}" FieldName="Claim Amount"
                    SummaryType="Sum" />
                <dx:ASPxSummaryItem DisplayFormat="Total Gain Share ={0:c2}" FieldName="Gain Share Amount"
                    SummaryType="Sum" />
            </TotalSummary>
            <Columns>
                <dx:GridViewCommandColumn ShowEditButton="true" ShowCancelButton="true" ShowUpdateButton="true" VisibleIndex="1" Width="60px" Caption="Edit" FixedStyle="Left">
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
                </dx:GridViewCommandColumn>
                <dx:GridViewDataDateColumn FieldName="Claim Submit Date" VisibleIndex="4"
                    ReadOnly="True" ExportWidth="80" ToolTip="Claim Submit Date">
                    <PropertiesDateEdit DisplayFormatInEditMode="True" DisplayFormatString="MM/dd/yyyy">
                    </PropertiesDateEdit>
                    <EditCellStyle HorizontalAlign="Center">
                    </EditCellStyle>
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("[Claim Submit Date]", "{0:MM/dd/yyyy}") %>'></asp:Label>
                    </EditItemTemplate>
                    <HeaderStyle Wrap="True" />
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataDateColumn>
                   <dx:GridViewDataTextColumn FieldName="Vendor Source" VisibleIndex="5" 
                    ExportWidth="100" ToolTip="Source">
                       <EditItemTemplate>
                            <asp:Label ID="Label11" runat="server" Text='<%# Eval("[Vendor Source]")%>'></asp:Label>
                       </EditItemTemplate>
                    <HeaderStyle Wrap="True" />
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataHyperLinkColumn Caption="Claim ID" FieldName="Claim_ID" ReadOnly="True"
                    VisibleIndex="6" Width="60px" ExportWidth="60">
                    <PropertiesHyperLinkEdit TextField="Claim_ID">
                    </PropertiesHyperLinkEdit>
                    <EditFormSettings Visible="True" />
                    <EditCellStyle HorizontalAlign="Center">
                    </EditCellStyle>
                    <DataItemTemplate>                       
                        <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl='<%# Eval("URL").ToString().Replace("\", "/")%>' Target="_blank"
                            Text='<%# Eval("Claim_ID") %>'></asp:HyperLink>
                    </DataItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Claim_ID") %>'></asp:Label>
                    </EditItemTemplate>
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataHyperLinkColumn>
                <dx:GridViewDataTextColumn FieldName="Vendor Name" VisibleIndex="8" ReadOnly="True"
                    Width="150px" ExportWidth="120" ToolTip="Vendor Name">
                    <EditItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("[Vendor Name]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Claim Reference Type" VisibleIndex="9"
                    ReadOnly="True" ExportWidth="75" ToolTip="Claim Reference Type">
                    <EditItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("[Recovery Type]") %>'></asp:Label>
                    </EditItemTemplate>
                    <HeaderStyle Wrap="True" />
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Claim Amount" VisibleIndex="10"
                    ReadOnly="True" ExportWidth="100" ToolTip="Claim Amount">
                    <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="c2">
                    </PropertiesTextEdit>
                    <EditItemTemplate>
                        <asp:Label ID="Label16" runat="server" Text='<%# Eval("[Claim Amount]", "{0:C2}") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Recovery Type" VisibleIndex="11"
                    ReadOnly="True" ExportWidth="80" ToolTip="Recovery Type">
                    <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="c2">
                    </PropertiesTextEdit>
                    <EditItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Eval("[Recovery Type]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Additional Comments" VisibleIndex="12"
                    ReadOnly="True" ExportWidth="100" ToolTip="Additional Comments">
                    <EditItemTemplate>
                        <asp:Label ID="Label9" runat="server" Text='<%# Eval("[Additional Comments]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Invoice Number" VisibleIndex="15"
                    ReadOnly="True" ExportWidth="85" Caption="Revenew Invoice" 
                    ToolTip="Invoice Number">
                    <EditItemTemplate>
                        <asp:Label ID="Label10" runat="server" Text='<%# Eval("[Additional Comments]") %>'></asp:Label>
                    </EditItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="Label11" runat="server" Text='<%# Eval("[Invoice Number]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="URL" VisibleIndex="17" ReadOnly="True" 
                    Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Entity" VisibleIndex="13"
                    ExportWidth="65" ToolTip="Entity">
                    <EditItemTemplate>
                        <asp:Label ID="Label15" runat="server" Text='<%# Eval("Entity") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataComboBoxColumn FieldName="Status" VisibleIndex="2" 
                    Caption="Review_Status  (Client Update)" 
                    ToolTip="Review Status (Client Update)">
                    <PropertiesComboBox ValueType="System.Int32">
                        <Items>
                            <dx:ListEditItem Text="Accept" Value="1" />
                            <dx:ListEditItem Text="Reject" Value="2" />
                            <dx:ListEditItem Text="Pending" Value="3" />
                        </Items>
                    </PropertiesComboBox>
                    <Settings AllowHeaderFilter="False" />
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataMemoColumn FieldName="Remarks" VisibleIndex="3" Width="100px" 
                    Caption="Remarks (Client_Update)" ToolTip="Remarks (Client Update)">
                    <cellstyle wrap="True">
			</cellstyle>
                </dx:GridViewDataMemoColumn>
                <dx:GridViewDataTextColumn FieldName="Claim Status" VisibleIndex="14" 
                    ToolTip="Revenew Status" Caption="Revenew Status">
                    <EditItemTemplate>
                        <asp:Label ID="Label17" runat="server" Text='<%# Eval("[Claim Status]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="ModifiedBy" VisibleIndex="22" 
                    Caption="Modified By">
                    <EditItemTemplate>
                        <asp:Label ID="Label184" runat="server" Text='<%# Eval("[ModifiedBy]")%>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="LeadAuditorEmail" Visible="False" 
                    VisibleIndex="19">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn ShowInCustomizationForm="True" VisibleIndex="0" 
                    Caption="E-Mail" FixedStyle="Left" Width="50px">
                    <EditFormSettings Visible="False" />
                    <EditCellStyle HorizontalAlign="Center">
                    </EditCellStyle>
                    <DataItemTemplate>
                        <a href="javascript:void(0);" onclick="popEmail.PerformCallback('<%# Eval("[Claim_ID]")%>|<%# Eval("[Status]")%>|<%# Eval("[Remarks]")%>|<%# Eval("[Claim Submit Date]")%>|<%# Eval("[Vendor Name]")%>|<%# Eval("[URL]").ToString().Replace("\", "/")%>');"><img src="images/email.png" tooltip="Email"/></a>
                    </DataItemTemplate>
                    <EditItemTemplate>
                        <a href="javascript:void(0);" onclick="popEmail.PerformCallback('<%# Eval("[Claim_ID]")%>|<%# Eval("[Status]")%>|<%# Eval("[Remarks]")%>|<%# Eval("[Claim Submit Date]")%>|<%# Eval("[Vendor Name]")%>|<%# Eval("[URL]").ToString().Replace("\", "/")%>');"><img src="images/email.png" tooltip="Email"/></a>
                    </EditItemTemplate>
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataDateColumn FieldName="ModifiedOn" 
                    ShowInCustomizationForm="True" VisibleIndex="24">
                    <PropertiesDateEdit DisplayFormatInEditMode="True" 
                        DisplayFormatString="MM/dd/yyyy">
                    </PropertiesDateEdit>
                    <EditItemTemplate>
                        <asp:Label ID="Label186" runat="server" 
                            Text='<%# Eval("ModifiedOn", "{0:d}") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataDateColumn>
                <%--<dx:GridViewDataTextColumn Caption="Process" FieldName="Dup or Statement" 
                    ShowInCustomizationForm="True" VisibleIndex="20">
                    <EditItemTemplate>
                        <dx:ASPxLabel ID="ASPxLabel176" runat="server" Text='<%# Eval("[Dup or Statement]")%>'>
                        </dx:ASPxLabel>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>--%>
                <dx:GridViewDataTextColumn FieldName="Vendor Number" ReadOnly="True" 
                    ShowInCustomizationForm="True" VisibleIndex="7">
                    <EditItemTemplate>
                         <asp:Label ID="Label17" runat="server" Text='<%# Eval("[Vendor Number]")%>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
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
            <SettingsBehavior ColumnResizeMode="Control"></SettingsBehavior>
            <SettingsPager Mode="ShowAllRecords" PageSize="25" RenderMode="Lightweight">
            </SettingsPager>
            <SettingsEditing Mode="Inline" />
            <Settings ShowFilterRowMenu="True" ShowHeaderFilterButton="True"
                ShowVerticalScrollBar="True" VerticalScrollableHeight="600"
                ShowFooter="True" HorizontalScrollBarMode="Auto" ShowFilterRowMenuLikeItem="True" />
            <SettingsCookies CookiesID="grdclaim0912" StoreControlWidth="True" Version="15" Enabled="True" />
            <Styles>
                <Header Wrap="True" HorizontalAlign="Center">
                </Header>
                <AlternatingRow Enabled="True">
                </AlternatingRow>
                <Cell Wrap="False">
                </Cell>
                <Footer Font-Bold="True">
                </Footer>
            </Styles>
        </dx:ASPxGridView></dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="Accepted Claims">
                    <ContentCollection>
                        <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                            <dx:ASPxGridView ID="grdClaimSubmissionAccepted" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDS" KeyFieldName="Claim_ID" Width="100%" ClientInstanceName="grdClaimSubmissionAccepted">
                                <TotalSummary>
                <dx:ASPxSummaryItem DisplayFormat="Total Claim ={0}" FieldName="Claim_ID"
                    SummaryType="Count" />
                <dx:ASPxSummaryItem DisplayFormat="Total Claim Amount ={0:c2}" FieldName="Claim Amount"
                    SummaryType="Sum" />
                <dx:ASPxSummaryItem DisplayFormat="Total Gain Share ={0:c2}" FieldName="Gain Share Amount"
                    SummaryType="Sum" />
            </TotalSummary>
                                <Columns>
                <dx:GridViewCommandColumn ShowEditButton="true" ShowCancelButton="true" ShowUpdateButton="true"  VisibleIndex="1" Width="60px" Caption="Edit" FixedStyle="Left">
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
                </dx:GridViewCommandColumn>
                <dx:GridViewDataDateColumn FieldName="Claim Submit Date" VisibleIndex="4"
                    ReadOnly="True" ExportWidth="80" ToolTip="Claim Submit Date">
                    <PropertiesDateEdit DisplayFormatInEditMode="True" DisplayFormatString="MM/dd/yyyy">
                    </PropertiesDateEdit>
                    <EditCellStyle HorizontalAlign="Center">
                    </EditCellStyle>
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("[Claim Submit Date]", "{0:MM/dd/yyyy}") %>'></asp:Label>
                    </EditItemTemplate>
                    <HeaderStyle Wrap="True" />
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataDateColumn>
                   <dx:GridViewDataTextColumn FieldName="Vendor Source" VisibleIndex="5" ExportWidth="100" 
                                        ToolTip="Source">
                       <EditItemTemplate>
                            <asp:Label ID="Label11" runat="server" Text='<%# Eval("[Vendor Source]")%>'></asp:Label>
                       </EditItemTemplate>
                    <HeaderStyle Wrap="True" />
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataHyperLinkColumn Caption="Claim ID" FieldName="Claim_ID" ReadOnly="True"
                    VisibleIndex="6" Width="60px" ExportWidth="60">
                    <PropertiesHyperLinkEdit TextField="Claim_ID">
                    </PropertiesHyperLinkEdit>
                    <EditFormSettings Visible="True" />
                    <EditCellStyle HorizontalAlign="Center">
                    </EditCellStyle>
                    <DataItemTemplate>                       
                        <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl='<%# Eval("URL").ToString().Replace("\", "/")%>' Target="_blank"
                            Text='<%# Eval("Claim_ID") %>'></asp:HyperLink>
                    </DataItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Claim_ID") %>'></asp:Label>
                    </EditItemTemplate>
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataHyperLinkColumn>
                <dx:GridViewDataTextColumn FieldName="Vendor Name" VisibleIndex="8" ReadOnly="True"
                    Width="150px" ExportWidth="120" ToolTip="Vendor Name">
                    <EditItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("[Vendor Name]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Claim Reference Type" VisibleIndex="9"
                    ReadOnly="True" ExportWidth="75" ToolTip="Claim Reference Type">
                    <EditItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("[Recovery Type]") %>'></asp:Label>
                    </EditItemTemplate>
                    <HeaderStyle Wrap="True" />
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Claim Amount" VisibleIndex="10"
                    ReadOnly="True" ExportWidth="100" ToolTip="Claim Amount">
                    <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="c2">
                    </PropertiesTextEdit>
                    <EditItemTemplate>
                        <asp:Label ID="Label16" runat="server" Text='<%# Eval("[Claim Amount]", "{0:C2}") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Recovery Type" VisibleIndex="11"
                    ReadOnly="True" ExportWidth="80" ToolTip="Recovery Type">
                    <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="c2">
                    </PropertiesTextEdit>
                    <EditItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Eval("[Recovery Type]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Additional Comments" VisibleIndex="12"
                    ReadOnly="True" ExportWidth="100" ToolTip="Additional Comments">
                    <EditItemTemplate>
                        <asp:Label ID="Label9" runat="server" Text='<%# Eval("[Additional Comments]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Invoice Number" VisibleIndex="17"
                    ReadOnly="True" ExportWidth="85" Caption="Revenew Invoice" 
                    ToolTip="Invoice Number">
                    <EditItemTemplate>
                        <asp:Label ID="Label10" runat="server" Text='<%# Eval("[Additional Comments]") %>'></asp:Label>
                    </EditItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="Label11" runat="server" Text='<%# Eval("[Invoice Number]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="URL" VisibleIndex="19" ReadOnly="True" 
                    Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Entity" VisibleIndex="13"
                    ExportWidth="65" ToolTip="Entity">
                    <EditItemTemplate>
                        <asp:Label ID="Label15" runat="server" Text='<%# Eval("Entity") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataMemoColumn FieldName="Remarks" VisibleIndex="3" Width="100px" 
                    Caption="Remarks (Client_Update)" ToolTip="Remarks (Client Update)">
                    <cellstyle wrap="True">
		</cellstyle>
                </dx:GridViewDataMemoColumn>
                <dx:GridViewDataTextColumn FieldName="Claim Status" VisibleIndex="14" ToolTip="Revenew Status" Caption="Revenew Status">
                    <EditItemTemplate>
                        <asp:Label ID="Label17" runat="server" Text='<%# Eval("[Claim Status]") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="ModifiedBy" VisibleIndex="23" 
                    Caption="Modified By">
                    <EditItemTemplate>
                        <asp:Label ID="Label184" runat="server" Text='<%# Eval("[ModifiedBy]")%>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="LeadAuditorEmail" Visible="False" 
                    VisibleIndex="20">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn ShowInCustomizationForm="True" VisibleIndex="0" 
                    Caption="E-Mail" FixedStyle="Left" Width="50px">
                    <EditFormSettings Visible="False" />
                    <EditCellStyle HorizontalAlign="Center">
                    </EditCellStyle>
                    <DataItemTemplate>
                        <a href="javascript:void(0);" onclick="popEmail.PerformCallback('<%# Eval("[Claim_ID]")%>|<%# Eval("[Status]")%>|<%# Eval("[Remarks]")%>|<%# Eval("[Claim Submit Date]")%>|<%# Eval("[Vendor Name]")%>|<%# Eval("[URL]").ToString().Replace("\", "/")%>');"><img src="images/email.png" tooltip="Email"/></a>
                    </DataItemTemplate>
                    <EditItemTemplate>
                        <a href="javascript:void(0);" onclick="popEmail.PerformCallback('<%# Eval("[Claim_ID]")%>|<%# Eval("[Status]")%>|<%# Eval("[Remarks]")%>|<%# Eval("[Claim Submit Date]")%>|<%# Eval("[Vendor Name]")%>|<%# Eval("[URL]").ToString().Replace("\", "/")%>');"><img src="images/email.png" tooltip="Email"/></a>
                    </EditItemTemplate>
                    <CellStyle HorizontalAlign="Center">
                    </CellStyle>
                </dx:GridViewDataTextColumn>
               <dx:GridViewDataDateColumn FieldName="ModifiedOn" 
                    ShowInCustomizationForm="True" VisibleIndex="25">
                    <PropertiesDateEdit DisplayFormatInEditMode="True" 
                        DisplayFormatString="MM/dd/yyyy">
                    </PropertiesDateEdit>
                    <EditItemTemplate>
                        <asp:Label ID="Label186" runat="server" 
                            Text='<%# Eval("ModifiedOn", "{0:d}") %>'></asp:Label>
                    </EditItemTemplate>
                </dx:GridViewDataDateColumn>
                                    <dx:GridViewDataTextColumn Caption="Review_Status  (Client Update)" 
                                        ShowInCustomizationForm="True" VisibleIndex="2">
                                        <DataItemTemplate>
                                            <asp:Label ID="Label187" runat="server" Text='Accepted'></asp:Label>
                                        </DataItemTemplate>
                                        <EditItemTemplate>
                                           <asp:Label ID="Label188" runat="server" Text='Accepted'></asp:Label>
                                        </EditItemTemplate>
                                    </dx:GridViewDataTextColumn>
                                   <%--<dx:GridViewDataTextColumn Caption="Process" FieldName="Dup or Statement" 
                    ShowInCustomizationForm="True" VisibleIndex="21">
                    <EditItemTemplate>
                        <dx:ASPxLabel ID="ASPxLabel176" runat="server" Text='<%# Eval("[Dup or Statement]")%>'>
                        </dx:ASPxLabel>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>--%>
                                    <dx:GridViewDataTextColumn FieldName="Vendor Number" ReadOnly="True" 
                                        ShowInCustomizationForm="True" VisibleIndex="7">
                                        <EditItemTemplate>
                                           <asp:Label ID="Label17" runat="server" Text='<%# Eval("[Vendor Number]")%>'></asp:Label>
                                        </EditItemTemplate>
                                    </dx:GridViewDataTextColumn>
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
            <SettingsBehavior ColumnResizeMode="Control"></SettingsBehavior>
            <SettingsPager Mode="ShowAllRecords" PageSize="25" RenderMode="Lightweight">
            </SettingsPager>
            <SettingsEditing Mode="Inline" />
            <Settings ShowFilterRowMenu="True" ShowHeaderFilterButton="True"
                ShowVerticalScrollBar="True" VerticalScrollableHeight="600"
                ShowFooter="True" HorizontalScrollBarMode="Auto" ShowFilterRowMenuLikeItem="True" />
            <SettingsCookies CookiesID="grdclaimAccepted0912" StoreControlWidth="True" Version="15" 
                                    Enabled="True" />
           <Styles>
                <Header Wrap="True" HorizontalAlign="Center">
                </Header>
                <AlternatingRow Enabled="True">
                </AlternatingRow>
                <Cell Wrap="False">
                </Cell>
                <Footer Font-Bold="True">
                </Footer>
            </Styles>
                            </dx:ASPxGridView>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="All Claims">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <dx:ASPxGridView ID="grdClaimSubmissionAll" runat="server" AutoGenerateColumns="False" ClientIDMode="Static" ClientInstanceName="grdClaimSubmissionAll" DataSourceID="SqlDS" KeyFieldName="Claim_ID" Width="100%">
                                <ClientSideEvents ColumnMoving="function(s, e) {
	adjustSize();
}" ColumnResized="function(s, e) {
	adjustSize();
}" ColumnSorting="function(s, e) {
	adjustSize();
}" EndCallback="function(s, e) {
	adjustSize();
}" Init="function(s, e) {
                       adjustSize();
	
}" />
                                <TotalSummary>
                                    <dx:ASPxSummaryItem DisplayFormat="Total Claim ={0}" FieldName="Claim_ID" SummaryType="Count" />
                                    <dx:ASPxSummaryItem DisplayFormat="Total Claim Amount ={0:c2}" FieldName="Claim Amount" SummaryType="Sum" />
                                    <dx:ASPxSummaryItem DisplayFormat="Total Gain Share ={0:c2}" FieldName="Gain Share Amount" SummaryType="Sum" />
                                </TotalSummary>
                                <Columns>
                                    <dx:GridViewCommandColumn ShowEditButton="true" ShowCancelButton="true" ShowUpdateButton="true" Caption="Edit" FixedStyle="Left" ShowInCustomizationForm="True" VisibleIndex="1" Width="60px">
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
                                    </dx:GridViewCommandColumn>
                                    <dx:GridViewDataDateColumn ExportWidth="80" FieldName="Claim Submit Date" ReadOnly="True" ShowInCustomizationForm="True" ToolTip="Claim Submit Date" VisibleIndex="4">
                                        <PropertiesDateEdit DisplayFormatInEditMode="True" DisplayFormatString="MM/dd/yyyy">
                                        </PropertiesDateEdit>
                                        <EditCellStyle HorizontalAlign="Center">
                                        </EditCellStyle>
                                        <EditItemTemplate>
                                            <asp:Label ID="Label189" runat="server" Text='<%# Eval("[Claim Submit Date]", "{0:MM/dd/yyyy}") %>'></asp:Label>
                                        </EditItemTemplate>
                                        <HeaderStyle Wrap="True" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataDateColumn>
                                    <dx:GridViewDataTextColumn ExportWidth="100" FieldName="Vendor Source" ShowInCustomizationForm="True" ToolTip="Source" VisibleIndex="5">
                                        <EditItemTemplate>
                                            <asp:Label ID="Label190" runat="server" Text='<%# Eval("[Vendor Source]")%>'></asp:Label>
                                        </EditItemTemplate>
                                        <HeaderStyle Wrap="True" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataHyperLinkColumn Caption="Claim ID" ExportWidth="60" FieldName="Claim_ID" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="6" Width="60px">
                                        <PropertiesHyperLinkEdit TextField="Claim_ID">
                                        </PropertiesHyperLinkEdit>
                                        <EditFormSettings Visible="True" />
                                        <EditCellStyle HorizontalAlign="Center">
                                        </EditCellStyle>
                                        <DataItemTemplate>
                                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("URL").ToString().Replace("\", "/")%>' Target="_blank" Text='<%# Eval("Claim_ID") %>'></asp:HyperLink>
                                        </DataItemTemplate>
                                        <EditItemTemplate>
                                            <asp:Label ID="Label191" runat="server" Text='<%# Eval("Claim_ID") %>'></asp:Label>
                                        </EditItemTemplate>
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataHyperLinkColumn>
                                    <dx:GridViewDataTextColumn ExportWidth="120" FieldName="Vendor Name" ReadOnly="True" ShowInCustomizationForm="True" ToolTip="Vendor Name" VisibleIndex="8" Width="150px">
                                        <EditItemTemplate>
                                            <asp:Label ID="Label192" runat="server" Text='<%# Eval("[Vendor Name]") %>'></asp:Label>
                                        </EditItemTemplate>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn ExportWidth="75" FieldName="Claim Reference Type" ReadOnly="True" ShowInCustomizationForm="True" ToolTip="Claim Reference Type" VisibleIndex="9">
                                        <EditItemTemplate>
                                            <asp:Label ID="Label193" runat="server" Text='<%# Eval("[Recovery Type]") %>'></asp:Label>
                                        </EditItemTemplate>
                                        <HeaderStyle Wrap="True" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn ExportWidth="100" FieldName="Claim Amount" ReadOnly="True" ShowInCustomizationForm="True" ToolTip="Claim Amount" VisibleIndex="10">
                                        <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="c2">
                                        </PropertiesTextEdit>
                                        <EditItemTemplate>
                                            <asp:Label ID="Label194" runat="server" Text='<%# Eval("[Claim Amount]", "{0:C2}") %>'></asp:Label>
                                        </EditItemTemplate>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn ExportWidth="80" FieldName="Recovery Type" ReadOnly="True" ShowInCustomizationForm="True" ToolTip="Recovery Type" VisibleIndex="11">
                                        <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="c2">
                                        </PropertiesTextEdit>
                                        <EditItemTemplate>
                                            <asp:Label ID="Label195" runat="server" Text='<%# Eval("[Recovery Type]") %>'></asp:Label>
                                        </EditItemTemplate>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn ExportWidth="100" FieldName="Additional Comments" ReadOnly="True" ShowInCustomizationForm="True" ToolTip="Additional Comments" VisibleIndex="12">
                                        <EditItemTemplate>
                                            <asp:Label ID="Label196" runat="server" Text='<%# Eval("[Additional Comments]") %>'></asp:Label>
                                        </EditItemTemplate>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Revenew Invoice" ExportWidth="85" FieldName="Invoice Number" ReadOnly="True" ShowInCustomizationForm="True" ToolTip="Invoice Number" VisibleIndex="16">
                                        <EditItemTemplate>
                                            <asp:Label ID="Label197" runat="server" Text='<%# Eval("[Invoice Number]") %>'></asp:Label>
                                        </EditItemTemplate>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="URL" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="20">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn ExportWidth="65" FieldName="Entity" ShowInCustomizationForm="True" ToolTip="Entity" VisibleIndex="13">
                                        <EditItemTemplate>
                                            <asp:Label ID="Label198" runat="server" Text='<%# Eval("Entity") %>'></asp:Label>
                                        </EditItemTemplate>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataComboBoxColumn Caption="Review_Status  (Client Update)" FieldName="Status" ExportWidth="80" ShowInCustomizationForm="True" ToolTip="Review Status (Client Update)" VisibleIndex="2">
                                        <PropertiesComboBox ValueType="System.Int32">
                                            <Items>
                                                <dx:ListEditItem Text="----------" Value="0" />
                                                <dx:ListEditItem Text="Accept" Value="1" />
                                                <dx:ListEditItem Text="Reject" Value="2" />
                                                <dx:ListEditItem Text="Pending" Value="3" />
                                            </Items>
                                        </PropertiesComboBox>
                                        <Settings AllowHeaderFilter="False" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataComboBoxColumn>
                                    <dx:GridViewDataMemoColumn Caption="Remarks (Client_Update)" FieldName="Remarks" ShowInCustomizationForm="True" ToolTip="Remarks (Client Update)" VisibleIndex="3" Width="100px">
                                    <cellstyle wrap="True"></cellstyle>
                                    </dx:GridViewDataMemoColumn>
                                    <dx:GridViewDataTextColumn FieldName="Claim Status" ShowInCustomizationForm="True" ToolTip="Revenew Status" Caption="Revenew Status" VisibleIndex="14">
                                        <EditItemTemplate>
                                            <asp:Label ID="Label199" runat="server" Text='<%# Eval("[Claim Status]") %>'></asp:Label>
                                        </EditItemTemplate>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="LeadAuditorEmail" ShowInCustomizationForm="True" Visible="False" VisibleIndex="22">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="E-Mail" FixedStyle="Left" ShowInCustomizationForm="True" VisibleIndex="0" Width="50px">
                                        <EditFormSettings Visible="False" />
                                        <EditCellStyle HorizontalAlign="Center">
                                        </EditCellStyle>
                                        <DataItemTemplate>
                                            <a href="javascript:void(0);" onclick='popEmail.PerformCallback(&#039;<%# Eval("[Claim_ID]")%>|<%# Eval("[Status]")%>|<%# Eval("[Remarks]")%>|<%# Eval("[Claim Submit Date]")%>|<%# Eval("[Vendor Name]")%>|<%# Eval("[URL]").ToString().Replace("\", "/")%>&#039;);'>
                                            <img src="images/email.png" tooltip="Email"/>
                                            </a>
                                        </DataItemTemplate>
                                        <EditItemTemplate>
                                            <a href="javascript:void(0);" onclick='popEmail.PerformCallback(&#039;<%# Eval("[Claim_ID]")%>|<%# Eval("[Status]")%>|<%# Eval("[Remarks]")%>|<%# Eval("[Claim Submit Date]")%>|<%# Eval("[Vendor Name]")%>|<%# Eval("[URL]").ToString().Replace("\", "/")%>&#039;);'>
                                            <img src="images/email.png" tooltip="Email"/>
                                            </a>
                                        </EditItemTemplate>
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <%--<dx:GridViewDataTextColumn Caption="Process" FieldName="Dup or Statement" ShowInCustomizationForm="True" VisibleIndex="18">
                                        <EditItemTemplate>
                                            <dx:ASPxLabel ID="ASPxLabel177" runat="server" Text='<%# Eval("[Dup or Statement]")%>'>
                                            </dx:ASPxLabel>
                                        </EditItemTemplate>
                                    </dx:GridViewDataTextColumn>--%>
                                    <dx:GridViewDataTextColumn FieldName="Vendor Number" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="7">
                                        <EditItemTemplate>
                                            <dx:ASPxLabel ID="ASPxLabel178" runat="server" Text='<%# Eval("[Vendor Number]")%>'>
                                            </dx:ASPxLabel>
                                        </EditItemTemplate>
                                    </dx:GridViewDataTextColumn>
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
                                <SettingsPager Mode="ShowAllRecords" PageSize="25">
                                </SettingsPager>
                                <SettingsEditing Mode="Inline">
                                </SettingsEditing>
                                <Settings HorizontalScrollBarMode="Auto" ShowFilterRowMenu="True" ShowFooter="True" ShowHeaderFilterButton="True" ShowStatusBar="Hidden" ShowVerticalScrollBar="True" VerticalScrollableHeight="600" />
                                <SettingsCookies CookiesID="grdclaimPending0912" Enabled="True" StoreControlWidth="True" Version="15" />
                                <Styles>
                                    <Header HorizontalAlign="Center" Wrap="True">
                                    </Header>
                                    <AlternatingRow Enabled="True">
                                    </AlternatingRow>
                                    <Cell Wrap="False">
                                    </Cell>
                                    <Footer Font-Bold="True">
                                    </Footer>
                                </Styles>
                            </dx:ASPxGridView>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
            </TabPages>
            
            <ClientSideEvents TabClick="function(s, e) {
	if(e.tab.index==1)
                grdClaimSubmission.Refresh();
	else if(e.tab.index==2)
                grdClaimSubmissionAccepted.Refresh();
	else if(e.tab.index==3)
                grdClaimSubmissionAll.Refresh();
}" />
            
            <Paddings Padding="0px" />
            <ContentStyle>
                <Paddings Padding="0px" />
            </ContentStyle>
            
        </dx:ASPxPageControl>        
        
        <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
        
        <asp:SqlDataSource ID="SqlDS" runat="server" ConnectionString="<%$ ConnectionStrings:connectionString %>"
            SelectCommand="ORClaimsList_sp" SelectCommandType="StoredProcedure" UpdateCommand="UpdateClaimStatus_sp"
            UpdateCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="hdnDatabase" Name="database" PropertyName="Value" Type="String" />                
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Direction="ReturnValue" Name="RETURN_VALUE" Type="Int32" />
                <asp:Parameter Name="Claim_ID" Type="Int32" />
                <asp:Parameter Name="Status" Type="Int32" />
                <asp:Parameter Name="Remarks" Type="String" />
                <asp:ControlParameter ControlID="hdnDatabase" DefaultValue=" " Name="database" PropertyName="Value" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        
        <asp:HiddenField ID="hdnDatabase" runat="server" />
        <dx:ASPxGridViewExporter ID="exportGrd" runat="server" Landscape="True" PaperKind="A4"
            LeftMargin="1" RightMargin="1">
            <Styles>
                <Header BackColor="#E2E1E1" Font-Bold="True" Font-Names="Arial"
                    Font-Size="10pt" ForeColor="Black" Wrap="True">
                    <Paddings Padding="1px" />
                </Header>
                <Cell Font-Names="Arial" Font-Size="10pt" Wrap="True">
                </Cell>
                <Footer Font-Bold="True" VerticalAlign="Middle" Wrap="True" Font-Names="Arial"
                    Font-Size="10pt">
                </Footer>
                <HyperLink Font-Underline="False" ForeColor="Black">
                </HyperLink>
            </Styles>
            <PageHeader>
                <Font Size="13pt"></Font>
            </PageHeader>
            <PageFooter>
                <Font Bold="True" Size="13pt"></Font>
            </PageFooter>

        </dx:ASPxGridViewExporter>
    </div>
    <dx:ASPxPopupControl ID="popEmail" runat="server" ClientInstanceName="popEmail" 
            Modal="True" PopupHorizontalAlign="WindowCenter" 
            PopupVerticalAlign="WindowCenter" AllowDragging="True" AllowResize="True" 
            HeaderText="E-Mail" RenderMode="Lightweight" Height="50px" 
        Width="500px" PopupAnimationType="Fade">
    <ClientSideEvents EndCallback="function(s, e) {
if(s.cpStatus=='success')
        {
        alert('Mail Sent');
        popEmail.Hide();
        }
else if(s.cpStatus=='failed')
        alert('Attachment not found');
else
	popEmail.Show();
        txtTo.Focus();
}" />
    <ContentCollection>
<dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" SupportsDisabledAttribute="True">
    <div class="fntstyle">To</div><dx:ASPxTextBox ID="txtTo" 
            ClientInstanceName="txtTo" runat="server" Width="100%" 
            NullText="Example: email@xyz.com, email@xyz.com"></dx:ASPxTextBox>
    <div class="fntstyle">Subject</div><dx:ASPxTextBox ID="txtSubject" runat="server" Width="100%"></dx:ASPxTextBox>
    <div class="fntstyle">Body</div><dx:ASPxHtmlEditor ID="txtBody" runat="server" Width="100%"></dx:ASPxHtmlEditor>
    <img src="images/attachment.png"  /><dx:ASPxLabel ID="lblAttachment" runat="server" Text="" ForeColor="#3366FF"></dx:ASPxLabel>
    <div style="float:right;padding-bottom:10px;padding-top:5px">
        <dx:ASPxButton ID="btnSend" runat="server" Text="Send" 
            Width="60px" AutoPostBack="False">
            <ClientSideEvents Click="function(s, e) {
                if(txtTo.GetText()=='')
                {
                txtTo.Focus();
                return;
                }
	popEmail.PerformCallback();
}" />
        </dx:ASPxButton>
        <dx:ASPxHiddenField ID="hdnFile" runat="server"></dx:ASPxHiddenField>
    </div>
        </dx:PopupControlContentControl>
</ContentCollection>
</dx:ASPxPopupControl>
    <script type="text/javascript">
        adjustSize();
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SubContent" runat="server">
</asp:Content>
