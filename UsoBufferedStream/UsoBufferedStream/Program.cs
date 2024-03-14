using UsoBufferedStream;

string archivoProductos = "productos.txt";

//Crear instancia del repsoitorio de productos
IProductRepository productoRepository = new ProductBufferedRepository(archivoProductos);

//Agregar Peoductos de ejemplo
productoRepository.Add(new Producto { id = 1, name = "Producto 1", price = 10.5m });
productoRepository.Add(new Producto { id = 2, name = "Producto 2", price = 20.75m });

//Mostrando los productos
Console.WriteLine("Todos los productos");
foreach (var product in productoRepository.GetAll())
{
    Console.WriteLine($"Id: {product.id}, Nombre: {product.name}, Precio: {product.price}");
}