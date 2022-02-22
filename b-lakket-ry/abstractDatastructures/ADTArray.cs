using System;
using System.Collections.Generic;
using System.Text;
using b_lakket_ry.model;

namespace b_lakket_ry.abstractDatastructures
{
    public class ADTArray : IFunktionalitet
    {
        private Bil[] biler;
        private int nextBil = 0;

        public ADTArray()
        {
            biler = new Bil[20];

            foreach (Bil b in MockDataFactory.GetBiler)
            {
                biler[nextBil++] = b;
            }

        }

        public void UdskrivAlleBiler()
        {
            Console.WriteLine("Alle Biler");
            for (int i = 0; i < nextBil; i++)
            {
                Console.WriteLine(biler[i]);
            }
        }

        public void TilføjBil(Bil bil)
        {
            if (findes(bil.Id))
            {
                throw new ArgumentException($"Id={bil.Id} findes i forvejen");
            }

            if (nextBil < biler.Length)
            {
                biler[nextBil++] = bil;
            }

        }

        public void FindOgUdskrivRødeBiler()
        {
            Console.WriteLine("Alle røde biler");
            for (int i = 0; i < nextBil; i++)
            {
                if (biler[i].Farve == "rød")
                {
                    Console.WriteLine(biler[i]);
                }
            }
        }

        public void FindOgUdskrivBilVedId(int id)
        {
            Console.WriteLine("Udskriver bil med id = " + id);
            if (findes(id))
            {
                for (int i = 0; i < nextBil; i++)
                {
                    if (biler[i].Id == id)
                    {
                        Console.WriteLine(biler[i]);
                    }
                }
            }
            else
            {
                throw new ArgumentException($"Id={id} findes ikke");
            }
        }

        public void FindOgUdskrivBilVedRegistreringsNummer(string regNummer)
        {
            Console.WriteLine("Udskriver bil med Registrerings nummer = " + regNummer);
            bool fundet = false;
            for (int i = 0; i < nextBil; i++)
            {
                if (biler[i].RegistreringsNr == regNummer)
                {
                    Console.WriteLine(biler[i]);
                    fundet = true;
                    break;
                }
            }

            if (!fundet)
            {
                throw new ArgumentException($"Registrering nummer ={regNummer} findes ikke");
            }
        }
    

    public void FindOgUdskrivÆldsteBil()
        {
            if (nextBil > 0)
            {
                Console.WriteLine(biler[0]);
            }
            else
            {
                Console.WriteLine("Der er ingen biler i collection");
            }
        }

        public void FindOgUdskrivNyesteBil()
        {
            if (nextBil > 0)
            {
                Console.WriteLine(biler[nextBil-1]);
            }
            else
            {
                Console.WriteLine("Der er ingen biler i collection");
            }
        }



        private bool findes(int id)
        {
            for (int i = 0; i < nextBil; i++)
            {
                if(biler[i].Id == id)
                {
                    return true;
                }
            }

            return false; // findes ikke
        }
    }
}
