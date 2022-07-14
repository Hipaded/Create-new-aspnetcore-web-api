using System.ComponentModel.DataAnnotations;

namespace my_books.Data.Models
{
    public class SignInModel
    {
       [Required(ErrorMessage = "User Name is required")]
       public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }    
        
    }
}
