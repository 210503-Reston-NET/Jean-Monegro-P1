using CarLotModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarLotWebUI.Models
{
    public class CarVM
    {
        public CarVM(int locationId)
        {
            LocationId = locationId;
        }

        public CarVM(Car car)
        {
            CarId = car.CarId;
            Make = car.Make;
            Model = car.Model;
            Year = car.Year;
            LocationId = car.LocationId;
        }
        public CarVM(){}
        public int CarId{get;set;}
        [Required]
        public string Make{get;set;}
        [Required]
        public string Model{get;set;}
        [DisplayName("Model")]
        [Required]
        public int LocationId{get;set;}
        [Required]
        public int Year{get;set;}
    }
}