using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Hiphop : IGenre
    {
        public void jenis()
        {
            Console.WriteLine("Genre Musik Hip hop");
        }
        public void info()
        {
            Console.WriteLine("Musik Hip hop dapat dianggap sebagai sub genre R&B.");
            Console.WriteLine("Berkembang tahun 1970-an di di pantai timur AS, disebut East Coast hip hop.");
        }
    }
}
