using System.ComponentModel.DataAnnotations;

namespace Diffrent.Practice.Concept.WebApi.Models.SignUpModel
{
    public class SignUpModel
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        
        [Required] 
        public string Password { get; set; } = string.Empty;
        
        [Required]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
