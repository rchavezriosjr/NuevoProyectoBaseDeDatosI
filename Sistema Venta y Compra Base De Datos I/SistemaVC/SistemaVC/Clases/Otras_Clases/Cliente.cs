using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVC
{
    public class Cliente
    {
        private int C_id;
        private string C_nomb;
        private string C_domi;
        private string C_tel;
        private string C_ema;

        public int C_Id
        {
            get { return C_id; }
            set { C_id = value; }
        }

        public string C_Nombre
        {
            get { return C_nomb; }
            set { C_nomb = value; }
        }

        public string C_Domicilio
        {
            get { return C_domi; }
            set { C_domi = value; }
        }

        public string C_Telefono
        {
            get { return C_tel; }
            set { C_tel = value; }
        }

        public string C_Email
        {
            get { return C_ema; }
            set { C_ema = value; }
        }

        public Cliente()
        {
        }

        public Cliente(int id, string nombre, string domicilio, string telefono, string email)
        {
            C_id = id;
            C_nomb = nombre;
            C_domi = domicilio;
            C_tel = telefono;
            C_ema = email;
        }
    }
}