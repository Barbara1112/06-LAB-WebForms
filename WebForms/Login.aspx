<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs"
    Inherits="WebFormsLab6.Login" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Login</h2>

    <asp:Label ID="Label1" runat="server" Text="Korisničko ime:" />
    <br />
    <asp:TextBox ID="txtUser" runat="server" />
    <br /><br />

    <asp:Label ID="Label2" runat="server" Text="Lozinka:" />
    <br />
    <asp:TextBox ID="txtPass" runat="server" TextMode="Password" />
    <br /><br />

    <asp:Button ID="btnLogin" runat="server"
        Text="Login"
        OnClick="btnLogin_Click" />
    <br /><br />

    <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />

</asp:Content>
