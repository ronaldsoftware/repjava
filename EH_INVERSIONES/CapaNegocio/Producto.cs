using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public  class Producto
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        private int codm;

        public int Codm
        {
            get { return codm; }
            set { codm = value; }
        }
        private int codc;

        public int Codc
        {
            get { return codc; }
            set { codc = value; }
        }
        public static int insertarProductos(Producto p)
        {
            return ProductoBD.insertarProducto(p.Nombre,p.Precio,p.Stock,p.Codm,p.Codc);
        }
        public static DataTable listarProductos()
        {
            return ProductoBD.listarProducto();
        }
        public static DataTable FiltrarProducto(Producto p)
        {
            return ProductoBD.FiltrarProducto(p.Nombre);
        }
    }
}
