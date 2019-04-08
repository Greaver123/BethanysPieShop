using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BethanysPieShop.DataSource.Models;

namespace BethanysPieShop.DataSource.Repositories
{
    public class SqlPieRepository : IPieRepository
    {
        private readonly PieShopDbContext context;

        public SqlPieRepository(PieShopDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return context.Pies.OrderBy(p=>p.Name).Select(p => p);
        }

        public Pie GetPieById(int pieId)
        {
            return context.Pies.FirstOrDefault(p => p.Id == pieId);
        }

        public Pie Add(Pie pie)
        {
            context.Pies.Add(pie);

            return pie;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
