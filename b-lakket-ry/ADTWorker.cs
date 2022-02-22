using System;
using System.Collections.Generic;
using b_lakket_ry.abstractDatastructures;
using b_lakket_ry.model;

namespace b_lakket_ry
{
    internal class ADTWorker
    {
        public ADTWorker()
        {
        }

        public void Start()
        {
            IFunktionalitet biler = new ADTArray();
            //IFunktionalitet biler = new ADTList();
            //IFunktionalitet biler = new ADTDictionary();
            //IFunktionalitet biler = new ADTLinkedList();
            //IFunktionalitet biler = new ADTQueue();
            //IFunktionalitet biler = new ADTStack();
            //IFunktionalitet biler = new ADTHashSet();

            //try
            //{
            //    biler.TilføjBil(new Bil("gul", "findes ikke", 100000));
            //    biler.TilføjBil(new Bil("Nok gul", "findes", 66666) { Id = 3 });
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //biler.UdskrivAlleBiler();
            //biler.FindOgUdskrivBilVedId(3);
            //biler.FindOgUdskrivRødeBiler();
            //biler.FindOgUdskrivBilVedRegistreringsNummer("CD12345");
            //biler.FindOgUdskrivNyesteBil();
            //biler.FindOgUdskrivÆldsteBil();

            DoSomeSorting(new List<Bil>(MockDataFactory.GetBiler));
        }

        private void DoSomeSorting(List<Bil> liste)
        {
            UdskrivListe("Hele listen", liste);

            List<Bil> liste1 = new List<Bil>(liste);
            liste1.Sort(new SortById());
            UdskrivListe("Sorteret efter ID", liste1);

            List<Bil> liste2 = new List<Bil>(liste);
            liste2.Sort(new SortByRegNr());
            UdskrivListe("Sorteret efter Registrerings nummer", liste2);

            List<Bil> liste3 = new List<Bil>(liste);
            liste3.Sort(new SortByColorAndRegNr());
            UdskrivListe("Sorteret efter Farve", liste3);

            List<Bil> liste4 = new List<Bil>(liste);
            liste4.Sort(new SortByPris(false));
            UdskrivListe("Sorteret efter pris lav-høj", liste4);

            List<Bil> liste5 = new List<Bil>(liste);
            liste5.Sort(new SortByPris(true));
            UdskrivListe("Sorteret efter pris høj-lav", liste5);

        }

        private void UdskrivListe(String heading, List<Bil> biler)
        {
            Console.WriteLine($" ==== {heading} ====");
            foreach (Bil bil in biler)
            {
                Console.WriteLine(bil);
            }

        }
    }
}