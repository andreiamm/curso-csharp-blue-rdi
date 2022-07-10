using System.Text;

namespace exercicio05.Entities
{
    internal class Individual : Client
    {
        public Individual(string id, string name, string email, string address, string phone) 
            : base(id, name, email, address, phone)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CPF: {Id}");
            sb.AppendLine($"Nome: {Name}");
            sb.AppendLine($"E-mail pessoal: {Email}");
            sb.AppendLine($"Endereço residencial: {Address}");
            sb.AppendLine($"Celular pessoal: {Phone}");

            return sb.ToString();
        }
    }
}
