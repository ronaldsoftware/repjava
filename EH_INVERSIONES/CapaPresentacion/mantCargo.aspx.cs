using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
   
    public partial class mantCargo : System.Web.UI.Page
    {
        Cargo ca = new Cargo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlarea.DataSource = Area.listarArea();
                ddlarea.DataTextField = "nombre";
                ddlarea.DataValueField = "codarea";
                ddlarea.DataBind();
            }
            this.listar();


        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            ca.Nombre = txtnom.Text;
            ca.Codar = Convert.ToInt32(ddlarea.SelectedValue);
          
            Cargo.insertarCargo(ca);
            txtnom.Text = "";
            this.listar();
        }
        private void listar()
        { 
           grvcargo.DataSource = Cargo.listarCargos();
            grvcargo.DataBind(); 
        }
    }
}