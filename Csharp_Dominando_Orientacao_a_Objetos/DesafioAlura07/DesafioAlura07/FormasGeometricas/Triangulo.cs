using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAlura07.FormasGeometricas
{
    class Triangulo : FormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }


        public override double CalcularArea()
        {
            double resultado = (Base * Altura) / 2;
            return resultado;
        }

        public override double Perimetro()
        {
            double resultado = Lado1 + Lado2 + Base;
            return resultado;
        }
    }
}
