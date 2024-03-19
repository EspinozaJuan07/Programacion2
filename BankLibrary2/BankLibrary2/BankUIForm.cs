using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLibrary2
{
    public partial class BankUIForm : Form
    {
        protected int TextBoxCount { get; set; } = 4;

        public enum TextBosIndices { Account, First, Last, Balance}
        public BankUIForm()
        {
            InitializeComponent();
        }

        private void BankUIForm_Load(object sender, EventArgs e)
        {

        }

        public void ClearTextBoxes()
        {
            foreach (Control guicontrol in Controls)
            {
                (guicontrol as TextBox)?.Clear();
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if(values.Length != TextBoxCount)
            {
                throw new ArgumentException(
                    $"There must be {TextBoxCount} strings in the array", nameof(values));
            }
            else
            {
                txtcuenta.Text = values[(int)TextBosIndices.Account];
                txtnombre.Text = values[(int)(TextBosIndices.First)];
                txtapellido.Text = values[(int)TextBosIndices.Last];
                txtsaldo.Text = values[(int)TextBosIndices.Balance];
            }

        }

        public string[] ObtenerValorTextBox()
        {
            return new string[]
            {
                txtcuenta.Text, txtnombre.Text, txtapellido.Text, txtsaldo.Text
            };
        }
    }

    
}
