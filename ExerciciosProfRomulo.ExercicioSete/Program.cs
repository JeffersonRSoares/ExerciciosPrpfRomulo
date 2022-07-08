using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.ExercicioSete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             *Exercício 7
            ================================================
            Mostrar os números de 100 até 1 de forma decrescen
            */
            int i = 100;
            while (i > 0)
            {
                Console.WriteLine(i);
                //i=i-i;
                i--;
            }
        
        Console.ReadKey();
          }
    }
}
