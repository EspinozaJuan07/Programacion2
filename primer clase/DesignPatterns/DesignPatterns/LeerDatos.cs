using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class LeerDatos : ILectorDatos
    {
        public string Leer() 
        {
            return "Datos extraidos de la fuente";      
        }
    }
}
