using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximocomundivisor
{
    public class tdd
    {
        public static int mcd(int nro1, int nro2)
        {
            while (nro2 != 0)
            {
             //Euclides
                int x = nro2;

                nro2 = nro1%nro2;

                nro1 = x;
            }
            return nro1;
        }
    }
}
