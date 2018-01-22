<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wydawnictwo_form.aspx.cs" Inherits="WebApplication1.Wydawnictwo_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
    <title></title>
</head>
<body bgcolor="#ffd480">
    <center>
    <form id="form4" runat="server">
        <h1>Wydawnictwa<br /></h1>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-right: 1px" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="nazwa" HeaderText="nazwa" SortExpression="nazwa" />
                <asp:BoundField DataField="rok" HeaderText="rok" SortExpression="rok" />
                <asp:BoundField DataField="wlasciciel" HeaderText="wlasciciel" SortExpression="wlasciciel" />
                <asp:BoundField DataField="kraj" HeaderText="kraj" SortExpression="kraj" />
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
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Powrót do menu" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbad_s426187ConnectionString %>" SelectCommand="SELECT * FROM [PprWydawnictwo]"></asp:SqlDataSource>
        <br /><br />
        <asp:Button ID="Button3" runat="server" Text="Dodaj Wydawnictwo" OnClick="Button3_Click" />                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Usun Wydawnictwo" />
    </form>
    </center>
    </body>
</html>

