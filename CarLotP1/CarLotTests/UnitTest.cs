using System;
using Xunit;
using Entity = CarLotDL;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CarLotDL;
using System.Linq;
using CarLotModels;

namespace CarLotTests
{
    public class UnitTest
    {
        private readonly DbContextOptions<PracticeContext> options;

        [Fact]
        public void Customer(){
            Customer test = new Customer();
            string firstName = "John";
            string lastName = "Doe";
            int pin = 3333;
            test.FirstName = firstName;
            test.LastName = lastName;
            test.Pin = pin;
        }

        [Fact]
        public void Car(){
            Car test = new Car();
            string make = "subaru";
            string model = "forester";
            int year = 2005;
            test.Make = make;
            test.Model = model;
            test.Year = year;
        }

        [Fact]
        public void Car2(){
            Car test = new Car();
            string make = "Canada";
            string model = "USA";
            int year = 5;
            test.Make = make;
            test.Model = model;
            test.Year = year;
        }
        [Fact]
        public void Location(){
            Location test = new Location();
            string city = "Yonkers";
            string state = "New York";
            string country = "Canada";
            test.City = city;
            test.State = state;
            test.Country = country;
        }
        [Fact]
        public void Location2(){
            Location test = new Location();
            string city = "Detroit";
            string state = "Michigan";
            string country = "USA";
            test.City = city;
            test.State = state;
            test.Country = country;
        }

        [Fact]
        public void Customer2(){
            Customer test = new Customer();
            string firstName = "George";
            string lastName = "Washington";
            int pin = 4365;
            test.FirstName = firstName;
            test.LastName = lastName;
            test.Pin = pin;
        }
        [Fact]
        public void Customer3(){
            Customer test = new Customer();
            string firstName = "Abraham";
            string lastName = "Lincoln";
            int pin = 2211;
            test.FirstName = firstName;
            test.LastName = lastName;
            test.Pin = pin;
        }
        [Fact]
        public void Customer4(){
            Customer test = new Customer();
            string firstName = "Hello";
            string lastName = "Fresh";
            int pin = 5667;
            test.FirstName = firstName;
            test.LastName = lastName;
            test.Pin = pin;
        }
        [Fact]
        public void Car3(){
            Car test = new Car();
            string make = "Toyota";
            string model = "Supra";
            int year = 1996;
            test.Make = make;
            test.Model = model;
            test.Year = year;
        }
        [Fact]
        public void Location3(){
            Location test = new Location();
            string city = "Seattle";
            string state = "Washington";
            string country = "USA";
            test.City = city;
            test.State = state;
            test.Country = country;
        }
    }
}