<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebCarritoCompras.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Carrito de compras</h1>
    
    <table class="table">
      <thead>
        <tr>
            <th scope="col"></th>
            <th scope="col">Nombre</th>
            <th scope="col">Precio</th>
            <th scope="col"></th>
        </tr>
      </thead>
        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate> 
                    <tbody>
                        <tr>                    
                            <td><img src="<%#Eval("ImagenUrl") %>" class="card-img-top" alt="<%#Eval("Descripcion")%>" style="max-width: 10rem;"></td>
                            <td style="padding-top:4rem;"><%#Eval("Nombre") %></td>
                            <td style="padding-top:4rem;"">$<%#Eval("Precio") %></td>
                            <td style="padding-top:4rem;""><asp:Button ID="Button1" Text="Eliminar" style="color: red;" CommandArgument='<%#Eval("Codigo")%>' CommandName="CodArticulo" runat="server" OnClick="EliminarArticuloCarrito" /></td>
                        </tr>
                    </tbody> 
            </ItemTemplate>
        </asp:Repeater>
    </table>                  

    <p class="alert alert-light" style="font-size: 20px;">Precio total: <%= decimal.Round(CalcularPrecioTotal(), 2)%></p>
    <a class="btn btn-primary" href="/ListaProductos">Seguir comprando</a>

</asp:Content>
