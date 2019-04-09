using System;
using System.Collections.Generic;
using System.Text;
using BethanysPieShop.DataSource.Models;

namespace BethanysPieShop.DataSource.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly PieShopDbContext pieShopDbContext;

        public FeedbackRepository(PieShopDbContext pieShopDbContext)
        {
            this.pieShopDbContext = pieShopDbContext;
        }

        public void Add(Feedback feedback)
        {
            pieShopDbContext.Add(feedback);
        }

        public void Save()
        {
            pieShopDbContext.SaveChanges();
        }
    }
}
