using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona: Edad, Sueldo, Nombre
            /*
             persona p1 = new persona();
            p1.setedad(35);
            p1.setnombre("lucas montegrosso");
            p1.setsueldo(1000);

            console.writeline("el nombre de la persona es: " + p1.getnombre() + ", tiene " + p1.getedad() + " años y su sueldo es de $" + p1.getsueldo());



            //botella
            botella b1 = new botella();
            b1.setcapacidad(2);
            b1.setcolor("azul");
            b1.setmaterial("plastico");

            console.writeline("la botella tienen una capacidad de: " + b1.getcapacidad());
            console.writeline("el color es: " + b1.getcolor());
            console.writeline("el material es de: " + b1.getmaterial());



            //sillas
            silla s1 = new silla();
            s1.material = ("madera");
            s1.tipo = ("oficina");
            s1.color = ("negro");

            console.writeline("el tipo del modelo 1 es: " + s1.tipo);
            console.writeline("el material es: " + s1.material);
            console.writeline("el color es:" + s1.color);


            silla s2 = new silla();
            s2.material = ("plastico");
            s2.tipo = ("parque");
            s2.color = ("blanco");

            console.writeline("el tipo del modelo de silla #2 es: " + s2.tipo);
            console.writeline("material: " + s2.material);
            console.writeline("color:" + s2.color);



             */

            //Recargar jarra

            Jarra j1 = new Jarra("Transparente", "Vidrio");
            Console.WriteLine("La capacidad de la jarra es: " + j1.Capacidad);
            Console.WriteLine("La capacidad actual es: " + j1.CapActual);

            j1.Recargar();
            Console.WriteLine("Despues de recargar, la capacidad actual es: " + j1.CapActual);



            Console.ReadKey();
        }
    }
}
