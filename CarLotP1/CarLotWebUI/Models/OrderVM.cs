using CarLotModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarLotWebUI.Models
{
    public class OrderVM
    {
        public OrderVM(){}
        public OrderVM(int locationId)
        {
            LocationId = locationId;
        }
        public OrderVM(Orders order)
        {
            OrderId = order.OrderId;
        }
        public int OrderId{get;set;}
        [Required]
        public int LocationId{get;set;}
    }
}