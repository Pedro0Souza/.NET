namespace Aula22;

public class Program
{
    public static void Main()
    {
        //1. Criar a instância bank
        var bankpiriquita = new Bank();
        bankpiriquita.Name = "Banco Piriquita";
        bankpiriquita.Id = 091822;
        //2. Envie um email
        bankpiriquita.RequestNewCard();
    }
}