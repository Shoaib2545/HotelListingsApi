using System.ComponentModel.DataAnnotations;

namespace HotelListings.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
    }
}
