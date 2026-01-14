namespace Aula19;
using System.IO;
public class Program
{
    public static void Main()
    {
        //1. Estrutura
        string path = @"C:\Users\pedro\Documents\Estudos\Dotnet\Aula19\";
        string fileName = "Lista_de_compras.txt";
        string filePath = path + fileName;

        List<string> shoppingList = new List<string>();

        //Lógica
        if (File.Exists(filePath))
        {
            shoppingList.AddRange(File.ReadAllLines(filePath));
        }
        while (true)
        {
            Console.WriteLine("\n== Lista de Compras ===");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Exibir Lista");
            Console.WriteLine("4. Limpar Lista");
            Console.WriteLine("5. Sair");
            Console.WriteLine("Escolha um número para continuar");

            string choiceUser = Console.ReadLine();

            switch (choiceUser)
            {
                case "1":
                    Console.WriteLine("Digite o nome do item para adicionar: ");
                    string itemInsert = Console.ReadLine();

                    if (!string.IsNullOrEmpty(itemInsert))
                    {
                        shoppingList.Add(itemInsert);
                        Console.WriteLine($"Item {itemInsert} adicionado com sucesso !");
                    }
                    else
                    {
                        Console.WriteLine("O item não pode ser vazio!");
                    }
                break;

                case "2":
                    Console.WriteLine("Digite o nome do item para remover: ");
                    string itemToRemove = Console.ReadLine();
                    if (shoppingList.Remove(itemToRemove))
                    {
                        Console.WriteLine($"item{itemToRemove} Removido com sucesso");
                    }
                    else
                    {
                        Console.WriteLine($"item{itemToRemove} não encontrado!");
                    }
                    break;

                case "3":
                    Console.WriteLine("\n Itens na sua Lista de Compras: ");
                    if (shoppingList.Count == 0)
                    {
                        Console.WriteLine("Sua lista esta vazia!");
                    }
                    else
                    {
                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {shoppingList[i]}");
                        }
                    }
                break;
    
                case"4":
                    if (shoppingList.Count > 0)
                        {
                        shoppingList.Clear();
                        Console.WriteLine("\n A lista de compras foi completamente esvaziada!");
                        }
                        else    
                        {
                        Console.WriteLine("\n A lista já está vazia. Nada foi removido.");
                        }
                    break;

                case"5":
                    File.WriteAllLines(filePath, shoppingList);
                    Console.WriteLine("Lista salva com sucesso! Saindo...");
                    return;

                default: 
                    Console.WriteLine("Opção inválida. Tente Novamente");
                break;
            }
        }
    }
}