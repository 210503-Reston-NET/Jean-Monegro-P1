using System;
using System.Collections.Generic;

namespace RRModels
{
    public class Order
    {
        public Order(){
            this.DateCreated = DateTime.Now;
            this.Closed = false;
        }

        public Order(Guid userId, int locationId) : this()
        {
            this.UserId = userId;
            this.LocationId = locationId;
        }
        public Order(Guid userId, int locationId, int id) : this(userId, locationId)
        {
            this.OrderId = id;
        }
        public Order(Guid userId, int locationId, int id, List<Review> items) : this(userId, locationId, id)
        {

        }
        public DateTime DateCreated { get; set; }
        public Guid UserId { get; set; }
        public int LocationId { get; set; }
        public List<Review> Inventory { get; set; }
        public bool Closed { get; set; }
        public decimal Total { get; set; }
        public int OrderId { get; set; }


        public override string ToString()
        {
            string ItemString = "";
            foreach (Review item in this.Inventory)
            {
                ItemString += "\n" + item.ToString();
            }
            return $"Date Created: {this.DateCreated.ToString("D")} \nItems: {ItemString} \nTotal: {this.Total}";
        }
    }
}
