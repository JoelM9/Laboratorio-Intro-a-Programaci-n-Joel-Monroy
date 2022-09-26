using System;

namespace L1_Joel_Monroy_1043721
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            Console.WriteLine("Escriba su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Soy " +nombre);

            Console.ReadKey();

            Console.Write("Hola Mundo Soy "+ nombre);
            Console.ReadKey();
        }
    }
}
