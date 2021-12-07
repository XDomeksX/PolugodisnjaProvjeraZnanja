using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polugodišnja_provjera_znanja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj=0, broj2=0, broj3=0;

            Console.WriteLine("Unesi broj: ");
            broj = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi broj: ");
            broj2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi broj: ");
            broj3 = Convert.ToInt32(Console.ReadLine());

            if (broj>broj2 && broj>broj3)
            {
                Console.WriteLine("Najveći je 1. broj sa vrijednošću od: " + broj);
            }
            if (broj2 > broj && broj2 > broj3)
            {
                Console.WriteLine("Najveći je 2. broj sa vrijednošću od: " + broj2);
            }
            if (broj3 > broj2 && broj3 > broj)
            {
                Console.WriteLine("Najveći je 3. broj sa vrijednošću od: " + broj3);
            }
            Console.ReadKey();
        }
    }
}
