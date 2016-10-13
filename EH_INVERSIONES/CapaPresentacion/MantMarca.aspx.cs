using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantMarca : System.Web.UI.Page
    {
        Marca m = new Marca();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
            this.listar();
            }
        }
        private void listar()
        {
            grvmarca.DataSource = Marca.listarMarcas();
            grvmarca.DataBind();
        }


        protected void btngrabar_Click(object sender, EventArgs e)
        {
            m.Nombre = txtnombre.Text;
            Marca.insertarMarcas(m);
            this.listar();
        }

        protected void btnactu_Click(object sender, EventArgs e)
        {
            m.Codigo = Convert.ToInt32(txtcod.Text);
            m.Nombre = txtnombre.Text;
            Marca.actualizarMarcas(m);
            this.listar();
        }


    }
}