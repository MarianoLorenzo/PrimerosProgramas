using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float km, v, r;

            Console.WriteLine("Ingrese los km entre las dos ciudades: ");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad prom. del vehículo: ");
            v = float.Parse(Console.ReadLine());

            r = km / v;

            Console.WriteLine("El tiempo de llegada es: " + r.ToString("0.0") + " horas");

        }
    }
}
