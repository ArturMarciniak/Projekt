<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Utwor_form.aspx.cs" Inherits="WebApplication1.Utwor_form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#ffd480"><center>
    <form id="form1" runat="server">
        <div> <h1>Utwory<br /></h1>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-right: 1px" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
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
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Powrot do menu" />
<br /><br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Dodaj utwór" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" Text="Usuń utwór" />
            <br />
        </div></center>
    </form>
</body>
</html>
