using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModels;
using my_books.Repository;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;  
        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }
         
        [HttpGet("get-all-book")]
        public IActionResult GetAllBook()
        {
            var allBook = _bookService.GetAllBook();    
            return Ok(allBook);
        }

        [HttpGet ("get-book-by-id/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _bookService.GetBookById(id);
            return Ok(book); 
        }
       
    
       [HttpPost("add-book")]
        public IActionResult AddBook ([FromBody]BookVM book)
        {
            _bookService.AddBook(book);
            return Ok();

        }
        [HttpPut("update-book-by-id/{id}")]
        public IActionResult UpdateBookById(int id,[FromBody]BookVM book) 
        {
            var updatedBook = _bookService.UpdateBookById(id, book); 
            return Ok(updatedBook); 
            
        }

        [HttpDelete("delete-book-by-id/{id}")]
        public IActionResult DeleteBookById(int id) 
        {
            _bookService.DeleteBookById(id);
            return Ok();
        }
    }
}
