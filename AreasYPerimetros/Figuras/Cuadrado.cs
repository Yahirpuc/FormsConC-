using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Figuras
{
    public class Cuadrado
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)//Parametros
        {
            Lado = lado;
        }

        public double CalcularAreaCuadrado()
        {
            double area = Lado * Lado;
            return area;
        }

        public double CalcularPerimetroCuadrado()
        {
            double perimetro = 4 * Lado;
            return perimetro;
        }

    }
}
