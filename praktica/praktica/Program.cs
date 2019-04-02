using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод данных");
            Biblio Maks = new Biblio();
            Maks.SetInfo();
            Maks.GetInfo();
            Console.ReadKey();
        }
    }
}
