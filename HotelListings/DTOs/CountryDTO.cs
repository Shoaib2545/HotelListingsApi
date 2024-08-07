﻿using System.ComponentModel.DataAnnotations;

namespace HotelListings.DTOs
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name Is Too Long")]
        public string? Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Country Name Is Too Long")]
        public string? ShortName { get; set; }
    }

    public class UpdateCountryDTO : CreateCountryDTO
    {
        public IList<HotelDTO>? Hotels { get; set; }
    }

    public class CountryDTO : UpdateCountryDTO
    {
        public int Id { get; set; }
    }
}
