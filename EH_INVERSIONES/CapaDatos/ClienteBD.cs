using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class ClienteBD
    {
        public static DataTable listarCliente()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarClientes");
            return AccesoDatos.datavirtual(sqlcmd);
        }
        public static int insertarCliente(string nombre, string ape, string dni, string telef, string cel, string dire, string correo)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_insertCliente");
            sqlcmd.Parameters.AddWithValue("@nomb", nombre);
            sqlcmd.Parameters.AddWithValue("@ape", ape);
            sqlcmd.Parameters.AddWithValue("@dni", dni);
            sqlcmd.Parameters.AddWithValue("@telef", telef);
            sqlcmd.Parameters.AddWithValue("@cel", cel);
            sqlcmd.Parameters.AddWithValue("@dir", dire);
            sqlcmd.Parameters.AddWithValue("@correo", correo);
        


            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static DataTable FiltrarCliente(string dni)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_filtroClientes");
            sqlcmd.Parameters.AddWithValue("@dni", dni);
            return AccesoDatos.datavirtual(sqlcmd);
        }
    }
}
