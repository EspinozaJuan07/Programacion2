using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Repositorio
{
    public class ProductoRepositoryArchivo : IproductoReposito
    {
        private string _nombreArchivo;
        public ProductoRepositoryArchivo(string nombreArchivo) {
            _nombreArchivo = nombreArchivo;
            }
        public void Guardartodos(List<Producto> productos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_nombreArchivo))
                {
                    foreach (Producto producto in productos)
                    {
                        sw.WriteLine($"{producto.Nombre},{producto.Precio}");
                    }
                }
            }
            catch (IOException e )
            {
                Console.WriteLine("Error al escribir ", "el archivo "+e.Message);
                throw;
            }
                throw new NotImplementedException();

        }

        public List<Producto> ObtenerTodos()
        {
           List<Producto>productos = new List<Producto>();
            try
            {
                using (StreamReader sr = new StreamReader(_nombreArchivo))
                {

                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        Producto producto = new Producto()
                        {
                            Nombre = datos[0],
                            Precio = Convert.ToDecimal(datos[1])
                        };

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }  

                


                return productos;
                throw new NotImplementedException();
        }
    }

}
