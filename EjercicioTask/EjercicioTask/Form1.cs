namespace EjercicioTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtresult.Enabled = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
        
        }

        private decimal Factorial(decimal x)
        {
            decimal result = 1;
            for (int i = 1; i <= x; i++)
            {
                result = result * i;
            }
            return result;          
        }
    }
}
