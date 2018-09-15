using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas_SOLID
{
    public class TrianguloEquilatero:ILadoGeometrico
    {
        public double lados { get; } = 3;
        public double longitud_lado { get; set; }

        public double Area() {

            return Math.Sqrt(3) * Math.Pow(longitud_lado, 2) / 4;
        }

        public double Perimetro() {
            return longitud_lado * 3;
        }
    }
}
