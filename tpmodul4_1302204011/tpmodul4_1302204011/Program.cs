using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric.SapaUser<string>("Putri");
        }
        class HaloGeneric
        {
            public static void SapaUser<X>(X inputUser)
            {
                Console.WriteLine("Halo user " + inputUser);
            }
        }
    }
}
