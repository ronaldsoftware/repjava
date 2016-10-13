using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class EmpleadoBD
    {
        public static DataTable listarEmpleado()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarEmpleados");
            return AccesoDatos.datavirtual(sqlcmd);
        }
        public static int insertarEmpleado(string nombre, string ape, string fecha, string dni, string telef,string cel ,string dire, string correo, int codcargo)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("insertEmpleado");
            sqlcmd.Parameters.AddWithValue("@nomb", nombre);
            sqlcmd.Parameters.AddWithValue("@ape", ape);
            sqlcmd.Parameters.AddWithValue("@feching", fecha);
            sqlcmd.Parameters.AddWithValue("@dni", dni);
            sqlcmd.Parameters.AddWithValue("@telef", telef);
            sqlcmd.Parameters.AddWithValue("@cel", cel);
            sqlcmd.Parameters.AddWithValue("@dire", dire);
            sqlcmd.Parameters.AddWithValue("@correo", correo);
            sqlcmd.Parameters.AddWithValue("@codcargo", codcargo);
            

            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static DataTable CargaEmpleado()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_CargaEmpleados");
            return AccesoDatos.datavirtual(sqlcmd);
        }
    }
}
