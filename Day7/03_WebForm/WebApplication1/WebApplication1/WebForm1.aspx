<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            A=<asp:TextBox ID="txtA" runat="server"></asp:TextBox><br />
            B=<asp:TextBox ID="txtB" runat="server"></asp:TextBox><br />
            Ans=<asp:TextBox ID="txtAns" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnAdd" runat="server" Text="+" OnClick="btnAdd_Click" />
            <asp:Button ID="btnSub" runat="server" Text="-" OnClick="btnSub_Click" />
            <asp:Button ID="btnMul" runat="server" Text="*" OnClick="btnMul_Click" />
            <asp:Button ID="btnDiv" runat="server" Text="/" OnClick="btnDiv_Click" />
        </div>
    </form>
</body>
</html>
