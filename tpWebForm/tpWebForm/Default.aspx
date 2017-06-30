<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tpWebForm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Forumlaire d&#39;authentification :<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Login :"></asp:Label>
        <br />
        <asp:TextBox ID="txtLogin" runat="server" ></asp:TextBox>
        <br />
        Password :<br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Valider" />
        <br />
        <br />
        <hr />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Liste des valeurs entrées :"></asp:Label>
        <br />
        <asp:ListBox ID="lstEntries" runat="server" Width="349px" ViewStateMode="Disabled"></asp:ListBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:HyperLink ID="LinkButton1" runat="server"  NavigateUrl="~/page1.aspx">Page 1</asp:HyperLink>
            <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl="~/page2.aspx">Page 2</asp:HyperLink>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
