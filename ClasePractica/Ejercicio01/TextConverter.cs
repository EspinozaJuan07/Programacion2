using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class TextConverter
    {
        public async Task<string> Convert(string text)
        {
            return await Task.Run(() => text.ToUpper());
        }
    }
}
