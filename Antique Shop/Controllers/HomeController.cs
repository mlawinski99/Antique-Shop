﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Antique_Shop.Models;

namespace Antique_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAuctionRepository auctionRepository;

        public HomeController(ILogger<HomeController> logger, IAuctionRepository auctionRepository)
        {
            _logger = logger;
            this.auctionRepository = auctionRepository;
        }

        public IActionResult Index()
        {
            var auction = auctionRepository.GetAllAuctions();
            return View(auction);
        }


        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
