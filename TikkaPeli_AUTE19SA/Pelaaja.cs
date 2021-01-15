using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkaPeli_AUTE19SA
{
    class Pelaaja
    {
        public int kokonaispisteet{ get; set; }
        private string Nimi;
        private List<Tikka> Tikat = new List<Tikka>();
        private Tikkataulu Tt;

        public Pelaaja(Tikkataulu tt)
        {
            Tt = tt;
        }
        public void Setnimi(string nimi)
        {
            Nimi = nimi;
        }
        public string GetNimi()
        {
            return Nimi;
        }
        public int TikkojenLKM()
        {
            return Tikat.Count();
        }
        public int Heitatikka()
        {
            //jos tikkojen määrä on 0 haetaan taulusta tikat

            if (Tikat.Count == 0)
            {
                Console.WriteLine("Tikkoja 0. Haetaan tikat taulusta");
                for (int i = 0; i < 5; i++)
                {
                    Tikka t = Tt.GetTikka();
                    Tikat.Add(t);
                }
            }
            int tulos = Tt.Osuma(Tikat.ElementAt(Tikat.Count() - 1));
            Tikat.RemoveAt(Tikat.Count() - 1);
            return tulos;

        }
    }
}
