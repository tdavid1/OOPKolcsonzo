using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKolcsonzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dvd> list = new List<Dvd>();
            Dvd d1 = new Dvd("film1",120);
            Dvd d2 = new Dvd("film2", 110);
            Dvd d3 = new Dvd("film3", 124);
            Dvd d4 = new Dvd("film4", 100);
            Dvd d5 = new Dvd("film5", 115);
            list.Add(d1);
            list.Add(d2);
            list.Add(d3);
            list.Add(d4);
            list.Add(d5);
            list.Sort();
            foreach(var item in list)
            {
                Console.WriteLine(item.MegjelenitendoNev());
            }
            Console.ReadKey();
        }
    }
}
