using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videl.Models;
using Videl.ViewModels;

namespace Videl.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Create()
        {
            var memberShipTypes = _context.MemberShipTypes
                .ToList();
            var viewModel = new NewCustomerViewModel
            {
                MemberShipType = memberShipTypes
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Index()
        {
            var customer = _context.Customers
                .Include(c => c.MemberShipType)
                .ToList();

            return View(customer);
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers
                .Include(c => c.MemberShipType)
               .SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MemberShipType = _context.MemberShipTypes.ToList(),
            };

            return View("Create", viewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers
                .Include(c => c.MemberShipType)
               .SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);        
        }

        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>()
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}