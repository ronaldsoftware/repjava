using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class AccesoDatos : IDisposable
    {
        //Comando de consultas
        private SqlCommand sqlcmd = new SqlCommand();

        //Constructor
        public AccesoDatos()
        {
            SqlConnection sqlcn = new SqlConnection(Conexion.ConexionBD);
            sqlcmd.Connection = sqlcn;
            sqlcmd.CommandType = CommandType.StoredProcedure;

        }

        public object executesc()
        {
            object obj = null;
            sqlcmd.Connection.Open();
            obj = sqlcmd.ExecuteScalar();
            sqlcmd.Connection.Close();
            return obj;
        }

        public object executesc(string commandtext)
        {
            object obj = null;
            sqlcmd.CommandText = commandtext;
            obj = this.executesc();
            return obj;
        }

        //Metodo Parametros
        public void AddParameters(string pname, object pvalue)
        {
            SqlParameter pa = new SqlParameter(pname, pvalue);
            sqlcmd.Parameters.Add(pa);
        }

        public void AddParameters(IDataAdapter iparam)
        {
            sqlcmd.Parameters.Add(iparam);
        }

        public static int ejecutarIUD(SqlCommand sqlcmd)
        {
            int ok = 0;
            sqlcmd.Connection.Open();
            ok = sqlcmd.ExecuteNonQuery();
            return ok;
        }

        public static SqlCommand consultaStore(string store)
        {

            SqlConnection sqlcn = new SqlConnection(Conexion.ConexionBD);
            SqlCommand sqlcmd = new SqlCommand(store, sqlcn);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            return sqlcmd;
        }

        public static DataTable datavirtual(SqlCommand sqlcmd)
        {
            DataTable dt = new DataTable();
            sqlcmd.Connection.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            sqlda.Fill(dt);
            sqlcmd.Connection.Close();
            return dt;
        }

        public void Dispose()
        {
            this.sqlcmd.Dispose();
        }
    }
}
