using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoBufferedStream
{
    public class ProductBufferedRepository : IProductRepository
    {
        private string _productFile;

        public ProductBufferedRepository(string productFile)
        {
            _productFile = productFile;
        }
        public void Add(Producto product)
        {
            using(Stream fs = new FileStream(_productFile,FileMode.Append))          
            using (Stream bs = new BufferedStream(fs))
            using(StreamWriter sw = new StreamWriter(fs))
            {
               sw.WriteLine($"{product.id},{product.name},{product.price}");
            }
            
        }

        List<Producto> IProductRepository.GetAll()
        {          
            List<Producto> productos = new List<Producto>();
            using(Stream fs = new FileStream(_productFile,FileMode.Open))
             using(Stream bs = new BufferedStream(fs))
            using(StreamReader sr = new StreamReader(fs))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(",");
                    productos.Add(new Producto
                    {
                        id = int.Parse(parts[0]),
                        name = parts[1],
                        price = decimal.Parse(parts[2]),
                    });
                }
            }

            return productos;
        }
    }
}
