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
    public partial class DetalleProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            ArticuloBusiness business = new ArticuloBusiness();
            lblSeleccionado.Text = id;

         
        }

        protected void btnCarrito_Click(object sender, EventArgs e)
        {
            Session.Add("id", Request.QueryString["id"]);
            Response.Redirect("Carrito.aspx");
        }
    }
}