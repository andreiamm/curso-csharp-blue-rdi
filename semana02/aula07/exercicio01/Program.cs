using System;
using System.Globalization;
using System.Collections.Generic;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            List<Students> students = new List<Students>();

            Console.Write("Quantos alunos serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nDados do {i + 1}o aluno:");
                Console.Write("Código do aluno: ");
                int register = int.Parse(Console.ReadLine());
                Console.Write("Nome no aluno: ");
                string name = Console.ReadLine();
                Console.Write("Nota do teste 1: ");
                double score1 = double.Parse(Console.ReadLine(), CI);
                Console.Write("Nota do teste 2: ");
                double score2 = double.Parse(Console.ReadLine(), CI);
                Console.Write("Percentual de presença: ");
                int attendance = int.Parse(Console.ReadLine());

                students.Add(new Students(register, name, score1, score2, attendance));
            }

            Console.Write("\nDigite 1 para pesquisar um aluno pelo código, 2 para mostrar todos os alunos ou 0 para sair: ");
            int valor = int.Parse(Console.ReadLine());

            while (valor != 0)
            {
                switch (valor)
                {
                    case 1:
                        Console.Write("Código do aluno: ");
                        int register = int.Parse(Console.ReadLine());

                        Students stu = students.Find(x => x.RegisterNumber == register);
                        if (stu != null)
                        {
                            Console.WriteLine(stu);
                        }
                        else
                        {
                            Console.WriteLine("Não há nenhum aluno cadastrado com este código");
                        }

                        break;
                    case 2:
                        foreach (Students student in students)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    default:
                        Console.WriteLine("Comando inválido.");
                        break;
                }

                Console.Write("\nDigite 1 para pesquisar um aluno pelo código, 2 para mostrar todos os alunos ou 0 para sair: ");
                valor = int.Parse(Console.ReadLine());
            }


        }
    }
}
