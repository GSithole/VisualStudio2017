<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WcfWebClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" >
            </asp:GridView>
            <br />
            <asp:HyperLink ID="Creat" runat="server" NavigateUrl="~/AddContact.aspx">Create new Contact</asp:HyperLink>
            <br />
            <br />
            <table id="tableContent" border="1" runat="server"></table>
        </div>
    </form>
</body>
</html>
