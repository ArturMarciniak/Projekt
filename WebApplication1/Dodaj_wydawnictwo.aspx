<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dodaj_wydawnictwo.aspx.cs" Inherits="WebApplication1.Dodaj_wydawnictwo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <center><h1>Dodawanie wydawnictwa:</h1>


    <form id="form1" runat="server">
        <div>


           <font size="5.5">
            Nazwa:                          <asp:TextBox ID="naz" runat="server"></asp:TextBox><br /><br />
            Rok_założenia:                      <asp:TextBox ID="rok" runat="server"></asp:TextBox><br /><br />
            Właściciel:                   <asp:TextBox ID="wlasc" runat="server"></asp:TextBox><br /><br />
            Kraj:                    <asp:TextBox ID="kra" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Powrot" OnClick="Button1_Click1" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Dodaj do bazy" />
            <br />

            </font></div>
    </form></center>
</body>
</html>
