<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="WebCarritoCompras.DetalleProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Producto Seleccionado</h1>
    <asp:Label Text="lala" ID= "lblSeleccionado" runat="server" />



    <asp:button text="Agregar" ID="btnCarrito" OnClick="btnCarrito_Click" runat="server"/>

    

</asp:Content>
