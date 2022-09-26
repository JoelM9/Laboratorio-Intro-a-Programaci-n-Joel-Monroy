using System;

namespace Tarea1_Joel_Monroy_1043721_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mi segundo programa");
            String snombre, sedad, scarrera, scarne;

            Console.WriteLine("Escriba Su Nombre");
            snombre = Console.ReadLine();

            Console.WriteLine("Escriba Su Edad");
            sedad = Console.ReadLine();

            Console.WriteLine("Escriba Su Carrera");
            scarrera = Console.ReadLine();

            Console.WriteLine("Escriba Su Carné");
            scarne = Console.ReadLine();

            Console.WriteLine(" Mi segundo programa ");
            Console.WriteLine("Nombre:  " + snombre);
            Console.WriteLine("Edad: " + sedad);
            Console.WriteLine("Carrera: " + scarrera);
            Console.WriteLine("Carné:" + scarne);

            Console.Write("Soy " + snombre + ",tengo " + sedad + " años y estudio la carrera de " + scarrera + " Mi número de carné es; " + scarne + ".");

            Console.ReadKey();


        }
    }
}
