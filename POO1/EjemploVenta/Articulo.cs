using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVenta
{
    internal class Articulo
    {
        /*
 - Código Artículo (3 digitos no correlativos)
 - Precio
 - Código de Marca (1 a 10)*/

        //Propiedad con formato reducido

        public int CodigoArticulo { get; set; }

        public float Precio { get; set; }

        private int _codMarca;

        public int CodigoMarca
        {
            get { return _codMarca; }
            set
            {
                if (value > 0 && value < 11)
                    _codMarca = value;
                else
                    _codMarca = -1;
            }
        } 


    }
}
