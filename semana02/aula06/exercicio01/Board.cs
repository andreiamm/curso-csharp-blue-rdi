namespace exercicio01
{
    internal class Board
    {
        private int[,] _board = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        public int Player1 { get; private set; }
        public int Player2 { get; private set; }
             
        public Board()
        {
        }

        public void SetPlayersMarks(char mark)
        {
            if (mark == 'o' || mark == 'O')
            {
                Player1 = -1;
                Player2 = 1;
            }
            else
            {
                Player1 = 1;
                Player2 = -1;
            }
        }

        public string PrintBoard()
        {
            string str = "\n";

            for (int line = 0; line < _board.GetLength(0); line++)
            {
                for (int column = 0; column < _board.GetLength(1); column++)
                {
                    if (_board[line, column] == 1)
                    {
                        str += " X ";
                    }
                    else if (_board[line, column] == -1)
                    {
                        str += " O ";
                    }
                    else
                    {
                        str += "   ";
                    }

                    if (column == 0 || column == 1)
                    {
                        str += "|";
                    }
                }
                str += "\n";
            }
            return str;
        }

        public bool IsPlayer1Turn(int round)
        {
            return (round % 2 != 0) ? true : false;
        }

        public bool CheckLineAndColumn(int value)
        {
            return (value == 0 || value == 1 || value == 2) ? true : false;
        }

        public bool IsPlaceTaken(int line, int column)
        {
            return (_board[line,column] == 0) ? false : true;
        }

        public void TakePlace(int line, int column, int player)
        {
            _board[line, column] = player;
        }

        public bool CheckWinnerPerLine()
        {
            for (int line = 0; line < _board.GetLength(0); line++)
            {
                if (_board[line, 0] + _board[line, 1] + _board[line, 2] == 3
                    || _board[line, 0] + _board[line, 1] + _board[line, 2] == -3)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckWinnerPerColumn()
        {
            for (int column = 0; column < _board.GetLength(1); column++)
            {
                if (_board[0, column] + _board[1, column] + _board[2, column] == 3
                    || _board[0, column] + _board[1, column] + _board[2, column] == -3)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckWinnerPerDiagonal()
        {
            if (_board[0, 0] + _board[1, 1] + _board[2, 2] == 3
                        || _board[0, 0] + _board[1, 1] + _board[2, 2] == -3)
            {
                return true;
            }
            if (_board[0, 2] + _board[1, 1] + _board[2, 0] == 3
                    || _board[0, 2] + _board[1, 1] + _board[2, 0] == -3)
            {
                return true;
            }
            return false;
        }

        public bool IsPlayer1Winner(int player)
        {
            return (Player1 == player) ? true : false;
        }
    }
}
