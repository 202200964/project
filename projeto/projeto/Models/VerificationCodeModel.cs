using System.ComponentModel.DataAnnotations;

namespace projeto.Models
{
    public class VerificationCodeModel
    {
        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } // To associate the code with an email
    }
}
