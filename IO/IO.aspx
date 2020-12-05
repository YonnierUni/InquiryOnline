<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IO.aspx.cs" Inherits="IO.IO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3><strong>REGISTRO</strong> </h3>
            </br>
        </div>
        <div class="row">
            <div class="col-md-6 mb-3">
                <input runat="server" type="text" class="entradas" id="usuario" placeholder="USUARIO" value="" required>
            </div>

            <div class="col-md-6 mb-3">
                <input runat="server" type="email" class="entradas" id="email" placeholder="EMAIL" value="" required>
            </div>

            <div class="col-md-6 mb-3">
                <input runat="server" type="password" class="entradas" id="contrasena" placeholder="CONTRASEÑA" value="" required>
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="Button" Width="127px" OnClick="Button1_Click1" />
            </div>
        </div>
         <p>
        <asp:Label ID="lblMensaje" runat="server">...</asp:Label>
    </p>
    </form>
     

</body>
</html>
