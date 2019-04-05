using BethanysPieShop.Models;
using System.Collections.Generic;
using System.Linq;


namespace BethanysPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}
