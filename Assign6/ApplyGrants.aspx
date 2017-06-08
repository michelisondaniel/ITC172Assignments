<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApplyGrants.aspx.cs" Inherits="ApplyGrants" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Grant Application</h1>
        <table>
            <tr>
                <td>First Name</td>
                <td>
                    <asp:TextBox ID="firstNameBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <asp:TextBox ID="lastNameBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email Address</td>
                <td>
                    <asp:TextBox ID="EmailBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Grant Date</td>
                <td>
                    <asp:TextBox ID="GrantDateBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Grant Amount</td>
                <td>
                    <asp:TextBox ID="GrantAmountBox" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
    </div>
    </form>
</body>
</html>
