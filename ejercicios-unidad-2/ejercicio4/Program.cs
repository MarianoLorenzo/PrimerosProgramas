using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float f, r;
            float sf = 15000;
            float c = 0.05F;

            Console.WriteLine("Total facturado por empleado: ");
            f = float.Parse(Console.ReadLine());

            r = sf + (f * c);

            Console.WriteLine("Sueldo del empleado: $" + r.ToString("0.00"));

        }
    }
}
