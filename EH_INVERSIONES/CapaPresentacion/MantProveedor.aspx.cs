using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantProveedor : System.Web.UI.Page
    {
        Proveedor p = new Proveedor();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.listar();
        }
        private void listar()
        {
            grvproveedor.DataSource = Proveedor.listarProveedor();
            grvproveedor.DataBind();
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            p.Nomb = txtnom.Text;
            p.Ruc = txtruc.Text;
            p.Dir = txtdir.Text;
            p.Corr = txtcorr.Text;
            p.Telef = txttel.Text;
            p.Cel = txtcel.Text;
            Proveedor.insertarPproveedor(p);
            this.listar();
        }

    }
}