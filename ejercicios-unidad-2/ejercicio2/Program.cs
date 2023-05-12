using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
          int kms, velocidad, resultado;

          Console.WriteLine("Ingrese los kms existentes entre dos ciudades: ");
          kms = int.Parse(Console.ReadLine());
          Console.WriteLine("Ingrese la velocidad promedio del vehículo: ");
          velocidad = int.Parse(Console.ReadLine());
          
          resultado = kms / velocidad;

          Console.WriteLine("Tardará en llegar: " + resultado + " horas");
          

        }
    }
}
