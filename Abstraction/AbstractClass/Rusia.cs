using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Rusia : Negara
    {
        public override void nmanegara()
        {
            Console.WriteLine("Nama Negara \t: Rusia");
        }
        public override void nmaik()
        {
            Console.WriteLine("Ibu Kota \t: Moskow");
        }
        public override void populasi()
        {
            Console.WriteLine("Populasi \t: 11.541.000");
        }
    }
}
