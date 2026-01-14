using System.Globalization;

namespace Aula21;

public class Program 
{
    //Alicação de Console - Ela vai  começar aqui 
    public static void Main()
    {
        //1. Instância(objeto) da Classe Cake - 'New'
        var cakestrawberry = new Cake();
        //2. Set de informações do bolo de morango
        cakestrawberry.Id = 472;
        cakestrawberry.Name = "Bolo de Morango Recheado";
        cakestrawberry.Description = "Intolerantes a lactose, não consumir";    
        cakestrawberry.Value = 30;
        cakestrawberry.Isfilling = true;

        //3. Mostrar ao usuário
        Console.WriteLine("Id: " + cakestrawberry.Id);
        Console.WriteLine("Nome: " + cakestrawberry.Name);
        Console.WriteLine("Descrição: " +  cakestrawberry.Description);
        Console.WriteLine("Valores: R$ " + cakestrawberry.Value);
        Console.WriteLine("É recheado: " + cakestrawberry.Isfilling);

        Console.WriteLine("--------------------------");
        //--------------------------------
        //4. Instância  de Bolo de Chocolate  
        var cakeChocolate = new Cake();

        cakeChocolate.Id = 556;
        cakeChocolate.Name = "Bolo de Chocolate";
        cakeChocolate.Description = "Cacau meio amargo 30%";    
        cakeChocolate.Value = 45;
        cakeChocolate.Isfilling = false;

        Console.WriteLine("Id: " + cakeChocolate.Id);
        Console.WriteLine("Nome: " + cakeChocolate.Name);
        Console.WriteLine("Descrição: " +  cakeChocolate.Description);
        Console.WriteLine("Valores: R$ " + cakeChocolate.Value);
        Console.WriteLine("É recheado: " + cakeChocolate.Isfilling);
        //--------------------------------
        //Listas de Bolos 
        Console.WriteLine("--------------------------");
        Console.WriteLine("Lista de Bolos - Criação  de Lista");
        List<Cake> cakeList = new List<Cake>();
        cakeList.Add(cakestrawberry);
        cakeList.Add(cakeChocolate);

        //6.Visualizar
        foreach(Cake cake  in cakeList)
        {
        Console.WriteLine("Id: " + cake.Id);
        Console.WriteLine("Nome: " + cake.Name);
        Console.WriteLine("Descrição: " +  cake.Description);
        Console.WriteLine("Valores: R$ " + cake.Value);
        Console.WriteLine("É recheado: " + cake.Isfilling);
        Console.WriteLine("--------------------------");

        }
    }
}