using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Login : System.Web.UI.Page
    {
        Usuario ou = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
  
        }
        private void login1()
        {
            ou.User = txtusu.Text;
            ou.Contra = txtpass.Text;
            ou.Cpermi = 1;
            if (Usuario.validar(ou) == true)
            {
                Response.Redirect("HomeAlmacen.aspx");
            }

        }

        private void login2()
        {
            ou.User = txtusu.Text;
            ou.Contra = txtpass.Text;
            ou.Cpermi = 2;
            if (Usuario.validar(ou) == true)
            {
                Response.Redirect("HomeVentas.aspx");
            }
        }
            private void login3()
            {
                ou.User = txtusu.Text;
                ou.Contra = txtpass.Text;
                ou.Cpermi = 3;
                if (Usuario.validar(ou) == true)
                {
                    Session["usersesion"] = txtusu.Text;
                    Response.Redirect("HomeCaja.aspx");
                   
                }
            }
            private void login4()
            {
                ou.User = txtusu.Text;
                ou.Contra = txtpass.Text;
                ou.Cpermi = 4;
                if (Usuario.validar(ou) == true)
                {
                    Session["usersesion"] = txtusu.Text;
                    Response.Redirect("HomeCompras.aspx");
                }
            }
            private void login5()
            {
                ou.User = txtusu.Text;
                ou.Contra = txtpass.Text;
                ou.Cpermi = 5;
                if (Usuario.validar(ou) == true)
                {
                    Response.Redirect("HomeLocal.aspx");
                }
            }
            private void login6()
            {
                ou.User = txtusu.Text;
                ou.Contra = txtpass.Text;
                ou.Cpermi = 6;
                if (Usuario.validar(ou) == true)
                {
                    Response.Redirect("HomeRH.aspx");
                }
            }
            private void login7()
            {
                ou.User = txtusu.Text;
                ou.Contra = txtpass.Text;
                ou.Cpermi = 7;
                if (Usuario.validar(ou) == true)
                {
                    Response.Redirect("HomeAdminSis.aspx");
                }
            }


            protected void btnLogin_Click(object sender, EventArgs e)
            {
                this.login1();
                this.login2();
                this.login3();
                this.login4();
                this.login5();
                this.login6();
                this.login7();
            }

        }

               
    }
           

        



