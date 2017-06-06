using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDeMultiplosV1
{
    class sumarmultiplos
    {
        public int sumMultiplos(int numMaximo, string numMultiplos)
        {
            string[] multiplos = numMultiplos.Split(',');
            int suma = 0;
            for (int i = 1; i < numMaximo; i++)
            {
                for (int j = 0; j < multiplos.Length; j++)
                {
                    if (i % Convert.ToInt32(multiplos[j]) == 0)
                    {
                        suma = suma + i;
                    }
                }
            }
            return suma;
        }
    }

    
}
