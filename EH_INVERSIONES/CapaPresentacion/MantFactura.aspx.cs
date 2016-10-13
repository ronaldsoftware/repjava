using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CapaNegocio;
using CapaDatos;
namespace CapaPresentacion
{
    public partial class MantFactura : System.Web.UI.Page
    {
       
        SqlConnection sqlcn = new SqlConnection("data source=localhost;initial catalog=BDVENTASEH08;integrated security=true;");
        SqlCommand sqlcmd;

        Factura fa = new Factura();
        Usuario u = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {

                total();
                txtprecio.Enabled = false;
                txtstock.Enabled = false;
                txtnrofact.Enabled = false;
                txtemp.Enabled = false;
                txtcodemp.Enabled = false;
                cargaProd();
                
                this.listartemp();
                this.cargapreStock();
                this.NumFact();
                this.cargaCliente();

                if (Session["usersesion"] != null)
                {
                    u.User = Session["usersesion"].ToString();

                    // lblnom.Text = Session["usersesion"].ToString();
                    txtemp.Text = UsuNombreApe(u).ToString();
                    txtcodemp.Text = UsuCodigo(u).ToString();
                    
                }
            }
           
        }
        private void total()
        {
        //    lbltotal.Text = grvdetatemp.Rows.Count.ToString();
            decimal suma = grvdetatemp.Rows.Cast<GridViewRow>().Sum(x => Convert.ToDecimal(x.Cells[5].Text));
            lbltotal.Text = suma.ToString();
        }

        private void cargaProd()
        {
            
            ddlprod.DataSource = Factura.listarProdu();
            ddlprod.DataTextField = "nombre";
            ddlprod.DataValueField = "codproducto";
            
            ddlprod.DataBind();

        }

        private void cargaCliente()
        {

            ddlcliente.DataSource = Cliente.listarClientes();
            ddlcliente.DataTextField = "nombre";
            ddlcliente.DataValueField = "codclient";

            ddlcliente.DataBind();

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
        //private void cargaProd2()
        //{


        //    string precio = ddlprod.SelectedValue = "nombre".ToString();

        //    //ASIGNACION DE LAS VARIABLES A LOS TEXTBOX 
        //    //txtBox1.Text = sNombre;
        //    //txtBox2.Text = sApellidoPat;
        //    //txtBox3.Text = sApellidoMat; 

        //}

        private void cargapreStock()
        {
           
            sqlcmd = new SqlCommand("sp_listarPrecioStock", sqlcn);
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
                txtstock.Text = dr[1].ToString();

            }
            sqlcn.Close();
        }
        protected void ddlprod_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargapreStock();
            

        }
        private void NumFact()
        {
            sqlcmd = new SqlCommand("sp_numroFactura", sqlcn);
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
        private void GrabarCabe()
        {
            fa.Codemp = Convert.ToInt32(txtcodemp.Text);
            fa.Codcli = Convert.ToInt32(ddlcliente.SelectedValue);
            Factura.insertaCabeceras(fa);
            this.NumFact();
        }
        protected void btngrabar_Click(object sender, EventArgs e)
        {
            this.GrabarCabe();
        }

        protected void btngrabardeta_Click(object sender, EventArgs e)
        {
            fa.Codigo = Convert.ToInt32(txtnrofact.Text);
            fa.Codprod = Convert.ToInt32(ddlprod.SelectedValue);
            fa.Precio = Convert.ToDecimal(txtprecio.Text);
            fa.Cant = Convert.ToInt32(txtcant.Text);
            Factura.insertaDetalles(fa);
            Factura.insertaDetalleTemporal(fa);
            this.cargapreStock();
            this.listartemp();
        }

        private void listartemp()
        {
            grvdetatemp.DataSource = FacturaBD.listarDetaTemp();
            grvdetatemp.DataBind();
            total();
        }

        protected void btnpdf_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reporte.aspx");
        }

        protected void btnnew_Click(object sender, EventArgs e)
        {
            Factura.eliminarTemporale();
            listartemp();
        }

        protected void btnimp_Click(object sender, EventArgs e)
        {
            fa.Codigo = Convert.ToInt32(txtnrofact.Text);
            fa.Importe = Convert.ToDecimal(txtimporte.Text);
            Factura.insertaPago(fa);

            decimal importe, vuelto, totale;

            


            importe = Convert.ToDecimal(txtimporte.Text);
            totale = Convert.ToDecimal(lbltotal.Text);
            vuelto = importe - totale;

            lblvuelto.Text = vuelto.ToString();

            lbltotal.Text = totale.ToString("C");
            lblimporte.Text = importe.ToString("C");
            lblvuelto.Text = vuelto.ToString("C");



        }


    }
}