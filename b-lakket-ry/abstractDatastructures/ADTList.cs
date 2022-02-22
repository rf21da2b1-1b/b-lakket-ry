using System;
using System.Collections.Generic;
using System.Text;
using b_lakket_ry.model;

namespace b_lakket_ry.abstractDatastructures
{
    public class ADTList:IFunktionalitet
    {
        private List<Bil> biler;

        public ADTList()
        {
            biler = new List<Bil>(MockDataFactory.GetBiler);
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
            if (biler.Exists(b => b.Id == bil.Id))
            {
                throw new ArgumentException($"Id={bil.Id} findes i forvejen");
            }

            biler.Add(bil);
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
                Console.WriteLine("ældste bil = " + biler[0]);
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
                Console.WriteLine("nyeste bil = " + biler[biler.Count-1]);
            }
            else
            {
                Console.WriteLine("Collection er tom");
            }
        }
    }
}
