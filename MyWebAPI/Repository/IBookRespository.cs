using MyWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyWebAPI.Repository
{
    public interface IBookRespository
    {
        Task<List<BookModel>> GetAllBooksAsync();
    }
}
