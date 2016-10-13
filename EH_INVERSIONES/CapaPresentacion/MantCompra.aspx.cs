using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class MantCompra : System.Web.UI.Page
    {
        SqlConnection sqlcn = new SqlConnection("data source=localhost;initial catalog=BDVENTASEH08;integrated security=true;");
        SqlCommand sqlcmd;

        Compra c = new Compra();
        Usuario u = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                total();
                txtdocumento.Text = "FACTURA";
                txtdocumento.Enabled = false;
                cargaProd();
                listar();
                txtcodemp.Enabled = false;
                txtemp.Enabled = false;
                txtnrofact.Enabled = false;
                txtprecio.Enabled = false;
                this.cargaProve();

                if (Session["usersesion"] != null)
                {
      
                    u.User = Session["usersesion"].ToString();

                    // lblnom.Text = Session["usersesion"].ToString();
                    txtemp.Text = UsuNombreApe(u).ToString();
                    txtcodemp.Text = UsuCodigo(u).ToString();
                    
                    NumCompra();
                }
            }
        }
        private void total()
        {
            //    lbltotal.Text = grvdetatemp.Rows.Count.ToString();
            decimal suma = grvdetatemp.Rows.Cast<GridViewRow>().Sum(x => Convert.ToDecimal(x.Cells[5].Text));
            lbltotal.Text = suma.ToString("C");
        }
        private void cargaProve()
        {

            ddlprove.DataSource = Proveedor.listarProveedor();
            ddlprove.DataTextField = "nombre";
            ddlprove.DataValueField = "codprove";

            ddlprove.DataBind();

        }

        private void cargaProd()
        {

            ddlprod.DataSource = Producto.listarProductos();
            ddlprod.DataTextField = "nombre";
            ddlprod.DataValueField = "codproducto";

            ddlprod.DataBind();

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
                nombre = e.Nombre + ", " + e.Ape;
            }
            else
            {
                nombre = "";
            }
            sqlcn.Close();
            return nombre;
        }
        public int UsuCodigo(Usuario u)
        {
            int codigo = 0;

            Empleado e = null;
            sqlcmd = new SqlCommand("SP_DatosUsu2", sqlcn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@nomUser", u.User);
            sqlcn.Open();
            SqlDataReader dr = sqlcmd.ExecuteReader();
            if (dr.Read())
            {
                e = new Empleado();
                e.Codigo = Convert.ToInt32(dr[0]);
                codigo = e.Codigo;

            }
            else
            {
                codigo = 0;
            }
            sqlcn.Close();
            return codigo;
        }
        private void NumCompra()
        {
            sqlcmd = new SqlCommand("sp_numcompra", sqlcn);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            //string query = "select precio,stock from Producto WHERE codproducto = @id";
            // SqlCommand cmd = new SqlCommand(query, sqlcn);

            // cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ddlprod.SelectedValue));
            sqlcn.Open();
            SqlDataReader dr = sqlcmd.ExecuteReader();
            if (dr.Read())
            {

                txtnrofact.Text = dr[0].ToString();


            }
            sqlcn.Close();
        }
        //private void cargapro()
        //{

        //    sqlcmd = new SqlCommand("sp_listaProdNombre", sqlcn);
        //    sqlcmd.CommandType = CommandType.StoredProcedure;
        //    sqlcmd.Parameters.AddWithValue("@cod", Convert.ToInt32(ddlprove.SelectedValue));
        //    //string query = "select precio,stock from Producto WHERE codproducto = @id";
        //    // SqlCommand cmd = new SqlCommand(query, sqlcn);

        //    // cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ddlprod.SelectedValue));

        //    sqlcn.Open();
        //    SqlDataReader dr = sqlcmd.ExecuteReader();
        //    if (dr.Read())
        //    {


        //        ddlprod.DataSource = Producto.listarProductos();
        //        ddlprod.DataTextField = "nombre";
        //        ddlprod.DataValueField = "codproducto";

        //        ddlprod.DataBind();
              

        //    }
        //    sqlcn.Close();
        //}



        private void CargaProductPrecio()
        {

            sqlcmd = new SqlCommand("sp_listaProductPrecio", sqlcn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@cod", Convert.ToInt32(ddlprod.SelectedValue));
            //string query = "select precio,stock from Producto WHERE codproducto = @id";
            // SqlCommand cmd = new SqlCommand(query, sqlcn);

            // cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ddlprod.SelectedValue));

            sqlcn.Open();
            SqlDataReader dr = sqlcmd.ExecuteReader();
            if (dr.Read())
            {

                txtprecio.Text = dr[0].ToString();
        


            }
            sqlcn.Close();
        }



        private void GrabarCabe()
        {
            c.Codemp = Convert.ToInt32(txtcodemp.Text);
            c.Codprove = Convert.ToInt32(ddlprove.SelectedValue);
            c.Documento = txtdocumento.Text;

            Compra.insertaCabecera(c);
            NumCompra();
        }




        protected void btngrabar_Click1(object sender, EventArgs e)
        {
            this.GrabarCabe();
        }



        protected void ddlprod_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaProductPrecio();
        }

        protected void btngrabardeta_Click(object sender, EventArgs e)
        {
            c.Codcompra = Convert.ToInt32(txtnrofact.Text);
            c.Codpro = Convert.ToInt32(ddlprod.SelectedValue);
            c.Cant = Convert.ToInt32(txtcant.Text);
            c.Precio = Convert.ToDecimal(txtprecio.Text);
            Compra.insertaDetalle(c);
            Compra.insertaDetalle_temporal(c);
            listar();
          
        }

        private void listar()
        {
            grvdetatemp.DataSource = Compra.listarTemporal();
            grvdetatemp.DataBind();
            total();
        }

        protected void btnnew_Click(object sender, EventArgs e)
        {
            Compra.eliminar_temporal();
            listar();
        }



    }
}