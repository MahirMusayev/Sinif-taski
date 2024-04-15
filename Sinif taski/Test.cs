using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_taski
{
    internal class Test
    {

        public int[] Arr { get; set; }
        public int this[int i]
        {
            get { return Arr[i]; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("deyer 0 - dan kicik ola bilmez");
                if (i > Arr.Length)
                    throw new IndexOutOfRangeException();
            }
        }
        public Test()
        {
            Arr = new int[10];
        }
    }
}
