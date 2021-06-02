using RRModels;
using System.Collections.Generic;
using System.Linq;

using Model = RRModels;

namespace RRDL
{
    public class RepoDB : IRepository
    {
        private RestaurantDBContext _context;

        public RepoDB(RestaurantDBContext context)
        {
            _context = context;
        }

        public Model.Location AddLocation(Model.Location location)
        {
            //This records a change in the context change tracker that we want to add this particular entity to the
            // db
            _context.Locations.Add(
                location
            );
            //This persists the change to the db
            // Note: you can create a separate method that persists the changes so that you can execute repo commands in
            //the BL and save changes only when all the operations return no exceptions
            _context.SaveChanges();
            return location;
        }

        public Model.Review AddReview(Location location, Review review)
        {
            _context.Reviews.Add(
                new Review
                {
                    Make = review.Make,
                    Model = review.Model,
                    Year = review.Year,
                    Desc = review.Desc,
                    Mpg = review.Mpg,
                    Price = review.Price,
                    LocationId = GetLocation(location).Id
                }
            );
            _context.SaveChanges();
            return review;
        }

        public Location DeleteLocation(Location location)
        {
            Location toBeDeleted = _context.Locations.First(resto => resto.Id == location.Id);
            _context.Locations.Remove(toBeDeleted);
            _context.SaveChanges();
            return location;
        }

        public List<Model.Location> GetAllLocations()
        {
            return _context.Locations
            .Select(
                location => location
            ).ToList();
        }

        public Model.Location GetLocation(Model.Location location)
        {
            //find me a restaurant from the db that is equal to the input restaurant
            Location found = _context.Locations.FirstOrDefault(resto => resto.City == location.City && resto.State == location.State && resto.Country == location.Country);
            // we get the results and return null if nothing is found, otherwise return a Model.Restaurant that was found
            if (found == null) return null;
            return new Model.Location(found.Id, found.City, found.State, found.Country);
        }

        public Location GetLocationById(int id)
        {
            return _context.Locations.Find(id);
        }

        public List<Review> GetReviews(Location location)
        {
            // We get the reviews such that, we find the restuarant that matches the restaurant being passed,
            // we get the id of that specific restaurant, compare it to the FK references in the Reviews table
            // get the reviews that match the condition
            //  transform the entity type reviews to a model type review
            // Immediately execute the linq query by calling tolist, which takes the data from the db and puts it in
            // a list

            //Finding the restaurant from the db, to be able to take advantage of the Id property the model doesn't have (well now it does)
            //Entity.Restaurant foundResto = _context.Restaurants.FirstOrDefault(resto => resto.Name == restaurant.Name && resto.City == restaurant.City && resto.State == restaurant.State);

            return _context.Reviews.Where(
                review => review.LocationId == GetLocation(location).Id
                ).Select(
                    review => review
                ).ToList();
        }

        public Location UpdateLocation(Location location)
        {
            _context.Locations.Update(location);
            _context.SaveChanges();
            return location;
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers
            .Select(
                customer => new Model.Customer(customer.FirstName, customer.LastName, customer.Pin, customer.Email)
            ).ToList();
        }
        public Customer FindCustomerById(int id)
        {
            return _context.Customers.Find(id);

        }

        public Model.Customer GetCustomer(Model.Customer customer)
        {
            Customer found = _context.Customers.FirstOrDefault(resto => customer.FirstName == customer.FirstName && customer.LastName == customer.LastName && customer.Pin == customer.Pin);
            if (found == null) return null;
            return new Model.Customer(found.FirstName, found.LastName, found.Pin, found.Email);
        }

        public Model.Customer AddCustomer(Model.Customer customer)
        {
            _context.Customers.Add(
                new Customer
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Pin = customer.Pin,
                    Email = customer.Email,
                }
            );
            _context.SaveChanges();
            return customer;
        }

        public Customer DeleteCustomer(Customer customer)
        {
            Customer toBeDeleted = _context.Customers.First(resto => resto.CustomerId == customer.CustomerId);
            _context.Customers.Remove(toBeDeleted);
            _context.SaveChanges();
            return customer;
        }
        public Customer UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return customer;
        }
    }
}