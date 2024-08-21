<%@ Page Title="" Language="C#" MasterPageFile="~/VISTAS/Inicio.Master" AutoEventWireup="true" CodeBehind="PaginaRegistrosViajeros.aspx.cs" Inherits="ExameFinalDeProgramacion_AnthonnyBlanco.Vistas.PaginaRegistrosViajeros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/RegistroViajeros.css" rel="stylesheet" />
</asp:Content>
 
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Formulario de Registro de Viajeros</h2>
    
    <div class="form-container">
        <label for="cedula">Cédula:</label>
        <asp:TextBox ID="txtCedula" runat="server" CssClass="form-input" ClientIDMode="Static" type="number"></asp:TextBox><br /><br />
        
        <label for="nombre">Nombre:</label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-input" ClientIDMode="Static"></asp:TextBox><br /><br />
        
        <label for="apellido1">Primer Apellido:</label>
        <asp:TextBox ID="txtApellido1" runat="server" CssClass="form-input" ClientIDMode="Static"></asp:TextBox><br /><br />
        
        <label for="apellido2">Segundo Apellido:</label>
        <asp:TextBox ID="txtApellido2" runat="server" CssClass="form-input" ClientIDMode="Static"></asp:TextBox><br /><br />
        
        <label for="ubicacion">Ubicación:</label>
        <asp:TextBox ID="txtUbicacion" runat="server" CssClass="form-input" ClientIDMode="Static"></asp:TextBox><br /><br />
        
        <label for="edad">Edad:</label>
        <asp:TextBox ID="txtEdad" runat="server" CssClass="form-input" ClientIDMode="Static" type="number"></asp:TextBox><br /><br />

        <asp:Button ID="btnRegistrar" CssClass="form-button" runat="server" Text="Registrar" OnClick="BtnRegistrar_Click" />
    </div>
</asp:Content>