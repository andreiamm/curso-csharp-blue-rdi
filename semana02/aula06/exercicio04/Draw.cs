using System;

namespace exercicio04
{
    internal class Draw
    {
        public int Number { get; private set; }
        public int Counter { get; private set; }

        public Draw()
        {
            Number = DrawNumber();
        }

        public int DrawNumber()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            return rnd.Next(1000);
        }

        public bool EvaluateGuess(int num)
        {
            Counter++;
            
            if (num == Number)
                return true;

            return false;
        }

        public bool IsGreater(int num)
        {
            if (num < Number)
                return true;

            return false; 
        }
    }
}
