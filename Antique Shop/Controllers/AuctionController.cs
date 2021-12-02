﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Antique_Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Antique_Shop.Controllers
{
    public class AuctionController : Controller
    {
        private readonly IAuctionRepository auctionRepository;
        public AuctionController(IAuctionRepository auctionRepository)
        {
            this.auctionRepository = auctionRepository;
        }
        public ViewResult Index()
        {
            var auction = auctionRepository.GetAllAuctions();
            return View(auction);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
