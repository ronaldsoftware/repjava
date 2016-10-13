using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
     public class FacturaBD
    {
         public static DataTable listarProdu()
         {
             SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listaProd");
             return AccesoDatos.datavirtual(sqlcmd);
         }
         public static DataTable listarFacturas()
         {
             SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarDetaTempoPDFOFICIAL2");
             return AccesoDatos.datavirtual(sqlcmd);
         }
         public static DataTable listarDetaTemp()
         {
             SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarDetaFactTemp");
             return AccesoDatos.datavirtual(sqlcmd);
         }
         public static int insertaCabecera(int codemp, int codcli)
         {
             SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_cabefact");
             sqlcmd.Parameters.AddWithValue("@codemp", codemp);
             sqlcmd.Parameters.AddWithValue("@codclient", codcli);

             return AccesoDatos.ejecutarIUD(sqlcmd);
         }
         public static int insertaDetalle(int nrofact, int codpro, decimal precio, int cant)
         {
             SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_detafactsubtotal");
             sqlcmd.Parameters.AddWithValue("@nrofact", nrofact);
             sqlcmd.Parameters.AddWithValue("@codpro", codpro);
             sqlcmd.Parameters.AddWithValue("@precio", precio);
             sqlcmd.Parameters.AddWithValue("@cant", cant);

             return AccesoDatos.ejecutarIUD(sqlcmd);
         }
         public static int insertaPago(int nrofact, decimal importe)
         {
             SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_ImportarPagoTotal");
             sqlcmd.Parameters.AddWithValue("@nrofactura", nrofact);
             sqlcmd.Parameters.AddWithValue("@importe", importe);
        

             return AccesoDatos.ejecutarIUD(sqlcmd);
         }
         public static int insertaDetalleTemporal(int nrofact, int codpro, decimal precio, int cant)
         {
             SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_detafactsubtotal_temporal2");
             sqlcmd.Parameters.AddWithValue("@nrofact", nrofact);
             sqlcmd.Parameters.AddWithValue("@codpro", codpro);
             sqlcmd.Parameters.AddWithValue("@precio", precio);
             sqlcmd.Parameters.AddWithValue("@cant", cant);

             return AccesoDatos.ejecutarIUD(sqlcmd);
         }
         public static int eliminarTemporal()
         {
             SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_eliminarTemporal");
     
            
             return AccesoDatos.ejecutarIUD(sqlcmd);
         }
    }
}
