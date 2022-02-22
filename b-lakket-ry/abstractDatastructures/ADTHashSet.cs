using System;
using System.Collections.Generic;
using System.Text;
using b_lakket_ry.model;

namespace b_lakket_ry.abstractDatastructures
{
    public class ADTHashSet:IFunktionalitet
    {
        // dette kræver at Equals metoden og GetHashCode metoden overrides i klassen Bil

        private HashSet<Bil> biler;

        public ADTHashSet()
        {
            biler = new HashSet<Bil>(MockDataFactory.GetBiler);
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
            if (!biler.Add(bil))
            {
                throw new ArgumentException($"Id={bil.Id} findes i forvejen");
            }

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
            Bil findbil = new Bil(){Id = id};
            Bil fundetBil;
            if (biler.TryGetValue(findbil, out fundetBil))
            {
                Console.WriteLine(fundetBil);
            }
            else
            {
                throw new ArgumentException($"Id={id} findes ikke");
            }
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
            Console.WriteLine("ikke Muligt");
        }

        public void FindOgUdskrivNyesteBil()
        {
            Console.WriteLine("ikke Muligt");
        }
    }
}
