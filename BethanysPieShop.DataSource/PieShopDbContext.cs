using BethanysPieShop.DataSource.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShop.DataSource
{
    public class PieShopDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Pie> Pies { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public PieShopDbContext(DbContextOptions<PieShopDbContext> options) : base(options)
        {

        }
    }
}
