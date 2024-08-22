using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {

         Validador validador = new Validador();

        // Software de validação de senha
        Console.WriteLine("==== Informe uma senha ela deve conter Maiuscula e no minimo 8 caracteres. ====");

        Console.Write("Digite uma senha: ");
        String senha = Console.ReadLine();
        
        Console.Write("Confirme a senha: ");
        String confirmarSenha = Console.ReadLine();

        // testa se todos foram positivos
        if (validador.ValidarSenha(senha)) {
            Console.WriteLine("Senha Valida!");
        }else {
            Console.WriteLine("Senha Invalida!");
        }
        // testa se a senha se coincidem
        if (senha != confirmarSenha){
            Console.WriteLine("Senhas nao se coincidem");
        }
    }
    // faz a validação 
    private static string ValidarSenha(){
        bool tamanhoValido = senha.Length >= 8;
        bool contemNumero = senha.Any(char.IsDigit);
        bool contemMaiuscula = senha.Any(char.IsUpper);
    }
}