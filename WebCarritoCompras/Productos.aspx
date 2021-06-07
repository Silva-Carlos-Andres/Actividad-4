<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebCarritoCompras.Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="Lista_Productos" runat="server">
        <div>
            <h1>Lista de Productos</h1>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:button text="Agregar" ID="btnAgregar" OnClick="btnAgregar_Click" runat="server"/>
        </div>
    </form>
</body>
</html>
