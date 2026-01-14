using System.Security.Cryptography.X509Certificates;

namespace Aula24
{
    public class BankOperation
    {
        decimal balance = 1000;
        public void CheckBalance()
        {
            Console.WriteLine($"Seu saldo é de R$ {balance}");
        }
        public void Deposit()
        {
            Console.WriteLine("Informe o valor a ser depositado: R$ ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount ) && amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente Novamente");
            }
        }
        public void WithDraw()
        {
            Console.WriteLine("informe o valor a ser retirado: R$ ");

            if (decimal.TryParse(Console.ReadLine(), out decimal amount ) && amount > 0)
            {
                if (amount <= balance)
                {
                    balance = balance - amount;
                    Console.WriteLine($"Valor de R$ {amount} retirado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Saldo inválido");
                }
            }
        }
            public void Exit()
            {
                Console.WriteLine("Saindo...");
            }
        }
    }

