using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public abstract class Forma
    {
        public abstract double CalcularArea();
    }
    public class Cuadrado : Forma
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }
    }
}
