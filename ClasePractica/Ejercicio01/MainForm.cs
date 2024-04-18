using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public partial class MainForm : Form
    {
        private readonly FileReader _reader;
        private readonly TextConverter _converter;
        private Button btnseleccionararchivo;
        private Button btnprocesar;
        private Button btnguardarcambios;
        private TextBox textBox1;
        private readonly FileWriter _writer;

        private void InitializeComponent()
        {
            btnseleccionararchivo = new Button();
            btnprocesar = new Button();
            btnguardarcambios = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnseleccionararchivo
            // 
            btnseleccionararchivo.Location = new Point(27, 12);
            btnseleccionararchivo.Name = "btnseleccionararchivo";
            btnseleccionararchivo.Size = new Size(133, 23);
            btnseleccionararchivo.TabIndex = 0;
            btnseleccionararchivo.Text = "Seleccionar Archivo";
            btnseleccionararchivo.UseVisualStyleBackColor = true;
            // 
            // btnprocesar
            // 
            btnprocesar.Location = new Point(27, 41);
            btnprocesar.Name = "btnprocesar";
            btnprocesar.Size = new Size(133, 23);
            btnprocesar.TabIndex = 1;
            btnprocesar.Text = "Procesar";
            btnprocesar.UseVisualStyleBackColor = true;
            btnprocesar.Click += btnprocesar_Click;
            // 
            // btnguardarcambios
            // 
            btnguardarcambios.Location = new Point(27, 70);
            btnguardarcambios.Name = "btnguardarcambios";
            btnguardarcambios.Size = new Size(133, 23);
            btnguardarcambios.TabIndex = 2;
            btnguardarcambios.Text = "Guardar Cambios";
            btnguardarcambios.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // MainForm
            // 
            ClientSize = new Size(329, 261);
            Controls.Add(textBox1);
            Controls.Add(btnguardarcambios);
            Controls.Add(btnprocesar);
            Controls.Add(btnseleccionararchivo);
            Name = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        public MainForm()
        {
            _converter = new TextConverter();
            _reader = new FileReader();
            _writer = new FileWriter();
        }

        private async void btnprocesar_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            //string convertedText = await
        }
    }
}
