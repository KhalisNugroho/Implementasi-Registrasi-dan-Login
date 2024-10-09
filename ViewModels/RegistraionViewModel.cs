using System;
using System.ComponentModel.DataAnnotations;

namespace SecureWeb.ViewModels;

public class RegistraionViewModel
{
    [Required]
    public string? Username { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "ConformPassword")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match")]
    public string? ConfirmPassword { get; set;}
}
