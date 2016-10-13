using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
     public class Compra
    {
        private int codcompra;

        public int Codcompra
        {
            get { return codcompra; }
            set { codcompra = value; }
        }
        private int codpro;

        public int Codpro
        {
            get { return codpro; }
            set { codpro = value; }
        }
        private int cant;

        public int Cant
        {
            get { return cant; }
            set { cant = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private int codemp;

        public int Codemp
        {
            get { return codemp; }
            set { codemp = value; }
        }
        private int codprove;

        public int Codprove
        {
            get { return codprove; }
            set { codprove = value; }
        }
        private string documento;

        public string Documento
        {
            get { return documento; }
            set { documento = value; }
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
        public static DataTable listarProdu()
        {
            return CompraBD.listarProdu();
        }
        public static int insertaCabecera(Compra c)
        {
            return CompraBD.insertaCabecera(c.Codemp,c.Codprove,c.Documento);
        }
        public static int insertaDetalle(Compra c)
        {
            return CompraBD.insertaDetalle(c.Codcompra,c.Codpro,c.Cant,c.Precio);
        }
        public static int insertaDetalle_temporal(Compra c)
        {
            return CompraBD.insertaDetalle_temporal(c.Codcompra, c.Codpro, c.Cant, c.Precio);
        }
        public static DataTable listarTemporal()
        {
            return CompraBD.listarTemporal();
        }
        public static int eliminar_temporal()
        {
            return CompraBD.eliminar_temporal();
        }
    }
}
