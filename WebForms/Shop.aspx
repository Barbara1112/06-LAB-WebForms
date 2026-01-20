<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shop.aspx.cs"
    Inherits="WebFormsLab6.Shop" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Shop</h2>

    <asp:Label ID="Label1" runat="server" Text="Naziv proizvoda:" />
    <br />
    <asp:TextBox ID="txtName" runat="server" />
    <br /><br />

    <asp:Label ID="Label2" runat="server" Text="Opis proizvoda:" />
    <br />
    <asp:TextBox ID="txtDesc" runat="server" />
    <br /><br />

    <asp:Button ID="btnSave" runat="server"
        Text="Spremi proizvod"
        OnClick="btnSave_Click" />
    <br /><br />

    <asp:GridView ID="gvProducts" runat="server"
        AutoGenerateColumns="true"
        BorderWidth="1px" />

</asp:Content>
