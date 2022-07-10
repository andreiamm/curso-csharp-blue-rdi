using System.Text;

namespace exercicio05.Entities
{
    internal class Company : Client
    {
        public Company(string id, string name, string email, string address, string phone)
            : base(id, name, email, address, phone)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CNPJ: {Id}");
            sb.AppendLine($"Nome Fantasia: {Name}");
            sb.AppendLine($"E-mail marketing: {Email}");
            sb.AppendLine($"Endereço comercial: {Address}");
            sb.AppendLine($"Telefone comercial: {Phone}");

            return sb.ToString();
        }
    }
}
