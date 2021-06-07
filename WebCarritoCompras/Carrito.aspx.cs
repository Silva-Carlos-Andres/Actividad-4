using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace WebCarritoCompras
{
    public partial class Carrito : System.Web.UI.Page
    {
        public List<Articulo> carrito;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                carrito = (List<Articulo>)Session["listaArticulos"];
                if (carrito == null)
                    carrito = new List<Articulo>();

                if (!IsPostBack)
                {
                        if (Request.QueryString["Codigo"] != "")
                        {
                            List<Articulo> listadoArticulos = (List<Articulo>)Session["listadoArticulos"];
                            if (listadoArticulos != null)
                                carrito.Add(listadoArticulos.Find(x => x.Codigo.ToString() == Request.QueryString["Codigo"]));
                        }

                        Session.Add("listaArticulos", carrito);



                    repetidor.DataSource = carrito;
                    repetidor.DataBind();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public decimal CalcularPrecioTotal()
        {
            decimal precioTotal = 0;
            foreach (Articulo item in carrito)
            {
                if (carrito != null && item != null)
                    precioTotal += item.Precio;
            }
            return precioTotal;
        }
        
        protected void EliminarArticuloCarrito(object sender, EventArgs e)
        {
            var Codigo = ((Button)sender).CommandArgument;

            try
            {
            List<Articulo> carrito = (List<Articulo>)Session["listaArticulos"];
            Articulo eliminar = carrito.Find(x => x.Codigo.ToString() == Codigo);
            carrito.Remove(eliminar);
            Session.Add("listaArticulos", carrito);
            repetidor.DataSource = null;
            repetidor.DataSource = carrito;
            repetidor.DataBind();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}