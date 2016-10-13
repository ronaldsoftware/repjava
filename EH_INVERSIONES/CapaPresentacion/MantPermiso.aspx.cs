using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantPermiso : System.Web.UI.Page
    {
        Permiso pe = new Permiso();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.listar();
        }
        private void listar()
        {
            grvpermiso.DataSource = Permiso.listarPermisos();
            grvpermiso.DataBind();
        }
        private void limpiar()
        {
            txtnom.Text = "";
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            pe.Nombre = txtnom.Text;
            Permiso.insertarPermisos(pe);
            this.limpiar();
            this.listar();
        }
    }
}