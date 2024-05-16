using System.Xml.Linq;

namespace GestionDeProductos
{
    public partial class Form1 : Form
    {
        private readonly IProductos ProductosRepository;
        private readonly CalcularTotal CalcularTotal;
        private readonly ProductosRepository ProductsRepository;
        public Form1()
        {
            InitializeComponent();
            ProductsRepository = new ProductosRepository();
            CalcularTotal = new CalcularTotal(ProductsRepository);
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            ProductosRepository prodrep = new ProductosRepository();
            Productos product = new Productos
            {
                Name = txtproducto.Text,
                Price = Convert.ToDouble(txtprecio.Text),
                Cantidad = Convert.ToInt32(txtcantidad.Text),
                Total = Convert.ToDecimal(txtprecio.Text) * Convert.ToDecimal(txtcantidad.Text)
            };
            ProductsRepository.Add(product);
            dataGridView1.DataSource = ProductsRepository.GetAll().ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Productos produ = new Productos
            {
                Name = txtproducto.Text,
                Price = Convert.ToDouble(txtprecio.Text),
                Cantidad = Convert.ToInt32(txtcantidad.Text),
                Total = Convert.ToDecimal(txtprecio.Text) * Convert.ToDecimal(txtcantidad.Text)
            };
            List<Productos> list = new List<Productos>();
            list.Add(produ);

            ProductsRepository.Save(list);
        }

        private async void BtnCalculate_Click(object sender, EventArgs e)
        {
            double total = await CalcularTotal.CalculateTotalAsync();
            MessageBox.Show($"El salario total es: {total}");
        }
    }
}
