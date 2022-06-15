using System;

namespace CalculoDePromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a, b, c, d, e;
            decimal total = 0;
            decimal promedio = 0;

            Console.WriteLine("Ingrese 5 valores para realizar su promedio");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());

            total = (a + b + c + d + e);
            promedio = (a + b + c + d + e) / 5;

            Console.WriteLine("La suma total de los numeros ingresados es: " + " " + total);
            Console.WriteLine("El promedio de los numeros ingresados es:" + " " + promedio);

            Console.ReadKey();
        }
    }
}
