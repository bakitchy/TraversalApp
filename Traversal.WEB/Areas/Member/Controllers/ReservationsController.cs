﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traversal.Core.Concrete;
using Traversal.Repository.EntityFramework;
using Traversal.Service.Concrete;

namespace Traversal.WEB.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class ReservationsController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationRepository());
        ReservationManager reservationManager = new ReservationManager(new EfReservationRepository());

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList()
                                           select new SelectListItem 
                                           { Text = x.City , Value = x.Id.ToString()}).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            reservationManager.TAdd(p);
            return RedirectToAction("MyCurrentReservation");
        }

        public IActionResult MyCurrentReservation()
        {
            return View();

        }

        public IActionResult MyOldReservation()
        {
            return View();

        }

    }
}
