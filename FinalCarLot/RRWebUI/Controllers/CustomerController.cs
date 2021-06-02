using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RRBL;
using RRModels;
using RRWebUI.Models;
using System.Linq;

namespace RRWebUI.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerBL _customerBL;

        public CustomerController(ICustomerBL customerBL)
        {
            _customerBL = customerBL;
        }

        public ActionResult Index()
        {
            return View(_customerBL
                .GetAllCustomers()
                .Select(customer => new CustomerVM(customer))
                .ToList()
                );
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerVM customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _customerBL.AddCustomer(new Customer { FirstName = customer.FirstName, LastName = customer.LastName, Email = customer.Email, Pin = customer.Pin });
                    return RedirectToAction(nameof(Index));
                    //_customerBL.AddCustomer(new Customer
                    //{
                    //    FirstName = customerVM.FirstName,
                    //    LastName = customerVM.LastName,
                    //    Email = customerVM.Email,
                    //    Pin = customerVM.Pin
                    //}
                    //);
                    //return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View(new CustomerVM(_customerBL.FindCustomerById(id)));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerVM customerVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _customerBL.UpdateCustomer(new Customer(customerVM.FirstName, customerVM.LastName, customerVM.Pin, customerVM.Email));
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int customerId)
        {
            return View(new CustomerVM(_customerBL.FindCustomerById(customerId)));
            //return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _customerBL.DeleteCustomer(_customerBL.FindCustomerById(id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}