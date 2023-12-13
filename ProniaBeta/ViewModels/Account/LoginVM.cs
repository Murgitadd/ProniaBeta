using System.ComponentModel.DataAnnotations;

namespace ProniaBeta.ViewModels.Account
{
    public class LoginVM
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool isRemembered { get; set; }
    }
}
