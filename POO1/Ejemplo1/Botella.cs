using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {

        public Botella()
        {
            _color = "";
            _capacidad = 0;
            _material = "";
        }

        public Botella(string color, string material, float capacidad) 
        { 
            this._color = color;
            this._material = material;
            this._capacidad = capacidad;
        }

        
        //Botella: Capacidad, Color, Material

        //atributos
        private float _capacidad;
        private string _color;
        private string _material;

        //set
        public void setCapacidad(float capacidad )
        {
            _capacidad = capacidad;
        }
        public void setColor(string color)
        {
            _color = color;
        }
        public void setMaterial(string material)
        { 
        _material = material;
        }

        //get
        public float getCapacidad() { return _capacidad; }
        public string getColor() { return _color; }
        public string getMaterial() { return _material; }
    }
}
