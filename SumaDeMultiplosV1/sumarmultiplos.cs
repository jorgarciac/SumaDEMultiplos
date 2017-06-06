using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDeMultiplosV1
{
    class sumarmultiplos
    {
        public int sumMultiplos()
        {
            int suma = 0;
            for (int i=1;i<1000;i++)
            {
                if (i%3==0 || i%5==0)
                {
                    suma =suma + i;
                }
            }
            return suma;
        }
    }

    
}
