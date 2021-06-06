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
<<<<<<< HEAD
                lista = Business.Listar2();
                
=======
                lista = Business.Listar2();  
                Session.Add("listadoArticulos", lista);
>>>>>>> ab8c97149f0087fbac33431a836a587e92f8d410
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