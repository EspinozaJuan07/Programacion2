using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoBufferedStream
{
    public interface IProductRepository
    {
        void Add(Producto product);

        List<Producto> GetAll();

    }
}
