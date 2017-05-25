using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodrigoEchandia
{
    class Liquido : Ingredinte
    {

        public enum Sabor
        {
            Acido,
            Salado,
            Neutro
        }
        public Sabor sabor;

        public Liquido(string nombre,  Sabor sabor) {
                  this.nombre = nombre;
                   this.sabor = sabor;

        }
  }
}
