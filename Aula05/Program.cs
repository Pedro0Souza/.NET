namespace Aula05
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-------------Calculadora Simples-------------");
            Console.WriteLine("Digite o primeiro número: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
    
            Console.WriteLine("Digite o segundo número: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int sub = number1 - number2;
            int mult = number1 * number2;
            int div = number2 / number1;
            int module = number2 % number1;

            Console.WriteLine("O valor da soma é: " + sum);
            Console.WriteLine("O valor da subtração é: " + sub);
            Console.WriteLine("O valor da multiplicação é: " + mult);
            Console.WriteLine("O valor da divisão é: " + div);
            Console.WriteLine("O valor do modulo é: " + module);
       }
    }
}