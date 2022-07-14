using Microsoft.EntityFrameworkCore;

namespace MyWebAPI.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {

        }
        public DbSet<Books> Books { get; set; }


        }
    }


