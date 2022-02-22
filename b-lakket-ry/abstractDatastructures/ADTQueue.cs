using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using b_lakket_ry.model;

namespace b_lakket_ry.abstractDatastructures
{
    public class ADTQueue:IFunktionalitet
    {
        private Queue<Bil> biler;

        public ADTQueue()
        {
            biler = new Queue<Bil>(MockDataFactory.GetBiler);
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
            Bil b = biler.FirstOrDefault(b => b.Id == bil.Id);
            if (b != null)
            {
                throw new ArgumentException($"Id={bil.Id} findes i forvejen");
            }

            biler.Enqueue(bil);
        }

        public void FindOgUdskrivRødeBiler()
        {
            Console.WriteLine("Alle røde Biler - gør lidt vold på ideen med Queue");
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
            Console.WriteLine("Udskriver bil med id = " + id + "- gør lidt vold på ideen med Queue");
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
            Console.WriteLine("Udskriver bil med Registrerings nummer = " + regNummer + "- gør lidt vold på ideen med Queue");
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
            if (biler.Count > 0)
            {
                Console.WriteLine("ældste bil = " + biler.Peek());
            }
            else
            {
                Console.WriteLine("Collection er tom");
            }

        }

        public void FindOgUdskrivNyesteBil()
        {
            // Gør lidt vold på queue da ideen er blot at sætte ind og tage ud
            if (biler.Count > 0)
            {
                Console.WriteLine("nyeste bil = " + biler.Last());
            }
            else
            {
                Console.WriteLine("Collection er tom");
            }
        }
    }
}
