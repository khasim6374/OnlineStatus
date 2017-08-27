<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="documentlibrary.aspx.vb" Inherits="OnlineStatus.documentlibrary" %>
<%@ Register assembly="DevExpress.Web.v15.1" namespace="DevExpress.Web" tagprefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent1" runat="server">
     <script language="javascript" type="text/javascript">
         function adjustSize() {
             var height = Math.max(0, document.documentElement.clientHeight);
             grid.SetHeight(height - 195);
         }
         function uploaddoc() {
             if (uploader.GetText() == '') {
                 grid.UpdateEdit();
             } else {
                 uploader.UploadFile();
             }
            
         }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent1" runat="server">
      <div class="pageHeader">
            Document Library
        </div>  <div style="background-color: white">

        <div style="float: right; padding-right: 20px">
            <a href="javascript:void(0);" onclick="grid.AddNewRow();" title="Add New">
                <img src="images/add_new.png" alt="" /></a>
        </div>

    <dx:ASPxGridView ID="grdDocumentLib" runat="server" 
        AutoGenerateColumns="False" DataSourceID="SqlDocumentLib" ClientIDMode="Static" 
        ClientInstanceName="grid" Width="100%" KeyFieldName="ID">
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
        <Columns>
            <dx:GridViewCommandColumn ButtonType="Image" VisibleIndex="4" Width="70px" 
                    Caption="Edit">
                    <EditButton Visible="True">
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
                    </UpdateButton>
                </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="ID" VisibleIndex="0" ReadOnly="True" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="DocType" VisibleIndex="1">
                <PropertiesTextEdit>
                    <ValidationSettings Display="Dynamic" SetFocusOnError="True">
                        <RequiredField ErrorText="Required" IsRequired="True" />
                    </ValidationSettings>
                </PropertiesTextEdit>
                <HeaderStyle HorizontalAlign="Left" />
                <CellStyle HorizontalAlign="Left">
                </CellStyle>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataHyperLinkColumn FieldName="URL" VisibleIndex="2">
                 <PropertiesHyperLinkEdit NavigateUrlFormatString="showfile.aspx?file={0}" Target="_blank">
		                </PropertiesHyperLinkEdit>
		                <DataItemTemplate>
		                   <a href='showfile.aspx?file=<%# GetUrl(Eval("URL"))%>' target='_blank'><%# GetFileName(Eval("URL"))%></a>
		                </DataItemTemplate>
		                <EditItemTemplate>
		                    <dx:ASPxUploadControl ID="uploader" runat="server" ClientInstanceName="uploader" Width="100%" NullText='<%# Eval("URL") %>' OnFileUploadComplete="uploader_FileUploadComplete">
		                        <ClientSideEvents FilesUploadComplete="function(s, e) {
			if (e.isValid) { grid.UpdateEdit(); }
		}" FileUploadComplete="function(s, e) {
			if (e.isValid) { grid.UpdateEdit(); }
}" />
                    </dx:ASPxUploadControl>
                </EditItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <CellStyle HorizontalAlign="Left">
                </CellStyle>
            </dx:GridViewDataHyperLinkColumn>
            <dx:GridViewDataDateColumn FieldName="crtd_dttm" 
                VisibleIndex="3" Visible="False">
            </dx:GridViewDataDateColumn>
        </Columns>
       <SettingsBehavior ColumnResizeMode="Control" />
            <SettingsPager Mode="ShowAllRecords">
          </SettingsPager>
            <SettingsEditing Mode="EditForm" />
            <Settings ShowFilterBar="Auto" ShowFilterRowMenu="True" ShowHeaderFilterButton="True"
                ShowVerticalScrollBar="True" VerticalScrollableHeight="600" 
                VerticalScrollBarStyle="Virtual" />
            <SettingsCookies CookiesID="grdAction3" />
            <Styles>
                <Header Wrap="True" HorizontalAlign="Center">
                    <BackgroundImage ImageUrl="~/images/bgBig.png" Repeat="RepeatX" />
                </Header>
                <AlternatingRow Enabled="True">
                </AlternatingRow>
                <Cell Wrap="True" HorizontalAlign="Center">
                </Cell>
            </Styles>
          <Templates>
              <EditForm>
                  <dx:ASPxGridViewTemplateReplacement runat="server" ReplacementType="EditFormEditors"/>
                  <table align="right">
                                                                                    <tr>
                                                                                        <td>
                                                                                            <a href="javascript:void(0)" onclick="uploaddoc();"><img src="images/updatesmall.png" alt="Update"/></a>
                                                                                        </td>
                                                                                        <td>
                                                                                            <a href="javascript:void(0)" onclick="grid.CancelEdit();"><img src="images/cancelsmall.png" alt="Cancel"/></a>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
              </EditForm>
          </Templates>
        </dx:ASPxGridView>
             </div>
    <asp:SqlDataSource ID="SqlDocumentLib" runat="server" ConnectionString="<%$ ConnectionStrings:connectionString %>" 
        SelectCommand="ORSelectDocumentLibrary" SelectCommandType="StoredProcedure" 
        InsertCommand="ORInsertDocumentLibrary" InsertCommandType="StoredProcedure" 
        UpdateCommand="ORUpdateDocumentLibrary" UpdateCommandType="StoredProcedure">
        <InsertParameters>
            <asp:Parameter Name="DocType" Type="String" />
            <asp:Parameter Name="URL" Type="String" />
            <asp:Parameter Name="crtd_dttm" Type="DateTime" />
            <asp:Parameter Name="database" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="DocType" Type="String" />
            <asp:Parameter Name="URL" Type="String" />
            <asp:Parameter Name="crtd_dttm" Type="DateTime" />
            <asp:Parameter Name="database" Type="String" />
            <asp:Parameter Name="ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SubContent" runat="server">
</asp:Content>
