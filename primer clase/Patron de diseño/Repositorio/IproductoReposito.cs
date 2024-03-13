using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{// codigo repositorio de producto
    public  interface IproductoReposito
    {
        List<Producto> ObtenerTodos();
        void Guardartodos(List<Producto> productos);
    
    }
}

