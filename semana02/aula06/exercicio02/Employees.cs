using System.Globalization;

namespace exercicio02
{
    internal class Employees
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public  string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public Employees(string name, string position, double salary)
        {
            Name = name;
            Position = position;

            if (salary > 0)
            {
                Salary = salary;
            }
            else
            {
                Salary = 0.0;
            }
        }

        public void IncreaseSalary()
        {
            if (Salary <= 400.0)
                Salary += Salary * 0.15;
            else if (Salary <= 800.0)
                Salary += Salary * 0.12;
            else if (Salary <= 1200.0)
                Salary += Salary * 0.1;
            else if (Salary <= 2000.0)
                Salary += Salary * 0.07;
            else
                Salary += Salary * 0.04;
        }

        override
        public string ToString()
        {
            return $"{Name}, que ocupa o cargo de {Position}, ganha R${Salary.ToString("F2", CI)} ao mês.";
        }
    }
}
