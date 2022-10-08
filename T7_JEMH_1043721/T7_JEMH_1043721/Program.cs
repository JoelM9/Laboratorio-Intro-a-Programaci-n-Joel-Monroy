using System;

namespace T7_JEMH_1043721
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double i=1, C=0;

            Console.WriteLine("escribir el numero");
            N = int.Parse(Console.ReadLine());

            do
            {
                C = C + (1 / i);
                i++;

            } while (N >= i);
            Console.WriteLine("La primer sumatoria es: " + C);

            double b = 0;
            double j = 1;
            do
            {
                b = b + (1 / Math.Pow(2, j));
                j++;

            } while (N >= j);
            Console.WriteLine("La segunda sumatoria es: " + b);

            Console.WriteLine(" Ingresar el valor de X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingresar el valor de a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingresar el valor de n");
            int n = int.Parse(Console.ReadLine());

            int y = n - 0;
            double f = 1 * Math.Pow(a, y);

            Console.WriteLine("El resultado es: "+f);
        }
    }
}
