using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class AdapatadorStreamReader : ILectorDatos
    {
        private StreamReader _streamreader;

        public AdapatadorStreamReader( StreamReader streamreader )
        {
            _streamreader = streamreader;
        }

        public string Leer()
        {
            return _streamreader.ReadLine();
        }
    }
}
