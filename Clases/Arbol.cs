using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arbol
    {
        public Nodo raizMain = null;
        
        public void maquillar(int datito)
        {
            insertar(ref raizMain, datito);
        }
        private void insertar( ref Nodo raicita, int datito)
        {
            if (raicita == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = datito;

                raicita = nuevo;
            }
            else
            {
                if (datito < raicita.dato)
                {
                    insertar(ref raicita.izq, datito);
                }
                else if (datito > raicita.dato)
                {
                    insertar(ref raicita.der, datito);
                }
                else
                {
                    Console.WriteLine("El dato ya existe en el árbol");
                }
            }
        }

        public void preOrden(Nodo raicita)
        {
            if (raicita != null)
            {
                Console.Write(raicita.dato+" - ");
                preOrden(raicita.izq);
                preOrden(raicita.der);
            }
        }

        public void postOrden(Nodo raicita)
        {
            if (raicita != null)
            {
                postOrden(raicita.izq);
                postOrden(raicita.der);
                Console.Write(raicita.dato + " - ");
            }
        }

        public void inOrden(Nodo raicita)
        {
            if(raicita != null)
            {
                inOrden(raicita.izq);
                Console.Write(raicita.dato + " - ");
                inOrden(raicita.der);
            }        }

        private void dibujarArbol(Nodo raicita,int lvl)
        {
            if(raicita != null)
            {
                dibujarArbol(raicita.der, lvl+1);
                for (int i = 0; i < lvl; i++)
                {
                    Console.Write("\t");
                }
                Console.WriteLine(raicita.dato+"("+lvl+")");
                dibujarArbol(raicita.izq, lvl+1);
            }
        }

        public void dibujito()
        {
            dibujarArbol(raizMain, 0);
        }
    }
}
