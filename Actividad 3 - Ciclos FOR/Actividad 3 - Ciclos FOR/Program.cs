using System;

namespace Tarea_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Desde que numero quieres empezar: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hasta donde va a terminar el ciclo el ciclo: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto quieres ir? ");
            z = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                for (int i = x; i <= y; i += z)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            if (x > y)
            {
                for (int i = x; i >= y; i -= z)
                {
                    Console.WriteLine("i = " + i);
                }
            }
        }
    }
}