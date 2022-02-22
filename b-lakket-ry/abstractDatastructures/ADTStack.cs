using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using b_lakket_ry.model;

namespace b_lakket_ry.abstractDatastructures
{
    public class ADTStack:IFunktionalitet
    {
        private Stack<Bil> biler;

        public ADTStack()
        {
            biler = new Stack<Bil>(MockDataFactory.GetBiler);
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
            if (biler.FirstOrDefault(b => b.Id == bil.Id) != null)
            {
                throw new ArgumentException($"Id={bil.Id} findes i forvejen");
            }

            biler.Push(bil);
        }

        public void FindOgUdskrivRødeBiler()
        {
            Console.WriteLine("Alle røde Biler  - gør lidt vold på ideen med Stack");
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
            Console.WriteLine("Udskriver bil med id = " + id + " - gør lidt vold på ideen med Stack");
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
            Console.WriteLine("Udskriver bil med Registrerings nummer = " + regNummer + " - gør lidt vold på ideen med Stack");
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
            // Gør lidt vold på stack da ideen er blot at push'e og pop'e
            if (biler.Count > 0)
            {
                Console.WriteLine("ældste bil = " + biler.Last());
            }
            else
            {
                Console.WriteLine("Collection er tom");
            }

        }

        public void FindOgUdskrivNyesteBil()
        {
            if (biler.Count > 0)
            {
                Console.WriteLine("nyeste bil = " + biler.Peek());
            }
            else
            {
                Console.WriteLine("Collection er tom");
            }
        }
    }
}
