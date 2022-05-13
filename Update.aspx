<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Labo11.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Actualizar</h1>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp; Ingrese Carne&nbsp;<asp:TextBox ID="TextBoxCarne" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="ButtonBuscarA" runat="server" OnClick="ButtonBuscarA_Click" Text="Buscar Alumno" />
</p>
<p>
    Nombre<asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
</p>
<p>
    Apellido<asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="ButtonModificar" runat="server" Text="Modificar" OnClick="ButtonModificar_Click" />
</p>
<p>
    &nbsp;</p>
</asp:Content>
