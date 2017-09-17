<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="rootcauseanalysis.ascx.vb"
    Inherits="OnlineStatus.rootcauseanalysis" %>
<style>
    .GroupCategory {
        vertical-align: middle;
    }
    .SubTotal {
        background-color: white
    }
    .SubTotalwithoutborder{
        border-bottom: black 1px solid;
    }
</style>
<script>
    function ShowrootcauseanalysisPopup(category, rcause) {
        var height = Math.max(0, document.documentElement.clientHeight);
        popClaims.SetHeight(height - 15);
        var width = Math.max(0, document.documentElement.clientWidth);
        popClaims.SetWidth(width - 507);
        popClaims.SetHeaderText('Claim Details');
        popClaims.SetContentUrl('ClaimDetails.aspx?category=' + category + '&rcause=' + rcause + '&height=' + height); popClaims.Show();
    }
</script>
<table border="0" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td bgcolor="White"  width="80%">
            <div class="grdBorder">
                <%--<div class="grdHeader">
                    Root Cause Analysis</div>--%>
                <asp:GridView ID="grdRootCause" runat="server" Width="100%" BackColor="White" BorderStyle="Solid"
                    BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="None" ShowFooter="false"
                    Font-Names="Calibri" BorderColor="#E8E8E8">
                    <FooterStyle BackColor="White" Font-Bold="False" Font-Names="Arial" Font-Size="8pt"
                        ForeColor="Black" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="Black" Font-Names="Arial"
                        Font-Size="8pt" HorizontalAlign="Center" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>
            </div>
        </td>
        <td align="center" valign="middle" bgcolor="#404040">
            <asp:Chart ID="crtRootCause" runat="server" Height="261px" Width="450px" BackColor="Transparent"
                BorderlineColor="Transparent" Palette="None" 
                PaletteCustomColors="255, 128, 128; ForestGreen; Blue; Yellow; Maroon; Olive; 192, 0, 192; Aqua; Gray; 128, 64, 0; 255, 192, 128; 192, 192, 255">
                <Series>
                    <asp:Series ChartType="Pie" Name="Series1" ChartArea="ChartArea1" BorderColor="White"
                        IsValueShownAsLabel="True" LabelFormat="{0:}%" Legend="Legend1" CustomProperties="CollectedSliceExploded=True" LabelBackColor="Transparent" LabelForeColor="White">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1" BackColor="Transparent">
                        <AxisY>
                            <LabelStyle ForeColor="LightGray" />
                        </AxisY>
                        <AxisX>
                            <LabelStyle ForeColor="LightGray" />
                        </AxisX>
                        <AxisX2>
                            <LabelStyle ForeColor="LightGray" />
                        </AxisX2>
                        <AxisY2>
                            <LabelStyle ForeColor="LightGray" />
                        </AxisY2>
                    </asp:ChartArea>
                </ChartAreas>
                <Legends>
                    <asp:Legend BackColor="Transparent" ForeColor="White" Name="Legend1" ShadowColor="White">
                    </asp:Legend>
                </Legends>
                <Titles>
                    <asp:Title Font="Microsoft Sans Serif, 10pt, style=Bold" ForeColor="White" Name="Gross Recoveries by Root Cause"
                        Text="Gross Recoveries by Root Cause">
                    </asp:Title>
                </Titles>
            </asp:Chart>
        </td>
    </tr>
</table>
