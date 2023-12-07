using System.ComponentModel.DataAnnotations;

namespace ProniaBeta.ViewModels.Account
{
    public class RegisterVM
    {
        [Required]
        [MinLength(5)]
        public string UserName { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(5)]
        public string  Name { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(5)]
        public string LastName { get; set; }
    }
}
