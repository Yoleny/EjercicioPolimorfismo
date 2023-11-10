using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Circulo : Forma
    {
        private double radio;

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
