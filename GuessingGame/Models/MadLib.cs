using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGame.Models
{
    public class MadLib
    {
        [Display(Name = "Enter an adjective")]
        [Required(ErrorMessage = "A word is required.")]
        public string Adjective1 { get; set; }

        [Display(Name = "Enter an adjective")]
        [Required(ErrorMessage = "A word is required.")]
        public string Adjective2 { get; set; }

        [Display(Name = "Enter a verb")]
        [Required(ErrorMessage = "A word is required.")]
        public string Verb1 { get; set; }

        [Display(Name = "Enter a verb")]
        [Required(ErrorMessage = "A word is required.")]
        public string Verb2 { get; set; }

        [Display(Name = "Enter a noun")]
        [Required(ErrorMessage = "A word is required.")]
        public string Noun1 { get; set; }

        [Display(Name = "Enter a noun")]
        [Required(ErrorMessage = "A word is required.")]
        public string Noun2 { get; set; }


    }
}