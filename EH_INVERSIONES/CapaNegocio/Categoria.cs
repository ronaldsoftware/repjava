using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
     public class Categoria
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string des;

        public string Des
        {
            get { return des; }
            set { des = value; }
        }
        public static int insertarCategorias(Categoria c)
        {
            return CategoriaBD.insertarCategoria(c.Des);
        }
        public static int actualizarCategorias(Categoria c)
        {
            return CategoriaBD.actualizarCategoria(c.Codigo,c.Des);
        }
        public static DataTable listarCategorias()
        {
            return CategoriaBD.listarCategoria();
        }
    }
}
