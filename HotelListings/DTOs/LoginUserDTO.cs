using System.ComponentModel.DataAnnotations;

namespace HotelListings.DTOs
{
    public class LoginUserDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(15, ErrorMessage = "Your Password is limited to {2} to {1} characters", MinimumLength = 2)]
        public string Password { get; set; } = string.Empty;
    }
}
