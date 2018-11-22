using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_HUERTA_MADUEÑO_OSCAR_ABRAHAM
{
    class MetodoBurbuja
    {
        public int[] vector;
        string linea;
        int Cantidad;

        public void Cargar()
        {
            Console.WriteLine("-------------Metodo de Burbuja-------------");
            Console.Write("Tamaño del Vector: "); //Se pide el tamaño del vector, asi se identifica cuantos numeros tocara ingresar
            linea = Console.ReadLine();
            Cantidad = int.Parse(linea);
            vector = new int[Cantidad];
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingrese elemento numero " + (f + 1) + ": "); //Valor del numero que se ordenara
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
        }

        public void ProcesoBurbuja()
        { //Se realiza un proceso de acomodamiento 
            int aux;
            for (int x = 1; x < vector.Length; x++)
                for (int i = vector.Length - 1; i >= x; i--)
                {
                    if (vector[i - 1] > vector[i]) //Acomodara los numeros menores de lado izquierdo y los mayores del derecho
                    {
                        aux = vector[i - 1];
                        vector[i - 1] = vector[i];
                        vector[i] = aux;
                    }
                }
        }

        public void Imprimir()
        {
            Console.WriteLine("Vector Ordenado: "); //Imprimir vector ordenado
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            MetodoBurbuja figura1 = new MetodoBurbuja(); //Creacion del objeto
            figura1.Cargar(); //Carga
            figura1.ProcesoBurbuja(); //Proceso
            figura1.Imprimir(); //Imprimir
        }
    }
}
