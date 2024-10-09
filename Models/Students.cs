using System.ComponentModel.DataAnnotations;

namespace SecureWeb.Models;

public class Students
{
    [Key]
    public string Nim { get; set; } = null!;
    public string FullName { get; set; } = null!;
}
