using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Pop : IGenre
    {
        public void jenis()
        {
            Console.WriteLine("Genre Musik Pop");
        }
        public void info()
        {
            Console.WriteLine("Musik Pop adalah genre penting namun batasnya sering kabur.");
            Console.WriteLine("Seringkali jenis musik ini masuk ke kategori rock, hip pop, country, dll.");
        }
    }
}
