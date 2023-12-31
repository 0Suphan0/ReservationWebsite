﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Controllers
{
    public class DestinationController : Controller
    {
        private DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values=destinationManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.i=id;
            var value = destinationManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();

        }
    }
}
