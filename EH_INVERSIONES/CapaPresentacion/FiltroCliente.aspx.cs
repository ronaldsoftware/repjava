using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FiltroCliente : System.Web.UI.Page
    {
        Cliente c = new Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            
            c.Dni = txtdni.Text;
            Cliente.FiltarClientes(c);
            this.listar();
        }
        private void listar()
        {
            grvcliente.DataSource = Cliente.FiltarClientes(c);
            grvcliente.DataBind();
        }
    }
}