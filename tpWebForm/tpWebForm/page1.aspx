<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="tpWebForm.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Bienvenu à la page une, vous venez d&#39;être redirigé.<br />
        voici les informations qu&#39;on vous a gardé :<br />
        <asp:LinkButton ID="btnRetour" runat="server" OnClick="btnRetour_Click">Retour à la page home</asp:LinkButton>
    </div>
    </form>
</body>
</html>
