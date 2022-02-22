using System;
using System.Collections.Generic;
using System.Text;
using b_lakket_ry.model;

namespace b_lakket_ry.abstractDatastructures
{
    public interface IFunktionalitet
    {
        /// <summary>
        /// Udskriver alle bilerne i collection på skærmen ved Console.WriteLine
        /// </summary>
        void UdskrivAlleBiler();

        /// <summary>
        /// Indsætter bilen 'bil' i collection, hvis den ikke allerede findes, ellers kastes en ArgumentException
        /// </summary>
        /// <param name="bil">Et bil objekt der skal indsættes</param>
        void TilføjBil(Bil bil);

        /// <summary>
        /// Finder alle biler der har farven rød og udskriver dem
        /// </summary>
        void FindOgUdskrivRødeBiler();

        /// <summary>
        /// Finder en bil udfra id og udskriver bilen, hvis der ikke findes en bil kastes en exception
        /// </summary>
        /// <param name="id">Det specificerede id der ønskes udskrevet</param>
        void FindOgUdskrivBilVedId(int id);

        /// <summary>
        /// Finder en bil udfra registreringsNummer og udskriver bilen, hvis der ikke findes en bil kastes en exception
        /// </summary>
        /// <param name="regNummer">Det registreringsNummer der ønskes udskrevet</param>
        void FindOgUdskrivBilVedRegistreringsNummer(string regNummer);

        /// <summary>
        /// Finder den bil der har været tilføjet først i collection og udskriver den
        /// </summary>
        void FindOgUdskrivÆldsteBil();

        /// <summary>
        /// Finder den bil der har været tilføjet sidst i collection og udskriver den
        /// </summary>
        void FindOgUdskrivNyesteBil();


    }
}
