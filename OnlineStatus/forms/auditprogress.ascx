<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="auditprogress.ascx.vb"
    Inherits="OnlineStatus.auditprogress" %>
<style type="text/css">
    .chartStyle
    {
        width: 100px;
        height: 500px;
    }
</style>
<div class="grdBorder">
    <%--<div class="grdHeader" >
        Audit Progress: Statement Solicitation
    </div>--%>
    <span style="font-weight: bold;">Statement Collection</span>
    <table cellpadding="0" cellspacing="0" border="0" width="100%" style="color: black;
        font-weight: bold; font-size: 12px; border-style: solid; border-color: #e5e2e2;
        border-width: 0px">
        <tr style="color:white">
            <td align="center">
                <asp:Label ID="Label1" ForeColor="Black" runat="server" Text="Vendor Count"></asp:Label>
            </td>
            <td align="center">
                <asp:Label ID="Label2" ForeColor="Black" runat="server" Text="Total Spend"></asp:Label>
            </td>
            <td align="center">
                <asp:Label ID="Label3" ForeColor="Black" runat="server" Text="Total Transaction Count"></asp:Label>
            </td>
        </tr>
        <tr >
            <td align="center">
                <asp:Chart ID="crtVendorCount" runat="server" CssClass="chartStyle"
                    Height="150px" Width="275px" Palette="None"
                    PaletteCustomColors="48, 165, 146; 241, 176, 38" BackColor="Transparent">
                    <Series>
                        <asp:Series ChartType="Pie" Name="Series1" IsValueShownAsLabel="True"
                            Legend="Legend1" LabelFormat="N0" BorderColor="White" LabelForeColor="Black">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1" BackColor="Transparent">
                        </asp:ChartArea>
                    </ChartAreas>
                    <Legends>
                        <asp:Legend Docking="Bottom" Name="Legend1" ForeColor="Black" Alignment="Center">
                        </asp:Legend>
                    </Legends>
                </asp:Chart>
            </td>
            <td align="center">
                <asp:Chart ID="crtTotalSpend" runat="server" CssClass="chartStyle"
                    Height="150px" Width="275px" Palette="None"
                    PaletteCustomColors="48, 165, 146; 241, 176, 38" BackColor="Transparent">
                    <Series>
                        <asp:Series ChartType="Pie" Name="Series1" IsValueShownAsLabel="True"
                            Legend="Legend1" LabelFormat="C0" BorderColor="White" LabelForeColor="Black">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1" BackColor="Transparent">
                        </asp:ChartArea>
                    </ChartAreas>
                    <Legends>
                        <asp:Legend Docking="Bottom" Name="Legend1" ForeColor="Black" Alignment="Center">
                        </asp:Legend>
                    </Legends>
                </asp:Chart>
            </td>
            <td align="center">
                <asp:Chart ID="crtTotalTransaction" runat="server" CssClass="chartStyle"
                    Height="150px" Width="275px" Palette="None"
                    PaletteCustomColors="48, 165, 146; 241, 176, 38" BackColor="Transparent">
                    <Series>
                        <asp:Series ChartType="Pie" Name="Series1" IsValueShownAsLabel="True"
                            Legend="Legend1" LabelFormat="N0" BorderColor="White" LabelForeColor="Black">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1" BackColor="Transparent">
                        </asp:ChartArea>
                    </ChartAreas>
                    <Legends>
                        <asp:Legend Docking="Bottom" Name="Legend1" ForeColor="Black" Alignment="Center">
                        </asp:Legend>
                    </Legends>
                </asp:Chart>
            </td>
        </tr>
        <tr  >
            <td align="char">
                <table cellpadding="0" cellspacing="0" width="80%" align="center">
                    <tr>
                        <td>Scope</td>
                        <td align="right">
                            <asp:Label ID="lblScope1" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Received</td>
                        <td align="right">
                            <asp:Label ID="lblReceived1" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Compliance %</td>
                        <td align="right">
                            <asp:Label ID="lblCompliance1" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <table cellpadding="0" cellspacing="0" width="80%" align="center">
                    <tr>
                        <td>Scope ($MM)</td>
                        <td align="right">
                            <asp:Label ID="lblScope2" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Received</td>
                        <td align="right">
                            <asp:Label ID="lblReceived2" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Compliance %</td>
                        <td align="right">
                            <asp:Label ID="lblCompliance2" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <table cellpadding="0" cellspacing="0" width="80%" align="center">
                    <tr>
                        <td>Scope (000's)</td>
                        <td align="right">
                            <asp:Label ID="lblScope3" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Received</td>
                        <td align="right">
                            <asp:Label ID="lblReceived3" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Compliance %</td>
                        <td align="right">
                            <asp:Label ID="lblCompliance3" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

</div>
