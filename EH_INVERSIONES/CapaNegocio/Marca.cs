using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
     public class Marca
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

        public static DataTable listarMarcas()
        {
            return MarcaBD.listarMarca();
        }
        public static int insertarMarcas(Marca m)
        {
            return MarcaBD.insertarMarca(m.Nombre);
        }
        public static int actualizarMarcas(Marca m)
        {
            return MarcaBD.actualizarMarca(m.Codigo,m.Nombre);
        }
    }
}
