using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKolcsonzo
{
    internal class Dvd : IKolcsonozheto , IComparable<Dvd>
    {
        private string cim;
        private int hossz;

        public string Cim { get => cim; set => cim = value; }
        public int Hossz { get => hossz; set => hossz = value; }

        public Dvd(string cim, int hossz)
        {
            this.cim = cim;
            this.hossz = hossz;
        }

        public string MegjelenitendoNev()
        {
            return $"{this.cim}({this.hossz})";
        }
        public int MeddigKolcsonozheto()
        {
            return 7;

        }

        public int CompareTo(Dvd other)
        {
            return this.hossz-other.Hossz;
        }
    }
}
