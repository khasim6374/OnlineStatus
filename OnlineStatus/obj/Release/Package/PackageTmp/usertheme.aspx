<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master"
    CodeBehind="usertheme.aspx.vb" Inherits="OnlineStatus.usertheme" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent1" runat="server">
    <div class="pageHeader">
        User Theme
    </div>
    <div style="background-color: white;padding-left:10px;">
        <h2>Select your theme</h2>
        <dx:ASPxRadioButtonList ID="rblThemes" runat="server"
            DataSourceID="DsTheme" TextField="Caption" ValueField="Theme"
            AutoPostBack="True" RepeatColumns="3" Font-Size="Small">
        </dx:ASPxRadioButtonList>
        <asp:SqlDataSource ID="DsTheme" runat="server"
            ConnectionString="<%$ ConnectionStrings:connectionString %>"
            SelectCommand="SELECT * FROM [Theme]"></asp:SqlDataSource>
        <div style="text-align: left">
            <asp:Label ID="lblStatus" runat="server" Visible="false" Font-Bold="False" ForeColor="Blue"></asp:Label></div>
        <br />
        <br />
        <br />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SubContent" runat="server">
</asp:Content>
