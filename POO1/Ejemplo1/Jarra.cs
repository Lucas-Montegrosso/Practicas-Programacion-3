using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Jarra
    {
        private string _color;
        private string _material;
        private int _capacidad;
        private int _cantActual;

        //Constructor
        public Jarra(string color, string material)
        {
            this._color = color;
            this._material = material;
            _capacidad = 100;
            _cantActual = 0;
        }

        public Jarra() { }

        //propiedades

        public int Capacidad
        {
            get { return _capacidad; }

        }

        public int CapActual
        {
            get { return _cantActual; }
        }

        public string Material
        {
            get { return _material; }
            set { _material = value; }
        }


        //metodos

        public float Recargar()
        {
            if (_cantActual > 0)
            {
                int diferencia = _capacidad - _cantActual;
                float monto = diferencia * 50 / 100f;  // Especifica que el 100 es un float para evitar conversiones innecesarias
                _cantActual += diferencia;
                return monto;
            }
            else
            {
                _cantActual = 100;
                return 50f; // Añade "f" para asegurar que es un float literal
            }
        }



    }
}
