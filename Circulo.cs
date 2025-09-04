using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojuegos3d
{
    internal class Circulo
    {
        double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double AreaCC()
        {
            return Math.Round(Math.PI * Math.Pow(radio,2),2);
        }
    }
}
