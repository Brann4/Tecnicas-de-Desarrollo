using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas_SOLID
{
    public class Rectangulo :ILadoGeometrico
    {
        public double Lados { get; } = 4;
        public double Alto { get; set; }
        public double Ancho { get; set; }


        public double Area()
        {
            return Alto * Ancho;
        }

        public double Perimetro() {

            return Alto * 2 + Ancho * 2;
        }
    }

    
}
