using System;
using System.Globalization;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome;
            int horasTrabalhadas;
            float valorHora;

            Console.WriteLine("DADOS DO FUNCIONÁRIO: ");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Quantidade de horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());   
            Console.Write("Pagamento por hora: R$ ");
            valorHora = float.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"\n{nome} receberá um salário de R$ {(horasTrabalhadas * valorHora).ToString("F2", CI)}");
        }
    }
}
