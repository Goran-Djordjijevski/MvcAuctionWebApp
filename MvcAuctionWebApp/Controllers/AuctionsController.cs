using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAuctionWebApp.Models;

namespace MvcAuctionWebApp.Controllers
{
    public class AuctionsController : Controller
    {
        // GET: Auctions
        public ActionResult Index()
        {
            var auctions = new List<Auction>()
            {
                new Models.Auction
                {
                    Title = "Example Auction #1",
                    Description = "This is an example Auction",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(7),
                    StartPrice = 1.0M,
                    CurrentPrice = null
                },

                new Models.Auction
                {
                    Title = "Example Auction #2",
                    Description = "This is a second example Auction",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(7),
                    StartPrice = 1.0M,
                    CurrentPrice = 30M
                },

                new Models.Auction
                {
                    Title = "Example Auction #3",
                    Description = "This is a third example Auction",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(7),
                    StartPrice = 10.0M,
                    CurrentPrice = 24M
                }
            };

            return View(auctions);
        }

        public ActionResult TempDataDemo()
        {
            TempData["SuccessMessage"] = "The action succeeded!";

            return RedirectToAction("Index");
        }

        public ActionResult Auction()
        {
            var auction = new MvcAuctionWebApp.Models.Auction()
            {
                Title = "Example Auction",
                Description = "This is an example Auction",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00M,
                CurrentPrice = null
            };

            return View(auction);
        }
    }
}