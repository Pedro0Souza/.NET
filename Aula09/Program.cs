namespace Aula09
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=====Operadores Lógicos=====");

            bool isLogged = false; 
            bool hasAdminAcces = false;

            Console.WriteLine("\nInformações do Usuário");
            Console.WriteLine("Usuário Logado: " + isLogged);
            Console.WriteLine("Acesso ao painel do administrador: " + hasAdminAcces);

            Console.WriteLine("\nPermissões");
            
            //Operador (||) - ou
            if (isLogged || hasAdminAcces)
            {
                Console.WriteLine("Acesso ao sistema concedido");
            }
            else
            {
                Console.WriteLine("Acesso ao sistema negado");
            }

            //Operador (&&) - E
            if (isLogged == true && hasAdminAcces == true)
            {
                Console.WriteLine("Acesso ao painel de administrador concedido");
            } else
            {
                Console.WriteLine("Acesso ao painel de administrador negado");
            }
            // Operador de negação (!)
            if (!isLogged)
            {
                Console.WriteLine("Usuário não está logado");
            }
            else
            {
                Console.WriteLine("Usuário está logado");
            }

        }
    }
}