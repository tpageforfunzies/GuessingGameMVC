using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGame.Models
{
    public class FizzBuzz
    {
        [Display(Name = "What number would you like FizzBuzz'd?")]
        [Required(ErrorMessage = "Number is required.")]
        [Range(1, 1000, ErrorMessage = "Guess must be greater than 0.")]
        public int FizzBuzzNumber { get; set; }
    }
}