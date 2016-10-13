using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class ListaDetaFactura : System.Web.UI.Page
    {
        Factura fa = new Factura();
        protected void Page_Load(object sender, EventArgs e)
        {
            grvfact.DataSource = Factura.listarFacturas();
            grvfact.DataBind();
        }
    }
}