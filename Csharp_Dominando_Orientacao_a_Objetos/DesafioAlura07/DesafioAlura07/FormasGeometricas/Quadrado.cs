using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAlura07.FormasGeometricas
{
    class Quadrado : FormaGeometrica
    {
        public double Lado { get; set; }
        public override double CalcularArea()
        {
            double resultado = Lado * Lado;
            return resultado;
        }

        public override double Perimetro()
        {
            double resultado = 4 * Lado;
            return resultado;
        }
    }
}
