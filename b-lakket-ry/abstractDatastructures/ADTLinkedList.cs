using System;
using System.Collections.Generic;
using System.Text;
using b_lakket_ry.model;

namespace b_lakket_ry.abstractDatastructures
{
    public class ADTLinkedList:IFunktionalitet
    {
        private LinkedList<Bil> biler;

        public ADTLinkedList()
        {
            biler = new LinkedList<Bil>(MockDataFactory.GetBiler);
        }

        public void UdskrivAlleBiler()
        {
            Console.WriteLine("Alle Biler");
            foreach (Bil bil in biler)
            {
                Console.WriteLine(bil);
            }
        }

        public void TilføjBil(Bil bil)
        {
            foreach (Bil b in biler)
            {
                if ( b.Id == bil.Id)
                {
                    throw new ArgumentException($"Id={bil.Id} findes i forvejen");
                }
            }

            biler.AddLast(bil);
        }

        public void FindOgUdskrivRødeBiler()
        {
            Console.WriteLine("Alle røde Biler");
            foreach (Bil bil in biler)
            {
                if (bil.Farve == "rød")
                {
                    Console.WriteLine(bil);
                }
            }
        }

        public void FindOgUdskrivBilVedId(int id)
        {
            Console.WriteLine("Udskriver bil med id = " + id);
            foreach (Bil bil in biler)
            {
                if (bil.Id == id)
                {
                    Console.WriteLine(bil);
                    return;
                }
            }

            throw new ArgumentException($"Id={id} findes ikke");
        }

        public void FindOgUdskrivBilVedRegistreringsNummer(string regNummer)
        {
            Console.WriteLine("Udskriver bil med Registrerings nummer = " + regNummer);
            foreach (Bil bil in biler)
            {
                if (bil.RegistreringsNr == regNummer)
                {
                    Console.WriteLine(bil);
                    return;
                }
            }

            throw new ArgumentException($"Registrerings nummer={regNummer} findes ikke");
        }

        public void FindOgUdskrivÆldsteBil()
        {
            // antage der kun benyttes Add til at indsætte (indsætter til sidst)
            if (biler.Count > 0)
            {
                Console.WriteLine("ældste bil = " + biler.First.Value);
            }
            else
            {
                Console.WriteLine("Collection er tom");
            }

        }

        public void FindOgUdskrivNyesteBil()
        {
            // antage der kun benyttes Add til at indsætte (indsætter til sidst)
            if (biler.Count > 0)
            {
                Console.WriteLine("nyeste bil = " + biler.Last.Value);
            }
            else
            {
                Console.WriteLine("Collection er tom");
            }
        }

    }
}
