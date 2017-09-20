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
<table cellpadding="0" cellspacing="0" border="0" width="100%">
    <tr style="height:1px;">
        <td width="80%">
            <div class="grdBorder" style="background-color:White;">
                <%--<div class="grdHeader">
                    Business Unit Analysis</div>--%><span style="font-weight: bold;">Business Unit Analysis</span>
                <asp:GridView ID="grdBusinessUnit" runat="server" Width="100%" BackColor="White"
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
        <td align="center" valign="middle" style="padding-left: 8px;height: inherit;">
            <div class="grdBorder" style="background-color: white;height: 97%;">
                <asp:Chart ID="crtBusinessUnit" runat="server" Height="250px" Width="432px"
                    BorderlineColor="Transparent">
                    <Series>
                        <asp:Series Name="Series1" YValueType="Auto" ChartArea="ChartArea1" BorderColor="White"
                            Color="48, 165, 146" LabelForeColor="Black" 
                            MarkerBorderColor="224, 224, 224" LabelFormat="C0">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1" BorderColor="Red" 
                            IsSameFontSizeForAllAxes="True">
                            <AxisY LineColor="White" InterlacedColor="White" 
                                IntervalAutoMode="VariableCount">
                                <MajorGrid LineColor="#b4b7ba" />
                                <MinorGrid LineColor="#b4b7ba" />
                                <MajorTickMark LineColor="Transparent" />
                                <LabelStyle ForeColor="Black" Format="C0" />
                            </AxisY>
                            <AxisX IsLabelAutoFit="False" LineColor="#b4b7ba">
                                <MajorGrid LineColor="Transparent" />
                                <MinorGrid LineColor="White" />
                                <MajorTickMark LineColor="Transparent" />
                                <LabelStyle Angle="45" Interval="1" ForeColor="Black" />
                            </AxisX>
                        </asp:ChartArea>
                    </ChartAreas>
                    <Titles>
                        <asp:Title Font="Microsoft Sans Serif, 10pt, style=Bold" ForeColor="Black" Name="Title1"
                            Text="Gross Recoveries by Business Unit">
                        </asp:Title>
                    </Titles>
                </asp:Chart>
            </div>
        </td>
    </tr>
</table>
