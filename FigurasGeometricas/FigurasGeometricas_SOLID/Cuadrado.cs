using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas_SOLID
{
    public class Cuadrado : ILadoGeometrico
    {
        public double Lados { get; } = 4;
        public double Medida_Lado { get; set; }

        public double Area() {
            return Medida_Lado * Medida_Lado;
        }

        public double Perimetro() {
            return Medida_Lado * 4;
        }
    }
}
