using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Silla
    {
        //atributos: Tipo, Material, Color

        private string _tipo;
        private string _material;
        private string _color;

        //propiedad o seudometodo
        public string Tipo
        {
            get { return _tipo;}
            set { _tipo = value;}
        }
        public string Material
        {
            get { return _material; }
            set { _material = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }
}
