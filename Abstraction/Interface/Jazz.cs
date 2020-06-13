using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Jazz : IGenre
    {
        public void jenis()
        {
            Console.WriteLine("Genre Musik Jazz");
        }
        public void info()
        {
            Console.WriteLine("Musik Jazz adalah jenis musik yang tumbuh dari penggabungan blues,ragtime dan musik Erope.");
            Console.WriteLine("Beberapa subgenre Jazz adalah Dixieland, swing, bebop, hard bop, dll.");
        }
    }
}
