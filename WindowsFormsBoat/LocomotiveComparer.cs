using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLocomotive
{
    public class LocomotiveComparer : IComparer<Vehicle>
    {

        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Electrovoz && y is Electrovoz)
            {
                return ComparerElectrovoz((Electrovoz)x, (Electrovoz)y);
            }
            if (y is Electrovoz)
            {
                return 1;
            }
            if (x is Electrovoz)
            {
                return -1;
            }
            else
            {
                return ComparerLocomotive((Locomotive)x, (Locomotive)y);
            }
        }

        private int ComparerLocomotive(Locomotive x, Locomotive y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerElectrovoz(Electrovoz x, Electrovoz y)
        {
            var res = ComparerLocomotive(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.roga != y.roga)
            {
                return x.roga.CompareTo(y.roga);
            }
            if (x.akum != y.akum)
            {
                return x.akum.CompareTo(y.akum);
            }
            return 0;
        }


    }
}
