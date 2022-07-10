namespace exercicio01
{
    internal class Alunos
    {
        public int RegisterNumber { get; private set; }
        public string Name { get; set; }
        public float Test1Score { get; set; }
        public float Test2Score { get; set; }
        public float HomeworkScore { get; set; }

        public Alunos(int registerNumber, string name, float test1Score, float test2Score, float homeworkScore)
        {
            RegisterNumber = registerNumber;
            Name = name;
            Test1Score = test1Score;
            Test2Score = test2Score;
            HomeworkScore = homeworkScore;
        }

        public float MeanScore()
        {
            return (Test1Score + Test2Score + HomeworkScore) / 3.0f;
        }

        public float FinalTestScore()
        {
            return 28.0f - (Test1Score + Test2Score + HomeworkScore);
        }
    }
}
