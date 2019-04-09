using BethanysPieShop.DataSource.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShop.DataSource
{
    public class PieShopDbContext : DbContext
    {
        public DbSet<Pie> Pies { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public PieShopDbContext(DbContextOptions<PieShopDbContext> options) : base(options)
        {

        }
    }
}
