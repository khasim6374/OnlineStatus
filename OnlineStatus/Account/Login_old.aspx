<%@ Page Title="Log In" Language="vb" MasterPageFile="Site1.Master" AutoEventWireup="false"
    CodeBehind="Login.aspx.vb" Inherits="OnlineStatus.Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
    
    <div style="padding-left: 15px;" align="center" >
        <div class="logincls">
            <br />
        Log In
   </div>
        <div style="width:1000px">
            <asp:Login ID="LoginUser" runat="server" EnableViewState="false" RenderOuterTable="false" >
        <LayoutTemplate>
            <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
            </span>
            <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification" 
                 ValidationGroup="LoginUserValidationGroup"/>
            <div class="accountInfo">
                <fieldset class="login">
                    <legend style="color:#fff;">Account Information</legend>
                    <p>
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Username:</asp:Label>
                        <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                             CssClass="failureNotification" ErrorMessage="User Name is required." ToolTip="User Name is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                        <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                             CssClass="failureNotification" ErrorMessage="Password is required." ToolTip="Password is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:CheckBox ID="RememberMe" runat="server" Visible="False"/>
                        <asp:Label ID="RememberMeLabel" runat="server" AssociatedControlID="RememberMe" 
                            CssClass="inline" Visible="False">Keep me logged in</asp:Label>
                    </p><p class="submitButton">
                        <br />
                    <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" 
                        ValidationGroup="LoginUserValidationGroup" onclick="LoginButton_Click" CssClass="btnLogin"/>
                </p>
                </fieldset>
                
            </div>
        </LayoutTemplate>
    </asp:Login>
        </div>
        <br /><br />
    </div>
</asp:Content>