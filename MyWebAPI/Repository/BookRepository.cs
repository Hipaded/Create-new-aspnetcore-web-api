using Microsoft.EntityFrameworkCore;
using MyWebAPI.Data;
using MyWebAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Repository
{
    public class BookRepository : IBookRespository
    {
        private readonly BookStoreContext _context;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }


        public async Task<List<BookModel>> GetAllBooksAsync()
        {
            var records = await _context.Books.Select (x => new BookModel()
            { 
                Id = x.Id,
                Title = x.Title,
                Description = x.Description
            }).ToListAsync();

            return records;
        }
    }
}
