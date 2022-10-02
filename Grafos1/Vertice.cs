using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos1
{
    public class Vertice
    {
        public Arco arco;
        public Vertice sig;
        public string _nombre;
        public bool visitado;

        public Vertice(string nombre)
        {
            _nombre = nombre;
            arco = null;
            visitado = false;
        }
    }
}
