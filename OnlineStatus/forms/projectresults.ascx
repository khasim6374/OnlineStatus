<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="projectresults.ascx.vb" Inherits="OnlineStatus.projectresults" %>
<script type="text/javascript">
    function ShowClaimSummaryPopup2() {
        var height = Math.max(0, document.documentElement.clientHeight);
        popClaims.SetHeight(height - 15);
        var width = Math.max(0, document.documentElement.clientWidth);
        popClaims.SetWidth(width - 250);
        popClaims.SetHeaderText('Claim Summary');
        popClaims.SetContentUrl('ClaimSummary.aspx?height='+height);
        popClaims.Show();
    }
    function closepopup() {
        popClaims.Hide();
    }
</script>
<table width="100%" cellpadding="0" cellspacing="0" border="0">
    <tr>
        <td width="33%" align="center">
            <div class="grdBorder" style="height:246px;background-color:White;border:#808080 1px solid;padding-left:8px;">
                <p style="font-weight: bold;margin-top: 0px;font-size: small;">Claim Summary</p>
                <div style="font-weight:bold;font-size:large;margin-top: 45px;">
                    <asp:Label runat="server" ID="GrossTotal" Text=""></asp:Label>
                </div><br />
                <%--<asp:LinkButton runat="server" ID="ClaimCount" Text=""></asp:LinkButton>--%>
                <div style="font-weight:bold;font-size:small;">
                    <asp:HyperLink runat="server" ID="ClaimCount" Text=""></asp:HyperLink>
                    <p>Net Value (less fees)</p>
                    <asp:Label runat="server" ID="NetTotal" Text=""></asp:Label>
                </div>
            </div>
        </td>
        <td width="33%" align="center">
            <div class="grdBorder" style="border:none;">
                <asp:Chart ID="crtRecoveryStatus" runat="server" Height="263px" Width="450px"
                    BorderlineColor="#808080" BorderlineDashStyle="Solid" Palette="None" 
                    PaletteCustomColors="48, 165, 146; 241, 176, 38; 252, 217, 69">
                    <Series>
                        <asp:Series ChartType="Pie" Name="Series2" ChartArea="ChartArea2" BorderColor="White"
                            IsValueShownAsLabel="True" LabelFormat="C0" Legend="Legend1" CustomProperties="CollectedSliceExploded=True" LabelForeColor="Black">
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
                        <asp:Legend  ForeColor="Black" Name="Legend1" ShadowColor="White">
                        </asp:Legend>
                    </Legends>
                    <Titles>
                        <asp:Title Font="Microsoft Sans Serif, 10pt, style=Bold" ForeColor="Black" Name="Recovery Status"
                            Text="Recovery Status">
                        </asp:Title>
                    </Titles>
                </asp:Chart>
            </div>
        </td>
        <td align="center" valign="middle" width="33%">
            <div class="grdBorder" style="border:none;margin-left: -8px;margin-right: -8px;">
                <asp:Chart ID="crtProjectResults" runat="server" Height="263px" Width="450px"
                    BorderlineColor="#808080" BorderlineDashStyle="Solid">
                    <Series>
                        <asp:Series Name="Series3" YValueType="Auto" ChartArea="ChartArea3" BorderColor="White"
                            Color="48, 165, 146" LabelForeColor="Black" Palette="None"
                            MarkerBorderColor="224, 224, 224" LabelFormat="C0">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea3" BorderColor="Red" 
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
                            Text="Benchmarking">
                        </asp:Title>
                    </Titles>
                </asp:Chart>
            </div>
        </td>
    </tr>
</table>
