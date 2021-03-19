using ArbolOrdenadoNombres.clases.ArbolBinarioOrdenado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolOrdenadoNombres
{
    class Program
    {
        public static void pruebaNumeros()
        {
            ArbolBinarioBusqueda ArBus = new ArbolBinarioBusqueda();
            int[] datos = { 30, 5, 2, 40, 36, 85 };
            SoloNumeros es = new SoloNumeros();
            foreach (int d in datos)
            {
                es.numero = d;
                es.descripcion = $"insertar No.{d}";
                ArBus.insertar(es);
                es = new SoloNumeros();

            }
            int pausa;
            pausa = 0;
            //eliminar el numero 36
            es = new SoloNumeros();
            es.numero = 36;
            es.descripcion = "cualquier cosa";
            ArBus.eliminar(es);
            pausa = 0;
        }

        public static void pruebaNombres()
        {
            ArbolBinarioBusqueda ArBus = new ArbolBinarioBusqueda();
            string[] datos = { "diego", "arnoldo", "jefferson", "ruldin", "alejandra", "andrea" };
            SoloNombres es = new SoloNombres();
            foreach (string d in datos)
            {
                es.nombre = d;
                es.numMat = 0905;
                ArBus.insertar(es);
                es = new SoloNombres();
            }
            int pausa;
            pausa = 0;
        }

        static void Main(string[] args)
        {
            //pruebaNumeros();
            pruebaNombres();
        }
    }
}
