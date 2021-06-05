<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebCarritoCompras.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Carrito de compras</h1>

    <table>
        <tr>
            <td> 
                Nombre
            </td>
            <td>
                Accion
            </td>
        </tr>
        <% foreach(Dominio.Articulo item in carrito){%>
        <tr>
            <td>
                <% = item.Nombre %>
            </td>
            <td>
                eliminar
            </td>
        </tr>
        <%} %>
    </table>
</asp:Content>
