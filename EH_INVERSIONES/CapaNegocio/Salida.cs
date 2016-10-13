using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
     public class Salida

    {
        private string serie;

        public string Serie
        {
            get { return serie; }
            set { serie = value; }
        }
        private string descripcion;

        public string Des
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public static DataTable listarSalidas()
        {
            return SalidaBD.listarSalida();
        }
        public static int insertarSalidas(Salida sa)
        {
            return SalidaBD.insertarSalida(sa.Serie,sa.Des);
        }
        public static DataTable listarProductos()
        {
            return ProductoBD.listarProducto();
        }
    }
}
