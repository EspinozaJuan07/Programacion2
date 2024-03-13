using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GestorProducto
    {
        private IProductoRepository _repository;

        public GestorProducto(IProductoRepository repository)
        {
            _repository = repository;
        }

        public List<Producto> ObtenerTodosProductos() 
        { 
            return _repository.ObtenerTodos();
        }

        public void Agregarproducto(Producto producto) 
        {
            List<Producto> productos = _repository.ObtenerTodos();
            productos.Add(producto);
            _repository.GuardarTodos(productos);
        }

    }
}
