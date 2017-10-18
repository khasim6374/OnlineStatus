<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ClaimSummary.aspx.vb" Inherits="OnlineStatus.ClaimSummary1" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function getQueryStrings() {
            var assoc = {};
            var decode = function (s) { return decodeURIComponent(s.replace(/\+/g, " ")); };
            var queryString = location.search.substring(1);
            var keyValues = queryString.split('&');

            for (var i in keyValues) {
                var key = keyValues[i].split('=');
                if (key.length > 1) {
                    assoc[decode(key[0])] = decode(key[1]);
                }
            }

            return assoc;
        }
        function ShowClaimSummaryPopup(subDate, creditStatus) {
            var parentWindow = window.parent;
            var height = Math.max(0, document.documentElement.clientHeight);
            parentWindow.popClaims.SetHeight(height);
            var width = Math.max(0, document.documentElement.clientWidth);
            parentWindow.popClaims.SetWidth(width);
            //parentWindow.popClaims.SetContentUrl('ClaimDetails.aspx?sdate=' + subDate + '&cstatus=' + creditStatus + '&height=' + height);
            console.log(parentWindow);
            //popClaims.Hide();
            parentWindow.popClaims.SetHeaderText('Claim Details');
            parentWindow.popClaims.SetContentUrl('ClaimDetails.aspx?sdate=' + subDate + '&cstatus=' + creditStatus + '&height=' + height); popClaims.Show();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="grdClaimSummary" runat="server" Width="100%" BackColor="White"
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="None"
        ShowFooter="True" Font-Names="Calibri" BorderColor="#9F9F9F">
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
    </asp:GridView>
    </div>
    </form>
</body>
<script type="text/javascript">
    function adjustsize() {
        var qs = getQueryStrings();
        ht = qs['height'];
        grdClaim.SetHeight(ht - 80);
    }
    adjustsize();
</script>
</html>
