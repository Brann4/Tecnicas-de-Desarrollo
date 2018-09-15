using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Principal : Rectangulo
    {
        private static void Main(string[] args)
        {
            var rectangulos = new[]
            {
            new Principal { Ancho = 10, Alto = 5 },
            new Principal { Ancho = 5, Alto = 1}
            };

            var sumaDeAreas = Rectangulo.SumAreas(rectangulos);
            var sumaDePerimetros = Rectangulo.SumPerimetro(rectangulos);

            Console.WriteLine($"Area total: {sumaDeAreas}" +
                              $"\nPerimetro total: {sumaDePerimetros}");
            Console.ReadKey();
        }
    }
}
