using RRModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RRWebUI.Models
{

    public class LocationVM
    {
        public LocationVM(Location location)
        {
            Id = location.Id;
            City = location.City;
            State = location.State;
            Country = location.Country;
        }

        public LocationVM()
        {
        }

        public int Id { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [DisplayName("Country")]
        [Required]
        public string Country { get; set; }
    }
}