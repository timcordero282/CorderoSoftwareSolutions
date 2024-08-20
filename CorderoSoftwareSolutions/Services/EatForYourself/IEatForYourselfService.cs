using CorderoSoftwareSolutions.Models.EatForYourself;

namespace CorderoSoftwareSolutions.Services.EatForYourself
{
    public interface IEatForYourselfService
    {
        Task<EatForYourselfResult?> USDASearch(EatForYourselfSearch eat);
    }
}