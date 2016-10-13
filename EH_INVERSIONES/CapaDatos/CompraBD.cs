using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public  class CompraBD
    {
        public static DataTable listarProdu()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listaProdNombre");
            return AccesoDatos.datavirtual(sqlcmd);
        }
        public static DataTable listarTemporal()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarDetaCompraTemporales");
            return AccesoDatos.datavirtual(sqlcmd);
        }
        public static int insertaCabecera(int codemp, int codprov, string documento)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_cabeCompra");
            sqlcmd.Parameters.AddWithValue("@codemp", codemp);
            sqlcmd.Parameters.AddWithValue("@codprove", codprov);
            sqlcmd.Parameters.AddWithValue("@documento", documento);
            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static int insertaDetalle(int codcompra, int codpro, int cant,decimal precio)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_detaCompra");
            sqlcmd.Parameters.AddWithValue("@codcompra", codcompra);
            sqlcmd.Parameters.AddWithValue("@codpro", codpro);
            sqlcmd.Parameters.AddWithValue("@cant", cant);
            sqlcmd.Parameters.AddWithValue("@precio", precio);

            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static int insertaDetalle_temporal(int codcompra, int codpro, int cant, decimal precio)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_detaCompra_temporale");
            sqlcmd.Parameters.AddWithValue("@codcompra", codcompra);
            sqlcmd.Parameters.AddWithValue("@codpro", codpro);
            sqlcmd.Parameters.AddWithValue("@cant", cant);
            sqlcmd.Parameters.AddWithValue("@precio", precio);

            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static int eliminar_temporal()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_eliminarTemporalCompra");
            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
    }
}
