using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.ExercicioOito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 8
             ======================

             * Crie um programa que entre com um número inteiro
                e mostre o fatorial desse número.
            Exemplo:
            5! = 120
            5*4*3*2*1=  120
            */
            int i, number, fact;
            Console.WriteLine("Digite um número");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFatorial do número dado é?: " + fact);
            Console.ReadLine();
        }
    }
}
