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
            carrito = (List<Articulo>)Session["listaArticulos"]; /* CREO UNA LISTA EN CASO DE QUE NO HAYA UNA PREVIA */
            if (carrito == null)
                carrito = new List<Articulo>();

            if(Request.QueryString["Id"] != "") { 
                List<Articulo> listaPrincipal = (List<Articulo>)Session["listadoArticulos"];
                carrito.Add(listaPrincipal.Find(x => x.Id.ToString() == Request.QueryString["Id"])); /*AGREGO EL ITEM A LA LISTA*/
            }

            Session.Add("listaArticulos", carrito); /*GUARDO LA LISTA EN EL SESSION*/
        }

    }
}