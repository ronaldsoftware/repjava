using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Permiso
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
        public static DataTable listarPermisos()
        {
            return PermisoBD.listarPermiso();
        }
        public static int insertarPermisos(Permiso p)
        {
            return PermisoBD.insertarPermiso(p.Nombre);
        }
    }
}
