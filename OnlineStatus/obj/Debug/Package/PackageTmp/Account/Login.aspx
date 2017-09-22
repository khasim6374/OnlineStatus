<%@ Page Title="Log In" Language="vb" MasterPageFile="Site1.Master" AutoEventWireup="false" enableEventValidation="false"
    CodeBehind="Login.aspx.vb" Inherits="OnlineStatus.Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
      <style>
        @charset "utf-8";
        /* CSS Document */

        /* ---------- FONTAWESOME ---------- */
        /* ---------- http://fortawesome.github.com/Font-Awesome/ ---------- */
        /* ---------- http://weloveiconfonts.com/ ---------- */

        @import url(http://weloveiconfonts.com/api/?family=fontawesome);

        /* ---------- ERIC MEYER'S RESET CSS ---------- */
        /* ---------- http://meyerweb.com/eric/tools/css/reset/ ---------- */

        @import url(http://meyerweb.com/eric/tools/css/reset/reset.css);

        /* ---------- FONTAWESOME ---------- */

        [class*="fontawesome-"]:before
        {
            font-family: 'FontAwesome', sans-serif;
        }

        /* ---------- GENERAL ---------- */
        body
        {
            line-height: 1;
        }

        ol, ul
        {
            list-style: none;
        }

        blockquote, q
        {
            quotes: none;
        }

            blockquote:before, blockquote:after,
            q:before, q:after
            {
                content: '';
                content: none;
            }

        table
        {
            border-collapse: collapse;
            border-spacing: 0;
        }

        body
        {
            background-color: #C0C0C0;
            color: #000;
            font-family: "Varela Round", Arial, Helvetica, sans-serif;
            font-size: 16px;
            line-height: 1.5em;
        }

        input
        {
            border: none;
            font-family: inherit;
            font-size: inherit;
            font-weight: inherit;
            line-height: inherit;
            -webkit-appearance: none;
        }

        /* ---------- LOGIN ---------- */

        #login
        {
            margin: 50px auto;
            width: 350px;
        }

            #login h2
            {
                background-color: #21420d;
                -webkit-border-radius: 20px 20px 0 0;
                -moz-border-radius: 20px 20px 0 0;
                border-radius: 20px 20px 0 0;
                color: #fff;
                font-size: 28px;
                padding: 20px 26px;
            }

                #login h2 span[class*="fontawesome-"]
                {
                    margin-right: 14px;
                }

            #login fieldset
            {
                background-color: #fff;
                -webkit-border-radius: 0 0 20px 20px;
                -moz-border-radius: 0 0 20px 20px;
                border-radius: 0 0 20px 20px;
                padding: 20px 26px;
                border: solid thin #21420d;
            }

                #login fieldset p
                {
                    color: #777;
                    margin-bottom: 14px;
                }

                    #login fieldset p:last-child
                    {
                        margin-bottom: 0;
                    }

                #login fieldset input
                {
                    -webkit-border-radius: 3px;
                    -moz-border-radius: 3px;
                    border-radius: 3px;
                }

                    #login fieldset input[type="text"], #login fieldset input[type="password"]
                    {
                        background-color: #eee;
                        color: #777;
                        padding: 4px 10px;
                        width: 250px;
                    }

                    #login fieldset input[type="submit"]
                    {
                        background-color: #33cc77;
                        color: #fff;
                        display: block;
                        margin: 0 auto;
                        padding: 4px 0;
                        width: 100px;
                    }

                        #login fieldset input[type="submit"]:hover
                        {
                            background-color: #28ad63;
                        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
    
     <div id="login">
        <asp:Login ID="LoginUser" runat="server" EnableViewState="false" RenderOuterTable="false">
            <LayoutTemplate>
                <span class="failureNotification">
                    <asp:Literal ID="FailureText" runat="server"></asp:Literal>
                </span>
                <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification"
                    ValidationGroup="LoginUserValidationGroup" />
                <h2><span class="fontawesome-lock"></span>Sign In</h2>

                <form action="javascript:void(0);" method="POST">

                    <fieldset>


                        <p>
                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Username:</asp:Label>
                        </p>
                        <p>
                            <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                CssClass="failureNotification" ErrorMessage="User Name is required." ToolTip="User Name is required."
                                ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                        </p>
                        <p>
                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                        </p>
                        <p>
                            <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                CssClass="failureNotification" ErrorMessage="Password is required." ToolTip="Password is required."
                                ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                        </p>

                        <p>
                            <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="LoginUserValidationGroup" OnClick="LoginButton_Click" />
                        </p>

                    </fieldset>

                </form>
            </LayoutTemplate>
        </asp:Login>
    </div>
</asp:Content>