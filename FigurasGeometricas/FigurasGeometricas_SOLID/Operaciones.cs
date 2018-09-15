using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas_SOLID
{
    public class Operaciones
    {
        public double TotalAreas { get; private set; }
        public double TotalPerimetros { get; private set; }
         
        public void Calcular(IEnumerable<ILadoGeometrico> figuras) {

            var Operacion_Area = new Operacion_Area();
            var Operacion_Perimetro = new Operacion_Perimetro();

            TotalAreas = Operacion_Area.Sum(figuras);
            TotalPerimetros = Operacion_Perimetro.Sum(figuras);
        }
        public class Operacion_Area{
            public double Sum(IEnumerable<IdeArea> lados) {
                double area = 0;
                foreach (var numlados in lados)
                    area += numlados.Area();
                return area;
            }
        }
        public class Operacion_Perimetro
        {
            public double Sum(IEnumerable<IdePerimetro> lados)
            {
                double perimetro = 0;
                foreach (var numlados in lados)
                    perimetro += numlados.Perimetro();
                return perimetro;
            }
        }
    }
}
