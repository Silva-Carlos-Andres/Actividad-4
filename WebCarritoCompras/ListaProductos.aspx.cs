using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Business;




namespace WebCarritoCompras
{
    public partial class ListaProductos : System.Web.UI.Page
    {

        public List<Articulo> lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloBusiness Business = new ArticuloBusiness();
            try
            {
                lista = Business.Listar2();  
                Session.Add("listadoArticulos", lista);
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                /*Response.Redirect("PaginaError.aspx"") A CREAR LA PAGINA DEL ERROR O UNA ALERTA, YA VEREMOS*/
            }
            

        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrito.aspx");

        }

    }
}