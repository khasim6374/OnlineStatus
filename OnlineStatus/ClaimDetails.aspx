<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ClaimDetails.aspx.vb" Inherits="OnlineStatus.ClaimDetails" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function getQueryStrings() {
            var assoc = {};
            var decode = function (s) { return decodeURIComponent(s.replace(/\+/g, " ")); };
            var queryString = location.search.substring(1);
            var keyValues = queryString.split('&');

            for (var i in keyValues) {
                var key = keyValues[i].split('=');
                if (key.length > 1) {
                    assoc[decode(key[0])] = decode(key[1]);
                }
            }

            return assoc;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <dx:ASPxGridView runat="server" SettingsCookies-Enabled="true" SettingsCookies-StoreColumnsWidth="true" KeyFieldName="Claim ID" AutoGenerateColumns="False" DataSourceID="SqlDS" Width="99%" ID="grdClaim" ClientInstanceName="grdClaim">
                <Columns>
                    <dx:GridViewDataDateColumn FieldName="Claim Submit Date" VisibleIndex="0" ShowInCustomizationForm="True" Width="70px">
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn FieldName="Vendor Source" VisibleIndex="1" ReadOnly="True" ShowInCustomizationForm="True" Width="55px">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Claim ID" ReadOnly="True" VisibleIndex="2" CellStyle-HorizontalAlign="Left" ShowInCustomizationForm="True" Width="40px">
                        <EditFormSettings Visible="False" />
                        <DataItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("URL").ToString().Replace("\", "/")%>' Target="_blank"
                                Text='<%# Eval("Claim ID") %>'></asp:HyperLink>
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>

                    <dx:GridViewDataTextColumn FieldName="Vendor Name" VisibleIndex="8" ShowInCustomizationForm="True" Width="175px">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Claim Reference Type" VisibleIndex="9" ShowInCustomizationForm="True" Width="60px">
                    </dx:GridViewDataTextColumn>

                    <dx:GridViewDataTextColumn FieldName="Claim Amount" VisibleIndex="12" ShowInCustomizationForm="True" UnboundType="Decimal" Width="80px">
                        <PropertiesTextEdit DisplayFormatInEditMode="True" DisplayFormatString="c2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>

                    <dx:GridViewDataTextColumn FieldName="Recovery Type" VisibleIndex="14" ShowInCustomizationForm="True" Width="150px">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Additional Comments" Width="300px" VisibleIndex="15" ShowInCustomizationForm="True">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Location" Caption="Entity" VisibleIndex="16" ShowInCustomizationForm="True" Width="60px">
                    </dx:GridViewDataTextColumn>

                    <dx:GridViewDataTextColumn FieldName="Claim Status" VisibleIndex="19" ShowInCustomizationForm="True" Width="90px">
                    </dx:GridViewDataTextColumn>

                    <dx:GridViewDataTextColumn FieldName="Invoice Number" Caption="Revenew Invoice" VisibleIndex="24" ShowInCustomizationForm="True" Width="100px">
                    </dx:GridViewDataTextColumn>



                </Columns>

                <SettingsBehavior ColumnResizeMode="Control" />

                <SettingsPager PageSize="30">
                </SettingsPager>

                <Settings HorizontalScrollBarMode="Auto" VerticalScrollBarMode="Auto"></Settings>
                <Styles>
                    <Header Wrap="True">
                    </Header>
                </Styles>
            </dx:ASPxGridView>

            <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:connectionString %>" SelectCommand="GetClaimDetails" SelectCommandType="StoredProcedure" ID="SqlDS"></asp:SqlDataSource>

        </div>
    </form>
</body>
<script>
    function adjustsize() {
        var qs = getQueryStrings();
        ht = qs['height'];
        grdClaim.SetHeight(ht - 80);
    }
    adjustsize();
</script>
</html>
