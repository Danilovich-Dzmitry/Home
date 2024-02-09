using System.ComponentModel.DataAnnotations;

namespace CarWorkshop.MVC.Models
{
    public class Login
    {
        [Display(Name = "Wpisz imie:")]
        public string Name { get; set; }
        [Display(Name = "Wpiz hasło:")]
        public string Password { get; set; }
    }
}
