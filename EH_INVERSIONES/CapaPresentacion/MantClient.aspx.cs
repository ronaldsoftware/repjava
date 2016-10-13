using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantClient : System.Web.UI.Page
    {
        Cliente cl = new Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.listar();
        }
        private void listar()
        {
            grvcliente.DataSource = Cliente.listarClientes();
            grvcliente.DataBind();
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            cl.Nombre = txtnom.Text;
            cl.Apellido = txtape.Text;
            cl.Dni = txtdni.Text;
            cl.Telef = txttelef.Text;
            cl.Cel = txtcel.Text;
            cl.Dir = txtdire.Text;
            cl.Correo = txtcorreo.Text;
            Cliente.insertarClientes(cl);
            this.listar();

        }
    }
}