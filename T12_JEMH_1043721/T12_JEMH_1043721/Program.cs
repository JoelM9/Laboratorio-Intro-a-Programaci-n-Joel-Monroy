using System;

namespace T12_JEMH_1043721
{
    class Program
    {
        static int cantidaddEquipos = 8;
        static Equipo[] equipos = new Equipo[cantidaddEquipos];
        static Random random = new Random();

        static int seleccionarGanador(int i, int j)
        {
            int x = random.Next(0, 100);

            if (x > 50)
            {
                return j;
            }
            return i;
        }

        static void mostrarEquipos()
        {
            int i = 0, j = cantidaddEquipos - 1;

            while(i< cantidaddEquipos/2) 
            {
                Console.WriteLine(equipos[i].nombre + " vs" + equipos[j].nombre);
                i++;
                j--;
            }          
        }

        static void simulacion()
        {          
            while(cantidaddEquipos>1)
            {
                mostrarEquipos();
                Console.WriteLine("====================");
                int i = 0, j = cantidaddEquipos - 1;

                while (i < cantidaddEquipos / 2)
                {
                    Console.WriteLine(equipos[i].nombre + " vs" + equipos[j].nombre);
                    int x = seleccionarGanador(i, j);
                    i++;
                    j--;

                    Console.WriteLine("Gano: " + equipos[i].nombre);
                    Console.WriteLine("--------------------------------");
                }
                cantidaddEquipos = cantidaddEquipos / 2;
                Console.WriteLine("=============================");
            }
            Console.WriteLine(" El campeon es: " + equipos[0].nombre);
        }

        static void sortearequipo()
        {
            for (int i = 0; i < cantidaddEquipos; i++)
            {
                int x = random.Next(0, cantidaddEquipos);
                Equipo aux = equipos[i];
                equipos[i] = equipos[x];
                equipos[x] = aux;             
            }

        }

        static void Main(string[] args)

        {
            for(int i=0; i < cantidaddEquipos; i++)
            {
                equipos[i] = new Equipo();
                equipos[i].nombre = "Equipo" + i;
            }
            sortearequipo();
            mostrarEquipos();
            simulacion();            
        }
    }
}
