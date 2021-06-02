using System.Collections.Generic;
using RRModels;
using RRDL;
using System;

namespace RRBL
{
    public class CustomerBL : ICustomerBL
    {

        private IRepository _repo;
        public CustomerBL(IRepository repo)
        {
            _repo = repo;
        }
        public Customer AddCustomer(Customer customer)
        {
            if (_repo.GetCustomer(customer) != null)
            {
                throw new Exception("Customer already exists.");
            }
            return _repo.AddCustomer(customer);
        }
        public Customer DeleteCustomer(Customer customer)
        {
            Customer toBeDeleted = _repo.GetCustomer(customer);
            if (toBeDeleted != null) return _repo.DeleteCustomer(toBeDeleted);
            else throw new Exception("Customer does not exist");
        }

        public List<Customer> GetAllCustomers()
        {
            return _repo.GetAllCustomers();
        }

        public Customer GetCustomer(Customer customer)
        {
            return _repo.GetCustomer(customer);
        }
        public Customer FindCustomerById(int id)
        {
            return _repo.FindCustomerById(id);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return _repo.UpdateCustomer(customer);
        }
    }
}