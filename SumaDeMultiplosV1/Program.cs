using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDeMultiplosV1
{
    class Program
    {
        static void Main(string[] args)
        {
            sumarmultiplos smulti = new sumarmultiplos();            
            Console.Write("La suma de los multiplos: "+ smulti.sumMultiplos(1000,"3,5"));
            Console.ReadKey();
        }
    }
}
