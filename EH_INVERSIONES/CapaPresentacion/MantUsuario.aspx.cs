using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantUsuario : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            
           if(!IsPostBack)
           {
               this.cargaempleado();
               this.cargaoermiso();
           this.listar();
           }
        }
        private void cargaempleado()
        {
            ddlempleado.DataSource = Empleado.CargaEmpleados();
            ddlempleado.DataTextField = "nemp";
            ddlempleado.DataValueField = "codemp";
            ddlempleado.DataBind();
        }
        private void cargaoermiso()
        {
            ddlpermiso.DataSource = Permiso.listarPermisos();
            ddlpermiso.DataTextField = "nombre";
            ddlpermiso.DataValueField = "codpermi";
            ddlpermiso.DataBind();
        }
        private void listar()
        {
            grvusuario.DataSource = Usuario.listarUsuarios();
            grvusuario.DataBind();
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            u.User = txtnom.Text;
            u.Contra = txtpass.Text;
            u.Codemp = Convert.ToInt32(ddlempleado.SelectedValue);
            u.Cpermi = Convert.ToInt32(ddlpermiso.SelectedValue);
            Usuario.insertarUsuarios(u);
            this.listar();
        }
    }
}