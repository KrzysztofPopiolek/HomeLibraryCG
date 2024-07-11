namespace HomeLibraryCG.src.models
{
    public class Book : Item
    {
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int Pages { get; set; }
        public Book() { }

        public Book(int id, string title, DateTime publishedDate, string description, string author, string isbn, int pages)
             : base(id, title, publishedDate, description, "Book")
        {
            Author = author;
            ISBN = isbn;
            Pages = pages;
        }

    }
}

