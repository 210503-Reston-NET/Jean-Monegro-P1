using System;

namespace RRModels
{
    public class Review
    {
        private decimal _price;

        /// <summary>
        /// This describes the overall numeric rating of a restaurant
        /// </summary>
        /// <value></value>
        public Review(string make, string model, int year, int mpg, string desc, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Mpg = mpg;
            this.Desc = desc;
            this.Price = price;
        }

        public Review()
        { }

        public decimal Price
        {
            get { return _price; }
            set
            {
                //Setting validation logic in properties
                if (_price < 0)
                {
                    throw new Exception("Price should be greater than $0");
                }
                _price = value;
            }
        }

        /// <summary>
        /// Verbose description of the dining experience
        /// </summary>
        /// <value></value>
        public string Desc { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mpg { get; set; }

        //FK reference to the restaurant
        public int LocationId { get; set; }

        public int ReviewId { get; set; }

        public override string ToString()
        {
            return $"\t Year: {Year} \n\t Make: {Make} \n\t Model: {Model} \n\t MPG: {Mpg} \n\t Description: {Desc} \n\t Price: {Price}";
        }
    }
}