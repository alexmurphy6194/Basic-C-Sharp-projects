using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CustomerInfo(string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth,
         int? CarYear, string CarMake, string CarModel, bool HaveDui, int? SpeedingTickets, 
         bool FullCoverage)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress)
                || CarYear == null || string.IsNullOrEmpty(CarMake) || string.IsNullOrEmpty(CarModel) || SpeedingTickets == null)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (CarInsuranceEntities db = new CarInsuranceEntities())
                {
                    int age = DateTime.Now.Year - DateOfBirth.Year;
                    string strDOB = DateOfBirth.ToString("MM-dd-yyyy");
                    decimal Quote = 50.0m;
                    //age
                    if (age >= 18 && age < 25)
                    {
                        Quote += 25m;
                    }
                    else if( age < 18)
                    {
                        Quote += 100m;
                    }
                    else if (age >100)
                    {
                        Quote += 25;
                    }
                    //car
                    if (CarYear < 2000 || CarYear >2015)
                    {
                        Quote += 25;
                    }
                    if (CarMake == "Porsche")
                    {
                        if (CarModel == "911 Carrera")
                        {
                            Quote += 25;
                        }
                        Quote += 25;
                    }
                    if (SpeedingTickets > 0)
                    {
                        Quote += (Convert.ToDecimal(SpeedingTickets) * 10);
                    }
                    if (HaveDui)
                    {
                        Quote += (Quote * .25m);
                    }
                    if (FullCoverage)
                    {
                        Quote += (Quote * .5m);
                    }
                    Quote = System.Math.Round(Quote, 2);
                    var customerInfo = new CustomerInfo();
                    customerInfo.FirstName = FirstName;
                    customerInfo.LastName = LastName;
                    customerInfo.EmailAddress = EmailAddress;
                    customerInfo.DateOfBirth = strDOB;
                    customerInfo.CarYear = CarYear;
                    customerInfo.CarMake = CarMake;
                    customerInfo.CarModel = CarModel;
                    customerInfo.HaveDui = HaveDui;
                    customerInfo.SpeedingTickets = SpeedingTickets;
                    customerInfo.FullCoverage = FullCoverage;
                    customerInfo.Quote = Quote;
                    db.CustomerInfoes.Add(customerInfo);
                    db.SaveChanges();
                    ViewBag.Message = customerInfo;
                 }
              return View("Success"); 
            }
        }
    }
}