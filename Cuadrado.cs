using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojuegos3d
{
    internal class Cuadrado
    {
        private double b;
        private double h;

        public Cuadrado(double b, double h) 
        {
            this.b = b;
            this.h = h;
        }

        public double AreaC()
        {
            return b * h;
        }


    }
}
