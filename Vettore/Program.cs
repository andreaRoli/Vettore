using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vettore v = new Vettore(8, 9);
            Vettore c = new Vettore(3, 5);

           

            Vettore b = new Vettore(0, 0);
            b = v * c;
            Console.WriteLine("{0}", b.ToString());
            Console.ReadLine();
        }
    }
}
