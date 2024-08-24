using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();

            Camioneta c1 = new Camioneta();
            c1.color = "Negro";
            c1.capCarga = 1000;
            c1.traccion = "4x2";
            c1.anio = 2024;
            c1.marca = "Ford";
            c1.tipo = "Furgon";

            Camioneta c2 = new Camioneta();
            c2.color = "Gris";
            c2.tipo = "Furgon";

            Camioneta c3 = new Camioneta();
            c3.traccion = "4x4";            
            c3.color = "Blanco";

            List<Camioneta> ListaCamionetas = new List<Camioneta>();
            ListaCamionetas.Add(c1);
            ListaCamionetas.Add (c2);
            ListaCamionetas.Add(c3);


            foreach (Camioneta cam in ListaCamionetas) 
            {
                Console.WriteLine("Color: " + cam.color);
                Console.WriteLine("carga: " + cam.capCarga);
                Console.WriteLine("traccion " + cam.traccion);
                Console.WriteLine();

            }
            Console.ReadKey();
            
        }
    }
}
