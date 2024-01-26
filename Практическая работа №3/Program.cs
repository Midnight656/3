using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;


namespace Практическая_работа__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            int[,] Notas = { { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 }, { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 } };
            Console.WriteLine("Переключение между октавами: F8 - 7 октава, F9 - 8 октава");
            while (true)
            {
                ConsoleKeyInfo key1 = Console.ReadKey(true);
                if (Octava(index, key1) != 2)
                {
                    index = Octava(index, key1);
                    Console.WriteLine($"{index + 7} октава");
                    key1 = Console.ReadKey(true);
                }
              //  Console.Clear();
                Console.Beep(Notas[index, Nota(key1)], 100);
            }
        }
        static int Octava(int index, ConsoleKeyInfo key1)
        {
            switch (key1.Key)
            {
                case ConsoleKey.F8:
                    return 0;
                case ConsoleKey.F9:
                    return 1;
                default:
                    return 2;
            }
        }
        static int Nota(ConsoleKeyInfo key1)
        {
            string[] Doremi = { "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c" };
            int index2 = Array.IndexOf(Doremi, key1.KeyChar.ToString());
            if (index2 > -1 && index2 < Doremi.Length)
            {
                return index2;
            }
            else { return 0; }
        }
    }
}
