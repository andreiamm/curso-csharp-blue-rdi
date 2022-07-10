using System;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            int round, player1, player2, player, playerLine, playerColumn;
            char mark;
            bool wins, taken;

            Console.Write("Jogador 1, escolha a sua marcação (O ou X): ");
            mark = char.Parse(Console.ReadLine());

            if (mark == 'o' || mark == 'O')
            {
                player1 = -1;
                player2 = 1;
            } else
            {
                player1 = 1;
                player2 = -1;
            }

            round = 1;
            wins = false;
            while (round <= 9 && !wins)
            {
                // SHOWS BOARD
                Console.WriteLine();
                for (int line = 0; line < 3; line++)
                {
                    for (int column = 0; column < 3; column++)
                    {                       
                        if (board[line,column] == 1)
                        {
                            Console.Write(" X ");
                        } else if (board[line, column] == -1)
                        {
                            Console.Write(" O ");
                        } else
                        {
                            Console.Write("   ");
                        }

                        if (column == 0 || column == 1)
                        {
                            Console.Write("|");
                        }
                    }
                    Console.WriteLine();
                }

                // CHECKS WHO'S NEXT
                if (round % 2 != 0)
                {
                    Console.WriteLine("\nJogador 1, é a sua vez!: ");
                    player = player1;
                } 
                else
                {
                    Console.WriteLine("\nJogador 2, é a sua vez!: ");
                    player = player2;
                }

                // PLAYS
                taken = true;
                while (taken)
                {
                    Console.Write("Linha: ");
                    playerLine = int.Parse(Console.ReadLine());

                    while (playerLine != 0 && playerLine != 1 && playerLine != 2)
                    {
                        Console.Write("Valor inválido! Escolha 0, 1 ou 2 para a linha: ");
                        playerLine = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Coluna: ");
                    playerColumn = int.Parse(Console.ReadLine());

                    while (playerColumn != 0 && playerColumn != 1 && playerColumn != 2)
                    {
                        Console.Write("Valor inválido! Escolha 0, 1 ou 2 para a coluna: ");
                        playerColumn = int.Parse(Console.ReadLine());
                    }

                    if (board[playerLine,playerColumn] == 0)
                    {
                        taken = false;
                        board[playerLine, playerColumn] = player;
                    } 
                    else
                    {
                        Console.WriteLine("Posição já marcada! Tente de novo.");
                    }
                }

                // CHECKS LINES
                for (int line = 0; line < 3; line++)
                {
                    if (board[line, 0] + board[line, 1] + board[line, 2] == 3
                        || board[line, 0] + board[line, 1] + board[line, 2] == -3)
                    {
                        wins = true;
                    }
                }

                // CHECKS COLUMNS
                for (int column = 0; column < 3; column++)
                {
                    if (board[0, column] + board[1, column] + board[2, column] == 3
                        || board[0, column] + board[1, column] + board[2, column] == -3)
                    {
                        wins = true;
                    } 
                }

                // CHECKS DIAGONALS
                if (board[0, 0] + board[1, 1] + board[2, 2] == 3
                        || board[0, 0] + board[1, 1] + board[2, 2] == -3)
                {
                    wins = true;
                }
                if (board[0, 2] + board[1, 1] + board[2, 0] == 3
                        || board[0, 2] + board[1, 1] + board[2, 0] == -3)
                {
                    wins = true;
                }

                // CHECKS WHO'S THE WINNER
                if (wins)
                {
                    if (player == player1)
                    {
                        Console.WriteLine("\nO JOGADOR 1 GANHOU!");
                    } else
                    {
                        Console.WriteLine("\nO JOGADOR 2 GANHOU!");
                    }
                }

                round++;
            } 
            
            if (round == 10)
            {
                Console.WriteLine("\nDEU VELHA!");
            }

            Console.ReadLine();

        } 
    } 
}  
