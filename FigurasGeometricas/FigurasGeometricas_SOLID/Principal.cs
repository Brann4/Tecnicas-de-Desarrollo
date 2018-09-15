using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas_SOLID
{
    public class Principal 
    {
        static void Main(string[] args)

        {
            var figuras = new ILadoGeometrico[]
                {
                    new Rectangulo {Ancho=10,Alto=5},
                    new Rectangulo {Ancho=10,Alto=5},
                    new Rectangulo {Ancho=10,Alto=5},
                    new TrianguloEquilatero{longitud_lado=12},
                     new TrianguloEquilatero{longitud_lado=7},
                     new Cuadrado{Medida_Lado=4}
                };
            var calculador = new Operaciones();
            calculador.Calcular(figuras);

            Console.WriteLine($"Area total: {calculador.TotalAreas}" +
                              $"\nPerimetro total: {calculador.TotalPerimetros}");
            Console.ReadKey();
        }
    }
}
