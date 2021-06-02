using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RRModels
{
    public class Customer
    {
        public Customer(string firstName, string lastName, int pin, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Pin = Pin;
            this.Email = Email;
        }
        public Customer(){}
        public Customer(int id)
        {
            this.CustomerId = id;
        }
        public Customer(int id, string firstName, string lastName, int pin, string email) : this(firstName, lastName, pin, email)
        {
            this.CustomerId = id;
        }
        public Customer(int id, string firstName, string lastName, string email, int pin, List<Order> orders) : this(id, firstName, lastName, pin, email)
        {
            this.Orders = orders;
        }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Pin { get; set; }
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return $" First Name: {FirstName} \n Last Name: {LastName} \n Pin: {Pin} \n Email: {Email}";
        }
        public bool Equals(Customer customer)
        {
            return this.FirstName.Equals(customer.FirstName) && this.LastName.Equals(customer.LastName) && this.Pin.Equals(customer.Pin);
        }

    }
}