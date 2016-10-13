using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
     public class AreaBD
    {
         public static DataTable listarArea()
         {
             SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarArea");
             return AccesoDatos.datavirtual(sqlcmd);
         }
         public static int insertarArea(string nombre)
         {
             SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_insertArea");
             sqlcmd.Parameters.AddWithValue("@nomb", nombre);
          

             return AccesoDatos.ejecutarIUD(sqlcmd);
         }
    }
}
