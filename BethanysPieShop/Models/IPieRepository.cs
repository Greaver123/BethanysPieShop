using BethanysPieShop.Models;
using System.Collections.Generic;
using System.Linq;

public interface IPieRepository
{
    IEnumerable<Pie> GetAllPies();
    Pie GetPieById(int pieId);
}
