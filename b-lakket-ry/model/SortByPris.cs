using System;
using System.Collections.Generic;
using System.Text;

namespace b_lakket_ry.model
{
    public class SortByPris:IComparer<Bil>
    {
        private bool reverse;

        public SortByPris(bool reverse)
        {
            this.reverse = reverse;
        }

        public int Compare(Bil x, Bil y)
        {
            int factor = (reverse) ? -1 : 1;

            return factor * (Convert.ToInt32(x.Pris) - Convert.ToInt32(y.Pris));

        }
    }
}
