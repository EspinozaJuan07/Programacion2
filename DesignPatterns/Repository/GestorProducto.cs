using Repository;

public class GestorProducto
{
    private IProductoRepository _repository;

    public GestorProducto(IProductoRepository repository)
    {
        _repository = repository;
    }

    public List<Producto> ObtenerTodoslosProductos()
    {
        return _repository.GetAll();
    }

    public void AgregarProducto(Producto producto)
    {
        List<Producto> productos = _repository.GetAll();
        productos.Add(producto);
        _repository.GuardarTodos(productos);
    }
}