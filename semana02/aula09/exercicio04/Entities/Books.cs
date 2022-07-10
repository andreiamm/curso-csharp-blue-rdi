using System.Text;

namespace exercicio04.Entities
{
    internal class Books : Catalog
    {
        public int Year { get; set; }
        public Books(int id, string title, string author, string subject, int year)
            : base(id, title, author, subject)
        {
            Year = year;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Livro n. {Id}");
            sb.AppendLine($"Título: {Title}");
            sb.AppendLine($"Autor: {Author}");
            sb.AppendLine($"Ano: {Year}");
            sb.AppendLine($"Categoria: {Subject}");

            return sb.ToString();
        }
    }
}
