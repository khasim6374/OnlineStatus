<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="rootcauseanalysisbyprocess.ascx.vb"
    Inherits="OnlineStatus.rootcauseanalysisbyprocess" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<script>
    function ShowrootcauseanalysisByprocessPopup(category, rcause) {
        var height = Math.max(0, document.documentElement.clientHeight);
        popClaims.SetHeight(height - 15);
        var width = Math.max(0, document.documentElement.clientWidth);
        popClaims.SetWidth(width - 507);
        popClaims.SetHeaderText('Claim Details');
        popClaims.SetContentUrl('ClaimDetails.aspx?process=' + category + '&height=' + height); popClaims.Show();

    }
</script>
<table border="0" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td bgcolor="White" width="80%">
            <div class="grdBorder">
                <%--<div class="grdHeader">
                    Process Analysis</div>--%>
                <asp:GridView ID="grdRootCause" runat="server" Width="100%" BackColor="White" BorderStyle="Solid"
                    BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="None" ShowFooter="True"
                    Font-Names="Calibri" BorderColor="#E8E8E8">
                    <AlternatingRowStyle BackColor="#F2F2F2" />
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
            <asp:Chart ID="crtRootCause" runat="server" Height="140px" Width="450px" BackColor="Transparent"
                BorderlineColor="Transparent" Palette="None" 
                
                
                PaletteCustomColors="255, 128, 128; ForestGreen; Blue; Yellow; Maroon; Olive; 192, 0, 192; Aqua; Gray; 128, 64, 0; 255, 192, 128; 192, 192, 255">
                <Series>
                    <asp:Series ChartType="Doughnut" Name="Series1" ChartArea="ChartArea1" BorderColor="White"
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
                    <asp:Title Font="Microsoft Sans Serif, 10pt, style=Bold" ForeColor="White" Name="Process Analysis"
                        Text="Process Analysis">
                    </asp:Title>
                </Titles>
            </asp:Chart>
        </td>
    </tr>
</table>
