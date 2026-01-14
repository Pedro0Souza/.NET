namespace Aula07;
public class Program
    {
    public static void Main()
    {
        Console.WriteLine("------------------------Operadores de Atribuição------------------------");
        //Inicializar a variável
        int x = 10;
        Console.WriteLine("\nValor Inicial da Variável de x: " + x);

        //Operador de atribuição simples (=)
        x = 20;
        Console.WriteLine("\nAtribuição Simples (=)");
        Console.WriteLine("Valor de x: " + x);
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (incremento, ++)
        x = x + 1;
        Console.WriteLine("\nAtribuição Composta Incremento (++)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (+=)
        x += 10;
        Console.WriteLine("\nAtribuição Composta (+=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (-=)
        x -= 10;
        Console.WriteLine("\nAtribuição Composta (-=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (*=)
        x *= 10;
        Console.WriteLine("\nAtribuição Composta (-=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (/=)
        x /= 10;
        Console.WriteLine("\nAtribuição Composta (/=)");
        Console.WriteLine("Novo valor de x: " + x);
    }
}
