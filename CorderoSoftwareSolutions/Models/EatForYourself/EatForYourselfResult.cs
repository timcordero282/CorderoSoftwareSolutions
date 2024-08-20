namespace CorderoSoftwareSolutions.Models.EatForYourself
{
    public class EatForYourselfResult
    {
        public Food[] foods { get; set; }       
    }

    public class Food
    {
        public string description { get; set; } = "";
        public string brandOwner { get; set; } = "";
        public string brandName { get; set; } = "";
        public string ingredients { get; set; } = "";
        public string marketCountry { get; set; } = "";
        public string foodCategory { get; set; } = "";
        public string servingSize { get; set; } = "";
        public string servingSizeUnit { get; set; } = "";
        public FoodNutrients[] foodNutrients { get; set; }
    }

    public class FoodNutrients
    {
        public string nutrientName { get; set; } = "";
        public string unitName { get; set; } = "";
        public string value { get; set; } = "";
        public string percentDailyValue { get; set; } = "";
    }
}
