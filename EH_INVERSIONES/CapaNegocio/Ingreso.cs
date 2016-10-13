using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
     public class Ingreso
    {
        private string serie;

        public string Serie
        {
            get { return serie; }
            set { serie = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private int codprove;

        public int Codprove
        {
            get { return codprove; }
            set { codprove = value; }
        }
        public static DataTable listarIngreso()
        {
            return IngresoBD.listarIngreso();
        }
        public static int insertarIngreso(Ingreso i)
        {
            return IngresoBD.insertarIngreso(i.Serie,i.Descripcion,i.Codprove);
        }
        public static DataTable listarProductos()
        {
            return ProductoBD.listarProducto();
        }
    }
}
