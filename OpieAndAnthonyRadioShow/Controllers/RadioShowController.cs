using Microsoft.AspNetCore.Mvc;
using OpieAndAnthonyRadioShow.Data;
using OpieAndAnthonyRadioShow.Models;

namespace OpieAndAnthonyRadioShow.Controllers
{
    public class RadioShowController : Controller
    {
        private readonly IRadioShow _radioShowService;
        public RadioShowController(IRadioShow radioShowService)
        {
            _radioShowService = radioShowService;
        }

        public IActionResult Index()
        {
            var radioShowList = _radioShowService.GetAll();

            var radioViewModel = new RadioShowViewModel()
            {
                RadioShows = radioShowList,
                SearchQuery = ""
            };
            return View(radioViewModel);
        }
    }
}