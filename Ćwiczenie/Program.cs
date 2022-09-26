using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Silink v8 = new Silink();

            v8.CzyWlaczony = false;

            v8.ZwiekszMoc(50);

            v8.CzyWlaczony = true;

            v8.ZwiekszMoc(150);

            Console.ReadLine();
        }
    }
}
