<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="claimsummary.ascx.vb"
    Inherits="OnlineStatus.claimsummary" %>
<script>
    function ShowClaimSummaryPopup(subDate, creditStatus) {
        var height = Math.max(0, document.documentElement.clientHeight);
        popClaims.SetHeight(height - 15);
        var width = Math.max(0, document.documentElement.clientWidth);
        popClaims.SetWidth(width - 507);
        popClaims.SetHeaderText('Claim Details');
        popClaims.SetContentUrl('ClaimDetails.aspx?sdate=' + subDate + '&cstatus=' + creditStatus + '&height=' + height); popClaims.Show();
    }
</script>
<div class="grdBorder">
    <%--<div class="grdHeader">
        Claim Summary</div>--%>
    <asp:GridView ID="grdClaimSummary" runat="server" Width="100%" BackColor="White"
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="None"
        ShowFooter="True" Font-Names="Calibri" BorderColor="#E8E8E8">
        <AlternatingRowStyle BackColor="#F2F2F2" />
        <FooterStyle BackColor="White" Font-Bold="False" Font-Names="Arial" 
            Font-Size="8pt" ForeColor="Black" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="Black" Font-Names="Arial"
            Font-Size="8pt" HorizontalAlign="Center" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView><%--<div align="right">* Assumes full award of performance guarantee</div>--%>
</div>

