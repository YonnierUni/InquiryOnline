<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="IO.IniciarSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <meta charset="UTF-8">
  <meta name="viewport" content="width=devuce-width, initial-scale=1.0">
  <title>Crea formularios gratis | Inquiry Online</title>
  <link rel="stylesheet" href="css/style_IniciarSesion.css" />
  <script src="https://kit.fontawesome.com/ffd192a881.js" crossorigin="anonymous"></script>
    <script type="text/javascript" src="js/Diseño_Inicio.js"></script>
  <link rel="icon" type="image/png" href="photos/logincuestICON.png" />
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
          <a href="../IniciarSesion.aspx"><input runat="server" type="button" value="Acceder"></a>
          <a href="../Registro.aspx"><input runat="server" type="button" value="Comenzar"></a>
        </div>
      </div>
    </header>

    <div class="container">
      <div class="texto">
        <h2>Iniciar sesión</h2><br>

        <div class="input-div one">
          <div class="i">
            <i class="fas fa-envelope"></i>
          </div>
          <div class="div">
            <h5>Email</h5>

            <input type="email" class="entradas" required>
          </div>
        </div>

        <div class="input-div pass">
          <div class="i">
            <i class="fas fa-lock"></i> </div>
          <div class="div">
            <h5>Contraseña</h5>

            <input type="password" class="entradas" required>
          </div>
        </div>
        <div class="inf">
          <a href="#">Olvidé mi contraseña</a>
          <a href="#">Registrarse</a><br>
          <button class="inicio">Iniciar</button>
        </div>
      </div>
    </div>
    <footer>
      <p>Página web 2020</p>
    </footer>
  </form>
</body>

</html>