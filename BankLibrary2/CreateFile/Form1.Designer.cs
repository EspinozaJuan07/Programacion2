namespace CreateFile
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
            btnguardar = new Button();
            btningresar = new Button();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(27, 216);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(100, 23);
            btnguardar.TabIndex = 16;
            btnguardar.Text = "Guardar como";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btningresar
            // 
            btningresar.Location = new Point(184, 216);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(100, 23);
            btningresar.TabIndex = 17;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(346, 216);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(100, 23);
            btnsalir.TabIndex = 18;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 274);
            Controls.Add(btnsalir);
            Controls.Add(btningresar);
            Controls.Add(btnguardar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Controls.SetChildIndex(btnguardar, 0);
            Controls.SetChildIndex(btningresar, 0);
            Controls.SetChildIndex(btnsalir, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnguardar;
        private Button btningresar;
        private Button btnsalir;
    }
}