using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        //Persona: Edad, Sueldo, Nombre
        //ATRIBUTOS o MIEMBROS
        private int edad;
        private float sueldo;
        private string nombre;

        //setters
        public void setEdad(int e)
        {
            edad = e;
        }
        public void setNombre(string n)
        {
            nombre = n;
        }
        public void setSueldo(float s)
        {
            sueldo = s;
        }

        //Getters
        public int getEdad() {  return edad; }
        public float getSueldo(){   return sueldo; }
        public string getNombre() { return nombre; }
        
            

    }
}
