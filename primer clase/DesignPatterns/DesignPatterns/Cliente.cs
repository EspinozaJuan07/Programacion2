using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Cliente
    {
        private ILectorDatos _lectordatos;

        public Cliente(ILectorDatos lectordatos) 
        { 
            _lectordatos = lectordatos;
        }

        public void RealizarAoperaciondeLectura()
        {
            string datos = _lectordatos.Leer();
            Console.WriteLine("Datos leidos: " + datos);
        }

    }
}
