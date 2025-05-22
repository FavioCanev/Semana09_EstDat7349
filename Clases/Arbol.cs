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
        
        public void insertarEncapsulado(int datito)
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


        public void eliminarEncapsulado(int buscado)
        {
            eliminar(ref raizMain, buscado);
        }

        private Nodo buscarMayor(Nodo raiz)
        {
            if (raiz.der == null)
            {
                return raiz;
            }
            else
            {
                return buscarMayor(raiz.der);
            }
        }

        private Nodo buscarMenor(Nodo raiz)
        {
            if (raiz.izq == null)
            {
                return raiz;
            }
            else
            {
                return buscarMenor(raiz.izq);
            }
        }
        private void eliminar(ref Nodo raicita, int buscado)
        {
            if (raicita == null)
            {
                Console.WriteLine("El dato no existe en el árbol");
            }
            else
            {
                if (buscado < raicita.dato) //izquierda
                {
                    eliminar(ref raicita.izq, buscado);
                }
                else if (buscado > raicita.dato) //derecha
                {
                    eliminar(ref raicita.der, buscado);
                }
                else //igual, encontré, eliminarlo
                {
                    if (raicita.izq == null && raicita.der == null)//verificamos si es una hoja
                    {
                        raicita = null;
                    }
                    else if (raicita.izq != null && raicita.der == null)// tiene un hijo a la izquierda
                    {
                        Nodo mayor = buscarMayor(raicita.izq);
                        int aux = raicita.dato;
                        raicita.dato = mayor.dato;
                        mayor.dato = aux;
                        eliminar(ref raicita.izq, buscado);
                    }
                    else //tiene un hijo a la derecha
                    {
                        Nodo mayor = buscarMenor(raicita.der);
                        int aux = raicita.dato;
                        raicita.dato = mayor.dato;
                        mayor.dato = aux;
                        eliminar(ref raicita.der, buscado);
                    }
                }
            }
        }
    }
}
