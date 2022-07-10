using System.Globalization;

namespace exercicio01
{
    internal class Students
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public int RegisterNumber { get; private set; }
        public string Name { get; set; }
        public double Test1Score { get; set; }
        public double Test2Score { get; set; }
        public int Attendance { get; set; }

        public Students(int registerNumber, string name, double test1Score, double test2Score, int attendance)
        {
            RegisterNumber = registerNumber;
            Name = name;
            Test1Score = test1Score;
            Test2Score = test2Score;
            Attendance = attendance;
        }

        public override string ToString()
        {
            return $"Aluno: {Name} (código {RegisterNumber}), " +
                $"Nota 1: {Test1Score.ToString("F1", CI)}, " +
                $"Nota 2: {Test2Score.ToString("F1", CI)}, " +
                $"Presença: {Attendance}%";
        }
    }
}
