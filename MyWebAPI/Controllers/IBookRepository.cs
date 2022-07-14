using System.Threading.Tasks;

namespace MyWebAPI.Controllers
{
    public interface IBookRepository
    {
        Task GetAllBooksAsync();
    }
}