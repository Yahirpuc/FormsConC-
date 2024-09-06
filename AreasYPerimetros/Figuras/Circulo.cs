using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Figuras
{
    public class Circulo
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double CalcularAreaCirculo()
        {
            double area = Math.PI * Math.Pow(Radio, 2);
            return area;
        }

        public double CalcularPerimetroCirculo()
        {
            double perimetro = 2 * Math.PI * Radio;
            return perimetro;
        }
    }
}
