using System;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, formacao, contribuicao;

            nome = "Augusta Ada King (Lady Lovelace)";
            formacao = "matemática";
            contribuicao = "utilizar seus conhecimentos matemáticos para criar programas para a Máquina de Babbage, tornando-se a primeira programadora de computador do mundo.";

            Console.WriteLine($"{nome} foi uma {formacao} que se destacou por {contribuicao}");

        }
    }
}
