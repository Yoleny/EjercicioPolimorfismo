using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Triangulo : Forma
    {
        private double baseTriangulo;
        private double altura;

        public double BaseTriangulo
        {
            get { return baseTriangulo; }
            set { baseTriangulo = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public override double CalcularArea()
        {
            return (baseTriangulo * altura) / 2;
        }
    }
}
