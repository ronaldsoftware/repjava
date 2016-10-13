using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
     public class Cliente
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
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private string telef;

        public string Telef
        {
            get { return telef; }
            set { telef = value; }
        }
        private string cel;

        public string Cel
        {
            get { return cel; }
            set { cel = value; }
        }
        private string dir;

        public string Dir
        {
            get { return dir; }
            set { dir = value; }
        }
        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public static DataTable listarClientes()
        {
            return ClienteBD.listarCliente();
        }
        public static int insertarClientes(Cliente c)
        {
            return ClienteBD.insertarCliente(c.Nombre,c.Apellido,c.Dni,c.Telef,c.Cel,c.Dir,c.Correo);
        }
        public static DataTable FiltarClientes(Cliente c)
        {
            return ClienteBD.FiltrarCliente(c.Dni);
        }
     }
}
