using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoTetris
{
    class Program
    {
        private int[,] matriz = {
                                    { 0, 0, 0, 0},
                                    { 0, 0, 1, 0},
                                    { 0, 1, 1, 1},
                                    { 0, 0, 0, 0} };
        public Program()
        {
            for (int i = 0; i < 5; i++)
            {
                imprimir();
                girar(1);
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            new Program();
        }

        public void girar(int sentido)
        {
            int filas = matriz.GetLength(0) - 1;
            int columnas = matriz.GetLength(1) - 1;
            int nf = 0, nc = 0;
            //Console.WriteLine("filas " + filas + " columnas " + columnas);
            int[,] matrizAux = new int[4, 4];
            for (int i = 0; i <= filas; i++)
            {
                for (int j = 0; j <= columnas; j++)
                {
                    if(sentido == 1)
                    {
                        nf = j;
                        nc = filas - i;
                    }

                    else if(sentido == -1)
                    {
                        nf = columnas - j;
                        nc = i;
                    }
                    
                    //Console.WriteLine("i: " + i + " j: " + j
                    //+ " nf: " + nf + " nc: " + nc);
                    matrizAux[i, j] = matriz[nf, nc];
                }
            }
            for (int i = 0; i <= filas; i++)
            {
                for (int j = 0; j <= columnas; j++)
                {
                    matriz[i, j] = matrizAux[i, j];
                }
            }

        }

        public void imprimir()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine("");
            }
        }

    }
}
