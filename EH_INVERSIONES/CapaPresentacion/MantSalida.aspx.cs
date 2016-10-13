using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantSalida : System.Web.UI.Page
    {
        CapaNegocio.Salida s = new CapaNegocio.Salida();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
         { 
            listar();
            cargaProducto();
          }
        }

        private void listar()
        { 
            grvsalida.DataSource = CapaNegocio.Salida.listarSalidas();
            grvsalida.DataBind();
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            s.Serie = txtserie.Text;
            s.Des = ddldes.SelectedValue;
            CapaNegocio.Salida.insertarSalidas(s);
            listar();
        }
        private void cargaProducto()
        {
            ddldes.DataSource = Producto.listarProductos();
            ddldes.DataTextField = "nombre";
            ddldes.DataValueField = "nombre";
            ddldes.DataBind();
        }
    }
}