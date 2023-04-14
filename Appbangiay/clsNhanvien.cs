using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appbangiay
{
    public class clsNhanvien
    {
       string sdt;
       public string sdtnv
        {
            get
            {
                return sdt;
            }

        set
            {
                sdt = value;
            }
        }
        public clsNhanvien(string sdt)
        {
            this.sdt = sdt;
        }
    }
}
