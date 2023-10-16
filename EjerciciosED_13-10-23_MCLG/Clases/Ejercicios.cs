using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EjerciciosED_13_10_23_MCLG.Clases
{
    internal class Ejercicios
    {
        //Considere un arreglo entero t de dos por tres.

        //a) Escriba una instrucción que declare y cree a t.
        int[,] t = new int[2, 3];

        //b) ¿Cuántas filas tiene t?
        // 2 filas

        //c) ¿Cuántas columnas tiene t?
        //3 columnas

        //d) ¿Cuántos elementos tiene t?
        // tiene espacio para gusradar 6 elemnetos

        //e) Escriba expresiones de acceso para todos los elementos en la fila 1 de t.
        public void AccederFila1()
        {
            Console.WriteLine(t[1, 0]);
            Console.WriteLine(t[1, 1]);
            Console.WriteLine(t[1, 2]);
        }

        //f ) Escriba expresiones de acceso para todos los elementos en la columna 2 de t.
        public void AccederColumna2()
        {
            Console.WriteLine(t[0, 2]);
            Console.WriteLine(t[1, 2]);
        }

        //g) Escriba una sola instrucción que asigne cero al elemento de t en la fila 0 y la columna 1.
        public void ElementoFila0Columna1()
        {
            t[0, 1] = 0;
        }

        //h) Escriba una serie de instrucciones que inicialice cada elemento de t con cero.No utilice una instrucción de repetición.
        public void InicializarElemntos()
        {
            t[0, 1] = 0;
            t[0, 0] = 0;
            t[0, 2] = 0;
            t[1, 0] = 0;
            t[1, 1] = 0;
            t[1, 2] = 0;
        }

        //i) Escriba una instrucción for anidada que inicialice cada elemento de t con cero.
        public void InicializarConFor()
        {
            for(int i=0; i<t.GetLength(0); i++)
            {
                for(int j=0; j<t.GetLength(1); j++)
                {
                    t[i,j] = 0;
                }
            }
        }

        //j) Escriba una instrucción for anidada que reciba como entrada del usuario los valores de los elementos de t.
        public void EntardaConFor()
        {
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    Console.WriteLine($" dame los elemetos de la posicion {i, j}");
                    t[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        //k) Escriba una serie de instrucciones que determine e imprima el valor más pequeño en t.
        public void ImprimirConFor()
        {
            int menor = t[0, 0];
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    Console.Write(t[i, j] + " ");
                    if (menor > t[i,j])
                    {
                        menor = t[i,j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"el numero menor es: {menor}");
        }

        //l) Escriba una instrucción Console.WriteLine que muestre los elementos de la primera fila de t. No utilice repetición.
        public void PrimeraFilaT()
        {
            Console.WriteLine($"{t[0, 0]} {t[0, 1]} {t[0, 2]}");
        }

        //m) Escriba una instrucción que totalice los elementos de la tercera columna de t.No utilice repetición.
        public void TotalizarElemntosColumna3T()
        {
            int suma = t[0,2] + t[1,2];
        }

        //n) Escriba una serie de instrucciones para imprimir el contenido de t en formato tabular.Enliste los índices
        //de columna como encabezados a lo largo de la parte superior, y enliste los índices de fila a la izquierda de cada fila.


    }
}
