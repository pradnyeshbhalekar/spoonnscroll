using System.ComponentModel.DataAnnotations;

namespace SpoonNScroll.Models
{
public class User
{
    public int Id { get; set; }
    public required string Username { get; set; } // ✅ Fix
    public required string Password { get; set; } // ✅ Fix
}

}
