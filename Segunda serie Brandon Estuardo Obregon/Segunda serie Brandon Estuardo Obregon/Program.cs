using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda_serie_Brandon_Estuardo_Obregon
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new vector(new List<int> { 2, 4, 6 }, new List<int> { 2, 9, 6 }, "+");
            Console.WriteLine("La suma de los vectores es de:");
            Console.WriteLine();

            for (int i = 0; i < v.segundocomponente.Count; i++)
            {
                Console.WriteLine(i + "->" + v.segundocomponente[i]);
            }
           Console.ReadKey();

        }
    }
}

