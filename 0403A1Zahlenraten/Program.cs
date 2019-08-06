using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0403A1Zahlenraten
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 0; // Später mal, Zufallszahl
            int n = 0; // Zähler für Versuche
            int r = 0; // Ratezahl

            Random zufall = new Random();
            z = zufall.Next(1, 101);

            do
            {
                Console.WriteLine();
                Console.Write("yessir? ");
                r = int.Parse(Console.ReadLine());
                if (r > z)
                    Console.WriteLine("zu hoch");
                if (r < z)
                    Console.WriteLine("zu tief");
                n++;
            } while (r != z);
            Console.WriteLine("nach {0} versuchen gefunden!", n);

        }
    }
}
