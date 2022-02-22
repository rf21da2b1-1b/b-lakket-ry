using System;
using System.Collections.Generic;
using System.Text;

namespace b_lakket_ry.model
{
    public class SortByRegNr:IComparer<Bil>
    {
        public int Compare(Bil x, Bil y)
        {
            return x.RegistreringsNr.CompareTo(y.RegistreringsNr);
        }
    }
}
