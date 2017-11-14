using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGame.Models
{
    public class ListModel
    {
        [Display(Name = "What number should I count down from?")]
        [Required(ErrorMessage = "Number is required.")]
        public int NumberToCount { get; set; }
    }
}