<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="IO.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="UTF-8">
    <meta name="viewport" content="width=devuce-width, initial-scale=1.0">
    <title>Crea formularios gratis | Inquiry Online</title>
    <link rel="stylesheet" href="css/style_Registro.css" />
    <script src="https://kit.fontawesome.com/ffd192a881.js" crossorigin="anonymous"></script>
    <link rel="icon" type="image/png" href="photos/logincuestICON.png" />
    <script type="text/javascript" src="js/Diseño_Inicio.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="divbarra">
                <a href="" class="titulo">Inquiry online</a>
                <nav>
                    <ul>
                        <li><a href="../Inicio.aspx">Inicio</a></li>
                        <li><a href="">Formularios</a></li>
                        <li><a href="">Acerca de</a></li>
                        <li><a href="">Contacto</a></li>
                    </ul>
                </nav>
                <div class="botones">
                    <a href="#">
                        <input runat="server" type="button" value="Acceder"></a>
                    <a href="../Registro.aspx">
                        <input runat="server" type="button" value="Comenzar"></a>
                </div>
            </div>
        </header>

        <div class="container">
            <div class="texto">
                  <h1>Registro</h1><br>
            <i class="fas fa-user"></i><input runat="server" id="usuario" type="text" placeholder="Usuario" class="entradas" required>
            <i class="fas fa-briefcase"></i><input runat="server" id="empresa" type="text" placeholder="Empresa" class="entradas"><br>
            <i class="fas fa-envelope"></i><input runat="server" id="email" type="email" class="entradas" placeholder="Email" required><br>
            <i class="fas fa-lock"></i><input runat="server" id="contrasena1" type="password" class="entradas" placeholder="Contraseña" required><br>
            <i class="fas fa-lock"></i><input runat="server" id="contrasena2" type="password" class="entradas" placeholder="Confirmar contraseña" required><br>
            <p><a href="#">Si ya tienes una cuenta ingresa aquí</a></p>
            <asp:Button ID="btnRegistro" class="inicio" runat="server" name="ini" OnClick="registrarPersona" Text="Registrarse" />&nbsp;
            <%--<button runat="server" id="registrarPersona" class="inicio">Registrarse</button>--%></div>
        </div>
        <footer>
            <p>Página web 2020</p>
        </footer>
    </form>
     <asp:Label ID="lblMensaje" runat="server">...</asp:Label>
</body>
</html>
