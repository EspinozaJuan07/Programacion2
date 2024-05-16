namespace GestionDeProductos
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
            btncalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            txtprecio = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnguardar = new Button();
            txtcantidad = new TextBox();
            txtproducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(238, 81);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(108, 29);
            btncalcular.TabIndex = 0;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Productos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Precio:";
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(82, 64);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(100, 23);
            txtprecio.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Cantidad:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(479, 150);
            dataGridView1.TabIndex = 9;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(352, 81);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(108, 29);
            btnguardar.TabIndex = 10;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(82, 103);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(100, 23);
            txtcantidad.TabIndex = 11;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(82, 25);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(100, 23);
            txtproducto.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 321);
            Controls.Add(txtproducto);
            Controls.Add(txtcantidad);
            Controls.Add(btnguardar);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(txtprecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btncalcular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private Label label1;
        private Label label2;
        private TextBox txtprecio;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnguardar;
        private TextBox txtcantidad;
        private TextBox txtproducto;
    }
}
