using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeProductos
{
    public interface IProductos
    {
        IEnumerable<Productos> GetAll();
        void Save(IEnumerable<Productos> productos);
        void Add(Productos productos);
    }
}
