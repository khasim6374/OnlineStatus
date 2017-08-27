<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master"
    CodeBehind="ActionItem.aspx.vb" Inherits="OnlineStatus.ActionItem" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent1" runat="server">
    <script type="text/javascript">
        function adjustSize() {
            var height = Math.max(0, document.documentElement.clientHeight);
            grdActionItems.SetHeight(height - 210);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent1" runat="server">
    <div class="pageHeader">
        Action Items/Admin
    </div>
    <div style="background-color: white">

        <div style="float: right; padding-right: 20px">
            <a href="javascript:void(0);" onclick="grdActionItems.AddNewRow();" title="Add New">
                <img src="images/add_new.png" alt="" /></a>
        </div>
        <dx:aspxgridview id="grdActionItems" runat="server" autogeneratecolumns="False" datasourceid="sqlActionItem"
            keyfieldname="ID" clientidmode="Static" clientinstancename="grdActionItems" width="100%">
            <ClientSideEvents Init="function(s, e) {
                       adjustSize();
	
}" ColumnMoving="function(s, e) {
	adjustSize();
}" ColumnResized="function(s, e) {
	adjustSize();
}" ColumnSorting="function(s, e) {
	adjustSize();
}" EndCallback="function(s, e) {
	adjustSize();
}" />
            <Columns>
                <dx:GridViewCommandColumn ButtonType="Image" VisibleIndex="6" Width="70px" 
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
                <dx:GridViewDataTextColumn FieldName="ID" ReadOnly="True" Visible="False" VisibleIndex="5">
                    <EditFormSettings Visible="False" />
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Priority" VisibleIndex="0" Width="100px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataMemoColumn FieldName="ActionItem" VisibleIndex="1">
                    <EditFormSettings ColumnSpan="2" />
                    <CellStyle HorizontalAlign="Left">
                    </CellStyle>
                </dx:GridViewDataMemoColumn>
                <dx:GridViewDataTextColumn FieldName="Responsible" VisibleIndex="2" Width="150px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataDateColumn FieldName="Target" VisibleIndex="3" Width="100px">
                    <PropertiesDateEdit DisplayFormatInEditMode="True" DisplayFormatString="MM-dd">
                    </PropertiesDateEdit>
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataComboBoxColumn FieldName="Status" VisibleIndex="4" 
                    Width="100px">
                    <PropertiesComboBox ValueType="System.String">
                        <Items>
                            <dx:ListEditItem Selected="True" Text="Open" Value="Open" />
                            <dx:ListEditItem Text="Complete" Value="Complete" />
                        </Items>
                    </PropertiesComboBox>
                </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataTextColumn FieldName="database" Visible="False" 
                    VisibleIndex="7">
                </dx:GridViewDataTextColumn>
            </Columns>
            <SettingsBehavior ColumnResizeMode="Control" />
            <SettingsEditing Mode="Inline" />
            <Settings ShowFilterBar="Auto" ShowFilterRowMenu="True" ShowHeaderFilterButton="True"
                ShowVerticalScrollBar="True" VerticalScrollableHeight="600" 
                VerticalScrollBarStyle="Virtual" />
            <SettingsCookies Enabled="True" CookiesID="grdAction2" />
            <Styles>
                <Header Wrap="True" HorizontalAlign="Center">
                    <BackgroundImage ImageUrl="~/images/bgBig.png" Repeat="RepeatX" />
                </Header>
                <AlternatingRow Enabled="True">
                </AlternatingRow>
                <Cell Wrap="True" HorizontalAlign="Center">
                </Cell>
            </Styles>
          </dx:aspxgridview>
    </div>
    <asp:SqlDataSource ID="sqlActionItem" runat="server" ConnectionString="<%$ ConnectionStrings:connectionString %>"
        SelectCommand="ORSelectActionItems" DeleteCommand="DELETE FROM [ActionItems] WHERE [ID] = @ID"
        InsertCommand="ORInsertActionItems" InsertCommandType="StoredProcedure" SelectCommandType="StoredProcedure"
        UpdateCommand="ORUpdateActionItems" UpdateCommandType="StoredProcedure">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="database" Type="String" />
            <asp:Parameter Name="Priority" Type="String" />
            <asp:Parameter Name="ActionItem" Type="String" />
            <asp:Parameter Name="Responsible" Type="String" />
            <asp:Parameter DbType="Datetime" Name="Target" />
            <asp:Parameter Name="Status" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="database" Type="String" />
            <asp:Parameter Name="ID" Type="Int32" />
            <asp:Parameter Name="Priority" Type="String" />
            <asp:Parameter Name="ActionItem" Type="String" />
            <asp:Parameter Name="Responsible" Type="String" />
            <asp:Parameter DbType="Datetime" Name="Target" />
            <asp:Parameter Name="Status" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SubContent" runat="server">
</asp:Content>
