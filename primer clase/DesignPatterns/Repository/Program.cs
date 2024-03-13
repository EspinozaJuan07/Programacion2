using Repository;

// Ruta del archivo para almacenar productos

string archivoProductos = "productos.txt";

//crear una instancia del repositorio de productos
//utilizando el archivo

IProductoRepository productoRepository = new ProductoRepositoryArchivo(archivoProductos);

//crear instancia del gestor productos
//utilizando el repositorio

GestorProducto gestorproducto = new GestorProducto(productoRepository);

//Agregar algunos de ejemplo
gestorproducto.Agregarproducto(new Producto { Nombre = "Leche", Precio = 32m });
gestorproducto.Agregarproducto(new Producto { Nombre = "Cafe", Precio = 24m });

//mostrar los productos
Console.WriteLine("Todos los productos:");
foreach(var producto in gestorproducto.ObtenerTodosProductos())
{
    Console.WriteLine($"Nombre: {producto.Nombre}, " + $"Precio: {producto.Precio}");
}