﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

using WebApplication2.DAL;
using System.Data.Entity.Validation;
using Aspose.Words;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 
            String lic = @"c:\Aspose.Words.lic";
            try
            {
                License license = new License();
                license.SetLicense(lic);
            }
            catch (Exception e) {
                Console.WriteLine("{0}",e);
            }
            return View();
        }

        public ActionResult Privacy()
        {
            ViewBag.Message = "Your application description page.";//
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Submit()
        {
            Contact newContact = new Contact();

            newContact.name = Request.Form["name"];
            newContact.subject = Request.Form["subject"];
            newContact.massage = Request.Form["massage"];

            ContactDal cdal = new ContactDal();
            cdal.contacts.Add(newContact);
            cdal.SaveChanges();
            return View("Thanks");////
        }

        //asdasdjdsbkjsabd
        public ActionResult DeleteAccountCompleteMassage()
        {
            return View();
        }


    }
}