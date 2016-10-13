using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
     public class Cargo
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
        private int codar;

        public int Codar
        {
            get { return codar; }
            set { codar = value; }
        }


        public static DataTable listarCargos()
        {
            return CargoBD.listarCargo();
        }
        public static int insertarCargo(Cargo c)
        {
            return CargoBD.insertarCargo(c.Nombre,c.Codar);
        }
    }
}
