using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, prom;

            Console.WriteLine("Ingrese la nota 1: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3: ");
            n3 = float.Parse(Console.ReadLine());

            prom = (n1 + n2 + n3) / 3;

            Console.WriteLine("El promedio es: " + prom.ToString("0.00"));
        }
    }
}
