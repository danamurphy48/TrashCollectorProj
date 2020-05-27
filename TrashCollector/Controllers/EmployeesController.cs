﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    [Authorize(Roles ="Employee")]
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EmployeesController
        public ActionResult Index(int ZipCode)
        {
            var todaysDay = DateTime.Today.DayOfWeek.ToString();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Where(e => e.IdentityUserId == userId).FirstOrDefault();

            
            var customer = _context.Customers.Where(c => c.ZipCode == employee.ZipCode && c.PickUpDay == todaysDay && c.IsSuspended == false || c.ExtraPickUpDate == DateTime.Today).ToList();
            return View(customer);
        }

        public ActionResult Filter()
        {
            return View();
        }

        // GET: EmployeesController/Details/5
        public ActionResult FuturePickUps(string PickUpDay)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Where(e => e.IdentityUserId == userId).FirstOrDefault();



            var customers = _context.Customers.Where(c => c.ZipCode == employee.ZipCode && c.PickUpDay == PickUpDay && c.IsSuspended == false).ToList();
            //var customersExtraPickup = _context.Customers.Where(c => c.ExtraPickUpDate == PickUpDay).ToList();
            //List<Customer> customersExtraPickup = null;

            //customers.AddRange(customersExtraPickup);
            return View(customers);

        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = userId;

                _context.Employees.Add(employee);
                _context.SaveChanges();
                //employee.IdentityUserId = userId;
                //_context.Add(employee);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult ConfirmPickUp(int id)
        {
            return View();
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmPickUp(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //// GET: EmployeesController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: EmployeesController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
