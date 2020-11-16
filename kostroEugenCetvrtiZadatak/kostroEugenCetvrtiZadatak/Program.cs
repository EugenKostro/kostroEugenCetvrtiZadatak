using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenCetvrtiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite cijenu sa PDV-om: ");
            double bezpdv = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cijena sa PDV-om: "+(bezpdv+bezpdv*0,25));

            Console.WriteLine("Upisite cijenu sa PDV-om: ");
            double pdv = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cijena bez PDV-a" + pdv * 0, 8);
            Console.ReadKey();
        }
    }
}
