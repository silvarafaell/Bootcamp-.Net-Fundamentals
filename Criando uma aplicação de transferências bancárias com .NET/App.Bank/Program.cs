using System;

namespace App.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaconta = new Conta(TipoConta.PessoaFisica, 0, 0, "Francisco Rafael");


            Console.WriteLine(minhaconta.ToString());
        }
    }
}
