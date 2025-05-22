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
            abb.insertarEncapsulado(15);
            abb.insertarEncapsulado(9);
            abb.insertarEncapsulado(20);
            abb.insertarEncapsulado(6);
            abb.insertarEncapsulado(14);
            abb.insertarEncapsulado(17);
            abb.insertarEncapsulado(64);
            abb.insertarEncapsulado(13);
            abb.insertarEncapsulado(26);
            abb.insertarEncapsulado(72);
            abb.insertarEncapsulado(8);

            abb.dibujito();

            Console.Write("Qué nodo quieres eliminar?: ");
            int nodito = int.Parse(Console.ReadLine());

            abb.eliminarEncapsulado(nodito);
            abb.dibujito();
        }
    }
}
