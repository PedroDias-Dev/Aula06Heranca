using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();

            cpf.nome = "Pedro";

            Console.WriteLine(cpf.Saudar());

            cpf.cpf = "000.000.000-00";
            Console.WriteLine(cpf.ValidarCPF());
        }

    }
}
