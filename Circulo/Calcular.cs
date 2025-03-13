using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    class Calcular
    {
      public  decimal Area { get; set;}
      public decimal Perimetro { get; set;}

        public Calcular(decimal Area,decimal Perimetro) 
        {
            Area = area;
            Perimetro = perimetro;
        }

        public void Resultado() 
        {
            return $"ÁREA:" { Area}" - " " PERIMETRO " { Perimetro};
        }
    }
}
