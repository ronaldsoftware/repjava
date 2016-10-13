using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantEmpleado : System.Web.UI.Page
    {
        Empleado em = new Empleado();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlcargo.DataSource = Cargo.listarCargos();
                ddlcargo.DataTextField = "nombre";
                ddlcargo.DataValueField = "codcargo";
                ddlcargo.DataBind();
            }
            this.listar();

        }
        private void listar()
        {
            grvempleado.DataSource = Empleado.listarEmpleados();
            grvempleado.DataBind();
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            em.Nombre = txtnom.Text;
            em.Ape = txtape.Text;
            em.Fecha = txtfecha.Text;
            em.Dni = txtdni.Text;
            em.Telef = txttelef.Text;
            em.Cel = txtcel.Text;
            em.Dire = txtdire.Text;
            em.Correo = txtcorreo.Text;
            em.Codcargo = Convert.ToInt32(ddlcargo.SelectedValue);
            Empleado.insertarEmpleados(em);
            this.listar();
        }
    }
}