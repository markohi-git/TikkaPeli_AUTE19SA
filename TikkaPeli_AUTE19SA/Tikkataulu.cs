using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkaPeli_AUTE19SA
{
    class Tikkataulu
    {
        private List<Tikka> Tikat = new List<Tikka>();
        Random rnd = new Random(DateTime.Now.Millisecond);
        public Tikkataulu()
        {
            for (int i = 0; i < 5; i++)
            {
                Tikka t = new Tikka();
                Tikat.Add(t);
            }
        }
        public Tikka GetTikka()
        {
            int tikkojenmaara = Tikat.Count();
            Tikka t = Tikat.ElementAt(tikkojenmaara - 1);
            Tikat.Remove(t);
            return t;
        }
        public int Osuma(Tikka tikka)
        {
            Tikat.Add(tikka);
            //Random rnd = new Random();
            
            return rnd.Next(11);
        }
        public int TikkojenLKM()
        {
            return Tikat.Count();
        }
    }
}

