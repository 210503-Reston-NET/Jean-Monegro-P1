using RRModels;
using System.Collections.Generic;

namespace RRDL
{
    public interface IRepository
    {
        List<Location> GetAllLocations();

        Location AddLocation(Location location);

        Location GetLocation(Location location);

        Location GetLocationById(int id);

        Location UpdateLocation(Location location);

        Location DeleteLocation(Location location);

        Review AddReview(Location location, Review review);

        List<Review> GetReviews(Location location);

        Customer GetCustomer(Customer customer);

        Customer FindCustomerById(int id);

        List<Customer> GetAllCustomers();
        List<Review> GetAllReviews();


        Customer DeleteCustomer(Customer customer);

        Customer AddCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
    }
}