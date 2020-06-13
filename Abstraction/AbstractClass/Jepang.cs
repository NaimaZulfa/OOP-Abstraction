using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Jepang : Negara
    {
        public override void nmanegara()
        {
            Console.WriteLine("Nama Negara \t: Jepang");
        }
        public override void nmaik()
        {
            Console.WriteLine("Ibu Kota \t: Tokyo");
        }
        public override void populasi()
        {
            Console.WriteLine("Populasi \t: 13.189.000");
        }
    }
}
