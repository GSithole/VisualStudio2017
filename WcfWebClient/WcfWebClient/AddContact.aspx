<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddContact.aspx.cs" Inherits="WcfWebClient.AddContact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>Firstname</td>
                    <td>
                        <asp:TextBox ID="TxtFrstname" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtFrstname" ErrorMessage="Please entert your firstname"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>LastName</td>
                    <td>
                        <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastname" ErrorMessage="Please enter your lastname"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:DropDownList ID="DpGender" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DpGender" ErrorMessage="Please select your gender"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Phone Number</td>
                    <td>
                        <asp:TextBox ID="txtPnumber" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPnumber" ErrorMessage="Please enter your phone number"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email Address</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please Enter your Email address"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please enter a valid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>City</td>
                    <td>
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCity" ErrorMessage="Please enter City"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="hypBack" runat="server" NavigateUrl="~/Default.aspx">Back</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
