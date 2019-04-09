using BethanysPieShop.DataSource.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShop.DataSource.Repositories
{
    public interface IFeedbackRepository
    {
        void Add(Feedback feedback);

        void Save();
    }
}
