namespace EjercicioTask
{
    public partial class Form1 : Form
    {
        private TaskScheduler _scheduler;
        public Form1()
        {
            InitializeComponent();
            _scheduler = TaskScheduler.FromCurrentSynchronizationContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtresult.Enabled = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int x;
            decimal result;
            x = Convert.ToInt32(maskedTextBox1.Text);
            result = Convert.ToDecimal(Factorial(x));

            txtresult.Text = result.ToString();
            new Task(() =>
            {
                Task[] tareas =
                {
                Task.Factory.StartNew(() => Factorial(x),
                CancellationToken.None,
                TaskCreationOptions.LongRunning,
                _scheduler),               
            };
                Task.WaitAll(tareas);

            }).Start();

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