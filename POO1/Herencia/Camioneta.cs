using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Camioneta : Vehiculo
    {
        public int capCarga { get; set; }
        public string tipo { get; set; }

        public string traccion { get; set; }
    }
}
