using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantCategoria : System.Web.UI.Page
    {
        Categoria c = new Categoria();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.listar();
        }
        private void listar()
        {
            grvcategoria.DataSource = Categoria.listarCategorias();
            grvcategoria.DataBind();
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            c.Des = txtdes.Text;
            Categoria.insertarCategorias(c);
            this.listar();
        }

        protected void btnactu_Click(object sender, EventArgs e)
        {
            c.Codigo = Convert.ToInt32(txtcod.Text);
            c.Des = txtdes.Text;
            Categoria.actualizarCategorias(c);
            this.listar();
        }
    }
}