using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 words!");

            Console.Write("Input First Word: ");
            var w1 = Console.ReadLine();

            Console.Write("Input Second Word: ");
            var w2 = Console.ReadLine();

            Console.Write("Input Third Word: ");
            var w3 = Console.ReadLine();

            Console.Write("Which Word Do You Like? ");
            var w = int.Parse(Console.ReadLine());

            if (w == 1)
            {
                Console.WriteLine("Your Word Is " + w1);
            }
            if (w == 2)
            {
                Console.WriteLine("Your Word Is " + w2);
            }
            if (w == 3)
            {
                Console.WriteLine("Your Word Is " + w3);
            }
        }
    }
}
