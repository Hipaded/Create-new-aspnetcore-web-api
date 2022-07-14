using Microsoft.AspNetCore.Identity;

namespace my_books.Data.Models
{
    public class BookApplicationUser : IdentityUser

    {
        public string Username { get; set; }
        public string Password { get; set; }
        
    }
}


