using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVenta
{
    internal class Venta
    {
        /*- Fecha
      - Código Artículo
      - Cantidad
      - Código Cliente (1 a 100)
      - Total*/


        //Constuctor

        

        public DateTime Fecha {  get; set; }
        public int CodArticulo { get; set; }
        public int Cantidad { get; set; }
        public int CodCliente { get; set; }
        public float Importe { get; set; }
    }
}
