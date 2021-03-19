using ArbolOrdenadoNombres.clases.ArbolBinario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolOrdenadoNombres.clases.ArbolBinarioOrdenado
{
    class ArbolBinarioBusqueda : ArbolBinario.ArbolBinario
    {
        public Nodo buscar(object buscado)
        {
            Comparador dato;
            dato = (Comparador)buscado;
            if (raiz == null)
            {
                return null;
            }
            else
            {
                return localizar(raizArbol(), dato);
            }
        }

        protected Nodo localizar(Nodo raizSub, Comparador buscado)
        {
            if (raizSub == null)
            {
                return null;
            }
            else if (buscado.igualQue(raizSub.valorNodo()))
            {
                return raiz;
            }
            else if (buscado.menorQue(raizSub.valorNodo()))
            {
                return localizar(raizSub.subarbolIzquierdo(), buscado);
            }
            else
            {
                return localizar(raizSub.subarbolDerecho(), buscado);
            }

        }

        public void insertar(object valor)
        {
            Comparador dato;
            dato = (Comparador)valor;
            raiz = insertar(raiz, dato);
        }

        protected Nodo insertar(Nodo raizSub, Comparador dato)
        {
            if (raizSub == null)
            {
                raizSub = new Nodo(dato);
            }
            else if (dato.menorIgualQue(raizSub.valorNodo()))
            {
                Nodo iz;
                iz = insertar(raizSub.subarbolIzquierdo(), dato);
                raizSub.ramaIzquierda(iz);

            }
            else if (dato.mayorQue(raizSub.valorNodo()))
            {
                Nodo dr;
                dr = insertar(raizSub.subarbolDerecho(), dato);
                raizSub.ramaDerecha(dr);
            }
            return raizSub;
        }//ef

        public void eliminar(object valor)
        {
            Comparador dato;
            dato = (Comparador)valor;
            raiz = eliminar(raiz, dato);
        }

        protected Nodo eliminar(Nodo raizSub, Comparador dato)
        {
            if (raizSub == null)
            {
                throw new Exception("No hay nodo para eliminar");
            }
            else if (dato.menorQue(raizSub.valorNodo()))
            {
                Nodo iz;
                iz = eliminar(raizSub.subarbolIzquierdo(), dato);
                raizSub.ramaIzquierda(iz);
            }
            else if (dato.mayorQue(raizSub.valorNodo()))
            {
                Nodo dr;
                dr = eliminar(raizSub.subarbolDerecho(), dato);
                raizSub.ramaDerecha(dr);
            }
            else //nodo encontrado
            {
                Nodo q;
                q = raizSub;
                if (q.subarbolIzquierdo() == null)
                {
                    raizSub = q.subarbolDerecho();
                }
                else if (q.subarbolDerecho() == null)
                {
                    raizSub = q.subarbolIzquierdo();
                }
                else //tiene rama izqda y dercha
                {
                    q = reemplazar(q);
                }
                q = null;
            }
            return raizSub;
        }

        private Nodo reemplazar(Nodo act)
        {
            Nodo a, p;
            p = act;
            a = act.subarbolIzquierdo(); //rama de nodos menores

            while (a.subarbolDerecho() != null)
            {
                p = a;
                p.subarbolDerecho();
            }
            act.nuevoValor(a.valorNodo());

            if (p == act)
            {
                p.ramaIzquierda(a.subarbolIzquierdo());
            }
            else
            {
                p.ramaDerecha(a.subarbolDerecho());
            }
            return a;
        }
    }
}
