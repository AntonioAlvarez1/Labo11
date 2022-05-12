<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Labo11._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">Universidad
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Mesoamericana</asp:ListItem>
                <asp:ListItem>Landivar</asp:ListItem>
                <asp:ListItem>San Carlos</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>Alumno</p>
        <p>Nombre<asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
        </p>
        <p>Apellido<asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
        </p>
        <p>Carne<asp:TextBox ID="TextBoxCarne" runat="server"></asp:TextBox>
        </p>
        <p>Curso<asp:TextBox ID="TextBoxCurso" runat="server"></asp:TextBox>
        </p>
        <p>Punteo<asp:TextBox ID="TextBoxPunteo" runat="server"></asp:TextBox>
            <asp:Button ID="IngresarNotas" runat="server" OnClick="IngresarNotas_Click" Text="Ingresar notas Alumno" />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
        <p>
            <asp:Button ID="ButtonIngresoAlumno" runat="server" Text="Ingresa Alumno a UNI" OnClick="ButtonIngresoAlumno_Click" />
        </p>
        <p>
            <asp:Button ID="ButtonGuardaU" runat="server" Text="Guardar Universidad" OnClick="ButtonGuardaU_Click" />
        </p>
    </div>

    </asp:Content>
