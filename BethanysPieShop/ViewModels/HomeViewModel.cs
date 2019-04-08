using BethanysPieShop.DataSource.Models;
using System.Collections.Generic;

namespace BethanysPieShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }

        public IEnumerable<Pie> Pies { get; set; }
    }
}
