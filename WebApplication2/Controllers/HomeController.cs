﻿using NSB.Messages;
using NSB.Messages.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Block()
        {
            System.Threading.Thread.Sleep(2000);
            return View("Index");
        }
        public ActionResult TestNSB()
        {
            Random rnd = new Random();
            var command = new PlaceOrderCommand()
            {
                Id = Guid.NewGuid(),
                Amount = rnd.Next(1, 100)
            };

            MvcApplication.Bus.Send(command);

            ViewBag.OrderId = command.Id;
            ViewBag.Amount = command.Amount;

            return View("Index");

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}