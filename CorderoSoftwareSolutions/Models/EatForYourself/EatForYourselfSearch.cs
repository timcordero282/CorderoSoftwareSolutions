using System.ComponentModel.DataAnnotations;

namespace CorderoSoftwareSolutions.Models.EatForYourself
{
    public class EatForYourselfSearch
    {
        [Required(ErrorMessage = "Please enter food description")]
        public string FoodDescription { get; set; } = "";
        public string Company { get; set; } = "";     
    }
}
