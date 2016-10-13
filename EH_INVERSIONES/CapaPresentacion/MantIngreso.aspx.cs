using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantIngreso : System.Web.UI.Page
    {
        Ingreso i = new Ingreso();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar();
                cargaProducto();
                cargaProveedor();
            }
        }
        private void listar()
        {
            grvingreso.DataSource = Ingreso.listarIngreso();
            grvingreso.DataBind();
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            i.Serie = txtserie.Text;
            i.Descripcion = ddldes.SelectedValue;
            i.Codprove = Convert.ToInt32(ddlproveedor.SelectedValue);
            Ingreso.insertarIngreso(i);
            listar();
        }
        private void cargaProducto()
        {
            ddldes.DataSource = Producto.listarProductos();
            ddldes.DataTextField = "nombre";
            ddldes.DataValueField = "nombre";
            ddldes.DataBind();
        }
        private void cargaProveedor()
        {
            ddlproveedor.DataSource = Proveedor.listarProveedor();
            ddlproveedor.DataTextField = "nombre";
            ddlproveedor.DataValueField = "codprove";
            ddlproveedor.DataBind();
        }
    }
}