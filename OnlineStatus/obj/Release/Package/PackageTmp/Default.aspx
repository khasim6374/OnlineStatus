<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="OnlineStatus._Default" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Src="forms/claimsummary.ascx" TagName="claimsummary" TagPrefix="uc1" %>
<%@ Register Src="forms/rootcauseanalysis.ascx" TagName="rootcauseanalysis" TagPrefix="uc2" %>
<%@ Register Src="forms/businessunitanalysis.ascx" TagName="businessunitanalysis"
    TagPrefix="uc3" %>
<%@ Register Src="forms/auditprogress.ascx" TagName="auditprogress" TagPrefix="uc5" %>
<%@ Register TagPrefix="uc4" TagName="currentitemsunder" Src="~/forms/currentitemsunder.ascx" %>
<%@ Register Src="~/forms/rootcauseanalysisbyprocess.ascx" TagPrefix="uc1" TagName="rootcauseanalysisbyprocess" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent1">    
    <style type="text/css">
        .mainview{
            margin-left:auto;
            margin-right:auto;
            max-width:1000px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent1">
    <div class="pageHeader">
        Supplier Payment Review Status Report
    </div>
    <div class="mainview">
    <table cellpadding="0" cellspacing="0" border="1">
        <tr><td style="background-color:white"><div style="float: right;margin-right:15px ">            
            <dx:ASPxButton ID="btnPdf" runat="server" Cursor="pointer" BackColor="Transparent" Border-BorderWidth="0" BackgroundImage-ImageUrl="~/images/trans.gif" CssClass="NoStyle" EnableTheming="False" ToolTip="Export to Pdf">                
<Image Url="~/images/pdf.png"></Image><Paddings Padding="0px" /> </dx:ASPxButton>
        </div></td></tr>
        <tr>
            <td align="left" style="background-color: white">
                <uc1:claimsummary ID="claimsummary1" runat="server" />
            </td>
        </tr>
        <tr>
            <td bgcolor="White">
                <uc2:rootcauseanalysis ID="rootcauseanalysis1" runat="server" />
            </td>
        </tr>
        <tr>
            <td bgcolor="White"> 
                <uc1:rootcauseanalysisbyprocess runat="server" ID="rootcauseanalysisbyprocess" />
            </td>
        </tr>
        <tr>
            <td bgcolor="#404040">
                <uc3:businessunitanalysis ID="businessunitanalysis1" runat="server" />
            </td>
        </tr>
        <tr>
            <td bgcolor="White">
                <uc4:currentitemsunder ID="currentitemsunder1" runat="server" />
            </td>
        </tr>
        <tr runat="server" id="trAudit">
            <td bgcolor="White">
                <uc5:auditprogress ID="auditprogress1" runat="server" />
            </td>
        </tr>
    </table>
        </div>
    <dx:ASPxPopupControl ID="popClaims" runat="server" ClientInstanceName="popClaims" Modal="True" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" AllowDragging="True" AllowResize="True" HeaderText="Claims" RenderMode="Lightweight" ShowMaximizeButton="True">
    <ClientSideEvents EndCallback="function(s, e) {
	popClaims.Show();
}" />
    <ContentCollection>
<dx:PopupControlContentControl runat="server" SupportsDisabledAttribute="True">
        </dx:PopupControlContentControl>
</ContentCollection>
</dx:ASPxPopupControl>
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="SubContent">
</asp:Content>
