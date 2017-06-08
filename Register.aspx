<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Register</h1>
            <table>
                <%--<tr>
                    <td>User Name</td>
                    <td>
                        <asp:TextBox ID="RegUserName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator 
                             ID="UserNameValidator"
                             runat="server"
                             ErrorMessage="User Name is Required"
                             ControlToValidate="RegUserName">
                             
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>--%>
                <tr>
                    <td>Last Name</td>
                    <td>
                        <asp:TextBox ID="RegLastName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator 
                            ID="LastNameValidator" 
                            runat="server" 
                            ErrorMessage="Last Name is Required"
                            ControlToValidate="RegLastName">

                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>First Name</td>
                    <td>
                        <asp:TextBox ID="RegFirstName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator 
                            ID="FirstNameValidator" 
                            runat="server" 
                            ErrorMessage="First Name is Required"
                            ControlToValidate="RegFirstName">

                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email Address</td>
                    <td>
                        <asp:TextBox ID="RegEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator 
                            ID="EmailValidator" 
                            runat="server" 
                            ErrorMessage="Invalid Email Address"
                            ControlToValidate="RegEmail"
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">

                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="RegPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator 
                            ID="PasswordValidator" 
                            runat="server" 
                            ErrorMessage="Password is Required"
                            ControlToValidate="RegPassword">

                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Confirm Password</td>
                    <td>
                        <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator 
                            ID="ConfirmPassValidator" 
                            runat="server" 
                            ErrorMessage="Confirmation of Password Required"
                            ControlToValidate="ConfirmPassword">

                        </asp:RequiredFieldValidator>
                        &nbsp;
                        <asp:CompareValidator 
                            ID="CompareValidator1" 
                            runat="server" 
                            ErrorMessage="CompareValidator"
                            ControlToValidate="ConfirmPassword"
                            ControlToCompare="RegPassword">
                            
                        </asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="SubmitRegButton" runat="server" Text="Submit" OnClick="SubmitRegButton_Click" />    
                    </td>
                    <td>
                         <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>

        
         
       
    </div>
    </form>
</body>
</html>
