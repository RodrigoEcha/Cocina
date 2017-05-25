using System;

namespace RodrigoEchandia
{
    class Taza : Fuente
    {

        public bool estaVacio {
            get {
                if (cantidad == 0)
                    return true;
                else
                    return false;
            }
        }

        public Taza (string nombre, int capacidad)
        {
            this.nombre = nombre;
            _capacidad = capacidad;        
        }

        public void Agregar(int cantidad) {
            if (_cantidad + cantidad > _capacidad)
                Console.WriteLine("Error capacidad excedida");
            else
                _cantidad += cantidad;
        }

    }
}
