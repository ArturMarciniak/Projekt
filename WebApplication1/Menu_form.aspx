<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu_form.aspx.cs" Inherits="WebApplication1.Menu_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Muzyczna Baza Danych</title>

</head>
<body bgcolor="#ffd480">
       <center> <h1> Muzyczna baza danych</h1>
    <form id="form2" runat="server">
        <div>
             </div>
       
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Utwory" /><br /><br />
        <asp:Button ID="Button3" runat="server" Text="Albumy" OnClick="Button3_Click" /><br /><br />
        <asp:Button ID="Button2" runat="server" Text="Wydawnictwa" OnClick="Button2_Click" style="height: 26px" /><br /><br />
    </form></center>
</body>
</html>
