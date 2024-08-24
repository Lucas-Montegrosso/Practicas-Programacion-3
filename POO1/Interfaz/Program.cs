using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato();
            g1.nombre = "Chicho";

            Perro p1 = new Perro();
            p1.nombre = "Milo";

            List <Flyable> animalesVoladores = new List <Flyable>();
            animalesVoladores.Add(new Canario());
            animalesVoladores.Add(new Aguila());


            foreach (Flyable animal in animalesVoladores)
            {
                animal.volar();
            }

            Console.ReadKey();
                
        }
    }
}
