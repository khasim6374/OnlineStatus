<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="businessunitanalysis.ascx.vb"
    Inherits="OnlineStatus.businessunitanalysis" %>
<script>
    function ShowbusinessunitanalysisPopup(bunit) {
        var height = Math.max(0, document.documentElement.clientHeight);
        popClaims.SetHeight(height - 15);
        var width = Math.max(0, document.documentElement.clientWidth);
        popClaims.SetWidth(width - 507);
        popClaims.SetHeaderText('Claim Details');
        popClaims.SetContentUrl('ClaimDetails.aspx?bunit=' + bunit + '&height=' + height); popClaims.Show();
    }
</script>
<table  cellpadding="0" cellspacing="0" border="0">
    <tr>
        <td bgcolor="White" width="80%">
            <div class="grdBorder">
                <div class="grdHeader">
                    Business Unit Analysis</div>
                <asp:GridView ID="grdBusinessUnit" runat="server" Width="700px" BackColor="White"
                    BorderStyle="Solid" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="None"
                    ShowFooter="True" Font-Names="Calibri" BorderColor="#E8E8E8" AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="#F2F2F2" />
                    <FooterStyle BackColor="White" Font-Bold="False" Font-Names="Arial" Font-Size="8pt"
                        ForeColor="Black" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="Black" Font-Names="Arial"
                        Font-Size="8pt" HorizontalAlign="Center" CssClass="grdHeaderBg" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                    <Columns>
                        <asp:BoundField DataField="Source" HeaderText="Business Unit" HeaderStyle-HorizontalAlign="Left"
                            SortExpression="Source">
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Claims" HeaderText="Claim Count" SortExpression="Claims"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="ClaimsTotal" HeaderText="% Total" ItemStyle-HorizontalAlign="Right"
                            SortExpression="ClaimsTotal">
                            <ItemStyle HorizontalAlign="Right"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Recoveries" HeaderText="Gross Recoveries" SortExpression="Recoveries"
                            DataFormatString="{0:c0}" ItemStyle-HorizontalAlign="Right">
                            <ItemStyle HorizontalAlign="Right"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="RecoveriesTotal" HeaderText="% Total" ItemStyle-HorizontalAlign="Right"
                            SortExpression="RecoveriesTotal">
                            <ItemStyle HorizontalAlign="Right"></ItemStyle>
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </div>
        </td>
        <td align="center" valign="middle">
            <asp:Chart ID="crtBusinessUnit" runat="server" Height="250px" Width="450px" BackColor="Transparent"
                BorderlineColor="Transparent">
                <Series>
                    <asp:Series Name="Series1" YValueType="Auto" ChartArea="ChartArea1" BorderColor="White"
                        Color="#27610d" LabelForeColor="White" 
                        MarkerBorderColor="224, 224, 224" LabelFormat="C0">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1" BackColor="Transparent" BorderColor="Red" 
                        IsSameFontSizeForAllAxes="True">
                        <AxisY LineColor="White" InterlacedColor="White" 
                            IntervalAutoMode="VariableCount">
                            <MajorGrid LineColor="White" />
                            <MinorGrid LineColor="White" />
                            <MajorTickMark LineColor="Transparent" />
                            <LabelStyle ForeColor="LightGray" Format="C0" />
                        </AxisY>
                        <AxisX IsLabelAutoFit="False" LineColor="White">
                            <MajorGrid LineColor="Transparent" />
                            <MinorGrid LineColor="White" />
                            <MajorTickMark LineColor="Transparent" />
                            <LabelStyle Angle="45" Interval="1" ForeColor="LightGray" />
                        </AxisX>
                    </asp:ChartArea>
                </ChartAreas>
                <Titles>
                    <asp:Title Font="Microsoft Sans Serif, 10pt, style=Bold" ForeColor="White" Name="Title1"
                        Text="Gross Recoveries by Business Unit">
                    </asp:Title>
                </Titles>
            </asp:Chart>
        </td>
    </tr>
</table>
