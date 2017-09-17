<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="projectresults.ascx.vb" Inherits="OnlineStatus.projectresults" %>
<script>
    function ShowClaimSummaryPopup2() {
        var height = Math.max(0, document.documentElement.clientHeight);
        popClaims.SetHeight(height - 15);
        var width = Math.max(0, document.documentElement.clientWidth);
        popClaims.SetWidth(width - 507);
        popClaims.SetHeaderText('Claim Summary');
        popClaims.SetContentUrl('ClaimSummary.aspx?height='+height);
        popClaims.Show();
    }
</script>
<table  cellpadding="0" cellspacing="0" border="0">
    <tr>
        <td bgcolor="White" width="33%" align="center">
            <p>Claim Summary</p>
            <asp:Label runat="server" ID="GrossTotal" Text=""></asp:Label><br />
            <%--<asp:LinkButton runat="server" ID="ClaimCount" Text=""></asp:LinkButton>--%>
            <asp:HyperLink runat="server" ID="ClaimCount" Text=""></asp:HyperLink>
            <p>Net Value (less fees)</p>
            <asp:Label runat="server" ID="NetTotal" Text=""></asp:Label>
        </td>
        <td width="33%" align="center" bgcolor="#404040">
            <asp:Chart ID="crtRecoveryStatus" runat="server" Height="261px" Width="450px" BackColor="Transparent"
                BorderlineColor="Transparent" Palette="None" 
                PaletteCustomColors="255, 128, 128; ForestGreen; Blue; Yellow; Maroon; Olive; 192, 0, 192; Aqua; Gray; 128, 64, 0; 255, 192, 128; 192, 192, 255">
                <Series>
                    <asp:Series ChartType="Pie" Name="Series2" ChartArea="ChartArea2" BorderColor="White"
                        IsValueShownAsLabel="True" LabelFormat="C0" Legend="Legend1" CustomProperties="CollectedSliceExploded=True" LabelBackColor="Transparent" LabelForeColor="White">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea2" BackColor="Transparent">
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
                    <asp:Title Font="Microsoft Sans Serif, 10pt, style=Bold" ForeColor="White" Name="Recovery Status"
                        Text="Recovery Status">
                    </asp:Title>
                </Titles>
            </asp:Chart>
        </td>
        <td align="center" valign="middle" width="33%" bgcolor="#404040">
            <asp:Chart ID="crtProjectResults" runat="server" Height="250px" Width="450px" BackColor="Transparent"
                BorderlineColor="Transparent">
                <Series>
                    <asp:Series Name="Series3" YValueType="Auto" ChartArea="ChartArea3" BorderColor="White"
                        Color="#27610d" LabelForeColor="White" 
                        MarkerBorderColor="224, 224, 224" LabelFormat="C0">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea3" BackColor="Transparent" BorderColor="Red" 
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
                        Text="Benchmarking">
                    </asp:Title>
                </Titles>
            </asp:Chart>
        </td>
    </tr>
</table>
