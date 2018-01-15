<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dodaj_utwor.aspx.cs" Inherits="WebApplication1.Dodaj_utwor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center><h1>Dodawanie utworu:</h1>


    <form id="form1" runat="server">
        <div>


           <font size="5.5">
            Tytuł:                          <asp:TextBox ID="Tytul" runat="server"></asp:TextBox><br /><br />
            Wykonawca:                      <asp:TextBox ID="Wykonawca" runat="server"></asp:TextBox><br /><br />
            Długość:                        <asp:TextBox ID="Dlugosc" runat="server"></asp:TextBox><br /><br />
            Rok wydania:                    <asp:TextBox ID="Rok" runat="server"></asp:TextBox><br /><br />
            Id Albumu:                      <asp:TextBox ID="Id_albumu" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Powrot" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Dodaj do bazy" />
            <br />

            </font></div>
    </form></center>
</body>
</html>
