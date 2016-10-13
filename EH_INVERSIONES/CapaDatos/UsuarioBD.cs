using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class UsuarioBD
    {
       public static bool validar(string usu, string pass, int cpermi)
       {
           bool ok = false;
           AccesoDatos ad = new AccesoDatos();
           ad.AddParameters("@usuario", usu);
           ad.AddParameters("@password", pass);
           ad.AddParameters("@codpermi", cpermi);
           int capValor = Convert.ToInt32(ad.executesc("USP_Login").ToString());
           if (capValor == 0)
           {
               ok = false;
           }
           else
           {
               ok = true;
           }

           return ok;
       }
       public static DataTable listarUsuario()
       {
           SqlCommand sqlcmd = AccesoDatos.consultaStore("usp_listaUsuarios");
           return AccesoDatos.datavirtual(sqlcmd);
       }
       public static int insertarUsuario(string nombre, string pass, int codemp, int codperm)
       {
           SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_insertUsuarios");
           sqlcmd.Parameters.AddWithValue("@nomb", nombre);
           sqlcmd.Parameters.AddWithValue("@pass", pass);
           sqlcmd.Parameters.AddWithValue("@codemp", codemp);
           sqlcmd.Parameters.AddWithValue("@codperm", codperm);
       
           return AccesoDatos.ejecutarIUD(sqlcmd);
       }

    }
}
