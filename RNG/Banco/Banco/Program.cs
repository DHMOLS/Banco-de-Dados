using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rng = rnd.Next(0, 9);
            int rng2 = rnd.Next(0, 9);
            int rng3 = rnd.Next(0, 9);
            int rng4 = rnd.Next(0, 9);

            Console.Write(rng);
            Console.Write(rng2);
            Console.Write(rng3);
            Console.Write(rng4);

            Console.ReadLine();
        }
    }
}
