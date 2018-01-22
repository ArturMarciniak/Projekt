<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dodaj_album.aspx.cs" Inherits="WebApplication1.Dodaj_album" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body> 
    <form id="form1" runat="server">
        <center><h1>Dodawanie albumu:</h1>
         <font size="5.5">

     

        <p>
            Nazwa:<asp:TextBox ID="naz" runat="server"></asp:TextBox>
        </p>
        <p>
            Dlugość:<asp:TextBox ID="dlu" runat="server"></asp:TextBox>
        </p>
        <p>
            Wydawnictwo:<asp:TextBox ID="wyk" runat="server"></asp:TextBox>
        </p>   </font>
        <asp:Button ID="Button1" runat="server" Text="Powrót" OnClick="Button1_Click" />
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Dodaj do bazy" /></center>
    </form>

</body>
</html>
