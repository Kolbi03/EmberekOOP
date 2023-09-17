using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmberekOOP
{
    internal class Ember
    {
        private string nev;
        private string szulDatum;
        private string szulHely;

        public Ember(string nev, string szulDatum, string szulHely)
        {
            this.nev = nev;
            this.szulDatum = szulDatum;
            this.szulHely = szulHely;
        }

        public string Nev { get => nev; set => nev = value; }
        public string SzulDatum { get => szulDatum; set => szulDatum = value; }
        public string SzulHely { get => szulHely; set => szulHely = value; }

        public override string ToString()
        {
            return this.nev + " a nevem, ekkor születtem: " + this.szulDatum + " és ebben a városban: " + this.szulHely.ToString();
        }

        List<string> Datum = new List<string>();

        public void Feltolt(int szam, string datum)
        {
            List<int> ev = new List<int>();
            List<int> honap = new List<int>();
            List<int> nap = new List<int>();


            string[] datumok = new string[3];

            for (int i = 0; i < szam; i++) 
            {
                datumok = datum.Split('.');

                ev.Add(int.Parse(datumok[0]));
                honap.Add(int.Parse(datumok[1]));
                nap.Add(int.Parse(datumok[2]));
            }

            for (int i = 0;i < szam; i++)
            {
                Console.WriteLine(ev[i] + "/" + honap[i] + "/" + nap[i]);
            }
        }
    }
}
