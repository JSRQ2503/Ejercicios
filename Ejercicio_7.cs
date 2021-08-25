using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc=0,a=0,b=0,c=0,d=0,e=0;
            double  f=0.00f;
            Console.WriteLine("Menu");
            Console.WriteLine("1.Precio terreno");
            Console.WriteLine("2.Servicios publicos");
            Console.WriteLine("3.Precio por metros ");
            opc = Int32.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Bienvenido");
                    Console.WriteLine("Precio del terreno");
                    Console.WriteLine("Ingrese ancho del lote");
                    a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese largo del lote");
                    b = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese precio por metro cuadrado");
                    c = Int32.Parse(Console.ReadLine());
                    d = a * b;
                    if (d>=400 && d<500)
                    {
                        e = (d * c);
                        f = e - (e * 0.1 );
                        Console.WriteLine("El precio es: {0}",f);
                    }
                break;
            }
                                    
        }
    }
}

