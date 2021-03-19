using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolOrdenadoNombres.clases.ArbolBinarioOrdenado
{
    interface Comparador
    {
        bool igualQue(object q);
        bool menorQue(object q);
        bool menorIgualQue(object q);
        bool mayorQue(object q);
        bool mayorIgualQue(object q);
    }
}
