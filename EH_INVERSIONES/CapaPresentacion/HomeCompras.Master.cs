using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using System.Data;
using System.Data.SqlClient;
namespace CapaPresentacion
{
    public partial class HomeCompras : System.Web.UI.MasterPage
    {
        SqlConnection sqlcn = new SqlConnection("data source=localhost;initial catalog=BDVENTASEH08;integrated security=true;");
        SqlCommand sqlcmd;

        Usuario u = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usersesion"] != null)
                {
                    u.User = Session["usersesion"].ToString();

                    // lblnom.Text = Session["usersesion"].ToString();
                    lblnom.Text = UsuNombreApe(u).ToString();
                }
            }
        }
                    public string UsuNombreApe(Usuario u)
        {
            string nombre = "";

            Empleado e = null;
            sqlcmd = new SqlCommand("SP_DatosUsu", sqlcn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@nomUser", u.User);
            sqlcn.Open();
            SqlDataReader dr = sqlcmd.ExecuteReader();
            if (dr.Read())
            {
                e = new Empleado();
                e.Nombre = dr[0].ToString();
                e.Ape = dr[1].ToString();
                nombre = e.Nombre +", "+ e.Ape;
            }
            else
            {
                nombre = "";
            }
            sqlcn.Close();
            return nombre;
        }
        }
    }
