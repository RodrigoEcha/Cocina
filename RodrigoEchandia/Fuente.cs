using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodrigoEchandia
{
    abstract class Fuente : Herramientas
    {
        protected int _cantidad;
        public int cantidad {
            get {
                return _cantidad;
            }
        }

        protected int _capacidad;
        public int capacidad {
            get {
                return _capacidad;
            }
        }
    }
}
