<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="IO.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="UTF-8">
    <meta name="viewport" content="width=devuce-width, initial-scale=1.0">
    <title>Crea formularios gratis | Inquiry Online</title>
    <link rel="stylesheet" href="css/style_Inicio.css" />
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
                    <a href="../IniciarSesion.aspx">
                        <input runat="server" type="button" value="Acceder"></a>
                    <a href="../Registro.aspx">
                        <input runat="server" type="button" value="Comenzar"></a>
                </div>
            </div>
        </header>

        <div class="container">
            <div class="image">
            </div>
            <div class="texto">
                <h1>¡Crea formularios en línea totalmente gratis!</h1>
                <br>
                <br>
                <p>¿Qué haces cuando necesitas información especifica de una persona? Le preguntas, no es cosa de otro mundo. Pero ¿qué sucede si no necesitas información de una una persona, si no de 10, 100, o incluso 100 personas? Se vuelve un trabajo un poco más complejo. Bueno ahora ya no lo será. Con Inquiry Online puedes crear un formulario y compartirlo con cuántas personas quieras sin ninguna clase de problema. Toda esa información que necesitas, la conseguirás. Prueba ya nuestros servicios.</p>
                <br>
                <br>
                <a href="../Registro.aspx"><input runat="server" type="button" value="Registrate gratis" class="registro"></a>
            </div>
        </div>
        <footer>
            <p>Página web 2020</p>
        </footer>
    </form>
</body>
</html>
