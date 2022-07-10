using System;
using System.Text;

namespace exercicio04.Entities
{
    internal class Journals : Catalog
    {
        public DateTime Date { get; set; }
        public Journals(int id, string title, string author, string subject, DateTime date)
            : base(id, title, author, subject)
        {
            Date = date;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Periódico n. {Id}");
            sb.AppendLine($"Título: {Title}");
            sb.AppendLine($"Autor: {Author}");
            sb.AppendLine($"Data de publicação: {Date}");
            sb.AppendLine($"Categoria: {Subject}");

            return sb.ToString();
        }
    }
}
