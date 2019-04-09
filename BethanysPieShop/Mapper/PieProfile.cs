using AutoMapper;
using BethanysPieShop.DataSource.Models;
using BethanysPieShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Mapper
{
    public class PieProfile : Profile
    {
        public PieProfile()
        {
            CreateMap<Pie, DetailsViewModel>();
        }
    }
}
