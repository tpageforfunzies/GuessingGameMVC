using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGame.Models
{
    public class FizzBuzz
    {
        [Required]
        public int FizzBuzzNumber { get; set; }
    }
}