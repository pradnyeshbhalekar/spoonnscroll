using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpoonNScroll.Data;
using SpoonNScroll.Models;
using System.Linq;

namespace SpoonNScroll.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public LoginModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User LoginUser { get; set; } = new User { Username = string.Empty, Password = string.Empty };

        public string? Message { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Message = "Please fill in all fields.";
                return Page();
            }

            // Debugging: Print all users to verify data
            var allUsers = _context.Users.ToList();
            foreach (var user in allUsers)
            {
                Console.WriteLine($"User: {user.Username}, Password: {user.Password}");
            }

            var existingUser = _context.Users
                .FirstOrDefault(u => u.Username.ToLower() == LoginUser.Username.ToLower() 
                                  && u.Password == LoginUser.Password); // Check hashing if applicable

            if (existingUser != null)
            {
                return RedirectToPage("/Index");
            }

            Message = "Invalid username or password.";
            return Page();
        }
    }
}
