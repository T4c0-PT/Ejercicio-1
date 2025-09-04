using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace videojuegos3d
{
    internal class Menu
    {

        public void Figuras()
        {
            Console.WriteLine("Que figura quier escoger");
            Console.WriteLine("1: Cuadrado \n2: Triangulo \n3: Circulo \n4: Salir");

            int selec;

            if (!int.TryParse(Console.ReadLine(), out selec))
            { 
                Console.Clear();
                Console.WriteLine("Porfavor Ingrese un numero valido");
                Figuras();
                return;
            }

            switch (selec)
            {
                case 1: Console.Clear(); Cuadrado();
                    break;
                case 2: Console.Clear(); Triangulo();
                    break;
                case 3: Console.Clear(); Circulo();
                    break;
                case 4:
                    Console.Clear(); Console.WriteLine("cerrando");
                    break;
                default:
                    Console.Clear(); Console.WriteLine("Opcion no valida, intente denuevo"); Figuras();
                    break;
            }

        }

        private void Cuadrado()
        {
            double h, b;

            Console.WriteLine("escribe el alto del cuadrado");
            while (!double.TryParse(Console.ReadLine(), out h))
                Console.WriteLine("Error, ingrese un numero");

            Console.WriteLine("escribe el base del cuadrado");
            while (!double.TryParse(Console.ReadLine(), out b))
                Console.WriteLine("Error, ingrese un numero");

            Console.Clear();
            Cuadrado resC = new Cuadrado(h, b);
            Console.WriteLine($"El area del cuadrado es: {resC.AreaC()}");

            Console.WriteLine("\nPresione cualquier tecla para volver al menu");
            Console.ReadKey();
            Console.Clear();
            Figuras();
        }

        private void Triangulo()
        { 
            double h, b;

            Console.WriteLine("escribe el alto del triangulo");
            while (!double.TryParse(Console.ReadLine(), out h))
                Console.WriteLine("Error, ingrese un numero");

            Console.WriteLine("escribe el base del triangulo");
            while (!double.TryParse(Console.ReadLine(), out b))
                Console.WriteLine("Error, ingrese un numero");

            Console.Clear();
            Triangulo resT = new Triangulo(h, b);
            Console.WriteLine($"El area del triangulo es: {resT.AreaT()}");

            Console.WriteLine("\nPresione cualquier tecla para volver al menu");
            Console.ReadKey();
            Console.Clear();
            Figuras();
        }

        private void Circulo()
        { 
            double radio;

            Console.WriteLine("escribe el radio del circulo");
            while (!double.TryParse(Console.ReadLine(), out radio))
                Console.WriteLine("Error, ingrese un numero");

            Console.Clear();
            Circulo resCC = new Circulo(radio);
            Console.WriteLine($"El area del circulo es: {resCC.AreaCC()}");

            Console.WriteLine("\nPresione cualquier tecla para volver al menu");
            Console.ReadKey();
            Console.Clear();
            Figuras();
        }


        /*private void Cuadrado()
        {
            Console.WriteLine("escribe el alto del cuadrado");
            double h = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("escribe el base del cuadrado");
            double b = double.Parse(Console.ReadLine());
            Console.Clear();

            Cuadrado resC = new Cuadrado(h, b);

            Console.WriteLine($"El area del cuadrado es: {resC.AreaC()}");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Que accion quiere hacer \n1: Elegir otra firugra       2: Salir");

            int selec = int.Parse(Console.ReadLine());

            switch (selec)
            {
                case 1:
                    Console.Clear(); Figuras();
                    break;
                case 2:
                    Console.Clear(); Console.WriteLine("cerrando");
                    break;
                default:
                    break;
            }
        }*/


    }
}
