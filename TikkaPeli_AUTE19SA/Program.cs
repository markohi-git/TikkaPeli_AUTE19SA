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
                int kokonaispisteet = 0;
                for (int i = 0; i < 5; i++)
                {
                    int tulos = p.Heitatikka();
                    kokonaispisteet = kokonaispisteet + tulos;
                    Console.WriteLine("tikka heitetty, tulos: " + tulos);
                    Console.WriteLine("tikkojen lkm pelaajalla: " + p.TikkojenLKM());
                    Console.WriteLine("Tikkojen lkm taulussa: " + tikkataulu.TikkojenLKM());
                }
                p.kokonaispisteet = kokonaispisteet;
                Console.WriteLine("Pelaajan "+p.GetNimi()+" pisteet "+p.kokonaispisteet);
            }
            
            Pelaaja voittaja=null;
            for (int j = 0; j < pelaajat.Count; j++)
            {
                //ensimmäinen kierros, laittetaan voittajaksi ensimmäinen pelaaja olio
                if (j == 0)
                {
                    voittaja = pelaajat.ElementAt(0);
                }
                //jos on vähintään toinen kierros, vertaillaan pelaajien pistemäärää eli nykyistä voittajaa 
                //listassa seuraavaan
                else
                {
                    //nykyisen voittajan pisteet ovat pienemmät kuin seuraavan pelaajan.
                    //vaihdetaan voittajaksi suuremmilla pisteillä oleva pelaaja
                    if (voittaja.kokonaispisteet < pelaajat.ElementAt(j).kokonaispisteet)
                    {
                        voittaja = pelaajat.ElementAt(j);
                    }
                }
            }
            Console.WriteLine("Voittaja on pelaaja: " + voittaja.GetNimi() + " pisteet: " + voittaja.kokonaispisteet);
            for (int k = 0; k < pelaajat.Count; k++)
            {
                for (int j = 0; j < pelaajat.Count - 1; j++)
                {
                    Pelaaja vp = pelaajat.ElementAt(j);
                    Pelaaja op = pelaajat.ElementAt(j+1);
                    //Vasemmalla puolella pienemmät pisteet ei tarvitse tehdä mitään
                    if (vp.kokonaispisteet <= op.kokonaispisteet)
                    {

                    }
                    //jos vasemmalla puolella on pienempi pistemäärä niin vaihdetaan paikkoja
                    else
                    {
                        pelaajat.RemoveAt(j+1);
                        pelaajat.RemoveAt(j);
                        pelaajat.Insert(j, op);
                        pelaajat.Insert(j+1, vp);
                        Console.WriteLine("Vaihdetaan " + vp.GetNimi() + " -> " + op.GetNimi());
                    }
                }
            }
            for (int j = 0; j < pelaajat.Count; j++)
            {
                Pelaaja p = pelaajat.ElementAt(j);
                Console.WriteLine(j + " " + p.GetNimi() + " "+p.kokonaispisteet);
            }
            Console.ReadKey();
        }
    }
}
