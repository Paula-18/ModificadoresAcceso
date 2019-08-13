using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Cuenta
    {
        public Cliente Propetario { get; set; }
        public float Saldo { get; set; }

        private string _identificador;
        public string Identificador
        {
            get
            {
                return _identificador;
            }
            set
            {
                if(value.Length == 10 || value.Length == 11 || value.Length == 12 || value.Length == 13 || value.Length == 14)
                {
                    _identificador = value;
                }
                else
                {
                    throw new Exception("No es de 10 a 14 caracteres");
                }
            }
        }



    }
}
