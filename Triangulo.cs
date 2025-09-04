using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojuegos3d
{
    internal class Triangulo
    {
        private double b;
        private double h;

        public Triangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }

        public double AreaT()
        {
            return b * h / 2;
        }

    }
}
