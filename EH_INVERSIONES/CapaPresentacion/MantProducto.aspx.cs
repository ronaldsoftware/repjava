using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantProducto : System.Web.UI.Page
    {
        Producto p = new Producto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                this.listar();
                this.CargaCategoria();
                this.CargaMarca();
            }
       
        }
        private void listar()
         {
             grvproducto.DataSource = Producto.listarProductos();
             grvproducto.DataBind();
         }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            p.Nombre = txtproduc.Text;
            p.Precio = Convert.ToDecimal(txtprecio.Text);
            p.Stock =  Convert.ToInt32(txtstock.Text);
            p.Codm =  Convert.ToInt32(ddlmarca.SelectedValue);
            p.Codc =  Convert.ToInt32(ddlcateg.SelectedValue);
            Producto.insertarProductos(p);
            this.listar();
        }
        private void CargaMarca()
        {
            ddlmarca.DataSource = Marca.listarMarcas();
            ddlmarca.DataTextField = "nombre";
            ddlmarca.DataValueField = "codmarca";
            ddlmarca.DataBind();
        }
        private void CargaCategoria()
        {
            ddlcateg.DataSource = Categoria.listarCategorias();
            ddlcateg.DataTextField = "descripcion";
            ddlcateg.DataValueField = "codcat";
            ddlcateg.DataBind();
        }

    }
}