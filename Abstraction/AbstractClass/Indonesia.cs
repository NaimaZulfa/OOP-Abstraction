using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Indonesia : Negara
    {
        public override void nmanegara()
        {
            Console.WriteLine("Nama Negara \t: Indonesia");
        }
        public override void nmaik()
        {
            Console.WriteLine("Ibu Kota \t: Jakarta");
        }
        public override void populasi()
        {
            Console.WriteLine("Populasi \t: 10.187.595");
        }
    }
}
