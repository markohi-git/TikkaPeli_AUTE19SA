using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkaPeli_AUTE19SA
{
    class Program
    {
        private static List<Pelaaja> pelaajat;
        private static Tikkataulu tikkataulu;
        static void Main(string[] args)
        {
            tikkataulu = new Tikkataulu();
            //luodaan kolme pelaajaa
            pelaajat = new List<Pelaaja>();
            Console.WriteLine("Montako pelaajaa: ");
            int maara = int.Parse(Console.ReadLine());
            for (int i = 0; i < maara; i++)
            {
                //Pelaaja p = new Pelaaja();
                Pelaaja pp = new Pelaaja(tikkataulu);
                Console.WriteLine("Anna pelaajan nimi: ");
                pp.Setnimi(Console.ReadLine());
                pelaajat.Add(pp);
            }
            //
            for (int j = 0; j < pelaajat.Count; j++)
            {

                Pelaaja p = pelaajat.ElementAt(j);

                Console.WriteLine("\nPelaaja: " + p.GetNimi());
                for (int i = 0; i < 5; i++)
                {
                    int tulos = p.Heitatikka();
                    Console.WriteLine("tikka heitetty, tulos: " + tulos);
                    Console.WriteLine("tikkojen lkm pelaajalla: " + p.TikkojenLKM());
                    Console.WriteLine("Tikkojen lkm taulussa: " + tikkataulu.TikkojenLKM());
                }
            }
            Console.ReadLine();
        }
    }
    
}
