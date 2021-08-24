using System;

namespace FilaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
                int totalDeCasosDeTeste = int.Parse(Console.ReadLine());

            for (int teste = 0; teste < totalDeCasosDeTeste; teste++)
            {



            int totalNumeroDeClientesCalculados = int.Parse(Console.ReadLine());

            string fila = Console.ReadLine();
            int[] filaNumerico = Array.ConvertAll(fila.Split(' '), s => int.Parse(s));
            int mudancasPosicao = 0;
            int[] filaComparar = new int[filaNumerico.Length];
            Array.Copy(filaNumerico, filaComparar, filaNumerico.Length);
            Array.Sort(filaComparar);
            Array.Reverse(filaComparar);

            for (int i = 0; i < filaNumerico.Length; i++)
            {
                if (filaNumerico[i] != filaComparar[i])
                {
                    mudancasPosicao++;
                }
            }

            Console.WriteLine(filaNumerico.Length - mudancasPosicao);
            }


        }
                   
    }
}
