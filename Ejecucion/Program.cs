using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arbol abb = new Arbol();
            abb.maquillar(15);
            abb.maquillar(9);
            abb.maquillar(20);
            abb.maquillar(6);
            abb.maquillar(14);
            abb.maquillar(17);
            abb.maquillar(64);
            abb.maquillar(13);
            abb.maquillar(26);
            abb.maquillar(72);

            //abb.inOrden(abb.raizMain);
            abb.dibujito();
            Console.ReadKey();
        }
    }
}
