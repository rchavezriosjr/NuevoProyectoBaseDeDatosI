using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class Proveedor
    {
        private int P_id;
        private string P_nomb;
        private string P_domi;
        private string P_tel;
        private string P_ema;

        public int P_Id
        {
            get { return P_id; }
            set { P_id = value; }
        }

        public string P_Nombre
        {
            get { return P_nomb; }
            set { P_nomb = value; }
        }

        public string P_Domicilio
        {
            get { return P_domi; }
            set { P_domi = value; }
        }

        public string P_Telefono
        {
            get { return P_tel; }
            set { P_tel = value; }
        }

        public string P_Email
        {
            get { return P_ema; }
            set { P_ema = value; }
        }

        public Proveedor()
        {
        }

        public Proveedor(int id, string nombre, string domicilio, string telefono, string email)
        {
            P_id = id;
            P_nomb = nombre;
            P_domi = domicilio;
            P_tel = telefono;
            P_ema = email;
        }

    }
}
