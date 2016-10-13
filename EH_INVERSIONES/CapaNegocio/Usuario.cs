using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class Usuario
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }


        private string contra;

        public string Contra
        {
            get { return contra; }
            set { contra = value; }
        }
        private int cpermi;

        public int Cpermi
        {
            get { return cpermi; }
            set { cpermi = value; }
        }

        private int codemp;

        public int Codemp
        {
            get { return codemp; }
            set { codemp = value; }
        }


        public static bool validar(Usuario us)
        {
            return UsuarioBD.validar(us.User,us.Contra,us.Cpermi);
        }
        public static DataTable listarUsuarios()
        {
            return UsuarioBD.listarUsuario();
        }
        public static int insertarUsuarios(Usuario us)
        {
            return UsuarioBD.insertarUsuario(us.User,us.Contra,us.Codemp,us.Cpermi);
        }

    }
}
