using System;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char mark;
            int round, player;
            bool wins, taken;
            
            Board board = new Board();

            Console.Write("Jogador 1, escolha a sua marcação (O ou X): ");
            mark = char.Parse(Console.ReadLine());
            board.SetPlayersMarks(mark);

            round = 1;
            wins = false;
            while (round <= 9 && !wins)
            {
                
                // Prints board.
                Console.WriteLine(board.PrintBoard());

                // Checks who's next.
                if (board.IsPlayer1Turn(round))
                {
                    Console.WriteLine("\nJogador 1, é a sua vez! ");
                    player = board.Player1;
                }
                else
                {
                    Console.WriteLine("\nJogador 2, é a sua vez! ");
                    player = board.Player2;
                }

                // Plays.
                taken = true;
                while (taken)
                {
                    Console.Write("Linha: ");
                    int line = int.Parse(Console.ReadLine());

                    while (!board.CheckLineAndColumn(line)) {
                        Console.Write("Valor inválido! Escolha 0, 1 ou 2 para a linha: ");
                        line = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Coluna: ");
                    int column = int.Parse(Console.ReadLine());

                    while (!board.CheckLineAndColumn(column))
                    {
                        Console.Write("Valor inválido! Escolha 0, 1 ou 2 para a linha: ");
                        column = int.Parse(Console.ReadLine());
                    }

                    if (board.IsPlaceTaken(line, column))
                    {
                        Console.WriteLine("Posição já marcada! Tente de novo.");
                    }
                    else
                    {
                        taken = false;
                        board.TakePlace(line, column, player);
                    }
                }

                // Checks if the player have winned.
                if (board.CheckWinnerPerLine() || board.CheckWinnerPerColumn() || board.CheckWinnerPerDiagonal())
                {
                    wins = true;
                }

                // Checks who's the winner.
                if (wins)
                {
                    if (board.IsPlayer1Winner(player))
                    {
                        Console.WriteLine(board.PrintBoard());
                        Console.WriteLine("O JOGADOR 1 GANHOU!");
                    }
                    else
                    {
                        Console.WriteLine(board.PrintBoard());
                        Console.WriteLine("O JOGADOR 2 GANHOU!");
                    }
                }

                round++;
            }

            if (round == 10)
            {
                Console.WriteLine(board.PrintBoard());
                Console.WriteLine("DEU VELHA!");
            }
        }
    }
}
