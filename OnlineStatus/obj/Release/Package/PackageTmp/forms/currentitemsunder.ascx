﻿<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="currentitemsunder.ascx.vb"
    Inherits="OnlineStatus.currentitemsunder" %>
<div class="grdBorder">
    <div class="grdHeader">
        Current Items Under Review</div>
    <asp:GridView ID="grdCurrentItems" runat="server" Width="100%" BackColor="White"
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="None"
        ShowFooter="True" Font-Names="Calibri" BorderColor="#E8E8E8" AutoGenerateColumns="false">
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
            <asp:BoundField DataField="Status" HeaderText="Status" HeaderStyle-HorizontalAlign="Left"
                SortExpression="Status" />
            <asp:BoundField DataField="Issue Count" HeaderText="Issue Count" SortExpression="Issue Count"
                ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Opportunity Amount" HeaderText="Opportunity Amount" DataFormatString="{0:c0}"
                ItemStyle-HorizontalAlign="Right" SortExpression="Opportunity Amount" />
            <asp:BoundField DataField="Probability" HeaderText="Probability" SortExpression="Probability"
                DataFormatString="{0:F0}%" ItemStyle-HorizontalAlign="Right" />
            <asp:BoundField DataField="Probablistic Amount" HeaderText="Probablistic Amount"
                DataFormatString="{0:c0}" ItemStyle-HorizontalAlign="Right" SortExpression="Probablistic Amount" />
            <asp:BoundField DataField="Comments" HeaderText="Comments" />
        </Columns>
    </asp:GridView>
</div>
