using Repositorio;
//ruta del archivo
string archivoProductos = "productos.txt";

//crear una instancia del repositorio
IproductoReposito productoRepository = new ProductoRepositoryArchivo(archivoProductos);

GestorProducto gestorproductos = new GestorProducto(productoRepository);

gestorproductos.AgregarProducto(new Producto { Nombre = "azucar ", Precio = 16m });
gestorproductos.AgregarProducto(new Producto { Nombre = "Queso ", Precio = 66m });
// mostrar producto
Console.WriteLine("todos los productos;");
foreach (var producto in gestorproductos.ObtenertodoslosProductos()) 
Console.WriteLine($"Nombre: {producto.Nombre}, precio: {producto.Precio}");





