using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeProductos
{
    public class CalcularTotal
    {
        private readonly IProductos product;

        public CalcularTotal(IProductos PRODUCTOS)
        {
            this.product = PRODUCTOS;
        }

        public async Task<double> CalculateTotalAsync()
        {
            double total = 0;

            var producto = product.GetAll();

            Parallel.ForEach(producto, prod =>
            {
                total += prod.Price * prod.Cantidad;
            });

            return total;
        }
    }
}
