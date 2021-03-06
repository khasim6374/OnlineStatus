﻿<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="currentitemsunder.ascx.vb"
    Inherits="OnlineStatus.currentitemsunder" %>
<table  cellpadding="0" cellspacing="0" border="0" width="100%">
    <tr>
        <td>
            <div class="grdBorder" style="background-color: white;">
                <%--<div class="grdHeader">
                    Current Items Under Review</div>--%>
                    <span style="font-weight: bold;">Current Items Under Review</span>
                <div style="border: 1px solid beige;">
                    <span style="margin-left:28%;">Payment Analysis</span>
                    <span style="margin-left:23%;">Statement Review</span>
                </div>
                <asp:GridView ID="grdCurrentItems" runat="server" Width="100%" BackColor="White"
                    BorderStyle="Solid" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="None"
                    ShowFooter="True" Font-Names="Calibri" BorderColor="#E8E8E8" AutoGenerateColumns="false">
                    <AlternatingRowStyle BackColor="#F2F2F2" />
                    <FooterStyle BackColor="White" Font-Bold="False" Font-Names="Arial" Font-Size="8pt"
                        ForeColor="Black" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="Black" Font-Names="Arial"
                        Font-Size="8pt" CssClass="grdHeaderBg" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                    <Columns>
                        <asp:BoundField DataField="Status" HeaderText="Status" ItemStyle-HorizontalAlign="Left" FooterStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left" SortExpression="Status" />
                        <asp:BoundField DataField="Issue Count" NullDisplayText="0" HeaderText="Issue Count" ItemStyle-HorizontalAlign="Center" FooterStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" SortExpression="Issue Count" />
                        <asp:BoundField DataField="Opportunity Amount" HeaderText="Opportunity Amount" ItemStyle-HorizontalAlign="Center" FooterStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" SortExpression="Opportunity Amount" DataFormatString="{0:c0}" />
                        <asp:BoundField DataField="Issue Count2" NullDisplayText="0" HeaderText="Issue Count" SortExpression="Issue Count" ItemStyle-HorizontalAlign="Center" FooterStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                        <asp:BoundField DataField="Opportunity Amount2" HeaderText="Opportunity Amount" DataFormatString="{0:c0}" ItemStyle-HorizontalAlign="Center" FooterStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" SortExpression="Opportunity Amount" />
                        <asp:BoundField DataField="Probability" HeaderText="Probability" SortExpression="Probability" DataFormatString="{0:F0}%" ItemStyle-HorizontalAlign="Center" FooterStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                        <asp:BoundField DataField="Projected Amount" HeaderText="Projected Amount" DataFormatString="{0:c0}" ItemStyle-HorizontalAlign="Center" FooterStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" SortExpression="Projected Amount" />
                        <%--<asp:BoundField DataField="Comments" HeaderText="Comments" />--%>
                    </Columns>
                </asp:GridView>
            </div>
        </td>
    </tr>
</table>
