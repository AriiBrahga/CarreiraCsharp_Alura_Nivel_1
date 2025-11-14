using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAlura07.FormasGeometricas
{
    class Circulo : FormaGeometrica
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            double resultado = Math.PI * Raio * Raio;
            return resultado;
        }

        public override double Perimetro()
        {
            
            double resultado = 2 * Math.PI * Raio;
            return resultado;
        }
    }
}
