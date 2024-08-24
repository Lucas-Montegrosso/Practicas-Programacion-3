using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
   * Primer lote con 10 registros de productos, cada producto tiene:
    - Código Artículo (3 digitos no correlativos)
    - Precio
    - Código de Marca (1 a 10)
   * Segundo lote con las ventas de la semana. Cada venta tiene:
      - Fecha
      - Código Artículo
      - Cantidad
      - Código Cliente (1 a 100)
      - Total
   Este lote corta con Código de Cliente cero. */


            //Primer lote

            Articulo[] articulos = new Articulo[10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese los datos del producto");
                Console.WriteLine("Codigo:");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Pricio");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 a 10)");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());

            }


            //Segundo lote

            Venta venta = new Venta();

            Console.WriteLine("Código cliente");
            Console.WriteLine("Código de cliente");
            venta.CodCliente = int.Parse(Console.ReadLine());


            while (venta.CodCliente != 0)
            {
                Console.WriteLine("Código de Artículo");
                venta.CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad");
                venta.Cantidad = int.Parse(Console.ReadLine());
            }
           //trabajamos

            //pido cliente nuevamente
            Console.WriteLine("Ingrese la venta");
            Console.WriteLine("Código de cliente");
            venta.CodCliente = int.Parse(Console.ReadLine());

           
        }


    }
}
