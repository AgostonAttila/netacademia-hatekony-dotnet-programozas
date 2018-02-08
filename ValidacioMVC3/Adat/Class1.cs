using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Adat
{
    public class Termek
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Ezt {0} mindenkeppen add meg")]
        public string Megnevezes { get; set; }

        [RegularExpression(@"^\d\d-[a-z]{2}\d$", ErrorMessage="Ennek a {0}-nak ilyennek kell lenni *{1}*")]
        public string Kod { get; set; }

        //[Display(ResourceType=typeof(MarketingOsztaly), Name="Felirat")]
        [SajatValidalas(MinimumMagyar=-5, MaximumMagyar=15)]
        public decimal Listaar { get; set; }

        [Display(Name="Minimum rendelhető mennyiség")]
        public int MinimumRendelheto { get; set; }

        [Display(Name = "Maximum rendelhető mennyiség")]
        public int MaximumRendelheto { get; set; }

        [SajatValidalas(MinimumMagyar=150, MaximumMagyar=300)]
        public decimal MyProperty { get; set; }
    }


    public class SajatValidalasAttribute:ValidationAttribute
    {
        public int MinimumMagyar { get; set; }
        public int MaximumMagyar { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            var ertek = (decimal)value;
            if (ertek < MinimumMagyar || ertek > MaximumMagyar)
                return new ValidationResult("Nem jo ar");

            return ValidationResult.Success;
        }
    }
}
