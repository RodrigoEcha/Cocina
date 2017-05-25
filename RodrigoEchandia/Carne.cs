using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodrigoEchandia
{
    class Carne : Ingredinte
    {
        bool cortado = false;
        public int peso = 30; //Kg ES LA UNIDAD DE MEDIDA

        public enum Sabor
        {
            Cosinado,
            Crudo,
            Terminomedio
        }
        public Sabor sabor;


        public Carne(string nombre, int peso) {
            this.nombre = nombre;
            this.peso = peso;
            sabor = Sabor.Crudo;
        }
    }
}
