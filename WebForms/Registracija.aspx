<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs"
    Inherits="WebFormsLab6.Registracija" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Registracija</h2>

    <asp:Label ID="Label1" runat="server" Text="Korisničko ime:" />
    <br />
    <asp:TextBox ID="txtUser" runat="server" />
    <br /><br />

    <asp:Label ID="Label2" runat="server" Text="Lozinka:" />
    <br />
    <asp:TextBox ID="txtPass" runat="server" TextMode="Password" />
    <br /><br />

    <asp:Label ID="Label3" runat="server" Text="Ime i prezime:" />
    <br />
    <asp:TextBox ID="txtName" runat="server" />
    <br /><br />

    <asp:Button ID="btnReg" runat="server"
        Text="Registriraj se"
        OnClick="btnReg_Click" />
    <br /><br />

    <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />

</asp:Content>
