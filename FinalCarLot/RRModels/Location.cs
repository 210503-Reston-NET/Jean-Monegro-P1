using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace RRModels
{

    public class Location
    {

        private string _city;

        public Location(string city, string state, string country)
        {
            this.City = city;
            this.State = state;
            this.Country = country;
        }

        public Location()
        {
        }

        public Location(int id, string city, string state, string country) : this(city, state, country)
        {
            this.Id = id;
        }

        public int Id { get; set; }


        public string City { get; set; }


        public string State
        {
            get { return _city; }
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$")) throw new Exception("City cannot have numbers!");
                _city = value;
            }
        }

        public string Country { get; set; }

        public List<Review> Reviews { get; set; }

        public override string ToString()
        {
            return $" City: {City} \n State: {State}, {Country}";
        }

        public bool Equals(Location location)
        {
            return this.City.Equals(location.City) && this.State.Equals(location.State) && this.Country.Equals(location.Country);
        }
    }
}