using System;
using System.Collections.Generic;
using System.Linq;

namespace ComprasSupermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
        
            for (int i = 0; i < totalDeCasosDeTeste; i++) {
                List<string> listDeCompras = new List<String>(Console.ReadLine().Split(' '));
                List<string> listaSemDuplicados = listDeCompras.Distinct().ToList();

                listaSemDuplicados.Sort();
            
                foreach (string item in listaSemDuplicados) {
                    Console.Write($"{item} ");
                }
                
                Console.WriteLine(" ");
            }
        }
    }
}
