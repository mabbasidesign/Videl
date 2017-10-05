﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videl.Models;

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

        // GET: customer
        public ActionResult Index()
        {
            var customer = _context.Customers
                .Include(c => c.MemberShipType)
                .ToList();

            return View(customer);
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