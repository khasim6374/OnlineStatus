<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master"
    CodeBehind="paymentreview.aspx.vb" Inherits="OnlineStatus.paymentreview" %>

<%@ Register Src="forms/businessunitanalysis.ascx" TagName="businessunitanalysis"
    TagPrefix="uc5" %>
<%@ Register Src="forms/currentitemsunder.ascx" TagName="currentitemsunder" TagPrefix="uc4" %>
<%@ Register Src="forms/auditprogress.ascx" TagName="auditprogress" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent1" runat="server">
    <style type="text/css">
        .tblStyle1
        {
            width: 100%;
        }
          .style2
        {
            width: 100%;
            border: #c4c4c4 5px solid;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent1" runat="server">
    <table style="width: 100%;" border="0" cellpadding="0" cellspacing="0" class="style2">
        <tr>
            <td bgcolor="White">
                <uc1:auditprogress ID="auditprogress1" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SubContent" runat="server">
    <table style="width: 100%;" cellspacing="0" cellpadding="0" border="0"  class="LeftMenu">
        <tr>
            <td class="LeftMenu" valign="top" style="width: 201px">
                <table class="tblStyle1" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td>
                            <div class="clsOpenClaim">
                                Open Claim Questions</div>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <ul class="clsOpenClaimOL">
                                <li>Is claim 527 eligible for a refund?</li><li>Revenew checking on additional support
                                    for claim 321</li><li>Has a refund check been issued to client for ABC company?</li><li>
                                        Checking with internal client on credit memos for claim 138</li></ul>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="MainCont">
                <table style="width: 100%;" border="0" cellpadding="0" cellspacing="0" >
                    <tr>
                        <td bgcolor="#404040">
                            <uc5:businessunitanalysis ID="businessunitanalysis1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="White" >
                            <uc4:currentitemsunder ID="currentitemsunder1" runat="server" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
