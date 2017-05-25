using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodrigoEchandia
{
    class Fruta : Ingredinte
    {
        public bool cascara = true;
        public bool cortado = false;
        public int semillas = 4;

        public Fruta(string nombre) {
            this.nombre = nombre;
        }

        public Fruta(string nombre, int semillas) {
            this.nombre = nombre;
            this.semillas = semillas;

        }
    }
}
