namespace exercicio04
{
    internal class Pet
    {
        private string _owner;
        private string _phone;
        public string PetName { get; set; }
        public string Type { get; set; }
        public string Color { get; set; } 
        

        public Pet(string pet, string type, string color, string owner, string phone)
        {
            PetName = pet;
            Type = type;
            Color = color;
            _owner = owner;
            _phone = phone;
        }

        public override string ToString()
        {
            return "O pet " + PetName + " é um " + Type + " da cor " + Color
                    + ". Seu tutor chama-se " + _owner + " e pode ser contactado pelo telefone "
                    + _phone + ".\n";
        }

    }
}
