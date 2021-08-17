using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, nota4, media;
            string aluno;

            Console.Write("Digite o nome do aluno:");
            aluno = Console.ReadLine();

            Console.Write("Digite a nota 1:");
            nota1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota 2:");
            nota2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota 3:");
            nota3 = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota 4:");
            nota4 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("O aluno: " +  aluno +  " " +  "obteve a media: " + media);

            if (media >= 7)
            {
               Console.WriteLine("Parabens você foi aprovado");
            }
            else
            {
                Console.WriteLine("Infelizmente você foi reprovado");
            }
               


        }
    }
}
