namespace exercicio04.Entities
{
    internal abstract class Catalog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }     

        protected Catalog(int id, string title, string author, string subject)
        {
            Id = id;
            Title = title;
            Author = author;
            Subject = subject;
        }
    }
}
