using System;
using System.Collections.Generic;
using System.Text;

namespace b_lakket_ry.model
{
    public class SortByColorAndRegNr:IComparer<Bil>
    {
        public int Compare(Bil x, Bil y)
        {
            int dif = x.Farve.CompareTo(y.Farve);
            if (dif != 0)
            {
                return dif;
            }

            return x.RegistreringsNr.CompareTo(y.RegistreringsNr);
        }
    }
}
