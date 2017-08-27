<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Statements.aspx.vb" Inherits="OnlineStatus.Statements" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent1" runat="server">
    <script language="javascript" type="text/javascript">
        function adjustSize() {
            var height = Math.max(0, document.documentElement.clientHeight);
            grdNotResponded.SetHeight(height - 215);
            grdResponded.SetHeight(height - 215);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent1" runat="server">
     <div class="pageHeader">Statements</div>
    <div style="float: right; padding-right: 20px; position:absolute; right:0px">           
                        <dx:ASPxButton ID="btnXls" BackColor="Transparent"  Border-BorderWidth="0" BackgroundImage-ImageUrl="~/images/trans.gif" CssClass="NoStyle" runat="server" Cursor="pointer"
                            EnableDefaultAppearance="False" EnableTheming="False" ToolTip="Export to Excel">
                            <Image Url="~/images/excel.png">
                            </Image>
                        </dx:ASPxButton>                    
        </div>
    <div style="background-color: white">
    <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%">
        <TabPages>
            <dx:TabPage Text="Responded">
                <ContentCollection>
                    <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                        <dx:ASPxGridView ID="grdResponded" runat="server" Width="100%" AutoGenerateColumns="False" DataSourceID="SqlDS" ClientInstanceName="grdResponded">
                            <Columns>
                                <dx:GridViewDataTextColumn FieldName="Column1" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="1" Visible="False">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Vendor Number" ShowInCustomizationForm="True" VisibleIndex="2" Width="120px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Vendor Name" ShowInCustomizationForm="True" VisibleIndex="3">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Invoice Count" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="4" Width="100px">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <CellStyle HorizontalAlign="Center">
                                    </CellStyle>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Gross Invoice Amount" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="5" Width="160px">
                                    <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="C2">
                                    </PropertiesTextEdit>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </dx:GridViewDataTextColumn>
                            </Columns>
                            <Settings ShowVerticalScrollBar="True" VerticalScrollableHeight="600" />
                            <SettingsPager PageSize="25">
                            </SettingsPager>
                        </dx:ASPxGridView>
                        
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Not Responded">
                <ContentCollection>
                    <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                        <dx:ASPxGridView ID="grdNotResponded" runat="server" Width="100%" AutoGenerateColumns="False" DataSourceID="SqlDS" ClientInstanceName="grdNotResponded">
                           <Columns>
                                <dx:GridViewDataTextColumn FieldName="Column1" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="1" Visible="False">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Vendor Number" ShowInCustomizationForm="True" VisibleIndex="2" Width="120px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Vendor Name" ShowInCustomizationForm="True" VisibleIndex="3">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Invoice Count" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="4" Width="100px">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <CellStyle HorizontalAlign="Center">
                                    </CellStyle>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Gross Invoice Amount" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="5" Width="160px">
                                    <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="C2">
                                    </PropertiesTextEdit>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </dx:GridViewDataTextColumn>
                            </Columns>
                            <Settings ShowVerticalScrollBar="True" VerticalScrollableHeight="600" />
                            <SettingsPager PageSize="25">
                            </SettingsPager>
                        </dx:ASPxGridView>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
        </TabPages>
         <Paddings Padding="0px" />
            <ContentStyle>
                <Paddings Padding="0px" />
            </ContentStyle>
    </dx:ASPxPageControl>
        <asp:SqlDataSource ID="SqlDS" runat="server" ConnectionString="<%$ ConnectionStrings:connectionString %>" SelectCommand="ORsatetmentSummary_sp" SelectCommandType="StoredProcedure">
                           
                        </asp:SqlDataSource>
        </div>
    <script type="text/javascript">
        adjustSize();
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SubContent" runat="server">
</asp:Content>
