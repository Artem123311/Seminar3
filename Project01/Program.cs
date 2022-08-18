using System;
using System.Linq;
namespace Massive
{
    class Program
    {
        static private void Main ()
        {
            Console.WriteLine("Введите числа: ");
            var s = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            s = Enumerable.Range(0,s.Length).Select(i=>s[i]>0?-s[i]:s[i]).ToArray();
            Array.ForEach(s,x=>Console.WriteLine($"{x}"));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}