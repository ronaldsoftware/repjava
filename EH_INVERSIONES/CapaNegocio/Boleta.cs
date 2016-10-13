using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Boleta
    {
        private int nroboleta;

        public int Nroboleta
        {
            get { return nroboleta; }
            set { nroboleta = value; }
        }
        private int codproducto;

        public int Codproducto
        {
            get { return codproducto; }
            set { codproducto = value; }
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
        private int codcli;

        public int Codcli
        {
            get { return codcli; }
            set { codcli = value; }
        }
        private int codemp;

        public int Codemp
        {
            get { return codemp; }
            set { codemp = value; }
        }
        private decimal importe;

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }
        public static DataTable listarProdu()
        {
            return BoletaBD.listarProdu();
        }
        public static DataTable listarBoletas()
        {
            return BoletaBD.listarBoletas();
        }
        public static DataTable listarDetaTemp()
        {
            return BoletaBD.listarDetaTemp();
        }
        public static int insertaCabecera(Boleta b)
        {
            return BoletaBD.insertaCabecera(b.Codcli,b.Codemp);
        }
        public static int insertaDetalle(Boleta b)
        {
            return BoletaBD.insertaDetalle(b.Nroboleta,b.Codproducto,b.Precio,b.Cant);
        }
        public static int insertaDetalleTemporal(Boleta b)
        {
            return BoletaBD.insertaDetalleTemporal(b.Nroboleta, b.Codproducto, b.Precio, b.Cant);
        }
        public static int eliminarTemporal()
        {
            return BoletaBD.eliminarTemporal();
        }
        public static int insertaPago(Boleta b)
        {
            return BoletaBD.insertaPago(b.Nroboleta, b.Importe);
        }

    }
}
