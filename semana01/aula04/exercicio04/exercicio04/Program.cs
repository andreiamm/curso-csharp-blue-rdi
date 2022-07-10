using System;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rodadas, opcaoUsuario, opcaoComputador, scoreUsuario, scoreComputador, empate;

            Console.Write("Quantas rodadas você quer jogar? ");
            rodadas = int.Parse(Console.ReadLine());

            opcaoComputador = 0;
            scoreUsuario = 0;
            scoreComputador = 0;
            empate = 0;

            while (rodadas != 0)
            {
                for (int i = 1; i <= rodadas; i++)
                {
                    Console.WriteLine($"\n{i}a RODADA:");
                    Console.Write("Escolha: 1 - pedra | 2 - papel | 3 - tesoura: ");
                    opcaoUsuario = int.Parse(Console.ReadLine());

                    while (opcaoUsuario < 1 || opcaoUsuario > 3)
                    {
                        Console.Write("Valor inválido! Escolha: 1 - pedra | 2 - papel | 3 - tesoura: ");
                        opcaoUsuario = int.Parse(Console.ReadLine());
                    }

                    Random rdn = new Random(DateTime.Now.Millisecond);
                    opcaoComputador = rdn.Next(1, 4);

                    if (opcaoUsuario == opcaoComputador)
                    {
                        Console.WriteLine("EMPATE!");
                        empate++;
                    }
                    else if ((opcaoUsuario == 1 && opcaoComputador == 2) || (opcaoUsuario == 2 && opcaoComputador == 3) || (opcaoUsuario == 3 && opcaoComputador == 1))
                    {
                        Console.WriteLine("Parabéns, VOCÊ ganhou!");
                        scoreUsuario++;
                    }
                    else
                    {
                        Console.WriteLine("Xi...o computador ganhou...");
                        scoreComputador++;
                    }
                }

                Console.WriteLine("\n********** PONTUAÇÃO ********** ");
                Console.WriteLine($"Você: {scoreUsuario}");
                Console.WriteLine($"Computador: {scoreComputador}");
                Console.WriteLine($"Empates: {empate}");

                Console.Write("\nInforme o número de rodadas ou 0 para parar de jogar: ");
                rodadas = int.Parse(Console.ReadLine());
            }
        }
    }
}
