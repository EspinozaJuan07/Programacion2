using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductoRepositoryArchivo : IProductoRepository
    {
        private string _nombre;

        public ProductoRepositoryArchivo(string nombre)
        {
            _nombre = nombre;
        }

        public List<Producto> GetAll()
        {
            List<Producto> productos1 = new List<Producto>();
            try
            {
                using (StreamReader sr = new StreamReader(_nombre))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        Producto producto = new Producto()
                        {
                            Nombre = datos[0],
                            Precio = Convert.ToDecimal(datos[1]),
                        };
                        productos1.Add(producto);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error al selecionar el archivo: {e.Message}");
            }
            return productos1;
        }

        public void GuardarTodos(List<Producto> productos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_nombre))
                {
                    foreach (Producto producto in productos)
                    {
                        sw.WriteLine($"{producto.Nombre},{producto.Precio}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error al escribi en el archivo: {e.Message}");
            }
        }
    }
}
