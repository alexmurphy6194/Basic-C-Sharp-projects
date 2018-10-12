using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {

                var customers = db.CustomerInfoes;
                
                var customerVMs = new List<customerVM>();
                foreach (var customer in customers)
                {
                    var CustomerVM = new customerVM();
                    CustomerVM.Id = customer.Id;
                    CustomerVM.FirstName = customer.FirstName;
                    CustomerVM.LastName = customer.LastName;
                    CustomerVM.EmailAddress = customer.EmailAddress;
                    CustomerVM.Quote = customer.Quote;
                    customerVMs.Add(CustomerVM);
                }
                return View(customerVMs);
            }

        }
      }
 }
