using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolOrdenadoNombres.clases.ArbolBinarioOrdenado
{
    class SoloNombres : Comparador
    {
        public int numMat;
        public string nombre;

        public bool igualQue(object q)
        {
            throw new System.NotImplementedException();
        }

        public bool mayorIgualQue(object q)
        {
            SoloNombres p2 = (SoloNombres)q;

            return nombre.CompareTo(p2.nombre) >= 0;
        }

        public bool mayorQue(object q)
        {
            SoloNombres p2 = (SoloNombres)q;
            return nombre.CompareTo(p2.nombre) > 0; //busca la letra mas cercana a la Z
        }

        public bool menorIgualQue(object q)
        {
            SoloNombres p2 = (SoloNombres)q;
            return nombre.CompareTo(p2.nombre) <= 0;
        }

        public bool menorQue(object op2)
        {
            SoloNombres p2 = (SoloNombres)op2;
            return nombre.CompareTo(p2.nombre) < 0; //busca la letra mas cercana a la A
        }
    }
}
