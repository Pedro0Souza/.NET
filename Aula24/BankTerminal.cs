namespace Aula24
{
    public class BankTerminal
    {
        //Instância da Classe BankOperations
        BankOperation bank = new BankOperation();
        public void Start()
        {
            var inExecution = true; 
            while (true)
            {
                DisplayMenu();
                string option = Console.ReadLine();

                if(option == "1")
                {
                    bank.CheckBalance();
                }
                else if (option =="2")
                {
                    bank.Deposit();
                }
                else if (option =="3")
                {
                    bank.WithDraw();
                }
                else if (option =="4")
                {
                    bank.Exit();
                }
            }
        }
        
        public void DisplayMenu()
        {
            Console.WriteLine("=====BANK=====");
            Console.WriteLine("1- Checar Saldo");
            Console.WriteLine("2- Depósito");
            Console.WriteLine("3- Saque");
            Console.WriteLine("4- Sair");
        }
    }
}