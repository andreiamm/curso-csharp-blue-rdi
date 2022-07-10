using System;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();

            // cadastra usuário
            Console.WriteLine(login.SignUp("jose01", "1234"));

            // tenta logar com usuário inválido
            Console.WriteLine(login.SignIn("jose", "1234"));

            // tenta logar com senha inválida
            Console.WriteLine(login.SignIn("jose01", "123"));

            // tenta alterar senha sem estar logado
            Console.WriteLine(login.ChangePassword("010203"));

            // tenta logar com usuário e senha corretos
            Console.WriteLine(login.SignIn("jose01", "1234"));

            // altera senha
            Console.WriteLine(login.ChangePassword("010203"));

        }
    }
}
