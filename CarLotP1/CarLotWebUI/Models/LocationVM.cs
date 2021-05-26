using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CarLotModels;



namespace CarLotWebUI.Models
{
    public class LocationVM
    {
        public LocationVM(Location location)
        {
            City = location.City;
            State = location.State;
            Country = location.Country;
            LocationId = location.LocationId;
        }
        public void RestaurantVM(){}
        public int LocationId{get;set;}
        [Required]
        public string City{get;set;}
        [Required]
        public string State{get;set;}
        [Required]
        public string Country{get;set;}
    }
}