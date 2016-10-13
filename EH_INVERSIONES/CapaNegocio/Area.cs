using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class Area
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
        public static DataTable listarArea()
        {
            return AreaBD.listarArea();
        }
        public static int insertarArea(Area a)
        {
            return AreaBD.insertarArea(a.Nombre);
        }
    }
}
