﻿using LayoutKullanimi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LayoutKullanimi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<Urun>()
            {
                new Urun()
                {
                    Id = 1,
                    Ad = "Karpuz",
                    Fiyat = 7
                },
                new Urun()
                {
                    Id=2,
                    Ad = "Erik",
                    Fiyat = 9
                }
            };

            return View(model);
        }
    }
}
