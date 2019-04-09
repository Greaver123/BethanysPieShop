using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BethanysPieShop.DataSource.Models;
using BethanysPieShop.DataSource.Repositories;
using BethanysPieShop.Models.Dtos;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{

    [Authorize]
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository feedbackRepository;
        private readonly IMapper mapper;

        public FeedbackController(IFeedbackRepository feedbackRepository, IMapper mapper)
        {
            this.feedbackRepository = feedbackRepository;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FeedbackAddRequest feedbackRequest)
        {
            if (ModelState.IsValid)
            { 
                feedbackRepository.Add(mapper.Map<Feedback>(feedbackRequest));
                feedbackRepository.Save();

                return RedirectToAction("FeedbackComplete");
            }
            return View(mapper.Map<FeedbackViewModel>(feedbackRequest));
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}