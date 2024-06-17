using System.ComponentModel.DataAnnotations;

namespace HotelListings.DTOs
{
    public class UserDTO : LoginUserDTO
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; } = string.Empty;

        public ICollection<string> Roles { get; set; }
    }
}
