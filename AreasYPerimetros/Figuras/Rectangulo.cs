using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Figuras
{
    public class Rectangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double baseRect, double alturaRect)
        {
            Base = baseRect;
            Altura = alturaRect;
        }

        public double CalcularAreaRectangulo()
        {
            double area = Base * Altura;
            return area;
        }

        public double CalcularPerimetroRectangulo()
        {
            double perimetro = 2 * (Base + Altura);
            return perimetro;
        }
    }
}
