using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class FileWriter
    {
        public async Task WriteFileAsync(string filepath,  string content)
        {
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                await writer.WriteAsync(content);
            }
        }
    }
}
