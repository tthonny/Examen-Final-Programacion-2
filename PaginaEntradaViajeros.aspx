<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Inicio.Master" AutoEventWireup="true" CodeBehind="PaginaEntradaViajeros.aspx.cs" Inherits="ExameFinalDeProgramacion_AnthonnyBlanco.Vistas.PaginaEntradaViajeros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/RegistroEntrada.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Formulario de Entrada de Viajeros</h2>
    
    <div class="form-container">
        <label for="txtCedula">Cédula:</label>
        <asp:TextBox ID="txtCedula" runat="server" CssClass="form-input" type="number"></asp:TextBox><br /><br />
        
        <label for="txtPaisProcede">País de Procedencia:</label>
        <asp:TextBox ID="txtPaisProcede" runat="server" CssClass="form-input"></asp:TextBox><br /><br />
        
        <label for="txtFechaEntrada">Fecha de Entrada:</label>
        <asp:TextBox ID="txtFechaEntrada" runat="server" CssClass="form-input"></asp:TextBox><br /><br />
        
        <label for="txtVisa">Visa:</label>
        <asp:TextBox ID="txtVisa" runat="server" CssClass="form-input"></asp:TextBox><br /><br />

        <asp:Button ID="btnRegistrar" CssClass="form-button" runat="server" Text="Registrar" OnClick="BtnRegistrar_Click" />
    </div>
</asp:Content>