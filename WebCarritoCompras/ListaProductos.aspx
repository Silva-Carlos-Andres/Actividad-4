<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProductos.aspx.cs" Inherits="WebCarritoCompras.ListaProductos" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

            <h1>Lista de Productos</h1>
<%--            <asp:GridView ID="dgvArticulos" runat="server"></asp:GridView>


<div class="card" style="width: 18rem;">
        <div class="card-body">
            <img src="..." class="card-img-top" alt="...">
            <h5 class="card-title">Special title treatment</h5>
            <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
            <a href="#" class="btn btn-primary">Go somewhere</a>
        </div>
    </div>

            <asp:button text="Agregar" ID="btnAgregar" OnClick="btnAgregar_Click" runat="server"/>--%>
    
    <div class="container">
        <div class="row">
        <% foreach (Dominio.Articulo item in lista)

            {%>
            <div class="col">

                <div class="card" style="width: 18rem;">
                    <img src="<% = item.ImagenUrl %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><% = item.Nombre %></h5>
                        <p class="card-text"><% = item.Descripcion %></p>
                            <ul class="list-group list-group-flush">
                                <li class="list-group-item"><% = item.Marca %></li>
                                <li class="list-group-item"><% = item.Categoria %></li>
                            </ul>
                        <div class="card-footer bg-transparent border-success"><h6><s>$<% = (item.Precio)-200 %></s> Envio Gratis</h6></div>
                        <div class="text-center">$<% = item.Precio %></div>
                        <a href="Carrito.aspx?codigo=<% = item.Codigo %>" class="btn btn-primary">Agregar al carrito</a>
                    </div>
                </div>
            </div>
            <%} %>
            </div>
    </div>    
</asp:Content>
