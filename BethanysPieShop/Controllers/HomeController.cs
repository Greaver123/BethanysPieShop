using System.Linq;
using AutoMapper;
using BethanysPieShop.DataSource.Repositories;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly IMapper mapper;

        public HomeController(IPieRepository pieRepository, IMapper mapper)
        {
            this._pieRepository = pieRepository;
            this.mapper = mapper;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Pie overview";
            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Bethany's Pie Shop",
                Pies = pies.ToList(),
            };

            return View(homeViewModel);
        }

       public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);

            if (pie ==null)
            {
                return NotFound();
            }
            var pieViewModel = mapper.Map<DetailsViewModel>(pie);

            return View(pieViewModel);
        }

    }
}
