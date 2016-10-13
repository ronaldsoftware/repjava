using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
     public class Factura
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private int codemp;

        public int Codemp
        {
            get { return codemp; }
            set { codemp = value; }
        }
        private int codcli;

        public int Codcli
        {
            get { return codcli; }
            set { codcli = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private decimal subtotal;

        public decimal Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        private decimal igv;

        public decimal Igv
        {
            get { return igv; }
            set { igv = value; }
        }
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        private int codprod;

        public int Codprod
        {
            get { return codprod; }
            set { codprod = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private int cant;

        public int Cant
        {
            get { return cant; }
            set { cant = value; }
        }

        private decimal importe;

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public static DataTable listarProdu()
        {
            return FacturaBD.listarProdu();
        }
        public static int insertaCabeceras(Factura f)
        {
            return FacturaBD.insertaCabecera(f.Codemp,f.Codcli);
        }
        public static int insertaDetalles(Factura f)
        {
            return FacturaBD.insertaDetalle(f.Codigo,f.Codprod,f.Precio,f.Cant);
        }
        public static int insertaDetalleTemporal(Factura f)
        {
            return FacturaBD.insertaDetalleTemporal(f.Codigo, f.Codprod, f.Precio, f.Cant);
        }
        public static DataTable listarDetaTemp()
        {
            return FacturaBD.listarDetaTemp();
        }
        public static int eliminarTemporale()
        {
            return FacturaBD.eliminarTemporal();
        }
        public static DataTable listarFacturas()
        {
            return FacturaBD.listarFacturas();
        }
        public static int insertaPago(Factura f)
        {
            return FacturaBD.insertaPago(f.Codigo, f.Importe);
        }
    }
}
