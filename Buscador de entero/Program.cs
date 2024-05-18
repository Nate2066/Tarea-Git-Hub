//By Nate :D

namespace BusquedaDeEntero
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese la cantidad deseada de espacios en el arreglo");
                byte RangoArreglo = Convert.ToByte(Console.ReadLine());

                int[] ArregloEnteros = new int[RangoArreglo];

                Console.WriteLine("Ingrese los valores dentro del arreglo");

                for (int i = 0; i < RangoArreglo; i++)
                {
                    Console.WriteLine($"Valor {i + 1} de {RangoArreglo}");
                    Console.Write(">>");
                    ArregloEnteros[i] = Convert.ToInt32(Console.ReadLine());
                }
                
                Console.Clear();
                Console.WriteLine("Arreglo desordenado:");
                Console.WriteLine("");
                foreach (int item in ArregloEnteros)
                {
                    Console.Write($"{item}, ");
                }

                //Ordenacion

                BubbleSort(ArregloEnteros);
                Console.WriteLine("");
                Console.WriteLine("Arreglo ordenado:");
                Console.WriteLine("");
                foreach (int item in ArregloEnteros)
                {
                    Console.Write($"{item}, ");
                }

                Console.WriteLine("");
                Console.WriteLine("Ingrese el numero que desee buscar");
                Console.WriteLine(">>");
                int Numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");



                Console.WriteLine( BusquedaBinaria(ArregloEnteros, Numero));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Solo numeros enteros");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error! Numero demasiado grande");
            }
        }
        public static string BusquedaBinaria(int[] arreglo, int elemento)
        {
            int inicio = 0;
            int fin = arreglo.Length - 1;

            while (inicio <= fin)
            {
                int medio = inicio + (fin - inicio) / 2;

                if (arreglo[medio] == elemento)
                {
                    return "El numero se encuentra en la posicion: " + (medio + 1);
                }

                if (arreglo[medio] > elemento)
                {
                    fin = medio - 1;
                }

                else
                {
                    inicio = medio + 1;
                }
            }
            return "El numero no se encuentra dentro del arreglo: " + -1;
        }
        static int[] BubbleSort(int[] Arreglo)
        {
            int n = Arreglo.Length;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n-i-1; j++)
                {
                    if(Arreglo[j] > Arreglo[j + 1])
                    {
                        int temp = Arreglo[j];
                        Arreglo[j] = Arreglo[j + 1];
                        Arreglo[j + 1] = temp;
                    }
                }
            }
            return Arreglo;
        }
    }
}