using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public  class BoletaBD
    {
        public static DataTable listarProdu()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listaProd");
            return AccesoDatos.datavirtual(sqlcmd);
        }
        public static DataTable listarBoletas()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarDetaTempoPDFOFICIAL2");
            return AccesoDatos.datavirtual(sqlcmd);
        }
        public static DataTable listarDetaTemp()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listaBoletaTemporal");
            return AccesoDatos.datavirtual(sqlcmd);
        }
        public static int insertaCabecera(int codcli,int codemp)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_cabeBole");
            sqlcmd.Parameters.AddWithValue("@codclient", codcli);
            sqlcmd.Parameters.AddWithValue("@codemp", codemp);

            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static int insertaDetalle(int nrobol, int codpro, decimal precio, int cant)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_detaBoletaTotal");
            sqlcmd.Parameters.AddWithValue("@nroboleta", nrobol);
            sqlcmd.Parameters.AddWithValue("@codpro", codpro);
            sqlcmd.Parameters.AddWithValue("@precio", precio);
            sqlcmd.Parameters.AddWithValue("@cant", cant);

            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static int insertaDetalleTemporal(int nrofact, int codpro, decimal precio, int cant)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_detaBoletaTotal_temporal2");
            sqlcmd.Parameters.AddWithValue("@nroboleta", nrofact);
            sqlcmd.Parameters.AddWithValue("@codpro", codpro);
            sqlcmd.Parameters.AddWithValue("@precio", precio);
            sqlcmd.Parameters.AddWithValue("@cant", cant);

            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static int eliminarTemporal()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_eliminarboleTempo");
            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static int insertaPago(int nrobol, decimal importe)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_ImportarPagoTotalBoleta");
            sqlcmd.Parameters.AddWithValue("@nroboleta", nrobol);
            sqlcmd.Parameters.AddWithValue("@importe", importe);


            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
    }
}
