namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnprocesararchivo = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnprocesararchivo
            // 
            btnprocesararchivo.Location = new Point(88, 87);
            btnprocesararchivo.Name = "btnprocesararchivo";
            btnprocesararchivo.Size = new Size(131, 50);
            btnprocesararchivo.TabIndex = 0;
            btnprocesararchivo.Text = "Procesar Archivo";
            btnprocesararchivo.UseVisualStyleBackColor = true;
            btnprocesararchivo.Click += btnprocesararchivo_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 198);
            Controls.Add(textBox1);
            Controls.Add(btnprocesararchivo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnprocesararchivo;
        private TextBox textBox1;
    }
}
