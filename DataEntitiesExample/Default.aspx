<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Log In</h1>
        <table>
            <tr>
                <td>UserName</td>
                <td>
                <asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox></td>
           </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td class="auto-style1"><asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password">
                    </asp:TextBox></td>
                
            </tr>
            <tr>
                <td>
                    <asp:Button ID="LoginButton" runat="server" Text="Log in" OnClick="LoginButton_Click" />
                    </td>
                <td>
                    <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
