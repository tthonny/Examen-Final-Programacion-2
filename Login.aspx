<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ExameFinalDeProgramacion_AnthonnyBlanco.Vistas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <link href="../CSS/login.css" rel="stylesheet" />
</head>
<body>
    <div class="background">
        <div class="shape"></div>
        <div class="shape"></div>
    </div>
    
    <form id="form1" runat="server">
        <h3>Login Here</h3>

        <label for="username">Username</label>
        <asp:TextBox ID="tusuario" placeholder="Email" CssClass="Section.form.inputBox" runat="server" ></asp:TextBox>
    
        <label for="password">Password</label>
        <asp:TextBox ID="tclave" placeholder="Password" CssClass="Section.form.inputBox" type="password" runat="server"></asp:TextBox>
    
        <asp:Button ID="bingresar" CssClass="Section.form.buttom" runat="server" Text="Ingresar" OnClick="bingresar_Click" />
    </form>
</body>
</html>
