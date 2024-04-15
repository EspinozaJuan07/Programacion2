namespace Ejercicio_Threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            listBox1.Items.Clear();

            if (int.TryParse(textBox1.Text, out int n))
            {
                // Creamos un hilo para calcular los números primos
                Thread primeThread = new Thread(() => CalcularNumerosPrimos(n));
                primeThread.Start();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un rango válido de números enteros.");
            }
        }

        private void CalcularNumerosPrimos(int n)
        {
            List<int> primes = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            // Actualizamos el resultado en el hilo de la interfaz de usuario
            this.Invoke(new Action(() =>
            {
                foreach (int prime in primes)
                {
                    listBox1.Items.Add(prime + Environment.NewLine);
                }
            }));
        }

        private bool IsPrime(int x)
        {
            if (x <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }

            return true;
        }
    }
}
