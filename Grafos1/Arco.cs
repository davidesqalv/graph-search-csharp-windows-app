using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos1
{
    public class Arco
    {
        public Arco sig;
        public string _nombre;

        public Arco(string nombre)
        {
            _nombre = nombre;
            sig = null;
        }
    }
}
