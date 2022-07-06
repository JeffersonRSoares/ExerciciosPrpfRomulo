using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.EscolinhaTicTic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 4 - Crie um programa para a escolinha Tic Tic
             calcular 3 notas de um aluno.
             Entrar com o nome do aluno e as três notas
             Mostrar a soma das notas e a média.*/

           //declarãção de variáveis
            string nomeDoAluno,resultado;
            double nota1, nota2, nota3;
            double media;

            //Entrada de Dados
            Console.WriteLine("Abençoado qual o seu nome:");
            nomeDoAluno = Console.ReadLine();
            Console.WriteLine("Digite três notas");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());
            media = (nota1 +nota2 + nota3) /3;
            /*if (media >= 7)
            {
                resultado = "aprovado";
            }
            else
            {
                resultado = "reprovado";
            }*/
            resultado = media >= 7 ? "aprovado" : "reprovado";

            Console.WriteLine($"O aluno {nomeDoAluno} obteve a média {media} e foi {resultado}");

            Console.ReadKey();

}

    }
}
