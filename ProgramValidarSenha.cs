using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("==== Informe uma senha ela deve conter Maiuscula e no minimo 8 caracteres. ====");

        Console.Write("Digite uma senha: ");
        string senha = ValidarSenha(Console.ReadLine());

        Console.Write("\nConfirme a senha: ");
        string confirmaSenha = ValidarSenha(Console.ReadLine());

        bool igual = ComparaTexto(senha, confirmaSenha);

        if (igual)
            Console.WriteLine("\nArmazenando dados!");
        else
            Console.WriteLine("\nRefaça o processo");
    }

    private static string ValidarSenha(string texto)
    {
        if (texto.Length < 8)
            Console.WriteLine("Tamanho inválido");
        if (!texto.Any(char.IsDigit))
            Console.WriteLine("Não possui número!");
        if (!texto.Any(char.IsUpper))
            Console.WriteLine("Não possui letra maiúscula");
        return texto;
    }

    private static bool ComparaTexto(string senha, string confirmaSenha)
    {
        if (senha == confirmaSenha)
        {
            Console.WriteLine("\nSenhas conferem!");
            return true;
        }
        else
        {
            Console.WriteLine("\nSenhas não conferem!");
            return false;
        }
    }
}
