using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcAuctionWebApp.Models
{
    public class AuctionsDataContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }
    }
}