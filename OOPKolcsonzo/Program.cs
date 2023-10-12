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
            List<IKolcsonozheto> kolcsonzes = new List<IKolcsonozheto>();
            Dvd dvd1 = new Dvd("film1", 120);
            Dvd dvd2 = new Dvd("film2", 110);
            Konyv k1 = new Konyv("Cim1", "szerzo1", "isbn1");
            Konyv k2 = new Konyv("Cim2", "szerzo2", "isbn2");
            Ujsag u1 = new Ujsag("cim1", 1999, 5);
            Ujsag u2 = new Ujsag("cim2", 2000, 10);
            kolcsonzes.Add(dvd1);
            kolcsonzes.Add(dvd2);
            kolcsonzes.Add(k1);
            kolcsonzes.Add(k2);
            kolcsonzes.Add(u1);
            kolcsonzes.Add(u2);
            foreach (var item in kolcsonzes)
            {
                Console.WriteLine(item.MegjelenitendoNev());
            }
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
