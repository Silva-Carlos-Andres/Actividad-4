<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProductos.aspx.cs" Inherits="WebCarritoCompras.ListaProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

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
    <div class="contenido">
    <div class="productos">
        <div class="row" >
        <% foreach (Dominio.Articulo item in lista)

            {%>
            <div class="col">

                <div class="card" style="width: 18rem;">
                    <img src="<% = item.ImagenUrl %>" class="card-img-top" alt="...">
<<<<<<< HEAD
                    <div class="card-body">                        
                        <h5 class="card-title"><% = item.Nombre %></h5>
                        <p class="card-text"><% = item.Descripcion %></p>
                          <ul class="list-group list-group-flush">                      
                        <div class="card-footer bg-transparent border-success"><h6><s>$<% = (item.Precio)-200 %></s> Envio Gratis</h6></div>
                              <div class="text-center">$<% = item.Precio %></div>
                              <a href="DetalleProducto.aspx?id=<% = item.Id %>" class="stretched-link"></a>
=======
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
>>>>>>> ab8c97149f0087fbac33431a836a587e92f8d410
                    </div>
                </div>
            </div>
            <%} %>
            </div>
<<<<<<< HEAD
    </div>
        </div>


<%--                <div class="card" style="width: 18rem;">
                    <div class="card-body">
                        <img src="<% = item.ImagenUrl %>" class="card-img-top" alt="...">
                        <h5 class="card-title"><% = item.Nombre %></h5>
                        <p class="card-text"><% = item.Descripcion %></p>
                          <ul class="list-group list-group-flush">                      
                        <div class="card-footer bg-transparent border-success"><h6><s>$<% = (item.Precio)-200 %></s> Envio Gratis</h6></div>
                              <div class="text-center">$<% = item.Precio %></div>
                              <a href="DetalleProducto.aspx?id=<% = item.Id %>" class="btn btn-primary">Detalle</a>
                    </div>
                </div>--%>
    <div class="container-menu">
        <div class="cont-menu">
            <br />
            <br />
            <br />
            <br />
            <h5>Filtrar por Categoria</h5>
            <select class="form-select" aria-label="Default select example">
                <option selected>Seleccionar...</option>

                <% foreach (Dominio.Articulo item in lista)
                    {%>

                <option value="<% = item.Nombre %>"><% = item.Categoria %></option>
                <%} %>

                <%--            <option value="value2" selected>Value 2</option>
            <option value="value3">Value 3</option>--%>
            </select>
        </div>

    </div>


=======
    </div>    
>>>>>>> ab8c97149f0087fbac33431a836a587e92f8d410
</asp:Content>
