using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodrigoEchandia
{
    class UtenciliosDeCosina : Herramientas
    {
        public int usosrestantes = 3;
        public enum Material
        {
            Metal,
            Barro,
            Madera

        }
        public Material material;

        public UtenciliosDeCosina (string nombre, Material material){
            this.nombre = nombre;
            this.material = material;
            
         }
    }
}
