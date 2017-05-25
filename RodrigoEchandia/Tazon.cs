using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodrigoEchandia
{
    class Tazon : Fuente
    {

        public bool estaVacio
        {
            get
            {
                if (cantidad == 0)
                    return true;
                else
                    return false;
            }
        }




        public Tazon (string nombre, int capacidad)
        {
            this.nombre = nombre;
            _capacidad = capacidad;
        }

        public void Agregar(int cantidad)
        {
            if (_cantidad + cantidad > _capacidad)
                Console.WriteLine("Error capacidad excedida");
            else
                _cantidad += cantidad;
        }
     }
 }
