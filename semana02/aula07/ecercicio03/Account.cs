using System.Globalization;

namespace exercicio03
{
    internal class Account
    {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account(int number, string holder)
        {
            Number = number;
            Holder = holder;
        }

        public Account(int number, string holder, double deposit) : this(number, holder)
        {
            Deposit(deposit);
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void Withdraw(double value)
        {
            Balance -= value;
        }

        public void UpdateHolderName(string name)
        {
            Holder = name;
        }

        public override string ToString()
        {
            return "Conta: " + Number
                   + ", Titular: " + Holder
                   + ", Saldo: R$ " + Balance.ToString("F2", CI);
        }
    }
}
