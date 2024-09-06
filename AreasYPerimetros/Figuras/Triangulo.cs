using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Figuras
{
    public class Triangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        /*Equilátero: todos los lados son iguales.
        /Isósceles: dos lados son iguales.
        Escaleno: todos los lados son diferentes.*/


        public Triangulo(double ladoA, double ladoB, double ladoC) //Constructor
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        // Método para calcular el área usando la fórmula de Herón
        public double CalcularAreaTriangulo()
        {
            double semiperimetro = (LadoA + LadoB + LadoC) / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - LadoA) * (semiperimetro - LadoB) * (semiperimetro - LadoC));
            return area;
        }

        // Método para calcular el perímetro
        public double CalcularPerimetroTriangulo()
        {
            return LadoA + LadoB + LadoC;
        }

        // Método para determinar el tipo de triángulo
        public string DeterminarTipoTriangulo(double LadoA, double LadoB, double LadoC)
        {
            // Validar que los lados forman un triángulo válido
            if (LadoA <= 0 || LadoB <= 0 || LadoC <= 0 ||
                LadoA + LadoB <= LadoC ||
                LadoA + LadoC <= LadoB ||
                LadoB + LadoC <= LadoA)
            {
                throw new ArgumentException("Los lados no forman un triángulo válido."); //Ventana de dialogo para errores
            }

            // Determinar el tipo de triángulo
            if (LadoA == LadoB && LadoB == LadoC)
            {
                return "Equilátero";
            }
            else if (LadoA == LadoB || LadoB == LadoC || LadoA == LadoC)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }

    }
}
