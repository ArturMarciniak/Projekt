<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dodaj_utwor.aspx.cs" Inherits="WebApplication1.Dodaj_utwor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#ffd480">
    <center><h1>Dodawanie utworu:</h1>
        
    <form id="form1" runat="server">
         <asp:GridView ID="GridView4" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-right: 1px" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="tytul" HeaderText="tytul" SortExpression="tytul" />
                <asp:BoundField DataField="wykonawca" HeaderText="wykonawca" SortExpression="wykonawca" />
                <asp:BoundField DataField="dlugosc" HeaderText="dlugosc" SortExpression="dlugosc" />
                <asp:BoundField DataField="rok" HeaderText="rok" SortExpression="rok" />
                <asp:BoundField DataField="id_albumu" HeaderText="id_albumu" SortExpression="id_albumu" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>

         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbad_s426187ConnectionString %>" SelectCommand="SELECT * FROM [PprUtwor]"></asp:SqlDataSource>

        <div>


           <font size="5.5">
            Tytuł:                          <asp:TextBox ID="Tytul" runat="server"></asp:TextBox><br /><br />
            Wykonawca:                      <asp:TextBox ID="Wykonawca" runat="server"></asp:TextBox><br /><br />
            Długość:                        <asp:TextBox ID="Dlugosc" runat="server"></asp:TextBox><br /><br />
            Rok wydania:                    <asp:TextBox ID="Rok" runat="server"></asp:TextBox><br /><br />
            Id Albumu:                      <asp:TextBox ID="Id_albumu" runat="server"></asp:TextBox><br />
            <br />

            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Powrót" />
&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Dodaj do bazy" />

            </font></div>
    </form></center>
    <p>
&nbsp;</p>
</body>
</html>
