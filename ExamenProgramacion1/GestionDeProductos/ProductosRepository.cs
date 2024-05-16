using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GestionDeProductos
{
    public class ProductosRepository : IProductos
    {
        private List<Productos> producto;
        private const string FILE_NAME = "Productos.txt";

        public ProductosRepository()
        {
            producto = LoadProductsfromFile();
        }
        public void Add(Productos productos)
        {
            producto.Add(productos);
        }

        public IEnumerable<Productos> GetAll()
        {
            return producto;
        }

        public void Save(IEnumerable<Productos> productos)
        {
            string json = JsonConvert.SerializeObject(producto, Newtonsoft.Json.Formatting.Indented);

            try
            {
                File.WriteAllText(FILE_NAME, json);
                MessageBox.Show("Datos de los productos guardados en el archivo " + FILE_NAME);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos de los productos: " + ex.Message);
            }
        }

        private List<Productos>? LoadProductsfromFile()
        {
            return new List<Productos>();
        }
    }
}
