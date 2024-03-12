using Repository;

//Ruta del archivo
string archivoProductos = "productos.txt";

//Crear una instancia del repositorio de producto
IProductoRepository productoRepository = new ProductoRepositoryArchivo(archivoProductos);

//Crear una instancia del gestor de productos utilizando el repositorio 
GestorProducto gestorProducto = new GestorProducto(productoRepository);

//Agregar algunos productos de ejemplo
gestorProducto.AgregarProducto(new Producto {Nombre = "Coca Cola 2lts", Precio = 45m });
gestorProducto.AgregarProducto(new Producto { Nombre = "Centrolac", Precio = 50m });

//Mostrar todos los productos
Console.WriteLine("Todos los productos");
foreach (var product in gestorProducto.ObtenerTodoslosProductos())
{
    Console.WriteLine($"Nombre: {product.Nombre}, " + $"Precio: {product.Precio}");
}

