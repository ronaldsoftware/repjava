using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Empleado
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
        private string ape;

        public string Ape
        {
            get { return ape; }
            set { ape = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
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
        private string dire;

        public string Dire
        {
            get { return dire; }
            set { dire = value; }
        }
        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private int codcargo;

        public int Codcargo
        {
            get { return codcargo; }
            set { codcargo = value; }
        }
        public static DataTable listarEmpleados()
        {
            return EmpleadoBD.listarEmpleado();
        }
        public static DataTable CargaEmpleados()
        {
            return EmpleadoBD.CargaEmpleado();
        }
        public static int insertarEmpleados(Empleado e)
        {
            return EmpleadoBD.insertarEmpleado(e.Nombre,e.Ape,e.Fecha,e.Dni,e.Telef,e.Cel,e.Dire,e.Correo,e.Codcargo);
        }
    }
}
