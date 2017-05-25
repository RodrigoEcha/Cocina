using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodrigoEchandia
{
    abstract class Electrodomestico : Herramientas
    {
        bool conectado = false;
        public int usosrestantes = 5;

    }
}
