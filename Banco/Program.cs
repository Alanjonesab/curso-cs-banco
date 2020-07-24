using System;
using System.Globalization;

namespace Banco {
    class Program {
        static void Main(string[] args) {

            Conta conta;

            Console.Write("Número da Conta: ");
            string numeroConta = Console.ReadLine();
            Console.Write("Nome do Titular: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n): ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S') {

                Console.Write("Informe o valor do depósito: R$ ");
                double dep_inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numeroConta, nomeTitular, dep_inicial);
            }

            else {
                conta = new Conta(numeroConta, nomeTitular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + conta);
            Console.WriteLine();
            Console.Write("Informe o valor de depósito: R$ ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados atualizados: " + conta);
            Console.WriteLine();
            Console.Write("Informe o valor para saque: R$ ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + conta);
        }
    }
}
