using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class MantArea : System.Web.UI.Page
    {
        Area a = new Area();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.listar();
        }
        private void listar()
        {
            grvarea.DataSource = Area.listarArea();
            grvarea.DataBind();
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
           
           a.Nombre = txtarea.Text;
           Area.insertarArea(a);
           this.listar();
           this.limpiar();
        }
        private void limpiar()
        {
            txtarea.Text = "";
        }
    }
}