namespace HomeLibraryCG.src.models
{
    public class Item
    {
        // Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ItemType { get; set; }


        public Item() { }

        public Item(int id, string title, DateTime publishedDate, string description, string itemType)
        {
            Id = id;
            Title = title;
            PublishedDate = publishedDate;
            Description = description;
            ItemType = itemType;
        }
    }
}

