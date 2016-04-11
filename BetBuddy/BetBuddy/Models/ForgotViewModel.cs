using System.ComponentModel.DataAnnotations;

namespace MVCBetBud.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}