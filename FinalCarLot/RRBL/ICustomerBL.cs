using System.Collections.Generic;
using RRModels;

namespace RRBL
{
    public interface ICustomerBL
    {
        public List<Customer> GetAllCustomers();
        public Customer AddCustomer(Customer customer);
        public Customer GetCustomer(Customer customer);
        public Customer DeleteCustomer(Customer customer);
        public Customer FindCustomerById(int id);
        Customer UpdateCustomer(Customer customer);
    }
}