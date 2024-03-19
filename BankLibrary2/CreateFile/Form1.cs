using BankLibrary2;

namespace CreateFile
{
    public partial class Form1 : BankUIForm
    {
        private FileRepository? _fileRepository;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("NOMBRE DEL ARCHIVO INVALIDO", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        _fileRepository = new FileRepository(fileName);
                        _fileRepository?.OpenOrCreateFile();

                        btnguardar.Enabled = false;
                        btningresar.Enabled = true;
                    }
                    catch (IOException eX)
                    {

                        MessageBox.Show(eX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string[] values = ObtenerValorTextBox();

            if (!string.IsNullOrEmpty(values[(int)TextBosIndices.Account])) 
            {
                try
                {
                    int numerocuenta = int.Parse(values[(int)TextBosIndices.Account]);

                    if (numerocuenta > 0)
                    {
                        var record = new Record(numerocuenta,
                            values[(int)TextBosIndices.First],
                            values[(int)TextBosIndices.Last],
                            decimal.Parse(values[(int)TextBosIndices.Balance]));

                        _fileRepository?.WriteRecordToFile(record);
                    }
                    else
                    {
                        MessageBox.Show("NUMERO DE CUENTA INVALIDO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (IOException ex)
                {

                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(FormatException)
                {
                    MessageBox.Show("Formato Invalido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}