using Microsoft.AspNetCore.Mvc;
using OpieAndAnthonyRadioShow.Models;

namespace OpieAndAnthonyRadioShow.Controllers
{
    public class RadioShowController : Controller
    {
        public IActionResult Index()
        {

            var radioViewModel = new RadioShowViewModel()
            {

            };
            return View(radioViewModel);
        }
    }
}