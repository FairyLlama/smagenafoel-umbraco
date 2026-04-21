using System.ComponentModel.DataAnnotations;

namespace ViewModels;

public class ContactForm
{
    [Required]
    public string Name { get; set; } = "";
    [Required]
    [EmailAddress(ErrorMessage = "Not valid email, byyyyee")]
    public string Email { get; set; } = "";
    [Required]
    public string Subject { get; set; } = "";
    [Required]
    public string Message { get; set; } = "";
}