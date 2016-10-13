using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Precio
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private int codprove;

        public int Codprove
        {
            get { return codprove; }
            set { codprove = value; }
        }
        private int codprod;

        public int Codprod
        {
            get { return codprod; }
            set { codprod = value; }
        }
        private decimal precios;

        public decimal Precios
        {
            get { return precios; }
            set { precios = value; }
        }

        public static DataTable listarPrecio()
        {
            return PrecioBD.listarPrecio();
        }
        public static int insertarPrecio( Precio p)
        {
            return PrecioBD.insertarPrecio(p.Codprove,p.Codprod,p.Precios);
        }


    }
}
