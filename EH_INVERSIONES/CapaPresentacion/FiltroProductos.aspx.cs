using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FiltroProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
               
                cargaProd();
            }
        }
        private void listar()
        {
            Producto p = new Producto();
            p.Nombre = ddlprod.SelectedValue;
            grvfiltro.DataSource = Producto.FiltrarProducto(p);
            grvfiltro.DataBind();
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            listar();
        }
        private void cargaProd()
        {

            ddlprod.DataSource = Factura.listarProdu();
            ddlprod.DataTextField = "nombre";
            ddlprod.DataValueField = "nombre";

            ddlprod.DataBind();

        }
    }
}