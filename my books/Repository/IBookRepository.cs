using Microsoft.AspNetCore.Identity;
using my_books.Data.Models;
using System.Threading.Tasks;

namespace my_books.Repository
{
    public interface IBookRepository
    {
        
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
    }
}
