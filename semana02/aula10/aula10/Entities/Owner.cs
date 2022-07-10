namespace aula10.Entities
{
    internal class Owner
    {
        private string _name { get; set; }

        private int _age { get; set; }

        public Owner(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public override string ToString()
        {
            return "Dono: " + _name
                   + ", de " + _age + " anos\n";
        }
    }
}
