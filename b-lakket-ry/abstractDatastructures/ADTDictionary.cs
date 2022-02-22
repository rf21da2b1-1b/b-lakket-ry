using System;
using System.Collections.Generic;
using System.Text;
using b_lakket_ry.model;

namespace b_lakket_ry.abstractDatastructures
{
    public class ADTDictionary:IFunktionalitet
    {
        private Dictionary<int, Bil> biler;

        public ADTDictionary()
        {
            biler = new Dictionary<int, Bil>();
            foreach (Bil bil in MockDataFactory.GetBiler)
            {
                biler.Add(bil.Id, bil);
            }
        }

        public void UdskrivAlleBiler()
        {
            Console.WriteLine("Alle Biler");
            foreach (Bil bil in biler.Values)
            {
                Console.WriteLine(bil);
            }
        }

        public void TilføjBil(Bil bil)
        {
            if (!biler.ContainsKey(bil.Id))
            {
                throw new ArgumentException($"Id={bil.Id} findes i forvejen");
            }

            biler.Add(bil.Id, bil);
        }

        public void FindOgUdskrivRødeBiler()
        {
            Console.WriteLine("Alle røde Biler");
            foreach (Bil bil in biler.Values)
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
            if (biler.ContainsKey(id))
            {
                Console.WriteLine(biler[id]);
                return;
            }

            throw new ArgumentException($"Id={id} findes ikke");
        }

        public void FindOgUdskrivBilVedRegistreringsNummer(string regNummer)
        {
            Console.WriteLine("Udskriver bil med Registrerings nummer = " + regNummer);
            foreach (Bil bil in biler.Values)
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
            Console.WriteLine("ikke Muligt");

        }

        public void FindOgUdskrivNyesteBil()
        {
            Console.WriteLine("ikke Muligt");
        }
    }
}
