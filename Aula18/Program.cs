namespace Aula18;
using System. IO;
public class Program
{
    public static void Main()
    {
        //1. Criar um arquivo
        // string content = "skate vibration";
        // File.WriteAllText("file2.txt", content);

        // Console.WriteLine("Arquivo criado com sucesso");

        //2. Criar arquivo em um lugar específico
        // string path = @"C:\Users\pedro\Documents\Estudos\Dotnet\fileName.txt";

        // string content = "Hello Worlds";
        // File.WriteAllText(path, content);
        
        // Console.WriteLine("Arquivo criado com sucesso");

        // string path = @"C:\Users\pedro\Documents\Estudos\Dotnet\Aula18";
        // string fileName = "myDocument.Doc";
        // string filhoPath = path + fileName;

        // string content = "Hello Worlds";
        // File.WriteAllText(filhoPath, content);
        
        // Console.WriteLine("Arquivo Word criado com sucesso");

        //4. Inserir um parágrafo em um arquivo
        // string path = @"C:\Users\pedro\Documents\Estudos\Dotnet/Aula18";
        // string fileName = "MyDocument.Doc";
        // string filePath = path + fileName;
    
        // string additionalContent = "| Curso de C# e .NET";
        // File.AppendAllText(filePath, additionalContent);
        // Console.WriteLine("Arquivo Atualizado com sucesso");

        //5.Ler o arquivo
        string path = @"C:\Users\pedro\Documents\Estudos\Dotnet/Aula18";
        string fileName = "MyDocument.Doc";
        string filePath = path + fileName;

        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);
    }
}