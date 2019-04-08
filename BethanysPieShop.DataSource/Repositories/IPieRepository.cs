using BethanysPieShop.DataSource.Models;
using System.Collections.Generic;
using System.Linq;


namespace BethanysPieShop.DataSource.Repositories
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
        Pie Add(Pie pie);
        void Save();
    }
}
