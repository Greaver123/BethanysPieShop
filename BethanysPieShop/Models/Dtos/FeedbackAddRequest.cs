﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models.Dtos
{
    public class FeedbackAddRequest
    {
        //public int FeedbackId { get; set; }

        [Required]

        [StringLength(100, ErrorMessage = "Your name is required")]
        public string Name { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="Your email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Message { get; set; }

        public bool ContactMe { get; set; }
    }
}
