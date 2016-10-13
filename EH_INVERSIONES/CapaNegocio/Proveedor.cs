using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
     public class Proveedor
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nomb;

        public string Nomb
        {
            get { return nomb; }
            set { nomb = value; }
        }
        private string ruc;

        public string Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }
        private string dir;

        public string Dir
        {
            get { return dir; }
            set { dir = value; }
        }
        private string corr;

        public string Corr
        {
            get { return corr; }
            set { corr = value; }
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
        public static int insertarPproveedor( Proveedor p)
        {
            return ProveedorBD.insertarPproveedor(p.Nomb,p.Ruc,p.Dir,p.Corr,p.Telef,p.Cel);
        }
 
        public static DataTable listarProveedor()
        {
            return ProveedorBD.listarProveedor();
        }
    }
}
