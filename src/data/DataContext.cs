using HomeLibraryCG.src.models;
using Microsoft.EntityFrameworkCore;

namespace HomeLibraryCG.src.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 

        }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Item> Items { get; set; }
    }
}
