using System;

namespace ordenarVector
{
    class Program
    {
        static void Main(string[] args)
        {
            /* onsole.WriteLine("Hello World!");*/
            int[] n = { 25, 63, 8, 12, 11, 5 };
            int temp;
            int t = n.Length;

            Console.WriteLine(" - Arrlego original -");


            foreach (int elemento in n)
            {
                Console.Write(elemento + " | ");
            }

            Console.WriteLine(" Tanamo vector " + t);

            /* ordenar el vector */
            /*   for (int i = 0 ; i< n.Length ; i++ )  */

            for (int j = 1; j < t; j++)
            {

                for (int i = 0; i < t - j; i++)
                {   /* inicia el for anidado */
                    if (n[i] > n[i + 1])
                    {
                        temp = n[i];
                        n[i] = n[i + 1];
                        n[i + 1] = temp;
                    }
                } /* finaliza el for anidado */
            }

            Console.WriteLine(" - Arrlego ordenado  -");
            foreach (int elemento in n)
            {
                Console.Write(elemento + " | ");
            }


            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
