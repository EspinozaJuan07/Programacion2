using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public  class GestorProducto
    {
        private IproductoReposito _repository;
        public GestorProducto(IproductoReposito repository)
        {
            _repository = repository;
        }
        public List<Producto> ObtenertodoslosProductos()
        {
            return _repository.ObtenerTodos();

        }
        public void AgregarProducto (Producto producto)
        {
          List<Producto> productos = _repository.ObtenerTodos();
            productos.Add(producto);
            _repository.Guardartodos(productos);


        }


    
    }




}
