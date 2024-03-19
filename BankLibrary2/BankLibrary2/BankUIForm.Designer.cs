namespace BankLibrary2
{
    partial class BankUIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblcuenta = new Label();
            lblnombre = new Label();
            lblapellido = new Label();
            lblsaldo = new Label();
            txtcuenta = new TextBox();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtsaldo = new TextBox();
            SuspendLayout();
            // 
            // lblcuenta
            // 
            lblcuenta.AutoSize = true;
            lblcuenta.Location = new Point(30, 28);
            lblcuenta.Name = "lblcuenta";
            lblcuenta.Size = new Size(51, 15);
            lblcuenta.TabIndex = 0;
            lblcuenta.Text = "CUENTA";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(30, 70);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(100, 15);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "PRIMER NOMBRE";
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(30, 107);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(113, 15);
            lblapellido.TabIndex = 2;
            lblapellido.Text = "APELLIDO PATERNO";
            // 
            // lblsaldo
            // 
            lblsaldo.AutoSize = true;
            lblsaldo.Location = new Point(30, 143);
            lblsaldo.Name = "lblsaldo";
            lblsaldo.Size = new Size(44, 15);
            lblsaldo.TabIndex = 3;
            lblsaldo.Text = "SALDO";
            // 
            // txtcuenta
            // 
            txtcuenta.Location = new Point(205, 25);
            txtcuenta.Name = "txtcuenta";
            txtcuenta.Size = new Size(329, 23);
            txtcuenta.TabIndex = 4;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(205, 67);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(329, 23);
            txtnombre.TabIndex = 5;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(205, 104);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(329, 23);
            txtapellido.TabIndex = 6;
            // 
            // txtsaldo
            // 
            txtsaldo.Location = new Point(205, 140);
            txtsaldo.Name = "txtsaldo";
            txtsaldo.Size = new Size(329, 23);
            txtsaldo.TabIndex = 7;
            // 
            // BankUIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 278);
            Controls.Add(txtsaldo);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(txtcuenta);
            Controls.Add(lblsaldo);
            Controls.Add(lblapellido);
            Controls.Add(lblnombre);
            Controls.Add(lblcuenta);
            Name = "BankUIForm";
            Text = "BankUIForm";
            Load += BankUIForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcuenta;
        private Label lblnombre;
        private Label lblapellido;
        private Label lblsaldo;
        private TextBox txtcuenta;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtsaldo;
    }
}