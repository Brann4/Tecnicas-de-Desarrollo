using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Rectangulo
    {
        #region Propiedades
        public double Lados { get; } = 4;
        public double Alto { get; set; }
        public double Ancho { get; set; }
        #endregion

        #region Metodos
        public static double SumAreas(IEnumerable<Rectangulo> rectangulos) {

            double area = 0;
            foreach (var rectangulo in rectangulos) 
                area += rectangulo.Alto * rectangulo.Ancho;
            return area;
        }

        public static double SumPerimetro(IEnumerable<Rectangulo> rectangulos) {
            double perimetro = 0;

            foreach (var rectanculo in rectangulos)
                perimetro += 2* rectanculo.Alto + 2 * rectanculo.Ancho;
            return perimetro;
        }
        #endregion
    }
}
