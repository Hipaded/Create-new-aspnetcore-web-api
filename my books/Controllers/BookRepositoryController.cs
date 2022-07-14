using Microsoft.AspNetCore.Authorization;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using my_books.Data.Models;
using my_books.Repository;
using System.Threading.Tasks;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookRepositoryController : ControllerBase
    {
        private readonly UserManager<BookApplicationUser> userManager;
        private readonly RoleManager<BookApplicationUser> roleManager;
        private readonly IConfiguration configuration;

        public AuthenticateController(UserManager<BookApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, IConfiguration Configuration, IConfiguration _configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;
        }
        public async Task<IActionResult> SignUp([FromBody] SignUpModel)
        {
            var userExist = await userManager.FindByNameAsync(SignUpModel.UserName);
            if (userExist != null)
                return StatusCode(StatusCode.Status500InternalServerError, new Response { StatusCode = "Error", Message = "User Creation Failed" });

        }
        return Ok(new Response{ Status = "Success", Message = "User Created Successfully" });    }


