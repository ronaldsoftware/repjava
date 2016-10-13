using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantPrecio : System.Web.UI.Page
    {
        Precio p = new Precio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
            listar();
            cargaProducto();
            cargaProveedor();
            }
          }
        private void listar()
        {
            grvprecio.DataSource = Precio.listarPrecio();
            grvprecio.DataBind();
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            p.Codprove = Convert.ToInt32(ddlprov.SelectedValue);
            p.Codprod = Convert.ToInt32(ddlproducto.SelectedValue);
            p.Precios =  Convert.ToDecimal(txtprecio.Text);
            Precio.insertarPrecio(p);
            listar();
        }
        private void cargaProducto()
        {
            ddlproducto.DataSource = Producto.listarProductos();
            ddlproducto.DataTextField = "nombre";
            ddlproducto.DataValueField = "codproducto";
            ddlproducto.DataBind();
        }
        private void cargaProveedor()
        {
            ddlprov.DataSource = Proveedor.listarProveedor();
            ddlprov.DataTextField = "nombre";
            ddlprov.DataValueField = "codprove";
            ddlprov.DataBind();
        }
    }
}