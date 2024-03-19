using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary2
{
    public class Record
    {
        public int cuenta { get; set; }
        public string PrimerNombre { get; set; }
        public string Apellido { get; set; }
        public decimal Balance { get; set; }

        public Record() : this(0, string.Empty, string.Empty, 0M) { }
        
        public Record(int cuent, string primernombre, string apellido, decimal balance)
        {
            cuenta = cuent;
            PrimerNombre = primernombre;
            Apellido = apellido;
            Balance = balance;
        }
    }
}
