namespace Ejercicio1
{
    public partial class Form1 : FileProcessed
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnprocesararchivo_Click(object sender, EventArgs e)
        {
            string fldpath = textBox1.Text.Trim();
            if(!Directory.Exists(fldpath))
            {
                MessageBox.Show("El directorio especificado no existe");
                return;
            }
            string[] files = Directory.GetFiles(fldpath, "ClasePractica.txt");
            foreach(string file in files)
            {
                
            }
        }
    }
}
